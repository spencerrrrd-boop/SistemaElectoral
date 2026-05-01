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
    public class UsuarioDAL
    {
        // Obtener usuario por matricula y contrasena (para el login)
        public static Usuario Login(string matricula, string contrasena)
        {
            Usuario usuario = null;
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                string query = @"SELECT u.UsuarioID, u.Matricula, u.Nombre, u.Apellido, 
                                        u.RolID, r.NombreRol, u.PadronID, u.Activo
                                 FROM Usuarios u
                                 JOIN Roles r ON r.RolID = u.RolID
                                 WHERE u.Matricula = @Matricula 
                                 AND u.Contrasena = @Contrasena
                                 AND u.Activo = 1";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@Matricula", matricula);
                cmd.Parameters.AddWithValue("@Contrasena", contrasena);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    usuario = new Usuario
                    {
                        UsuarioID = (int)dr["UsuarioID"],
                        Matricula = dr["Matricula"].ToString(),
                        Nombre = dr["Nombre"].ToString(),
                        Apellido = dr["Apellido"].ToString(),
                        RolID = (int)dr["RolID"],
                        NombreRol = dr["NombreRol"].ToString(),
                        PadronID = dr["PadronID"] == System.DBNull.Value ? (int?)null : (int)dr["PadronID"],
                        Activo = (bool)dr["Activo"]
                    };
                }
            }
            return usuario;
        }

        // Obtener todos los usuarios
        public static List<Usuario> ObtenerTodos()
        {
            List<Usuario> lista = new List<Usuario>();
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                string query = @"SELECT u.UsuarioID, u.Matricula, u.Nombre, u.Apellido,
                                        u.RolID, r.NombreRol, u.PadronID,
                                        p.Curso, p.Seccion, u.Activo
                                 FROM Usuarios u
                                 JOIN Roles r ON r.RolID = u.RolID
                                 LEFT JOIN Padrones p ON p.PadronID = u.PadronID
                                 ORDER BY u.Nombre";
                SqlCommand cmd = new SqlCommand(query, cn);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new Usuario
                    {
                        UsuarioID = (int)dr["UsuarioID"],
                        Matricula = dr["Matricula"].ToString(),
                        Nombre = dr["Nombre"].ToString(),
                        Apellido = dr["Apellido"].ToString(),
                        RolID = (int)dr["RolID"],
                        NombreRol = dr["NombreRol"].ToString(),
                        PadronID = dr["PadronID"] == System.DBNull.Value ? (int?)null : (int)dr["PadronID"],
                        Curso = dr["Curso"] == System.DBNull.Value ? "" : dr["Curso"].ToString(),
                        Seccion = dr["Seccion"] == System.DBNull.Value ? "" : dr["Seccion"].ToString(),
                        Activo = (bool)dr["Activo"]
                    });
                }
            }
            return lista;
        }

        // Registrar un nuevo usuario
        public static bool Registrar(Usuario u, string contrasenaHash)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                string query = @"INSERT INTO Usuarios 
                                    (Matricula, Nombre, Apellido, Contrasena, RolID, PadronID)
                                 VALUES 
                                    (@Matricula, @Nombre, @Apellido, @Contrasena, @RolID, @PadronID)";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@Matricula", u.Matricula);
                cmd.Parameters.AddWithValue("@Nombre", u.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", u.Apellido);
                cmd.Parameters.AddWithValue("@Contrasena", contrasenaHash);
                cmd.Parameters.AddWithValue("@RolID", u.RolID);
                cmd.Parameters.AddWithValue("@PadronID", u.PadronID.HasValue ? (object)u.PadronID.Value : System.DBNull.Value);
                cn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Verificar si una matricula ya existe
        public static bool MatriculaExiste(string matricula)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                string query = "SELECT COUNT(*) FROM Usuarios WHERE Matricula = @Matricula";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@Matricula", matricula);
                cn.Open();
                return (int)cmd.ExecuteScalar() > 0;
            }
        }

        // Desactivar usuario
        public static bool Desactivar(int usuarioID)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                string query = "UPDATE Usuarios SET Activo = 0 WHERE UsuarioID = @UsuarioID";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@UsuarioID", usuarioID);
                cn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
