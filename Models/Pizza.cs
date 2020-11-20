using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GourmetPizzaPrac3.Models
{
    public class Pizza
    {
        [Display(Name = "Pizza Name")]
        public int ID { get; set; }

        [Display(Name = "Pizza Name")]
        [Required(ErrorMessage = "Select a Pizza Please")]
        [RegularExpression(@"^[A-Z][0-9 a-zA-Z'-]{1,20}$")]
        public string pizzaName { get; set; }

        [Display(Name = "Pizza Price")]
        public double price { get; set; }

        public ICollection<Purchase> ThePurchases { get; set; }
    }
}
