# Owin.Security.Strava
Owin.Security.Strava is a [OWIN](http://owin.org/) authentication provider for [Strava](https://developer.strava.com).

## Installation via NuGet Package

Create a Strava app to get your unique Client ID and Client Secret from: [https://developer.strava.com](https://developer.strava.com)

	Install-Package Owin.Security.Strava

	Add the following to Startup.Auth.cs (VS2013) or AuthConfig.cs (VS2012):

            app.UseStravaAuthentication(
                clientId: "",
                clientSecret: "");