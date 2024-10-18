using Microsoft.AspNetCore.Mvc;
using OnlineWS.Business.Contracts;
using OnlineWSModel.Dtos.ProductDtos;

namespace OnlineWS.WebAPI.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductManager _productManager;
        public ProductController(IProductManager productManager)
        {
            _productManager = productManager;
        }
        [HttpGet("GetProductsByPriceRange")]
        public async Task<IActionResult> GetProductsByPriceRange(decimal min, decimal max, [FromQuery] string[] includeList)
        {
            var products = await _productManager.GetProductbyPriceAsync(min, max, includeList);

            if (products == null || !products.Any())
            {
                return NotFound("No products found in the specified price range.");
            }

            return Ok(products);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            ProductGetDto productDto = await _productManager.GetById(id);
            return Ok(productDto);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var productList = await _productManager.GetAllProducts();
            return Ok(productList);
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct([FromBody] ProductPostDto dto)
        {
            await _productManager.AddProduct(dto);
            return Ok();

        }
        [HttpPut]
        public async Task<IActionResult> UpdateProduct([FromBody] ProductPutDto dto)
        {
            await _productManager.UpdateProduct(dto);  
            return Ok();    
        }
        [HttpDelete("{id}")]   
        public async Task<IActionResult> DeleteProduct([FromRoute] int id)
        {
            await _productManager.DeleteProduct(id);
            return Ok();
        }
    }
}
