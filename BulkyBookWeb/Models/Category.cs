using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BulkyBookWeb.Models
{
    // (SQL server use)
    public class Category
    {
        // Data annotation/attribute [Key]
        // Use: Makes Id a primary key & identity column
        [Key]
        public int Id { get; set; }
        [Required]  // Use of [Required]: When script is created, Name isn't nullable
        public string Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1,100, ErrorMessage = "Display Order must be between 1 and 100.")]

        public int DisplayOrder { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}
