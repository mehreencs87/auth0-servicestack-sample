Sample using Auth0 and ServiceStack

https://docs.auth0.com/servicestack-tutorial

Change the Web.config with your client id and secrets from [Auth0](http://auth0.com)

```
<add key="oauth.auth0.AppId" value="YOUR CLIENT ID" />
<add key="oauth.auth0.AppSecret" value="YOUR CLIENT SECRET" />
<add key="oauth.auth0.OAuthServerUrl" value="YOUR AUTH0 DOMAIN: https://{tenant}.auth0.com" />
```

The callback URL will be http://localhost:port/api/auth/auth0

## Issue Reporting

If you have found a bug or if you have a feature request, please report them at this repository issues section. Please do not report security vulnerabilities on the public GitHub issue tracker. The [Responsible Disclosure Program](https://auth0.com/whitehat) details the procedure for disclosing security issues.

## Author

[Auth0](auth0.com)

## License

This project is licensed under the MIT license. See the [LICENSE](LICENSE) file for more info.
