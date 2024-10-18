using BaseLib.DataAccess.Implementations.EF;
using OnlineWS.DateAccess.Contracts.Repositories;
using OnlineWS.DateAccess.EF.Contexts;
using OnlineWSModel.Entities;

namespace OnlineWS.DateAccess.EF.Repositories
{
    public class EmployeeRepository : BaseRepository<Employee, int, ECommerceContext>, IEmployeeRepository
    {
        public async Task<List<Employee>> GetByCity(string city, params string[] includeList)
        {
          return await FilterAsycn(x=> x.City == city,includeList);
        }
    }
}
