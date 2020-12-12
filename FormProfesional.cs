using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class FormProfesional : Form
    {
        SqlConnection conexion = new SqlConnection("server=localhost\\SQLEXPRESS ; database=PROYECTOFC# ; integrated security = true");
        Form ventana;
        public FormProfesional(Form v)
        {
            ventana = v;
            InitializeComponent();

        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Hide();
            ventana.Show();
        }

        private void FormProfesional_FormClosed(object sender, FormClosedEventArgs e)
        {
            ventana.Show();
        }

        private void btn_realizar_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("server=localhost\\SQLEXPRESS ; database=PROYECTOFC# ; integrated security = true");
            string query2 = "INSERT INTO DISPONIBILIDAD (Dias) VALUES (@dias)";
            conexion.Open();
            SqlCommand c2 = new SqlCommand(query2, conexion);
            c2.Parameters.AddWithValue("@dias", listbox_disponibilidad.SelectedItems);
            c2.ExecuteNonQuery();

            string query = "INSERT INTO PROFESIONAL (Nombre, Apellido, Telefono, Num_doc, Profesion) VALUES (@nombre, @apellido, @telefono, @num_doc, @profesion)";
            
            SqlCommand c = new SqlCommand(query, conexion);
            c.Parameters.AddWithValue("@nombre", txt_nombre.Text);
            c.Parameters.AddWithValue("@apellido", txt_apellido.Text);
            c.Parameters.AddWithValue("@telefono", txt_telefono.Text);
            c.Parameters.AddWithValue("@num_doc", txt_cedula.Text);
            c.Parameters.AddWithValue("@profesion", txt_profesion.Text);
            c.ExecuteNonQuery();
            MessageBox.Show("Valores Insertados");
        }

        private void btn_seleccionar_Click(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand("Select * from PROFESIONAL", conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataTable_profesional.DataSource = tabla;
        }
    }
}
