using AutoMapper;
using OnlineWSModel.Dtos.ProductPhotoDto;
using OnlineWSModel.Entities;

namespace OnlineWS.Business.Mapping.Automapper.Profiles
{
    public class ProductPhotoProfile:Profile
    {
        public ProductPhotoProfile()
        {
            CreateMap<ProductPhoto, ProductPhotoDto>();
        }
    }
}
