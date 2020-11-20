using System;
using System.ComponentModel.DataAnnotations;
namespace GourmetPizzaPrac3.Models
{
    public class Statistic
    {
        [Display(Name = "Purchased Pizza Count ")]
        public int PizzaCount { get; set; }

        [Display(Name = "Number of Purchases")]
        public int Total { get; set; }
    }
}
