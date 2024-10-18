  using BaseLib.Model;

namespace OnlineWSModel.Entities
{
    public class Product:BaseEntity<int>
    {
        public string Name {  get; set; }   
        public decimal? Price { get; set; }
        public short? Stock {  get; set; }
        public string? Description { get; set; }
        public int CategoryId {  get; set; }    
        public string? PhotoPath {  get; set; }  
        public byte[]? Picture { get; set; } 
        public Category? Category { get; set; }
        // public ICollection<ProductPhoto>? ProductPhotos { get; set; }

      
    }
}
