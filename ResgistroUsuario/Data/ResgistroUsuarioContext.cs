using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ResgistroUsuario.Modelos;

namespace ResgistroUsuario.Data
{
    public class ResgistroUsuarioContext : DbContext
    {
        public ResgistroUsuarioContext (DbContextOptions<ResgistroUsuarioContext> options)
            : base(options)
        {
        }

        public DbSet<ResgistroUsuario.Modelos.RegistroU> RegistroU { get; set; }
    }
}
