using BaseLib.Model;
using Microsoft.AspNetCore.Http;

namespace OnlineWSModel.Dtos.CategoryDtos
{
    public class CategoryPostDto:IDto
    {
        public string? Name {  get; set; }   
        public string? Description { get; set; }
        public IFormFile? Picture { get; set; }
       public string? PhotoPath {  get; set; }
    }
}
