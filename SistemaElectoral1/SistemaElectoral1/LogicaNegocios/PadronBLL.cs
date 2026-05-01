using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SistemaElectoral1.AccesoDatos;
using SistemaElectoral1.Models;
using System.Collections.Generic;

namespace SistemaElectoral1.LogicaNegocio
{
    public class PadronBLL
    {
        public static List<Padron> ObtenerTodos()
        {
            return PadronDAL.ObtenerTodos();
        }

        public static (bool exito, string mensaje) Registrar(Padron p)
        {
            if (string.IsNullOrEmpty(p.Curso))
                return (false, "El curso es obligatorio.");
            if (string.IsNullOrEmpty(p.Seccion))
                return (false, "La seccion es obligatoria.");
            if (p.Anio < 2024)
                return (false, "El año no es valido.");
            bool resultado = PadronDAL.Registrar(p);
            return resultado ? (true, "Padron registrado exitosamente.")
                             : (false, "Error al registrar el padron.");
        }

        public static Padron ObtenerPorID(int padronID)
        {
            return PadronDAL.ObtenerPorID(padronID);
        }
    }
}
