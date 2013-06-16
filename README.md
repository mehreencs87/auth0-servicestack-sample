Sample using Auth0 and ServiceStack

https://docs.auth0.com/servicestack-tutorial

Change the Web.config with your client id and secrets from [Auth0](http://auth0.com)

```
<add key="oauth.auth0.AppId" value="YOUR CLIENT ID" />
<add key="oauth.auth0.AppSecret" value="YOUR CLIENT SECRET" />
<add key="oauth.auth0.OAuthServerUrl" value="YOUR AUTH0 DOMAIN: https://{tenant}.auth0.com" />
```

The callback URL will be http://localhost:port/api/auth/auth0

