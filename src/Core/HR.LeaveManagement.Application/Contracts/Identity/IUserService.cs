using HR.LeaveManagement.Application.Models.Identity;

namespace HR.LeaveManagement.Application.Contracts.Identity;

public interface IUserService
{
    Task<AuthResponse> Login(AuthRequest request);
    
    Task<RegistrationResponse> Register(RegistrationRequest request);
}