using ContactosMAVI.Clases;
using ContactosMAVI.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactosMAVI
{
    public partial class Form1 : Form
    {

        Contacto Newcon = new Contacto();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //muestra todos los contactos en la tabla
            ListarContactos();

        }

        //funcion para buscar contactos por nombre
        private void ListarContactosporNombre()
        {
            Contacto con1 = new Contacto();
            con1.Nombre = txtBuscar.Text;
            dataGridView1.DataSource = con1.Mostrar();
        }

        //muestra todos los contactos
        private void ListarContactos()
        {
            Contacto con = new Contacto();
            dataGridView1.DataSource = con.MostrarTodos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListarContactosporNombre();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Elimina un contatos seleccionado 
            //Para eliminar hay que seleccionar toda la fila y despuesdar click en eliminar
            if (dataGridView1.SelectedRows.Count > 0)
            {
                txtBuscar.Text = dataGridView1.CurrentRow.Cells["idContacto"].Value.ToString();
                Newcon.ID = Convert.ToInt32(txtBuscar.Text);
                Newcon.Eliminar();
                ListarContactos();
            }

        }

        private void txtMostrarTodos_Click(object sender, EventArgs e)
        {
            //muestra los contactos en la tabla
            ListarContactos();
        }

        //envia al segundo formulario 
        private void btnVer_Click(object sender, EventArgs e)
        {
            Contacto con2 = new Contacto();
            //Al hacer clic envia el id para realizar una busqueda en la clase contactos
            txtBuscar.Text = dataGridView1.CurrentRow.Cells["idContacto"].Value.ToString();
            con2.ID = Convert.ToInt32(txtBuscar.Text);
            con2.Buscar();

            //envia al formulario dos los valores de las propiedades de la clase contacto
            Form2 form2 = new Form2();
            form2.habilitar = false;
            form2.Nombre = con2.Nombre;
            form2.Tipo = con2.TipoContacto;
            form2.Sexo = con2.Sexo;
            form2.Telefonofijo = con2.Telefono_Fijo;
            form2.Telefonomovil = con2.Telefono_Movil;
            form2.Estado = con2.EstadoCivil;

            form2.Show();
        }

        private void btnAñadirContacto_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.habilitar = true;
            form2.insertar = true;
            form2.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            Contacto con2 = new Contacto();
            txtBuscar.Text = dataGridView1.CurrentRow.Cells["idContacto"].Value.ToString();
            con2.ID = Convert.ToInt32(txtBuscar.Text);
            con2.Buscar();

            Form2 form2 = new Form2();
            form2.habilitar = false;
            form2.Nombre = con2.Nombre;
            form2.Tipo = con2.TipoContacto;
            form2.Sexo = con2.Sexo;
            form2.Telefonofijo = con2.Telefono_Fijo;
            form2.Telefonomovil = con2.Telefono_Movil;
            form2.Estado = con2.EstadoCivil;
            form2.id = con2.ID;


            form2.habilitar = true;
            form2.insertar = false;
            form2.Show();
        }
    }
}
