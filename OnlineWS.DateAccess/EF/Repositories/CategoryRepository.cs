using BaseLib.DataAccess.Implementations.EF;
using OnlineWS.DateAccess.Contracts.Repositories;
using OnlineWS.DateAccess.EF.Contexts;
using OnlineWSModel.Entities;

namespace OnlineWS.DateAccess.EF.Repositories
{
    public class CategoryRepository:BaseRepository<Category, int, ECommerceContext>, ICategoryRepository
    {
        public async Task<int?> GetProductCount(int categoryId)
        {
            var category=await GetByIdAsync(categoryId, "Products");
            if (category.Products != null && category.Products.Count>=0) 
            
                return category.Products.Count;

            return null;
        }

       
    }
}
