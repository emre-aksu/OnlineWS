using AutoMapper;
using OnlineWSModel.Dtos.CategoryDtos;
using OnlineWSModel.Entities;

namespace OnlineWS.Business.Mapping.Automapper.Profiles
{
    public class CategoryProfile:Profile
    {
        /// <summary>
        /// Eğer entity de olmayan bir kolon var ise aşağıdaki gibi bunu açıklıyoruz.
        /// </summary>
        public CategoryProfile()
        {
            
            CreateMap<Category, CategoryGetDto>()
                .ForMember(dest => dest.ProductCount, opt => opt.MapFrom(src => src.Products!=null? src.Products.Count:0));

            CreateMap<CategoryPostDto, Category>();
            CreateMap<CategoryPutDto, Category>();

            //buda bir seçenek
            //CreateMap<CategoryPostDto, Category>()
            //    .ForMember(dest => dest.Picture, opt => opt.MapFrom(src => Convert.FromBase64String(src.Picture)));

        }
    }
}
