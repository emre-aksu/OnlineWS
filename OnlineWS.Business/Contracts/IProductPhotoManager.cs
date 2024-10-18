using BaseLib.DataAccess.Contracts;
using OnlineWSModel.Entities;

namespace OnlineWS.Business.Contracts
{
    public  interface IProductPhotoManager
    {
        Task Delete(int id);   
    }
}
