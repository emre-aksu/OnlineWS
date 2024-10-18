using BaseLib.Model;

namespace OnlineWSModel.Entities
{
    public class Category:BaseEntity<int>
    {
        public Category()
        {
            Products=new  HashSet<Product>();
        }
        public string Name {  get; set; }
        public string? Description {  get; set; }   
        public string? PhotoPath {  get; set; }
        
        //Navigation Propertyler
        public ICollection<Product>? Products { get; set; }  
    }
}
