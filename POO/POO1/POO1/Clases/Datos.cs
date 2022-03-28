using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Esta clase es estatica, solo para almacenar los datos y buscarlos de los
//empleados agregados
namespace POO1.Clases
{
    static class Datos
    {
        //lista para almacenar los empleados
        private static Empleado[] empleados = new Empleado[100];
        private static int indice = 0;

        //propiedad de solo lectura del tamaño del indice para los arrays
        public static int Size
        {
            get { return indice; }
        }
        

        //agregar un nuevo empleado a la lista
        public static void addEmple (Empleado nuevoEmpleado)
        {
            if (indice < 100)
            {
                empleados[indice] = nuevoEmpleado;
                indice++;
            }
        }

        public static Empleado GetEmpleado(int i)
        {
            if (i >= 0 && i <= 99)
            {
                return empleados[i];
            }
            else
            {
                return null;
            }
        }
    }
}
