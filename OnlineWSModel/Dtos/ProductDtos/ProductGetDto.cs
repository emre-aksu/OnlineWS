using BaseLib.Model;
using Microsoft.AspNetCore.Http;
using OnlineWSModel.Entities;

namespace OnlineWSModel.Dtos.ProductDtos
{
    public class ProductGetDto : IDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal? Price { get; set; }
        public short? Stock { get; set; }
        //public int Category {  get; set; }    burasını da kapattım hata alırsam açacağım
        public int CategoryId { get; set; }
        public string  PhotoPath { get; set; }
        //public byte[]? Picture { get; set; }

    }
}
