using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MovieCoreApp.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [StringLength(60,MinimumLength =2)]
        [Required] //zorunlu olduğu
        public string Title { get; set; }
        
        [Display(Name ="Release Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }

        //[Range(1,100)]
        //[DataType(DataType.Currency)]
        [Range(1, 100), DataType(DataType.Currency)]
        [Column(TypeName="decimal(18,2)")]
        public decimal Price { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [Required]
        [StringLength(30)]
        public string Genre { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [Required]
        [StringLength(5)]
        public string Rating { get; set; }
    }
}
