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

        [HttpGet("getproduct")]
        public IActionResult GetProduct()
        {

            return Ok("Produt list");
        }

        [HttpGet("getproductbylist")]
        public IActionResult GetProductByList()
        {

            return Ok("Produt list");
        }
    }
}
