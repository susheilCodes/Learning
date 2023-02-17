using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveType.Queries.GetAllLeaveTypes
{
    //public  class GetLeaveTypesQuery:IRequest<List<LeaveTypeDTO>>
    //{

    //}

    public record GetLeaveTypesQuery : IRequest<List<LeaveTypeDTO>>
    {

    }

}
