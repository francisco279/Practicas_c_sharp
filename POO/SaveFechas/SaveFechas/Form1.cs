using System;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace SaveFechas
{
    public partial class Form1 : Form
    {
        //instanciamos la clase de conexion a la base de datos
        private ConexionBD Conexion = new ConexionBD();
        private SqlCommand Comando = new SqlCommand();



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            monthCalendar1.Visible = false;
            monthCalendar2.Visible = false;
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            monthCalendar1.Visible = true;
            monthCalendar2.Visible = false;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            monthCalendar2.Visible = true;
            monthCalendar1.Visible = false;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBox1.Text = monthCalendar1.SelectionEnd.Date.ToString();
            //monthCalendar1.Visible = false;
        }

        private void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBox2.Text = monthCalendar2.SelectionEnd.Date.ToString();
            
        }

        private void btn_Click(object sender, EventArgs e)
        {
            //Verificamos que no esten vacios los textbox
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Los campos no contienen datos");
            }
            else
            {
                //Convertimos nuestros textbox a tipo de datos Date
                DateTime fecha_inicial = Convert.ToDateTime(textBox3.Text);
                DateTime fecha_final = Convert.ToDateTime(textBox4.Text);

                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "Insert into Fechas values('" + textBox3.Text + "', '"+ textBox4.Text + "')";
                Comando.ExecuteNonQuery();
                Comando.Parameters.Clear();
                Conexion.CerrarConexion();

            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = textBox1.Text.Substring(1, 10);
            textBox4.Text = textBox2.Text.Substring(1, 10);
        }
    }
}
