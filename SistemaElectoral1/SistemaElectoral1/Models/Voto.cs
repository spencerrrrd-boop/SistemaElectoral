using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaElectoral1.Models
{
    public class Voto
    {
        public int VotoID { get; set; }
        public int UsuarioID { get; set; }
        public int PeriodoID { get; set; }
        public int? PlanchaID { get; set; }
        public bool EsNulo { get; set; }
        public System.DateTime Timestamp { get; set; }
        public string HashVoto { get; set; }

        public Voto()
        {
            Timestamp = System.DateTime.Now;
            EsNulo = false;
        }
    }
}