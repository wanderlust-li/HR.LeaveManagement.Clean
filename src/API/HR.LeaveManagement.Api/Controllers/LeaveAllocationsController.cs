using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class LeaveAllocationsController : ControllerBase
{
    private readonly IMediator _mediator;

    public LeaveAllocationsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    
}