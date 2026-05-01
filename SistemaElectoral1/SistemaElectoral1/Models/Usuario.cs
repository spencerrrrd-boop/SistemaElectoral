using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaElectoral1.Models
{
    public class Usuario
    {
        public int UsuarioID { get; set; }
        public string Matricula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Contrasena { get; set; }
        public int RolID { get; set; }
        public int? PadronID { get; set; }
        public System.DateTime FechaRegistro { get; set; }
        public bool Activo { get; set; }

        // Propiedades de navegacion (no van a la DB)
        public string NombreCompleto => Nombre + " " + Apellido;
        public string NombreRol { get; set; }
        public string Curso { get; set; }
        public string Seccion { get; set; }

        public Usuario()
        {
            FechaRegistro = System.DateTime.Now;
            Activo = true;
        }
    }
}
