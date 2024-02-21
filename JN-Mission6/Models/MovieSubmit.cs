﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JN_Mission6.Models
{
    public class MovieSubmit
    {
        [Key]
        [Required]
        public int MovieID { get; set; }
        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public string Title { get; set; }
        public string Year { get; set; }
        public string Director { get; set; }
        public string Rating { get; set; }
        public bool Edited { get; set; }
        public bool? LentTo { get; set; }
        public bool CopiedToPlex {  get; set; }
        public string? Notes { get; set; }
    }
}
