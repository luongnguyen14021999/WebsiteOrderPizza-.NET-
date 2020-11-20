using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GourmetPizzaPrac3.Models
{
    public class Purchase
    {
        // primary key
        public int ID { get; set; }

        //foreign key
        public int pizzaID { get; set;}

        //foreign key
        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string CustomerEmail { get; set; }

        [Range(1,80)]
        [Display(Name = "Pizza Count")]
        public int PizzaCount { get; set; }

        [Range(1.00,1000.00)] 
        [Display(Name = "Total Cost")]
        public double TotalCost { get; set; }

        // Navigation properties
        [Display(Name = "Pizza Name")]
        public Pizza ThePizza { get; set; }

        [Display(Name = "Full Name")]
        public Customer TheCustomer { get; set; }
    }
}
