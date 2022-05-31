using System.ComponentModel.DataAnnotations;

namespace Eterna.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength:25)]
        public string Name { get; set; }
    }
}
