using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DeliveryCart.Models;

namespace DeliveryCart.Pages.DeliveryPersons
{
    public class DetailsModel : PageModel
    {
        private readonly DbContext _context;

        public DetailsModel(DbContext context)
        {
            _context = context;
        }

        public DeliveryPerson DeliveryPerson { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            DeliveryPerson = await _context.DeliveryPersons.FirstOrDefaultAsync(m => m.ID == id);

            if (DeliveryPerson == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
