using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveType.Queries.GetLeaveTypeDetails
{
    public record GetLeaveTypesDetailQuery(int Id) : IRequest<LeaveTypeDetailsDTO>
    {

    }
}
