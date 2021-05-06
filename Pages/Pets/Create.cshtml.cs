using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using EllroyVetClinic.Models;

namespace EllroyVetClinic.Pages.Pets
{
    public class CreateModel : PageModel
    {
        private readonly EllroyVetClinic.Models.PetContext _context;

        public CreateModel(EllroyVetClinic.Models.PetContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["OwnerID"] = new SelectList(_context.Owner, "OwnerID", "OwnerID");
        ViewData["VeterinarianId"] = new SelectList(_context.Veterinarian, "VeterinarianId", "VeterinarianId");
            return Page();
        }

        [BindProperty]
        public Pet Pet { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Pet.Add(Pet);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
