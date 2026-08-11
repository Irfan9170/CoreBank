using Microsoft.AspNetCore.Mvc;
using ProductAPI.Models;
namespace ProductAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductAPIController : ControllerBase
{
    private static List<Product> products =
    [
        new Product { Id = 1, Name = "Laptop", Price = 35000 },
        new Product { Id = 2, Name = "Mobile", Price = 3000 },
        new Product { Id = 3, Name = "Camera", Price = 78000 }
    ];

    [HttpGet]
    public IActionResult GetProducts()
    {
        return Ok(products);
    }
}
