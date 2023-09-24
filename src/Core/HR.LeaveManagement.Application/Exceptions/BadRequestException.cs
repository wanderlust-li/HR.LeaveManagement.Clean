﻿using System.ComponentModel.DataAnnotations;

namespace HR.LeaveManagement.Application.Exceptions;

public class BadRequestException : Exception
{
    public BadRequestException(string message) : base(message)
    {

    }
    
    public BadRequestException(string message, ValidationResult validationResult) : base(message)
    {
        ValidationErrors = new();
        foreach (var error in ValidationErrors.Errors)
        {
            ValidationErrors.Add(error.ErrorMessage);
        }
    }
    
    public List<string> ValidationErrors { get; set; }
}