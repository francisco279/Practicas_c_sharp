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
    public partial class ALtaChofer : POO1.Forms.AltaEmpleados
    {
        public ALtaChofer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //para usar los textBox del fotmulario alta empleado hay que cambiar sus propoiedades 
            //a protected
            string clave = txtClave.Text;
            string nombre = txtNombre.Text;
            int edad = Convert.ToInt32(txtEdad.Text);
            char licencia = Convert.ToChar(cbLicencia.Text); 

            //Ahora si usamos la clase Chofer

            Chofer objChofer = new Chofer(clave, nombre, edad, licencia);
            //guardamos los datos del chofer en la clase datos
            Datos.addEmple(objChofer);
            this.Close();
        }
    }
}
