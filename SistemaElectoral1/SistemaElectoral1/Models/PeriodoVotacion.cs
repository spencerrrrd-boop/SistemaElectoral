using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaElectoral1.Models
{
    public class PeriodoVotacion
    {
        public int PeriodoID { get; set; }
        public string Descripcion { get; set; }
        public System.DateTime FechaInicio { get; set; }
        public System.DateTime FechaFin { get; set; }
        public bool Activo { get; set; }
        public int CreadoPor { get; set; }

        // Propiedades de navegacion
        public string NombreDirector { get; set; }

        // Propiedad calculada
        public System.TimeSpan TiempoRestante => FechaFin - System.DateTime.Now;
        public bool EstaVigente => System.DateTime.Now >= FechaInicio &&
                                   System.DateTime.Now <= FechaFin && Activo;

        public PeriodoVotacion()
        {
            Activo = false;
        }
    }
}
