using System;
using System.Collections.Generic;
using System.Linq;
using GourmetPizzaPrac3.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;

namespace GourmetPizzaPrac3.Pages.Purchases
{

    [Authorize(Roles = "Customers")]
    public class CalcPurchaseStatsModel : PageModel
    {
        private readonly GourmetPizzaPrac3.Data.ApplicationDbContext _context;

        public CalcPurchaseStatsModel(GourmetPizzaPrac3.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        // For passing the results to the Content file
        public IList<Statistic> Stats { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            var pizzaGroups = _context.Purchase.GroupBy(m => m.PizzaCount);

            Stats = await pizzaGroups.Select(g => new Statistic { PizzaCount = g.Key, Total = g.Count() }).ToListAsync();

            return Page();
        }

       
    }
}