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
        [HttpDelete("Sil{id}")]
        public void Delete(int id)
        {
            categoryService.Delete(id);
        }
        [HttpPut("Güncelleme")]
        public void Update([FromBody]Category category)
        {
            categoryService.Update(category);
        }

        [HttpGet("Listele")]
        public List<Category> GetAll()
        {
            return categoryService.GetAll();
        }
        

    }
}
