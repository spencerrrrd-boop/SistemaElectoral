using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using SistemaElectoral1.Models;
using System.Collections.Generic;

namespace SistemaElectoral1.AccesoDatos
{
    public class VotoDAL
    {
        // Registrar voto usando el stored procedure
        public static bool RegistrarVoto(int usuarioID, int? planchaID, bool esNulo, string hashVoto)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_RegistrarVoto", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UsuarioID", usuarioID);
                cmd.Parameters.AddWithValue("@PlanchaID", planchaID.HasValue ? (object)planchaID.Value : System.DBNull.Value);
                cmd.Parameters.AddWithValue("@EsNulo", esNulo);
                cmd.Parameters.AddWithValue("@HashVoto", hashVoto);
                cn.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
        }

        // Verificar si un usuario ya voto
        public static bool UsuarioYaVoto(int usuarioID)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_UsuarioYaVoto", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UsuarioID", usuarioID);
                SqlParameter outputParam = new SqlParameter("@YaVoto", System.Data.SqlDbType.Bit);
                outputParam.Direction = System.Data.ParameterDirection.Output;
                cmd.Parameters.Add(outputParam);
                cn.Open();
                cmd.ExecuteNonQuery();
                return (bool)outputParam.Value;
            }
        }

        // Obtener estadisticas generales
        public static PanelGeneral ObtenerPanelGeneral()
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                string query = "SELECT * FROM vw_PanelGeneral";
                SqlCommand cmd = new SqlCommand(query, cn);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    return new PanelGeneral
                    {
                        TotalPadron = (int)dr["TotalPadron"],
                        VotosEmitidos = (int)dr["VotosEmitidos"],
                        VotosNulos = (int)dr["VotosNulos"],
                        FechaFin = dr["FechaFin"] == System.DBNull.Value ? (System.DateTime?)null : (System.DateTime)dr["FechaFin"]
                    };
                }
                return new PanelGeneral();
            }
        }

        // Obtener resultados por plancha
        public static List<ResultadoPlancha> ObtenerResultados()
        {
            List<ResultadoPlancha> lista = new List<ResultadoPlancha>();
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                string query = "SELECT * FROM vw_ResultadosPorPlancha ORDER BY TotalVotos DESC";
                SqlCommand cmd = new SqlCommand(query, cn);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new ResultadoPlancha
                    {
                        PlanchaID = (int)dr["PlanchaID"],
                        NombrePlancha = dr["NombrePlancha"].ToString(),
                        LogoRuta = dr["LogoRuta"] == System.DBNull.Value ? "" : dr["LogoRuta"].ToString(),
                        TotalVotos = (int)dr["TotalVotos"],
                        PorcentajeVotos = dr["PorcentajeVotos"] == System.DBNull.Value ? 0 : (double)dr["PorcentajeVotos"]
                    });
                }
            }
            return lista;
        }
    }
}
