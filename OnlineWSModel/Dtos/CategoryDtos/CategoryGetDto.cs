using BaseLib.Model;
using OnlineWSModel.Dtos.ProductDtos;

namespace OnlineWSModel.Dtos.CategoryDtos
{
    public class CategoryGetDto:IDto
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Description { get; set; } 
        public int ProductCount {  get; set; }
        public string? PhotoPath { get; set; }
        public List<ProductGetDto> Products { get; set; }   

    }
}
