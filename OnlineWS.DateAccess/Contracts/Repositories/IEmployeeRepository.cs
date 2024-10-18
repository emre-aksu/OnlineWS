using BaseLib.DataAccess.Contracts;
using OnlineWSModel.Entities;

namespace OnlineWS.DateAccess.Contracts.Repositories
{
    public interface IEmployeeRepository:IRepository<Employee, int>
    {
        Task<List<Employee>> GetByCity(string city,params string[] includeList);
    }
}
