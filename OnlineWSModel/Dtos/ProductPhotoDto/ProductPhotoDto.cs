using BaseLib.Model;

namespace OnlineWSModel.Dtos.ProductPhotoDto
{
    public class ProductPhotoDto:IDto
    {
        public int ProductId { get; set; }
        public string? PhotoPath { get; set; }
    }
}
