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
    public class PadronDAL
    {
        public static List<Padron> ObtenerTodos()
        {
            List<Padron> lista = new List<Padron>();
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                string query = @"SELECT PadronID, Curso, Seccion, Anio, Activo
                                 FROM Padrones
                                 ORDER BY Curso, Seccion";
                SqlCommand cmd = new SqlCommand(query, cn);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new Padron
                    {
                        PadronID = (int)dr["PadronID"],
                        Curso = dr["Curso"].ToString(),
                        Seccion = dr["Seccion"].ToString(),
                        Anio = (int)dr["Anio"],
                        Activo = (bool)dr["Activo"]
                    });
                }
            }
            return lista;
        }

        public static bool Registrar(Padron p)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                string query = @"INSERT INTO Padrones (Curso, Seccion, Anio)
                                 VALUES (@Curso, @Seccion, @Anio)";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@Curso", p.Curso);
                cmd.Parameters.AddWithValue("@Seccion", p.Seccion);
                cmd.Parameters.AddWithValue("@Anio", p.Anio);
                cn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public static Padron ObtenerPorID(int padronID)
        {
            Padron padron = null;
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                string query = @"SELECT PadronID, Curso, Seccion, Anio, Activo
                                 FROM Padrones WHERE PadronID = @PadronID";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@PadronID", padronID);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    padron = new Padron
                    {
                        PadronID = (int)dr["PadronID"],
                        Curso = dr["Curso"].ToString(),
                        Seccion = dr["Seccion"].ToString(),
                        Anio = (int)dr["Anio"],
                        Activo = (bool)dr["Activo"]
                    };
                }
            }
            return padron;
        }
    }
}
