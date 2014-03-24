using System.Threading.Tasks;

namespace Owin.Security.Strava
{
    public interface IStravaAuthenticationProvider
    {
        Task Authenticated(StravaAuthenticatedContext context);
        Task ReturnEndpoint(StravaReturnEndpointContext context);
    }
}
