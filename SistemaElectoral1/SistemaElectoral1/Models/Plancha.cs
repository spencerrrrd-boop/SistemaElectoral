using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace SistemaElectoral1.Models
{
    public class Plancha
    {
        public int PlanchaID { get; set; }
        public string NombrePlancha { get; set; }
        public string Lema { get; set; }
        public string LogoRuta { get; set; }
        public int AdministradorID { get; set; }
        public bool Activa { get; set; }
        public System.DateTime FechaCreacion { get; set; }

        // Propiedades de navegacion
        public string NombreAdministrador { get; set; }
        public List<Candidato> Candidatos { get; set; }

        public Plancha()
        {
            Activa = true;
            FechaCreacion = System.DateTime.Now;
            Candidatos = new List<Candidato>();
        }
    }
}
