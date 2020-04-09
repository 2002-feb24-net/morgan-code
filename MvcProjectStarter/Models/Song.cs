using System;
using System.ComponentModel.DataAnnotations;

namespace MvcProjectStarter.Models
{
    public class Song
    {
        public int id { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string title { get; set; }

        [Display(Name = "Category of Music")]
        [Required]
        public string genre { get; set; }
        public string artist { get; set; }
        public string album { get; set; }

        [Display(Name = "Release Date")]
        [Required]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

    }
}
