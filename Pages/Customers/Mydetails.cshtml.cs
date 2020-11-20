using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using GourmetPizzaPrac3.Models;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;

namespace GourmetPizzaPrac3.Pages.Customers
{
    [Authorize(Roles = "Customers")]
    public class MyDetailsModel : PageModel
    {
        private readonly GourmetPizzaPrac3.Data.ApplicationDbContext _context;

        public MyDetailsModel(GourmetPizzaPrac3.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public CustomerViewModel Customers { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            // retrieve the logged-in user's email
            // need to add "using System.Security.Claims;"
            string _email = User.FindFirst(ClaimTypes.Name).Value;

            Customer customer = await _context.Customer.FirstOrDefaultAsync(m => m.Email == _email);

            if (customer != null)
            {
                // The user has been created in the database
                ViewData["ExistInDB"] = "true";
                Customers = new CustomerViewModel
                {
                    // Retrieve his/her details for display in the web form
                    FamilyName = customer.FamilyName,
                    GivenName = customer.GivenName,
                    DateOfBirth = customer.DateOfBirth,
                    MobileNumber = customer.MobileNumber,
                    PostalCode = customer.PostalCode
                };
            }
            else
            {
                ViewData["ExistInDB"] = "false";
            }

            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            // retrieve the logged-in user's email
            // need to add "using System.Security.Claims;"
            string _email = User.FindFirst(ClaimTypes.Name).Value;

            Customer customer = await _context.Customer.FirstOrDefaultAsync(m => m.Email == _email);

            if (customer != null)
            {
                // This ViewData entry is needed in the content file
                // The user has been created in the database
                ViewData["ExistInDB"] = "true";
            }
            else
            {
                ViewData["ExistInDB"] = "false";
            }

            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (customer == null)
            {
                // creating a customer object for inserting database
                customer = new Customer();
            }

            // Construct this customer object based on 'Customer'
            customer.Email = _email;
            customer.FamilyName = Customers.FamilyName;
            customer.GivenName = Customers.GivenName;
            customer.DateOfBirth = Customers.DateOfBirth;
            customer.MobileNumber = Customers.MobileNumber;
            customer.PostalCode = Customers.PostalCode;

            if ((string)ViewData["ExistInDB"] == "true")
            {
                _context.Attach(customer).State = EntityState.Modified;
            }
            else
            {
                _context.Customer.Add(customer);
            }

            try  // catching the conflict of editing this record concurrently
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }

            ViewData["SuccessDB"] = "success";
            return Page();
        }
    }
}
