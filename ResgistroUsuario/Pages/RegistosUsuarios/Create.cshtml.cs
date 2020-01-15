using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ResgistroUsuario.Data;
using ResgistroUsuario.Modelos;

namespace ResgistroUsuario
{
    public class CreateModel : PageModel
    {
        private readonly ResgistroUsuario.Data.ResgistroUsuarioContext _context;

        public CreateModel(ResgistroUsuario.Data.ResgistroUsuarioContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public RegistroU RegistroU { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.RegistroU.Add(RegistroU);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
