using System.Reflection;

namespace ShotcutPOO.Models
{
 

    public class Empleados
    {
        public int ID { get; set; }
        public string nombre_completo { get; set; }
        public string puesto { get; set; }
        public double sueldo_base { get; set; }
        public int horario { get; set; }
        public int jefe_inmediato_ID { get; set; }

    }

 
}