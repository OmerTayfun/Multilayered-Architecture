using Business.Abstracts;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        ICategoryService categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }
        [HttpPost("Ekle")]
        public void Add([FromBody] Category category)
        {
            categoryService.Add(category);
        }
        [HttpGet]
        public List<Category> GetAll()
        {
            return categoryService.GetAll();
        }
        [HttpPost("Delete")]
        public void Delete([FromBody] int id)
        {
            var category = categoryService.GetById(id);
        }

    }
}
