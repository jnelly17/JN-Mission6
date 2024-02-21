using System.ComponentModel.DataAnnotations;

namespace JN_Mission6.Models
{
    public class Category
    {
        [Key]
        public int CategoryId {  get; set; }
        public string CategoryName { get; set; }
    }
}
