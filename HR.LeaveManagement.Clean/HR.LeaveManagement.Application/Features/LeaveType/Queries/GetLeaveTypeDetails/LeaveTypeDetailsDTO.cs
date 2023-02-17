namespace HR.LeaveManagement.Application.Features.LeaveType.Queries.GetLeaveTypeDetails
{
    public class LeaveTypeDetailsDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public int DefaultDays { get; set; }
        public string CreatedBy { get; set; } = String.Empty;
        public DateTime DateCreated { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? DateModified { get; set; }

    }
}
