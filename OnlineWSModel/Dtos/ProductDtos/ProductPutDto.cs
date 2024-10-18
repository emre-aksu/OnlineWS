using BaseLib.Model;
using Microsoft.AspNetCore.Http;

namespace OnlineWSModel.Dtos.ProductDtos
{
    public class ProductPutDto:IDto
    {
        public int Id {  get; set; }    
        public string Name { get; set; }
        public decimal Price { get; set; }
        public short Stock { get; set; }
        public string? Description { get; set; }
        public string? PhotoPath { get; set; }
        public IFormFile? Picture { get; set; }
      
        public int? CategoryId {  get; set; }    
    }
}
