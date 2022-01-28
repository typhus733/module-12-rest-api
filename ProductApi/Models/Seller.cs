using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProductApi.Models
{
    public class Seller
    {
        [Key]
        [Required]
        [Display(Name = "SellerId")]
        public string Id { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Products Sold")]
        public virtual List<Product> ProductsSold { get; set; }

        [Display(Name = "Available Stock")]
        public int Stock { get; set; }

    }
}
