using Microsoft.AspNetCore.Mvc;
using OnlineWS.Business.Contracts;

namespace OnlineWS.WebAPI.Controllers
{
    [Route("api/productphotos")]
    [ApiController]
    public class ProductPhotoController : ControllerBase
    {
        private readonly IProductPhotoManager _productPhotoManager;
        public ProductPhotoController(IProductPhotoManager productPhotoManager)
        {
            _productPhotoManager = productPhotoManager;
        }

        [HttpPost]
        public async Task<IActionResult> DeletePhoto(int id)
        {
            await _productPhotoManager.Delete(id);


            // KLASORDEN SIL

            return Ok();

        }
    }
}
