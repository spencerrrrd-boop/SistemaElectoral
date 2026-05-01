using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaElectoral1.Models
{
    public class Log
    {
        public int LogID { get; set; }
        public int? UsuarioID { get; set; }
        public string Accion { get; set; }
        public string Detalle { get; set; }
        public string IPMaquina { get; set; }
        public System.DateTime Timestamp { get; set; }

        // Constantes de acciones
        public const string ACCION_LOGIN = "LOGIN";
        public const string ACCION_LOGOUT = "LOGOUT";
        public const string ACCION_VOTO = "VOTO_EMITIDO";
        public const string ACCION_PLANCHA_CREADA = "PLANCHA_CREADA";
        public const string ACCION_USUARIO_REGISTRADO = "USUARIO_REGISTRADO";
        public const string ACCION_PERIODO_ABIERTO = "PERIODO_ABIERTO";
        public const string ACCION_PERIODO_CERRADO = "PERIODO_CERRADO";

        public Log()
        {
            Timestamp = System.DateTime.Now;
            IPMaquina = System.Net.Dns.GetHostName();
        }
    }
}
