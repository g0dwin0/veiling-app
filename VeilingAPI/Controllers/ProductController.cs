using Microsoft.AspNetCore.Mvc;
using VeilingAPI.Model;

namespace VeilingAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductController : Controller
{
    // GET
    [HttpGet("voorbeeld")]
    public Product getExampleProduct()
    {
        return new Product();
    }
}