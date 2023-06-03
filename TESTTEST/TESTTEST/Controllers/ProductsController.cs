using System.Runtime.CompilerServices;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace TESTTEST.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private IMediator _mediator;

    public ProductsController(IMediator mediator)
    {
        _mediator = mediator;
    }
    
    
    


}