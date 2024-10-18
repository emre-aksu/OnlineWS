using BaseLib.Model;

namespace OnlineWSModel.Entities
{
    public class ProductPhoto:BaseEntity<int>
    {
        public int ProductId { get; set; }
        public string? PhotoPath { get; set; }

        public Product? Product { get; set; }
    }
}
