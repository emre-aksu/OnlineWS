using AutoMapper;
using OnlineWSModel.Dtos.ProductDtos;
using OnlineWSModel.Entities;

namespace OnlineWS.Business.Mapping.Automapper.Profiles
{
    public class ProductProfile:Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductGetDto > ();
            CreateMap<ProductPostDto,Product  > ();
            CreateMap<ProductPutDto,Product  > (); 
          
            
        }
    }
}
