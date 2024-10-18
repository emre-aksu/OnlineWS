using Microsoft.AspNetCore.Mvc;
using OnlineWS.Business.Contracts;
using OnlineWSModel.Dtos.CategoryDtos;

namespace OnlineWS.WebAPI.Controllers
{
    [Route("api/categories")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryManager _categoryManager;
        public CategoriesController(ICategoryManager categoryManager)
        {
            _categoryManager = categoryManager;
        }

        /// <summary>
        /// Id ye göre ürünleri listeliyoruz ve Ürünleri dahil ediyoruz
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute]int id)
        {
          CategoryGetDto categoryDto= await _categoryManager.GetById(id,"Products");
            return Ok(categoryDto);
        }


        /// <summary>
        /// tüm ürünleri buradan çekiyoruz 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var categoryList=await _categoryManager.GetAllCategories();
             return Ok(categoryList);
        }

        /// <summary>
        /// CATEGORY INSERT ISLEMI 
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> AddCategory([FromBody] CategoryPostDto dto)
        {
            await _categoryManager.AddCategorry(dto);
            return Ok();
        }
        //.../api/categories
        [HttpPut]
        public async Task<IActionResult> UpdateCategory([FromBody] CategoryPutDto dto)
        {
            await _categoryManager.UpdateCategory(dto);
            return Ok();
        }
        //.../api/categories//1---DELETE
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory([FromRoute] int id)
        {
            await _categoryManager.DeleteCategory(id);
            return Ok();
        }
    }
}
