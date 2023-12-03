using System.ComponentModel.DataAnnotations;

namespace Task_14.Models.Customers
{
    public class BaseEntity
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }
    }
}
