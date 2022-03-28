using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO1.Clases
{
    class Profesor : Empleado //Profesor hereda de la clase empleado
    {
        private string escolaridad;
        //private string cvu;

        public string Escolaridad
        {
            get { return escolaridad; }
            set { escolaridad = value; }
        }

        /* public string CVU
         {
             get { return cvu; }
             set { cvu = value; }
         }
         */

        //constructor 
        public Profesor (string claveProfesor, string nombreProfesor, int edadProfesor, string escolaridadProfesor) //Image foto)//string cvu)
                        : base(claveProfesor,         nombreProfesor,     edadProfesor)   //  foto
            //el unico dato que se usa es escolaridadProfesor (solo eso por eso se usa el base)
        {
            this.Escolaridad = escolaridadProfesor;
            //this.CVU = cvu;
        }

        public override string ToString()
        {
            return "Experiencia = " + Escolaridad;
        }

        /*
        public override void accion()
        {
            Process.Start(cvu);
        }
        */
    }
}
