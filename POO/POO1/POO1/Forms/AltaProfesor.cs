using POO1.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace POO1.Forms
{
    public partial class AltaProfesor : POO1.Forms.AltaEmpleados
    {
        public AltaProfesor()
        {
            InitializeComponent();
        }

        private void btnAgregarProfesor_Click(object sender, EventArgs e)
        {
            //para usar los textBox del fotmulario alta empleado hay que cambiar sus propoiedades 
            //a protected
            string clave        = txtClave.Text;
            string nombre       = txtNombre.Text;
            int edad            = Convert.ToInt32(txtEdad.Text);
            string escolaridad  = txtEscolaridad.Text;

            //Ahora si usamos la clase Profesor
            Profesor objProfesor = new Profesor(clave, nombre, edad, escolaridad);
            //guardamos los datos del profesor en la clase datos
            Datos.addEmple(objProfesor);
            this.Close();
        }
    }
}
