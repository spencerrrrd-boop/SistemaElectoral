using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaElectoral1.Models
{
    public class Candidato
    {
        public int CandidatoID { get; set; }
        public int PlanchaID { get; set; }
        public int PuestoID { get; set; }
        public int UsuarioID { get; set; }

        // Propiedades de navegacion
        public string NombreCompleto { get; set; }
        public string NombrePuesto { get; set; }
        public string NombrePlancha { get; set; }
        public string Matricula { get; set; }
    }
}
