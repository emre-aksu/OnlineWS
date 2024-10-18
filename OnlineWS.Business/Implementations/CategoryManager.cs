using AutoMapper;
using OnlineWS.Business.Contracts;
using OnlineWS.DateAccess.Contracts.Repositories;
using OnlineWSModel.Dtos.CategoryDtos;
using OnlineWSModel.Entities;

namespace OnlineWS.Business.Implementations
{
    public class CategoryManager : ICategoryManager
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;
        public CategoryManager(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        /// <summary>
        /// Category Ekleme ve Validasyon yaptığımız yer
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        /// //not aşağıdaki kod düzenlene bilir maping işlemi için
        public async Task AddCategorry(CategoryPostDto dto)
        {
            var entity = _mapper.Map<Category>(dto);
           await _categoryRepository.InsertAsync(entity);
        }
        /// <summary>
        /// Category Silme 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task DeleteCategory(int id)
        {
            await _categoryRepository.DeleteAsync(id);
        }

        /// <summary>
        /// Bütün Category Listesini çekiyoruz
        /// </summary>
        /// <param name="includeList"></param>
        /// <returns></returns>
        public async Task<List<CategoryGetDto>> GetAllCategories(params string[] includeList)
        {
            List<Category> categories =await _categoryRepository.GetAllAsycn(includeList);
            List<CategoryGetDto> list= _mapper.Map<List<CategoryGetDto>>(categories);
            return list;
        }
        /// <summary>
        /// ID ye göre Categori listesini çekip Ürünleri de dahil ediyoruz
        /// </summary>
        /// <param name="id"></param>
        /// <param name="includeList"></param>
        /// <returns></returns>
        public async Task<CategoryGetDto> GetById(int id, params string[] includeList)
        {
            Category category= await _categoryRepository.GetByIdAsync(id, includeList);
           CategoryGetDto dto= _mapper.Map<CategoryGetDto>(category);
            return dto;
        }

        /// <summary>
        /// Category Update kısmı
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task UpdateCategory(CategoryPutDto dto)
        {
           var entity=_mapper.Map<Category>(dto);
            await _categoryRepository.UpdateAsync(entity);
        }
    }
}
