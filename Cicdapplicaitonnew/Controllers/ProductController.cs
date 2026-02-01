using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cicdapplicaitonnew.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public ProductController()
        {


        }

        [HttpGet]
        public IActionResult GetProduct()
        {

            return Ok("Produt list");
        }

    }
}
