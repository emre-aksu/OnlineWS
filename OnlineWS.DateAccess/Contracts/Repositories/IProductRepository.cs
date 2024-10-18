using BaseLib.DataAccess.Contracts;
using OnlineWSModel.Entities;

namespace OnlineWS.DateAccess.Contracts.Repositories
{
    public interface IProductRepository:IRepository<Product,int>
    { 
        Task <List<Product>> GetByPrice(decimal min,decimal max,params string[] includeList); // Burada  IRepository de Insert, Update, Delete vs  üzerine bu methodu da ekleyerek ProductRepository' e aktarıyor. 
    }
}
