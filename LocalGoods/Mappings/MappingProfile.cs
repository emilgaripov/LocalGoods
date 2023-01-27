using AutoMapper;
using LocalGoods.Core.Models;
using LocalGoods.Resources;

namespace LocalGoods.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, ProductResource>();
            CreateMap<Category, CategoryResource>();

            CreateMap<ProductResource, Product>();
            CreateMap<CategoryResource, Category>();
        }
    }
}
