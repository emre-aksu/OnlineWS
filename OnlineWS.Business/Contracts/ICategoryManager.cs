using OnlineWSModel.Dtos.CategoryDtos;

namespace OnlineWS.Business.Contracts
{
    public interface ICategoryManager
    {
        Task<CategoryGetDto> GetById(int id, params string[] includeList);
        Task<List<CategoryGetDto>> GetAllCategories(params string[] includeList);   
        Task AddCategorry(CategoryPostDto dto);
        Task UpdateCategory(CategoryPutDto dto);
        Task DeleteCategory(int id);
    }
}
