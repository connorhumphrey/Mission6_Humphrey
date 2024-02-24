using System.ComponentModel.DataAnnotations;

namespace Mission6_Humphrey.Models
{
    public class MovieCategories
    {
        [Key]
        [Required]
        public int CategoryId { get; set; }

        [Required]
        public string CategoryName { get; set; }

        public ICollection<Submission1> Submissions { get; set; } // Represents the collection of related submissions

    }
}
