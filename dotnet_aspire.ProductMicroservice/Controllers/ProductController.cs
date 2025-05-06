using dotnet_aspire.ProductMicroservice.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_aspire.ProductMicroservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet("GetProducts")]
        public IActionResult GetProducts()
        {
            return Ok(new List<ProductModel>()
            {
                new ProductModel
                {
                    ProductId = 1,
                    ProductName = "Product 1",
                    Price = 1000
                },
                new ProductModel
                {
                    ProductId = 2,
                    ProductName = "Product 2",
                    Price = 1000
                },
                new ProductModel
                {
                    ProductId = 3,
                    ProductName = "Product 3",
                    Price = 1000
                }
            });
        }
    }
}
