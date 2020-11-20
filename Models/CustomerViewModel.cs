using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GourmetPizzaPrac3.Models
{
    public class CustomerViewModel
    {
        [Display(Name = " Family Name")]
        [Required(ErrorMessage = "The Family Name field is required")]
        [RegularExpression(@"^[a-zA-Z""'\s-]*$", ErrorMessage = "Family name can only consists of English letters, hyphen and apostrophe")]
        [MinLength(2), MaxLength(20)]
        public String FamilyName { get; set; }

        [Display(Name = " Given Name")]
        [Required(ErrorMessage = "The Given Name field is required")]
        [RegularExpression(@"^[a-zA-Z""'\s-]*$", ErrorMessage = "Given name can only consists of English letters, hyphen and apostrophe")]
        [MinLength(2), MaxLength(20)]
        public String GivenName { get; set; }

        [Display(Name = " Date Of Birth")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:DD/MM/YYYY}", ApplyFormatInEditMode = true)]
        // [RegularExpression(@"^(0[1-9]|1[012])[/](0[1-9]|[12][0-9]|3[01])[/]\d{4}$", ErrorMessage = "End Date should be in MM/dd/yyyy format")]
        // [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0: d}")]
        public String DateOfBirth { get; set; }

        [Display(Name = " Mobile Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?(04[0-9]{1})\)?[,-]?([0-9]{3})[,-]?([0-9]{4})$", ErrorMessage = "Phone Number must start with 04, the number must be 10 digits")]
        public String MobileNumber { get; set; }

        [Display(Name = " Postal Code")]
        [RegularExpression(@"^[0-8]{1}[0-9]{3}", ErrorMessage = "Postal Code must have 4 digits and it cannot begin with 9")]
        public String PostalCode { get; set; }
    }
}
