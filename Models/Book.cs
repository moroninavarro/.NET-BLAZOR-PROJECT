using System.Globalization;
using System.ComponentModel.DataAnnotations;

namespace BookTracker.Models;

    public class Book
    {
        public string UserId { get; set; } = string.Empty;
        public ApplicationUser? User { get; set; }
        
        public int BookId { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; } = "";

        [Required]
        [StringLength(100)]
        public string Author { get; set; } = "";

        public string Genre { get; set; } = "";

        [Range(1, 10000)]
        public int TotalPages { get; set; }

        public int CurrentPage { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? FinishDate { get; set; }

        public string Status { get; set; } = "Want to Read";

        [Range(0, 5)]
        public int Rating { get; set; }

        public string Notes { get; set; } = "";
    }
