using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ResgistroUsuario.Modelos
{
    public class RegistroU
    {
        public int ID { get; set; }
        public string Nombre { get; set; }

        public string Apellidos { get; set; }
        

        public string Usuario { get; set; }
      
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }



    }
}
