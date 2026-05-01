using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaElectoral1.AccesoDatos;
using SistemaElectoral1.Models;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using SistemaElectoral1.AccesoDatos;
using SistemaElectoral1.Models;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace SistemaElectoral1.LogicaNegocio
{
    public class VotoBLL
    {
        // Generar hash unico para el voto
        private static string GenerarHashVoto(int usuarioID, int? planchaID, bool esNulo)
        {
            string datos = $"{usuarioID}-{planchaID}-{esNulo}-{System.DateTime.Now.Ticks}";
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(datos));
                StringBuilder sb = new StringBuilder();
                foreach (byte b in bytes)
                    sb.Append(b.ToString("X2"));
                return sb.ToString();
            }
        }

        // Emitir voto con validaciones
        public static (bool exito, string mensaje) EmitirVoto(int usuarioID, int? planchaID, bool esNulo)
        {
            // Validar que no haya votado antes
            if (VotoDAL.UsuarioYaVoto(usuarioID))
                return (false, "Ya has emitido tu voto. No puedes votar dos veces.");

            // Validar que si no es nulo tenga plancha
            if (!esNulo && planchaID == null)
                return (false, "Debes seleccionar una plancha o marcar voto nulo.");

            string hash = GenerarHashVoto(usuarioID, planchaID, esNulo);

            bool resultado = VotoDAL.RegistrarVoto(usuarioID, planchaID, esNulo, hash);
            return resultado ? (true, "¡Voto emitido exitosamente!")
                             : (false, "Error al registrar el voto.");
        }

        // Verificar si usuario ya voto
        public static bool UsuarioYaVoto(int usuarioID)
        {
            return VotoDAL.UsuarioYaVoto(usuarioID);
        }

        // Obtener panel general
        public static PanelGeneral ObtenerPanelGeneral()
        {
            return VotoDAL.ObtenerPanelGeneral();
        }

        // Obtener resultados por plancha
        public static List<ResultadoPlancha> ObtenerResultados()
        {
            return VotoDAL.ObtenerResultados();
        }
    }
}
