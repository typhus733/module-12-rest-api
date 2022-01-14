using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProductApi.Models
{
    public class Review
    {
        [Key]
        [Required]
        [Display(Name = "reviewNumber")]
        public string ReviewNumber { get; set; }

        [Required]
        [Display(Name = "reviewAuthor")]
        public string Reviewer { get; set; }

        [Required]
        [Display(Name = "reviewScore")]
        [Range(1, 5)]
        public int ReviewScore { get; set; }

        [Display(Name = "reviewText")]
        public string ReviewText { get; set; }

    }
}
