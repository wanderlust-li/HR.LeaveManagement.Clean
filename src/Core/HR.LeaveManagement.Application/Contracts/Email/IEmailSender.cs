namespace HR.LeaveManagement.Application.Contracts.Email;
using HR.LeaveManagement.Application.Models.Emails;

public interface IEmailSender
{
    Task<bool> SendEmail(EmailMessage email);
}