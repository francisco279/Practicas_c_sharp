using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJEMPLO.CLASES
{
    class Profesor : Empleados
    {
        private string escolaridad;

        public string Escolaridad
        {
            get { return escolaridad; }
            set { escolaridad = value; }
        }

        private string cvu;

        public string CVU
        {
            get { return cvu; }
            set { cvu = value; }
        }

        //metodo constructor
        public Profesor(string nombre, int edad, string foto, string tipoEmpleado, string escolaridad, string cvu)
                        :base(nombre ,         edad     ,    foto   , tipoEmpleado)
        {
            this.Escolaridad    = escolaridad;
            this.CVU            = cvu;
        }
        
    }
}
