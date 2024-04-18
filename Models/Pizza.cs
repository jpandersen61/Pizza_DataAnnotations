using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pizza_StoreV3.Models
{
    public class Pizza
    {
        [Display(Name = "Pizza ID" )]
        [Required(ErrorMessage = "The '{0}' is required")]
        [Range(typeof(int),
               "1",
               "100",
               ErrorMessage = "Value for '{0}' must be between {1} and {2}")]
        public int? Id { get; set; }
        [Required(ErrorMessage = "The '{0}' is required")]
        [Display(Name = "Pizza Name")]
        public string Name { get; set; }

        [Display(Name = "Pizza Description")]
        public string Description { get; set; }

        [Display(Name = "Pizza price")]
        [Required(ErrorMessage = "The '{0}' is required")]
        [Range(typeof(decimal),
               "1",
               "250",
               ErrorMessage = "Value for {0} must be between {1} and {2}")]

        
        public decimal? Price { get; set; }

        [Display(Name = "Image name")]
        public string ImageName { get; set; }
    }
}
