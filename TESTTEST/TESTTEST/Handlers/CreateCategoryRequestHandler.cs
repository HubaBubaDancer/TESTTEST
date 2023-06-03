using System.Reflection;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using TESTTEST.Models;
using HostingEnvironmentExtensions = Microsoft.Extensions.Hosting.HostingEnvironmentExtensions;

namespace TESTTEST.Handlers;


public class CreateCategoryRequest : IRequest<Category>
{
    public string Name { get; set; } = null!;
    public List<Product>? Products { get; set; }

    public CreateCategoryRequest(string name, List<Product>? products)
    {
        Name = name;
        Products = products;
    }
}

public class CreateCategoryRequestHandler : IRequestHandler<CreateCategoryRequest, Category>
{
    private readonly IMapper _mapper;
    private readonly ApplicationDbContext _context;

    public CreateCategoryRequestHandler(IMapper mapper, ApplicationDbContext context)
    {
        _mapper = mapper;
        _context = context;
    }

    public async Task<Category> Handle(CreateCategoryRequest request, CancellationToken cancellationToken)
    {
        var category = _mapper.Map<Category>(request);
        await _context.AddAsync(category);
        await _context.SaveChangesAsync();
        return category;
    }
}