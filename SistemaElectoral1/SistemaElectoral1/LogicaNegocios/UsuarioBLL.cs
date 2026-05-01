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
    public class UsuarioBLL
    {
        private static string HashContrasena(string contrasena)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(contrasena));
                StringBuilder sb = new StringBuilder();
                foreach (byte b in bytes)
                    sb.Append(b.ToString("X2"));
                return sb.ToString();
            }
        }

        public static Usuario Login(string matricula, string contrasena)
        {
            if (string.IsNullOrEmpty(matricula) || string.IsNullOrEmpty(contrasena))
                return null;
            string hash = HashContrasena(contrasena);
            return UsuarioDAL.Login(matricula, hash);
        }

        public static (bool exito, string mensaje) Registrar(Usuario u, string contrasena)
        {
            if (string.IsNullOrEmpty(u.Matricula))
                return (false, "La matrícula es obligatoria.");
            if (string.IsNullOrEmpty(u.Nombre) || string.IsNullOrEmpty(u.Apellido))
                return (false, "El nombre y apellido son obligatorios.");
            if (string.IsNullOrEmpty(contrasena) || contrasena.Length < 6)
                return (false, "La contraseña debe tener al menos 6 caracteres.");
            if (UsuarioDAL.MatriculaExiste(u.Matricula))
                return (false, "Esta matrícula ya está registrada.");
            string hash = HashContrasena(contrasena);
            bool resultado = UsuarioDAL.Registrar(u, hash);
            return resultado ? (true, "Usuario registrado exitosamente.")
                             : (false, "Error al registrar el usuario.");
        }

        public static List<Usuario> ObtenerTodos()
        {
            return UsuarioDAL.ObtenerTodos();
        }

        public static (bool exito, string mensaje) Desactivar(int usuarioID)
        {
            bool resultado = UsuarioDAL.Desactivar(usuarioID);
            return resultado ? (true, "Usuario desactivado correctamente.")
                             : (false, "Error al desactivar el usuario.");
        }

        public static bool EsDirector(Usuario u) => u != null && u.NombreRol == Rol.DIRECTOR;
        public static bool EsAdministrador(Usuario u) => u != null && u.NombreRol == Rol.ADMINISTRADOR;
        public static bool EsVotante(Usuario u) => u != null && u.NombreRol == Rol.VOTANTE;
    }
}
