using System;
using System.ComponentModel.DataAnnotations;

namespace IndyBooks.Models
{
    public class Book
    {
        //TODO: Adjust properties according to ERD Diagram (Figure 1)
        [Key]
        public int BookId { get; set; }

        [Required]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [Required]
        [Display(Name = "SKU")]
        public string SKU { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [Display(Name = "Price")]
        public decimal Price { get; set; }

        public virtual Writer Author { get; set; }

    }
}
