using BaseLib.DataAccess.Contracts;
using OnlineWSModel.Entities;

namespace OnlineWS.DateAccess.Contracts.Repositories
{
    public interface ICategoryRepository : IRepository<Category,int>
    {
        Task<int?> GetProductCount(int categoryId);
    }
}
