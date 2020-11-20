using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using GourmetPizzaPrac3.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace GourmetPizzaPrac3.Pages.Purchases
{
    [Authorize(Roles = "Customers")]
    public class CreateModel : PageModel
    {
        private readonly GourmetPizzaPrac3.Data.ApplicationDbContext _context;

        public CreateModel(GourmetPizzaPrac3.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public SelectList TitleList { get; set; }


        public IActionResult OnGet()
        {
            ViewData["PizzaID"] = new SelectList(_context.Pizza, "ID", "pizzaName");
            ViewData["CustomerEmail"] = new SelectList(_context.Customer, "Email", "FullName");
            TitleList = new SelectList(_context.Pizza, "ID", "pizzaName");
            return Page();
        }

        [BindProperty]
        public PurchaseModel Purchases { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            string _email = User.FindFirst(ClaimTypes.Name).Value;
            var errors = ModelState.Values.SelectMany(v => v.Errors);
            if (ModelState.IsValid)
            {
                Purchase purchase = new Purchase();

                purchase.pizzaID = Purchases.pizzaID;
                purchase.CustomerEmail = _email;
                purchase.PizzaCount = Purchases.PizzaCount;

                var thePizza = await _context.Pizza.FindAsync(Purchases.pizzaID);
                purchase.TotalCost = purchase.PizzaCount * thePizza.price;

                ViewData["TotalPrice"] = purchase.PizzaCount * thePizza.price;

                // insert this new purchase into database
                _context.Purchase.Add(purchase);
                await _context.SaveChangesAsync();

            }

            return Page();

        }

    }
}
