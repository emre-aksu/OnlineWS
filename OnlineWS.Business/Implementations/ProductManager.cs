using AutoMapper;
using OnlineWS.Business.Contracts;
using OnlineWS.DateAccess.Contracts.Repositories;
using OnlineWSModel.Dtos.ProductDtos;
using OnlineWSModel.Entities;

namespace OnlineWS.Business.Implementations
{
    /// <summary>
    /// Bu ProductManagerr sınıfının Data access ile haberleşmesi gerektiği için burada IPrroductRepository sınıfına ihtiyacı var bu ihtiyacı Dependency injection yöntemi  ile gideriyoruz
    /// </summary>
    public class ProductManager : IProductManager
    {
        private readonly IProductRepository _productRepository;// burada gideriyoruz
        private readonly IMapper _mapper;  
        public ProductManager(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }
        public async Task<List<Product>> GetProductbyPriceAsync(decimal min,decimal max,params string[] includeList) // burasını sonradan ekledim hata olursa sileceğim 
        {
            //return await _productRepository.FilterAsycn(x=> x.Price > min  && x.Price < max);
            return await _productRepository.GetByPrice(min, max,includeList);
        }
        public async Task AddProduct(ProductPostDto dto)
        {
           var entity=_mapper.Map<Product>(dto);    
            await _productRepository.InsertAsync(entity);
        }

        public async Task DeleteProduct(int id)
        {
           await _productRepository.DeleteAsync(id);    
        }

        public async Task<List<ProductGetDto>> GetAllProducts(params string[] includeList)
        {
            List<Product> products=await _productRepository.GetAllAsycn(includeList);
            List<ProductGetDto>list=_mapper.Map<List<ProductGetDto>>(products); 
            return list;
        }

        public async Task<ProductGetDto> GetById(int id, params string[] includeList)
        {
            Product product=await _productRepository.GetByIdAsync(id,includeList);  
            ProductGetDto dto=_mapper.Map<ProductGetDto>(product);
            return dto; 
        }

        public async Task UpdateProduct(ProductPutDto dto)
        {
            var entity = _mapper.Map<Product>(dto);
            await _productRepository.UpdateAsync(entity);   
        }
        
    }
}
