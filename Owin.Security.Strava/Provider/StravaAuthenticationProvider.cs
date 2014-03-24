using System;
using System.Threading.Tasks;

namespace Owin.Security.Strava
{
    public class StravaAuthenticationProvider : IStravaAuthenticationProvider
    {
        public StravaAuthenticationProvider()
        {
            OnAuthenticated = context => Task.FromResult<object>(null);
            OnReturnEndpoint = context => Task.FromResult<object>(null);
        }

        public Func<StravaAuthenticatedContext, Task> OnAuthenticated { get; set; }

        public Func<StravaReturnEndpointContext, Task> OnReturnEndpoint { get; set; }

        public virtual Task Authenticated(StravaAuthenticatedContext context)
        {
            return OnAuthenticated(context);
        }

        public virtual Task ReturnEndpoint(StravaReturnEndpointContext context)
        {
            return OnReturnEndpoint(context);
        }
    }
}
