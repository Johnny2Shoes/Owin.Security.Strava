using System;
using Owin.Security.Strava;

namespace Owin
{
    public static class StravaAuthenticationExtensions
    {
        public static IAppBuilder UseStravaAuthentication(this IAppBuilder app, StravaAuthenticationOptions options)
        {
            if (app == null)
            {
                throw new ArgumentNullException("app");
            }
            if (options == null)
            {
                throw new ArgumentNullException("options");
            }

            app.Use(typeof(StravaAuthenticationMiddleware), app, options);
            return app;
        }

        public static IAppBuilder UseStravaAuthentication(
            this IAppBuilder app,
            string clientId,
            string clientSecret)
        {
            return UseStravaAuthentication(
                app,
                new StravaAuthenticationOptions
                {
                    ClientId = clientId,
                    ClientSecret = clientSecret
                });
        }
    }
}
