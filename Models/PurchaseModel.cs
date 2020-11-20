using System;
using System.ComponentModel.DataAnnotations;
namespace GourmetPizzaPrac3.Models
{
    public class PurchaseModel
    {
        [Display(Name = "Pizza Name")]
        public int pizzaID { get; set; }

        [Range(1, 80)]
        [Display(Name = "Pizza Count")]
        public int PizzaCount { get; set; }
    }
}
