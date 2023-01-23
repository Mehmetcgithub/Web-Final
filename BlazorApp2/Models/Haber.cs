using System.ComponentModel.DataAnnotations;

namespace BlazorApp2.Models
{
    public class Haber
    {
        public int HaberId { get; set; }

        public string HaberTitle { get; set; }

        public string HaberDescription { get; set; }

        public string HaberAuthor { get; set; }

        public string HaberImage { get; set; }
        [Required]
        public string HaberCategory { get;set; }

        


    }
}
