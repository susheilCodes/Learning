using AutoMapper;
using HR.LeaveManagement.Application.Contracts.Persistence;
using HR.LeaveManagement.Application.Exceptions;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveType.Queries.GetLeaveTypeDetails
{
    public class GetLeaveTypeDetailQueryHandler : IRequestHandler<GetLeaveTypesDetailQuery, LeaveTypeDetailsDTO>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private readonly Mapper _mapper;

        public GetLeaveTypeDetailQueryHandler(Mapper mapper, ILeaveTypeRepository _leaveTypeRepository)
        {
            this._mapper = mapper;
            this._leaveTypeRepository = _leaveTypeRepository;
        }

        public async Task<LeaveTypeDetailsDTO> Handle(GetLeaveTypesDetailQuery request, CancellationToken cancellationToken)
        {
            //  query the database
            var leaveTypeDetails = await _leaveTypeRepository.GetByIdAsync(request.Id);

            if (leaveTypeDetails == null)
            {
                throw new NotFoundException(nameof(LeaveType), request.Id);
            }

            //  convert data objects to DTO
            var data = _mapper.Map<LeaveTypeDetailsDTO>(leaveTypeDetails);

            //  return list of DTO object
            return data;
        }
    }
}
