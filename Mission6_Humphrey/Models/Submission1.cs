using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission6_Humphrey.Models
{
    public class Submission1
    {
        [Key]
        [Required]
        public int MovieId { get; set; }

        [ForeignKey("CategoryId")]
        public int? CategoryId {  get; set; }

        [Required(ErrorMessage = "Enter a Title")]
        public string Title { get; set; }

        [Required]
        [Range(1888, 2024, ErrorMessage = "Enter a valid year (1888-2024)")]
        public int Year { get; set; } = 0;

        public string? Director { get; set; }

        public string? Rating { get; set; }

        [Required(ErrorMessage = "The Edited field is required")]
        public bool Edited { get; set; }

        public string? LentTo { get; set; }

        [Required(ErrorMessage = "The Copied to Plex field is required")]
        public bool CopiedToPlex { get; set; }

        public string? Notes { get; set; }

        public MovieCategories? Category { get; set; }

    }
}
