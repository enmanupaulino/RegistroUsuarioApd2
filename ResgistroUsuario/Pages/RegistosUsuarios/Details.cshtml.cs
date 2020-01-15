using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ResgistroUsuario.Data;
using ResgistroUsuario.Modelos;

namespace ResgistroUsuario
{
    public class DetailsModel : PageModel
    {
        private readonly ResgistroUsuario.Data.ResgistroUsuarioContext _context;

        public DetailsModel(ResgistroUsuario.Data.ResgistroUsuarioContext context)
        {
            _context = context;
        }

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
    }
}
