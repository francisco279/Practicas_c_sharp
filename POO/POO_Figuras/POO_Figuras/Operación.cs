using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Figuras
{
    class Operación
    {
        //encapsulacion
        private double resultado;
        private double parametroUno;
        private double parametroDos;


        public double Resultado
        {
            get { return resultado; }
            set { resultado = value; }
        }

        public double ParametroUno
        {
            get { return parametroUno; }
            set { parametroUno = value; }
        }

      
        public double ParametroDos
        {
            get { return parametroDos; }
            set { parametroDos = value; }
        }

        public double multiplicacion(double valorUno, double valorDos)
        {
            resultado = valorUno * valorDos;
            return resultado;
        }

        public double multiplicacion()
        {
            this.Resultado = this.ParametroUno * ParametroDos;
            return Resultado;
        }

    }
}
