using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using DeliveryCart.Models;

namespace DeliveryCart.Pages.DeliveryPersons
{
    public class CreateModel : PageModel
    {
        private readonly DbContext _context;

        public CreateModel(DbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public DeliveryPerson DeliveryPerson { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.DeliveryPersons.Add(DeliveryPerson);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
