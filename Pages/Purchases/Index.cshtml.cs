using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GourmetPizzaPrac3.Data;
using GourmetPizzaPrac3.Models;
using System.Security.Claims;

namespace GourmetPizzaPrac3.Pages.Purchases
{
    public class IndexModel : PageModel
    {
        private readonly GourmetPizzaPrac3.Data.ApplicationDbContext _context;

        public IndexModel(GourmetPizzaPrac3.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Purchase> Purchase { get;set; }


        public async Task<IActionResult> OnGetAsync(string sortOrder)
        {
            string _email = User.FindFirst(ClaimTypes.Name).Value;

            Purchase = await _context.Purchase
                .Include(p => p.ThePizza)
                .Include(p => p.TheCustomer)
                .ToListAsync();

            if (string.IsNullOrEmpty(sortOrder))
            {
                sortOrder = "Pizza_Name_asc";

            }
            var purchase = (IQueryable<Purchase>)_context.Purchase.Include(p => p.TheCustomer).Include(p => p.ThePizza)
                .Where(p => p.CustomerEmail == _email);

            switch (sortOrder)
            {
                case "Pizza Name_asc":
                    purchase = purchase.OrderBy(p => p.ThePizza.pizzaName);
                    break;
                case "Pizza Name_desc":
                    purchase = purchase.OrderByDescending(p => p.ThePizza.pizzaName);
                    break;
                case "Pizza Count_asc":
                    purchase = purchase.OrderBy(p => p.PizzaCount);
                    break;
                case "Pizza Count_desc":
                    purchase = purchase.OrderByDescending(p => p.PizzaCount);
                    break;
                case "Total Cost_asc":
                    purchase = purchase.OrderBy(p => p.TotalCost);
                    break;
                case "Total Cost_desc":
                    purchase = purchase.OrderByDescending(p => p.TotalCost);
                    break;
                case "Customer Name_asc":
                    purchase = purchase.OrderBy(p => p.TheCustomer);
                    break;
                case "Customer Name_desc":
                    purchase = purchase.OrderByDescending(p => p.TheCustomer);
                    break;
            }

            ViewData["NextNameOrder"] = sortOrder != "Pizza Name_asc" ? "Pizza Name_asc" : "Pizza Name_desc";
            ViewData["NextNumberOrder"] = sortOrder != "Pizza Count_asc" ? "Pizza Count_asc" : "Pizza Count_desc";
            ViewData["NextCostOrder"] = sortOrder != "Total Cost_asc" ? "Total Cost_asc" : "Total Cost_desc";
            Purchase = await purchase
                .AsNoTracking()
                .ToListAsync();
            return Page();
        }
    }
}
