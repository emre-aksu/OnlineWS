using OnlineWS.Business.Contracts;
using OnlineWS.DateAccess.Contracts.Repositories;

namespace OnlineWS.Business.Implementations
{
    public class ProductPhotoManager:IProductPhotoManager
    {
        private readonly IProductPhotoRepository _productPhotoRepository;
        public ProductPhotoManager(IProductPhotoRepository productPhotoRepository)
        {
            _productPhotoRepository = productPhotoRepository;
        }

        public async Task Delete(int id)
        {
           _productPhotoRepository.DeleteAsync(id); 
        }
    }
}
