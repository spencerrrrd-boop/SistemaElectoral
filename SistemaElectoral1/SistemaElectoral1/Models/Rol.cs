using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaElectoral1.Models
{
    public class Rol
    {
        public int RolID { get; set; }
        public string NombreRol { get; set; }
        public string Descripcion { get; set; }

        // Constantes para evitar strings magicos en el codigo
        public const string DIRECTOR = "Director";
        public const string ADMINISTRADOR = "Administrador";
        public const string VOTANTE = "Votante";
    }
}