using CRUD_POO2.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_POO2
{
    public partial class Form1 : Form
    {

        Productos Obj_Productos = new Productos();
        private string idProd = null; //para editar un producto
        private bool editar = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarProductos();
        }

        private void MostrarProductos()
        {
            Productos Obj = new Productos();
            dataGridView1.DataSource = Obj.Mostrar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (editar == false)
            {
                double precio = Convert.ToDouble(txtprecio.Text);
                int stock = Convert.ToInt32(txtstock.Text);
                Obj_Productos.Insertar(txtnombre.Text, txtdesc.Text, txtmarca.Text, precio, stock);
                MostrarProductos();
            }

            if (editar == true)
            {
                double precio = Convert.ToDouble(txtprecio.Text);
                int stock = Convert.ToInt32(txtstock.Text);
                int id = Convert.ToInt32(idProd);
                Obj_Productos.Editar(txtnombre.Text, txtdesc.Text, txtmarca.Text, precio, stock, id);

                MostrarProductos();
                editar = false;
            }
            

        }

        private void txtEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                editar = true;
                //Envia losdatos de la tabla a los textbox
                txtnombre.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                txtdesc.Text = dataGridView1.CurrentRow.Cells["Descripcion"].Value.ToString();
                txtmarca.Text = dataGridView1.CurrentRow.Cells["Marca"].Value.ToString();
                txtprecio.Text = dataGridView1.CurrentRow.Cells["Precio"].Value.ToString();
                txtstock.Text = dataGridView1.CurrentRow.Cells["Stock"].Value.ToString();
                idProd = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
            }
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            idProd = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
            int val = Convert.ToInt32(idProd);
            Obj_Productos.Eliminar(val);
        }
    }
}
