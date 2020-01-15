using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ResgistroUsuario.Data;
using ResgistroUsuario.Modelos;

namespace ResgistroUsuario
{
    public class EditModel : PageModel
    {
        private readonly ResgistroUsuario.Data.ResgistroUsuarioContext _context;

        public EditModel(ResgistroUsuario.Data.ResgistroUsuarioContext context)
        {
            _context = context;
        }

        [BindProperty]
        public RegistroU RegistroU { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            RegistroU = await _context.RegistroU.FirstOrDefaultAsync(m => m.ID == id);

            if (RegistroU == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(RegistroU).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RegistroUExists(RegistroU.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool RegistroUExists(int id)
        {
            return _context.RegistroU.Any(e => e.ID == id);
        }
    }
}
