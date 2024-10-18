using BaseLib.DataAccess.Implementations.EF;
using OnlineWS.DateAccess.Contracts.Repositories;
using OnlineWS.DateAccess.EF.Contexts;
using OnlineWSModel.Entities;

namespace OnlineWS.DateAccess.EF.Repositories
{
    public class ProductRepository : BaseRepository<Product, int, ECommerceContext>, IProductRepository 
    {
        public async Task<List<Product>> GetByPrice(decimal min, decimal max, params string[] includeList)
        {
          return await FilterAsycn(x => x.Price > min && x.Price < max,includeList);
        }
    }
}
