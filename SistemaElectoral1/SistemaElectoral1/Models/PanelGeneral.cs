using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaElectoral1.Models
{
    public class PanelGeneral
    {
        public int TotalPadron { get; set; }
        public int VotosEmitidos { get; set; }
        public int VotosNulos { get; set; }
        public System.DateTime? FechaFin { get; set; }

        public int VotosFaltantes => TotalPadron - VotosEmitidos;
        public double PorcentajeParticipacion => TotalPadron == 0 ? 0 :
            (double)VotosEmitidos / TotalPadron * 100;
        public double PorcentajeNulos => VotosEmitidos == 0 ? 0 :
            (double)VotosNulos / VotosEmitidos * 100;
        public string TiempoRestante => FechaFin.HasValue ?
            (FechaFin.Value - System.DateTime.Now).ToString(@"hh\:mm\:ss") : "Sin periodo activo";
    }
}

