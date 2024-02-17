using System.ComponentModel.DataAnnotations;

namespace Mission6_Humphrey.Models
{
    public class Submission
    {
        [Key]
        [Required]
        public int SubmissionID { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Year { get; set; }
        [Required]
        public string Director { get; set; }
        [Required]
        public string Rating { get; set; }
        public bool? Edited { get; set; }
        public string? LentTo { get; set; }
        [StringLength(25)]
        public string? Notes { get; set; }

    }
}
