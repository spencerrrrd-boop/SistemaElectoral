using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaElectoral1.Models
{
    public class Padron
    {
        public int PadronID { get; set; }
        public string Curso { get; set; }
        public string Seccion { get; set; }
        public int Anio { get; set; }
        public bool Activo { get; set; }

        // Propiedad de navegacion
        public string NombreCompleto => Curso + " - " + Seccion;

        public Padron()
        {
            Anio = System.DateTime.Now.Year;
            Activo = true;
        }
    }
}
