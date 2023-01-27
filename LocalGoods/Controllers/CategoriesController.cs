using AutoMapper;
using LocalGoods.Core.Models;
using LocalGoods.Core.Services;
using LocalGoods.Resources;
using Microsoft.AspNetCore.Mvc;

namespace LocalGoods.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService categoryService;
        private readonly IMapper mapper;
        public CategoriesController(ICategoryService categoryService,IMapper mapper)
        {
            this.categoryService = categoryService;
            this.mapper = mapper;
        }
        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            var categories=await categoryService.GetAllCategories();
            return Ok(categories);
        }

        [HttpPost]
        public async Task AddCategory([FromBody] CategoryResource category)
        {
            await categoryService.Create(mapper.Map<CategoryResource, Category>(category));
        }

    }
}
