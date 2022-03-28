using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Figuras
{
    class Program
    {
        static void Main(string[] args)
        {
            Operación op = new Operación();
            Console.WriteLine("5.2 + 9.1 = " + op.multiplicacion(5.2, 9.1));
            Console.Write("Introduce un número: ");
            op.ParametroUno = Double.Parse(Console.ReadLine());
            Console.Write("Introduce un número: ");
            op.ParametroDos = Double.Parse(Console.ReadLine());
            Console.WriteLine("El resultado es: " + op.multiplicacion());
            Console.ReadLine();
        }
    }
}
