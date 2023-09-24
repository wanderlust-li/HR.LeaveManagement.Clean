﻿using System.ComponentModel.DataAnnotations;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveType.Commands.CreateLeaveType;

public class CreateLeaveTypeCommand : IRequest<int>
{
    // [Required]
    public string Name { get; set; } = string.Empty;
    
    public int DefaultDays { get; set; }
}