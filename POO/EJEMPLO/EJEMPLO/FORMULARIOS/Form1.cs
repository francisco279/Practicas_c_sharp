using EJEMPLO.CLASES;
using EJEMPLO.FORMULARIOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJEMPLO
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Profesor Lprof = new Profesor(txtNombre.Text, Convert.ToInt32(txtEdad.Text), txtFoto.Text, comboBox1.Text, txtEscolaridad.Text, txtcvu.Text);
            Lprof.Insertar(txtEscolaridad.Text, txtcvu.Text, comboBox2.Text);
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Chofer chofi = new Chofer(txtNombre.Text, Convert.ToInt32(txtEdad.Text), txtFoto.Text, comboBox1.Text, comboBox2.Text);
            chofi.Insertar(txtEscolaridad.Text, txtcvu.Text, comboBox2.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Chofer chofi = new Chofer(txtNombre.Text, Convert.ToInt32(txtEdad.Text), txtFoto.Text, comboBox1.Text, comboBox2.Text);
            chofi.EditarChofer(Convert.ToInt32(txtclaveEditar.Text));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 fo = new Form2();
            fo.Show();
        }
    }
}
