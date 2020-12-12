using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class Form1 : Form
    {
        SqlConnection conexion = new SqlConnection("server=localhost\\SQLEXPRESS ; database=PROYECTOFC# ; integrated security = true");
        public Form1()
        {
            InitializeComponent();
            try
            {
                conexion.Open();
                MessageBox.Show("Conectado");

            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (cbx_seccion.SelectedIndex == 0)
            {
                Cita ventana = new Cita(this);
                ventana.Show();
            }
            else if(cbx_seccion.SelectedIndex == 1)
            {
                FormCliente ventana = new FormCliente(this);
                ventana.Show();
            }
            else if (cbx_seccion.SelectedIndex == 2)
            {
                this.Hide();
                FormProfesional ventana = new FormProfesional(this);
                ventana.Show();
            }
        }
    }
}
