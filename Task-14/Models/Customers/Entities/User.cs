using System.ComponentModel.DataAnnotations;

namespace Task_14.Models.Customers.Entities
{
    public class User : BaseEntity
    {
        [Required]
        [MaxLength(25)]
        [MinLength(3)]
        public string? Name { get; set; }
        [Required]
        [MaxLength(25)]
        [MinLength(3)]
        public string? SurName { get; set; }
        [Required]
        [MaxLength(100)]
        [MinLength(1)]
        public byte Age { get; set; }

        [Required]
        [MaxLength(100)]
        [MinLength(1)]
        public string? Country { get; set; }
        [Required]
        [MaxLength(13)]
        [MinLength(13)]
        [Phone]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
    }
}
