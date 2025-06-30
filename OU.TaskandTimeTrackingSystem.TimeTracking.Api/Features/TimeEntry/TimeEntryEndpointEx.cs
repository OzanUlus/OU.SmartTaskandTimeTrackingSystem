using OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.TimeEntry.Create;
using OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.TimeEntry.GetActiveEntryByUserId;
using OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.TimeEntry.GetActivesEntryByUserId;
using OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.TimeEntry.GetAllEntryByUserId;
using OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.TimeEntry.GetByIdAsync;
using OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.TimeEntry.Stop;

namespace OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.TimeEntry
{
    public static class TimeEntryEndpointEx
    {
        public static void AddTimeEntryGroupEndpointExt(this WebApplication app)
        {

            app.MapGroup("api/timeEntry").WithTags("TimeEntries")

                .CreateTimeEntryGroupItemEndpoint()
                .StopTimeEntryGroupItemEndpoint()
                .GetActivesEntryByUserIdGroupItemEndpoint()
                .GetAllEntryByUserIdGroupItemEndpoint()
                .GetActiveEntryByUserIdGroupItemEndpoint()
                .GetByIdAsyncGroupItemEndpoint();



        }
    }
}
