using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUD_INENER_JOIN.DATOS;

namespace CRUD_INENER_JOIN
{
    public partial class Form1 : Form
    {
        //PAra las actualizaciones, inserciones y eliminaciones 
        //En las busquedas hay que instanciar nuevamente la clase
        ClsProductos objProducto = new ClsProductos();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListarCategorias();
            ListarMarcas();
            ListarProductos();
        }

        private void ListarCategorias()
        {
            ClsProductos objProd = new ClsProductos();
            cmbCategoria.DataSource = objProd.ListarCategorias();
            cmbCategoria.DisplayMember = "CATEGORIA";
            cmbCategoria.ValueMember = "IDCATEG";
        }

        private void ListarMarcas()
        {
            //Cada que se muestran datos hay qque instanciar la clase
            ClsProductos objProd = new ClsProductos();
            cmbMarca.DataSource = objProd.ListarMarcas();
            cmbMarca.DisplayMember = "MARCA";
            cmbMarca.ValueMember = "IDMARCA";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ClsProductos objProducto = new ClsProductos();
            objProducto.InsertarProductos(Convert.ToInt32(cmbCategoria.SelectedValue), Convert.ToInt32(cmbMarca.SelectedValue), txtDescripcion.Text, Convert.ToDouble(txtPrecio.Text));
            MessageBox.Show("Insertado correctamente");
            ListarProductos();

        }

        //usando el inner join
        private void ListarProductos()
        {
            ClsProductos objProd = new ClsProductos();
            dataGridView1.DataSource = objProd.ListarProductos();
            
        }

       
    }
}
