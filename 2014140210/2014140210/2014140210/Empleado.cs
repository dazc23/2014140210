using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014140210
{
    public class Empleado
    {
        public String  nombre { get; set; }
        public String apellido { get; set; }
        public String correo { get; set; }
        public decimal sueldo { get; set; }

        public Empleado (String nombre, String apellido, String correo, decimal sueldo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.correo = correo;
            this.sueldo = sueldo;
        }
    }
}
