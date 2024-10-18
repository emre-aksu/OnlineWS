using BaseLib.Model;
using Microsoft.AspNetCore.Http;
using System.Globalization;

namespace OnlineWSModel.Dtos.ProductDtos
{
    public class ProductPostDto:IDto
    {
        public string Name {  get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }  
        public short Stock { get; set; }
        public string PhotoPath { get; set; }
        public int CategoryId {  get; set; }    
     
        //public IFormFile Picture { get; set; }
    }
}
