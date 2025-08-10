using Microsoft.AspNetCore.Mvc;
using Market;

namespace Products.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutoController : ControllerBase
    {
        private static List<Produto> produtos = new List<Produto>();

        [HttpGet]
        public ActionResult<IEnumerable<Produto>> Get()
        {
            return Ok(produtos);
        }

    }

    
}