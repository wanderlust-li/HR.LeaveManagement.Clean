using System.ComponentModel.DataAnnotations;
using HR.LeaveManagement.Domain.Common;

namespace HR.LeaveManagement.Domain;

public class LeaveType : BaseEntity
{
    // [StringLength((50))]
    public string Name { get; set; } = string.Empty;
    
    public int DefaultDays { get; set; }
}