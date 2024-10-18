using OnlineWSModel.Dtos.ProductDtos;
using OnlineWSModel.Entities;

namespace OnlineWS.Business.Contracts
{
    public  interface IProductManager
    { 
        Task<List<Product>> GetProductbyPriceAsync(decimal min, decimal max, params string[] includeList); // burasını sonradan ekledim hata olursa sileceğim
        Task<ProductGetDto> GetById(int id, params string[] includeList);
        Task<List<ProductGetDto>> GetAllProducts(params string[] includeList);
        Task AddProduct(ProductPostDto dto);
        Task UpdateProduct(ProductPutDto dto);
        Task DeleteProduct(int id);
    }
}
