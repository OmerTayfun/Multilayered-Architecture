using Business.Abstracts;
using Business.Concretes;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        IProductService productService; // ❌❌❌
        

        public ProductsController(IProductService productService)
        {
            this.productService = productService;
        }

                
        [HttpPost]
        public void Add([FromBody] Product product)
        {
            productService.Add(product);
        }
        [HttpDelete("Ürün Sil{id}")]
        public void Delete(int id)
        {
            productService.Delete(id);
        }
        [HttpPut("Güncelle")]
        public void Update([FromBody]Product product)
        {
            productService.Update(product);
        }
        [HttpGet("Listele")]
        public List<Product> GetAll()
        {
            return productService.GetAll();
        }
    }
}
