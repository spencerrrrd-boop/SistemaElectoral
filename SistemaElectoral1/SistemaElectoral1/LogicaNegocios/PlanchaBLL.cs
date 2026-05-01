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
    public class PlanchaBLL
    {
        public static List<Plancha> ObtenerTodas()
        {
            return PlanchaDAL.ObtenerTodas();
        }

        public static Plancha ObtenerMiPlancha(int administradorID)
        {
            return PlanchaDAL.ObtenerPorAdministrador(administradorID);
        }

        public static (bool exito, string mensaje) Registrar(Plancha p)
        {
            if (string.IsNullOrEmpty(p.NombrePlancha))
                return (false, "El nombre de la plancha es obligatorio.");
            if (p.AdministradorID == 0)
                return (false, "La plancha debe tener un administrador.");
            bool resultado = PlanchaDAL.Registrar(p);
            return resultado ? (true, "Plancha registrada exitosamente.")
                             : (false, "Error al registrar la plancha.");
        }

        public static (bool exito, string mensaje) Actualizar(Plancha p, int usuarioLogueadoID)
        {
            if (p.AdministradorID != usuarioLogueadoID)
                return (false, "No tienes permiso para editar esta plancha.");
            if (string.IsNullOrEmpty(p.NombrePlancha))
                return (false, "El nombre de la plancha es obligatorio.");
            bool resultado = PlanchaDAL.Actualizar(p);
            return resultado ? (true, "Plancha actualizada correctamente.")
                             : (false, "Error al actualizar la plancha.");
        }
    }
}
