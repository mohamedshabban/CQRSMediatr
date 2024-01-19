using CQRSMediatr.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CQRSMediatr.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ISender _sender;
        public ProductsController(ISender sender)
        {
            _sender = sender;
        }
        [HttpGet("GetAll")]
        public async Task<ActionResult> GetAllProducts()
        {
            var products = await _sender.Send(new GetProductQuery());
            return Ok(products);
        }
        [HttpGet("{Id}")]
        public async Task<ActionResult> GetProductById(int Id)
        {
            var product = await _sender.Send(new GetProductByIdQuery(Id));
            return Ok(product);
        }
    }
}
