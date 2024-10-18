using BaseLib.Model;
using Microsoft.AspNetCore.Http;

namespace OnlineWSModel.Dtos.CategoryDtos
{
    public class CategoryPutDto:IDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public IFormFile? Picture { get; set; } // hata alırsan buna bak
        public string? PhotoPath { get; set; }
    }
}
