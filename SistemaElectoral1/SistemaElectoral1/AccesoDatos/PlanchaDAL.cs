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
    public class PlanchaDAL
    {
        // Obtener todas las planchas
        public static List<Plancha> ObtenerTodas()
        {
            List<Plancha> lista = new List<Plancha>();
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                string query = @"SELECT p.PlanchaID, p.NombrePlancha, p.Lema, p.LogoRuta,
                                        p.AdministradorID, p.Activa, p.FechaCreacion,
                                        u.Nombre + ' ' + u.Apellido AS NombreAdministrador
                                 FROM Planchas p
                                 JOIN Usuarios u ON u.UsuarioID = p.AdministradorID
                                 ORDER BY p.NombrePlancha";
                SqlCommand cmd = new SqlCommand(query, cn);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new Plancha
                    {
                        PlanchaID = (int)dr["PlanchaID"],
                        NombrePlancha = dr["NombrePlancha"].ToString(),
                        Lema = dr["Lema"] == System.DBNull.Value ? "" : dr["Lema"].ToString(),
                        LogoRuta = dr["LogoRuta"] == System.DBNull.Value ? "" : dr["LogoRuta"].ToString(),
                        AdministradorID = (int)dr["AdministradorID"],
                        Activa = (bool)dr["Activa"],
                        FechaCreacion = (System.DateTime)dr["FechaCreacion"],
                        NombreAdministrador = dr["NombreAdministrador"].ToString()
                    });
                }
            }
            return lista;
        }

        // Obtener plancha por administrador (para el rol Administrador)
        public static Plancha ObtenerPorAdministrador(int administradorID)
        {
            Plancha plancha = null;
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                string query = @"SELECT p.PlanchaID, p.NombrePlancha, p.Lema, p.LogoRuta,
                                        p.AdministradorID, p.Activa, p.FechaCreacion,
                                        u.Nombre + ' ' + u.Apellido AS NombreAdministrador
                                 FROM Planchas p
                                 JOIN Usuarios u ON u.UsuarioID = p.AdministradorID
                                 WHERE p.AdministradorID = @AdministradorID";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@AdministradorID", administradorID);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    plancha = new Plancha
                    {
                        PlanchaID = (int)dr["PlanchaID"],
                        NombrePlancha = dr["NombrePlancha"].ToString(),
                        Lema = dr["Lema"] == System.DBNull.Value ? "" : dr["Lema"].ToString(),
                        LogoRuta = dr["LogoRuta"] == System.DBNull.Value ? "" : dr["LogoRuta"].ToString(),
                        AdministradorID = (int)dr["AdministradorID"],
                        Activa = (bool)dr["Activa"],
                        FechaCreacion = (System.DateTime)dr["FechaCreacion"],
                        NombreAdministrador = dr["NombreAdministrador"].ToString()
                    };
                }
            }
            return plancha;
        }

        // Registrar nueva plancha
        public static bool Registrar(Plancha p)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                string query = @"INSERT INTO Planchas 
                                    (NombrePlancha, Lema, LogoRuta, AdministradorID)
                                 VALUES 
                                    (@NombrePlancha, @Lema, @LogoRuta, @AdministradorID)";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@NombrePlancha", p.NombrePlancha);
                cmd.Parameters.AddWithValue("@Lema", string.IsNullOrEmpty(p.Lema) ? (object)System.DBNull.Value : p.Lema);
                cmd.Parameters.AddWithValue("@LogoRuta", string.IsNullOrEmpty(p.LogoRuta) ? (object)System.DBNull.Value : p.LogoRuta);
                cmd.Parameters.AddWithValue("@AdministradorID", p.AdministradorID);
                cn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Actualizar plancha
        public static bool Actualizar(Plancha p)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                string query = @"UPDATE Planchas 
                                 SET NombrePlancha = @NombrePlancha,
                                     Lema = @Lema,
                                     LogoRuta = @LogoRuta
                                 WHERE PlanchaID = @PlanchaID
                                 AND AdministradorID = @AdministradorID";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@NombrePlancha", p.NombrePlancha);
                cmd.Parameters.AddWithValue("@Lema", string.IsNullOrEmpty(p.Lema) ? (object)System.DBNull.Value : p.Lema);
                cmd.Parameters.AddWithValue("@LogoRuta", string.IsNullOrEmpty(p.LogoRuta) ? (object)System.DBNull.Value : p.LogoRuta);
                cmd.Parameters.AddWithValue("@PlanchaID", p.PlanchaID);
                cmd.Parameters.AddWithValue("@AdministradorID", p.AdministradorID);
                cn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
