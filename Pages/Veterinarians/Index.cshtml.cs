using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using EllroyVetClinic.Models;

namespace EllroyVetClinic.Pages.Veterinarians
{
    public class IndexModel : PageModel
    {
        private readonly PetContext _context;
        private readonly ILogger<IndexModel> _logger;
        public List<Veterinarian> Veterinarians {get; set;}

        public IndexModel(PetContext context, ILogger<IndexModel> logger)
        {
            _context = context;
            _logger = logger;
        }

        public void OnGet()
        {
            Veterinarians = _context.Veterinarian.ToList();
        }
    }
}