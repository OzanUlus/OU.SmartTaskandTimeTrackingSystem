using OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.BreakPeriod.Create;
using OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.BreakPeriod.Stop;

namespace OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.BreakPeriod
{
    public static class BreakPeriodEndpointExt
    {
        public static void BreakPeriodGroupEndpointExt(this WebApplication app)
        {

            app.MapGroup("api/breakPeriod").WithTags("BreakPeriods")

                .CreateBreakPeriodGroupItemEndpoint()
                .StopBreakPeriodGroupItemEndpoint();



        }
    }
}
