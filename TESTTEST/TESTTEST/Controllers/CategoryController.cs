using MediatR;
using Microsoft.AspNetCore.Mvc;
using TESTTEST.Handlers;
using TESTTEST.Models;

namespace TESTTEST.Controllers;


[ApiController]
[Route("api/[controller]")]
public class CategoryController : ControllerBase
{

    private IMediator _mediator;

    public CategoryController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<Category> CreateCategory(CreateCategoryRequest request)
    {
        var category = await _mediator.Send(request);
        return category;
    }
    
    


}