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

namespace SistemaElectoral1.LogicaNegocio
{
    public class VotoBLL
    {
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

        public static (bool exito, string mensaje) EmitirVoto(int usuarioID, int? planchaID, bool esNulo)
        {
            if (VotoDAL.UsuarioYaVoto(usuarioID))
                return (false, "Ya has emitido tu voto. No puedes votar dos veces.");
            if (!esNulo && planchaID == null)
                return (false, "Debes seleccionar una plancha o marcar voto nulo.");
            string hash = GenerarHashVoto(usuarioID, planchaID, esNulo);
            bool resultado = VotoDAL.RegistrarVoto(usuarioID, planchaID, esNulo, hash);
            return resultado ? (true, "Voto emitido exitosamente.")
                             : (false, "Error al registrar el voto.");
        }

        public static bool UsuarioYaVoto(int usuarioID)
        {
            return VotoDAL.UsuarioYaVoto(usuarioID);
        }

        public static PanelGeneral ObtenerPanelGeneral()
        {
            return VotoDAL.ObtenerPanelGeneral();
        }

        public static List<ResultadoPlancha> ObtenerResultados()
        {
            return VotoDAL.ObtenerResultados();
        }
    }
}
