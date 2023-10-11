using HR.LeaveManagement.Application.Models.Identity;

namespace HR.LeaveManagement.Application.Contracts.Identity;

public interface IAuthService
{
    Task<List<Employee>> GetEmployees();
    
    Task<Employee> GetEmployee(string userId);
}