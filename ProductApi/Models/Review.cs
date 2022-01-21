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
        [Display(Name = "reviewNumber")]
        public int ReviewNumber { get; set; }

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
