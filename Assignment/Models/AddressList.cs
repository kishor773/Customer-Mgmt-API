using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment.Models
{
    public class AddressList
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CustomerId { get; set; }
        public string? City { get; set; }
        public string? StreetAddress { get; set; }
        [Required]
        public string? Phone { get; set; }

    }
}
