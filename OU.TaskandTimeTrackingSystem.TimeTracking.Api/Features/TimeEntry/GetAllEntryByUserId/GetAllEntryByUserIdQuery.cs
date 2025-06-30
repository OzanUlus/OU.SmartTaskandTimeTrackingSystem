using MediatR;
using SharadResult = SmartTaskandTimeTrackingSystem.Shared.Result.IResult;

namespace OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.TimeEntry.GetAllEntryByUserId
{
    public record GetAllEntryByUserIdQuery(Guid UserId) : IRequest<SharadResult>
    {
    }
}
