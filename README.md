# Goal of library
C# library to access Battlenet API.

# Supported APIs
- Authentication
- Starcraft 2

# Install NuGet

```xml
<PackageReference Include="ASoft.BattleNet" Version="1.0.0.*" />
```

# Create BattleNetClient
```csharp
var config = new ConfigurationBuilder()
.AddCommandLine(args)
.Build();

var serviceCollection = new ServiceCollection();
serviceCollection.AddLogging();
serviceCollection.AddBattleNetClient(config);

var serviceProvider = serviceCollection.BuildServiceProvider();
var battleNetClient = serviceProvider.GetRequiredService<IBattleNetClient>();
```

# Authentication
Battlenet supports two authentication types:
- Partner authentication - restricted access, no user data.
- User authentication - full access to user data.

## Partner authentication
Library is designed with expectation, that it will be used by 1 partner only, therefore credentials are provided only one time during initialization as part of configuration.
Credentials can be obtained from [Battlenet developer portal](https://develop.battle.net/access/clients).

**Be aware** - RedirectUrl MUST be registered correctly otherwise you will not be able to proceed with User authentication.

Domain "https://localhost" is accepted for local testing.

Configuration is trying to parse this model:
```csharp
public class BattleNetClientOption
{
    public string ClientId? { get; set; } // cannot be null, but ```ConfigurationBuilder``` does not support immutable types yet.
    public string Secret? { get; set; } // cannot be null, but ```ConfigurationBuilder``` does not support immutable types yet.
    public Region Region { get; set; }
    public Uri RedirectUrl { get; set; }
}
```

## User authentication
Design goal was, that application needs to process data from different users, therefore different credentials all the time. This means, that authentication needs to be done per user bases.

First, user needs to authenticate with 2FA on url below. Url will redirect user to specified redirectUrl.
```
https://eu.battle.net/oauth/authorize?access_type=online&client_id=<client_id>&redirect_uri=<url_encoded_redirect_url>&response_type=code&state=
```

**Be aware**:
- Redirect url must **exactly** match redirect url registered in mentioned [Battlenet developer portal](https://develop.battle.net/access/clients) (be aware of trailing slashes, etc.).
- Authorization code has short validity (about 1 minute)

After obtaining authorization code through the redirect, you can get access token for given user:
```csharp
var authorizationCode = "<authorization_code>";
var token = await this.battlenetClient.AuthenticateByUserCredentialsAsync(options.ClientId!, options.Secret!, authorizationCode, options.RedirectUrl).ConfigureAwait(false);
```

Because you don't want to force user to go throu 2FA all the time, library provides also way how to authenticate with remembered token (see below).
This method is just verifying validity and storing the token in strong typed object with the expiration. Token has long validity and can be reused without bothering user to reauthenticate.

```csharp
var token = await this.battlenetClient.AuthenticateByAccessTokenAsync("remebered token").ConfigureAwait(false);
```

## How to query data

See samples below (library supports more ...).
```csharp
var user = await this.battlenetClient.GetUser(token).ConfigureAwait(false);
var players = await this.battlenetClient.GetPlayers(user.Id, token).ConfigureAwait(false);
var playerIndex = 0;
var regionId = players[playerIndex].RegionId;
var realmId = players[playerIndex].RealmId;
var profileId = players[playerIndex].ProfileId;
var grandmasterLeaderboard = await this.battlenetClient.GetGrandmasterLeaderBoardAsync(regionId, token).ConfigureAwait(false);
var season = await this.battlenetClient.GetSeasonAsync(regionId, token).ConfigureAwait(false);
```
