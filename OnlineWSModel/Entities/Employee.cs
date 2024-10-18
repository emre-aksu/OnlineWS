using BaseLib.Model;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineWSModel.Entities
{
    public class Employee : BaseEntity<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime? HireDate { get; set; }
        public string? PhotoPath { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }

        [NotMapped]
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
    }
}