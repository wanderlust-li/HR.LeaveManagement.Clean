﻿namespace HR.LeaveManagement.Application.Models.Emails;

public class EmailMessage
{
    public string To { get; set; }
    
    public string Subject { get; set; }
    
    public string Body { get; set; }
}