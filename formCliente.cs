using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class FormCliente : Form
    {
        SqlConnection conexion = new SqlConnection("server=localhost\\SQLEXPRESS ; database=PROYECTOFC# ; integrated security = true");
        Form c;
        public FormCliente(Form s)
        {
            c = s;
            InitializeComponent();

        }
        private void btn_conectar_Click(object sender, EventArgs e)
        {
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
        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Hide();
            c.Show();

        }

        private void FormCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            c.Show();
        }

        private void btn_realizar_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("server=localhost\\SQLEXPRESS ; database=PROYECTOFC# ; integrated security = true");
            string query = "INSERT INTO VISITANTE (Nombre, Apellido, Telefono, Num_doc, Tipo_doc) VALUES (@nombre, @apellido, @telefono, @num_doc, @tipo_doc)";
            conexion.Open();
            SqlCommand c = new SqlCommand(query, conexion);
            c.Parameters.AddWithValue("@nombre", txt_nombre.Text);
            c.Parameters.AddWithValue("@apellido", txt_apellido.Text);
            c.Parameters.AddWithValue("@telefono", txt_telefono.Text);
            c.Parameters.AddWithValue("@num_doc", txt_cedula.Text);
            c.Parameters.AddWithValue("@tipo_doc", txt_tipoDoc.Text);
            c.ExecuteNonQuery();
            MessageBox.Show("Insertado");
        }

        private void btn_seleccionar_Click(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand("Select * from VISITANTE", conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataTable_cliente.DataSource = tabla;
        }
    }
}
