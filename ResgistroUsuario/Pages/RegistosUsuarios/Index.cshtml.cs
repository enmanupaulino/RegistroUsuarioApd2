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
    public class IndexModel : PageModel
    {
        private readonly ResgistroUsuario.Data.ResgistroUsuarioContext _context;

        public IndexModel(ResgistroUsuario.Data.ResgistroUsuarioContext context)
        {
            _context = context;
        }

        public IList<RegistroU> RegistroU { get;set; }

        public async Task OnGetAsync()
        {
            RegistroU = await _context.RegistroU.ToListAsync();
        }
    }
}
