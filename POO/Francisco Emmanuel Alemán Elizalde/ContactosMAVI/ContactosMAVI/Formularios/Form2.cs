using ContactosMAVI.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactosMAVI.Formularios
{
    public partial class Form2 : Form
    {
        //variables para habilitar o deshabilitar elementos del formulario
        public bool habilitar = false;
        public bool insertar = false;
        public bool editar = false;
        Contacto objContacto = new Contacto();

        //variables para imprimir en los textbox al buscar o editar un registro
        public string Nombre = "";
        public string Tipo = "";
        public string Sexo = "";
        public string Telefonofijo = "";
        public string Telefonomovil = "";
        public string Estado = "";
        public int id = 0;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
                if (habilitar == false)
                {
                    //deshabilitar los elementos del formulario 
                    txtNombre.Enabled = false;
                    cmbTipo.Enabled = false;
                    cmbSexo.Enabled = false;
                    cmbEstado.Enabled = false;
                    txtTelefonofijo.Enabled = false;
                    txtTelefonomovil.Enabled = false;
                    mcfecha.Enabled = false;
                    btnGuardar.Enabled = false;

                    cargarDatos();



                }
                if (habilitar == true)
                {
                    btnGuardar.Enabled = true;
                    cargarDatos();
                }

            textBox1.Visible = false;
            textBox2.Visible = false;
            txtID.Visible    = false;




        }

        //carga los datos de la busqueda al hacer clic en editar o ver contacto
        private void cargarDatos()
        {
            txtNombre.Text = Nombre;
            cmbTipo.Text = Tipo;
            cmbSexo.Text = Sexo;
            txtTelefonofijo.Text = Telefonofijo;
            txtTelefonomovil.Text = Telefonomovil;
            cmbEstado.Text = Estado;
            textBox2.Text = Convert.ToString(id);
        }

       

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            //Set de las propiedaddes dela clase contacto
            objContacto.Nombre = txtNombre.Text;
            objContacto.TipoContacto = cmbTipo.Text;
            objContacto.Telefono_Fijo = txtTelefonofijo.Text;
            objContacto.Telefono_Movil = txtTelefonomovil.Text;
            textBox1.Text = mcfecha.SelectionEnd.ToShortDateString();
            objContacto.Fecha_Nacimiento = textBox1.Text;

            objContacto.Sexo = cmbSexo.Text;
            objContacto.EstadoCivil = cmbEstado.Text;

            objContacto.ID = Convert.ToInt32(textBox2.Text);

            if (insertar == true)
            {
                //Contacto buscarIDcontacto = new Contacto();
                //verifica que los campos se llenen por completo
                if (txtNombre.Text == "" || cmbTipo.Text == "" || txtTelefonomovil.Text == "" || textBox1.Text == "" || cmbSexo.Text == "" || cmbEstado.Text == "" || txtTelefonomovil.TextLength != 10 ||txtTelefonofijo.TextLength !=10)
                {
                    MessageBox.Show("Ingrese todos los datos y verifique que los telefonos cuenten con 10 dígitos");
                }
                else
                {
                    objContacto.BuscarId();
                    txtID.Text = Convert.ToString(objContacto.ID);
                    if (txtID.Text == "0")
                    {
                        objContacto.Insertar();
                        MessageBox.Show("Contacto creado");
                    }
                    else if (txtID.Text != "0")
                    {
                        MessageBox.Show("Registro encontrado, los datos se actualizaran");
                        objContacto.Editar();
                    }
                    //almacena informacion
                    //
                }


            }
            else if (insertar == false)
            {
                //Edita la información
                objContacto.Editar();
                MessageBox.Show("Los datos se han actualizado");
            }
          
            
            
        }

        private void txtTelefonofijo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Solo permitir numeros en el textbox
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
          
        }

        //Solo permitir valores numéricos
        private void txtTelefonomovil_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
