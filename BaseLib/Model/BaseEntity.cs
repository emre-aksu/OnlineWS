namespace BaseLib.Model
{
    public abstract class BaseEntity<TId>
    {
        public TId Id { get; set; } 
        public DateTime? Added { get; set; }
        public DateTime? Modified { get; set; }
        public int? AddedBy {  get; set; }
        public int? ModifiedBy { get; set;}
    }
}
