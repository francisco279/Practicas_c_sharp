using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO1.Clases
{
    class Empleado
    {
        private string  clave;
        private string  nombre;
        private int     edad;
        //private Image   foto;

        public string Clave
        {
            get { return clave; }
            set { clave = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Edad
        {
            get { return edad; }
            set {
                //verificamos que la edad este dentro del rango de o a 100
                if (value > 0 && value <= 100)
                    edad = value;
                else
                    edad = 0;
            }
        }
        /*
        public Image Foto
        {
            get { return foto; }
            set { foto = value; }
        }
        */

        //metodo constructor para inicializar el empleado
        //Con el mismo nombre de la clase
        public Empleado(string claveEmpleado, string nombreEmpleado, int edadEmpleado) //Image foto
        {
            this.Clave  = claveEmpleado;
            this.Nombre = nombreEmpleado;
            this.Edad   = edadEmpleado;
            //this.Foto   = foto;
        }

        //Metodo accion
        //Metodo que se puede sobreescribir por eso se usa la propiedad virtual
        public virtual void accion()
        {

        }
    }
}
