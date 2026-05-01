using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaElectoral1.Models
{
    public class ResultadoPlancha
    {
        public int PlanchaID { get; set; }
        public string NombrePlancha { get; set; }
        public string LogoRuta { get; set; }
        public int TotalVotos { get; set; }
        public double PorcentajeVotos { get; set; }
    }
}
