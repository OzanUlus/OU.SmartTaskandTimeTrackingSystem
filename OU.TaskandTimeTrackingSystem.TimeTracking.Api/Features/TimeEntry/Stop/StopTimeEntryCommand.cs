using MediatR;
using SmartTaskandTimeTrackingSystem.Shared.Result;

namespace OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.TimeEntry.Stop
{
    public record StopTimeEntryCommand() : IRequest<Result>
    {
        public Guid EntryId { get; set; }
        public DateTime EndTime { get; set; } = DateTime.Now;
    }
}
