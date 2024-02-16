using System.ComponentModel.DataAnnotations;

namespace JN_Mission6.Models
{
    public class MovieSubmit
    {
        [Key]
        public int ApplicationID { get; set; }
        public string Category { get; set; }
        public string Title { get; set; }
        public string Year { get; set; }
        public string Director { get; set; }
        public string Rating { get; set; }
        public bool? Edited { get; set; }
        public bool? LentTo { get; set; }
        public string? Notes { get; set; }
    }
}
