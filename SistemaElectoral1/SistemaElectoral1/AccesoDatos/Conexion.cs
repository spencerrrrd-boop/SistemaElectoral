using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace SistemaElectoral1.AccesoDatos
{
    public class Conexion
    {
        private static readonly string _cadenaConexion =
            "Server=DESKTOP-6EUMOCJ\\SQLEXPRESS01;Database=SistemaElectoral;Trusted_Connection=True;TrustServerCertificate=True;";

        public static SqlConnection ObtenerConexion()
        {
            return new SqlConnection(_cadenaConexion);
        }
    }
}
