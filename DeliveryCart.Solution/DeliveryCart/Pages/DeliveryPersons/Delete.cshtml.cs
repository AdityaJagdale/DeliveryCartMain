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
    public class DeleteModel : PageModel
    {
        private readonly DbContext _context;

        public DeleteModel(DbContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            DeliveryPerson = await _context.DeliveryPersons.FindAsync(id);

            if (DeliveryPerson != null)
            {
                _context.DeliveryPersons.Remove(DeliveryPerson);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
