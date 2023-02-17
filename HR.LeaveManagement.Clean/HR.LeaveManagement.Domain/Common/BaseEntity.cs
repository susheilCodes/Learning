namespace HR.LeaveManagement.Domain.Common;

public abstract class BaseEntity
{
    public int Id { get; set; }
    public string CreatedBy { get; set; } = String.Empty;
    public DateTime DateCreated { get; set; }
    public string? ModifiedBy { get; set; }
    public DateTime? DateModified { get; set; }

}
