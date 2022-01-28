using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProductApi.Models
{
    public class Sellers
    {
        [Key]
        [Required]
        [Display(Name = "SellerId")]
        public string Id { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [NotMapped]
        [Display(Name = "Inventory")]
        public Dictionary<string, int> Inventory { get; set; }
    }
}
