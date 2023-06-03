using AutoMapper;
using TESTTEST.Handlers;
using TESTTEST.Models;

namespace TESTTEST.Modules;

public class CategoryProfile : Profile
{

    public CategoryProfile()
    {
        CreateMap<CreateCategoryRequest, Category>();




    }
    
    
    
}