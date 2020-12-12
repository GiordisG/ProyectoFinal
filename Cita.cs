using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class Cita : Form
    {
        SqlConnection conexion = new SqlConnection("server=localhost\\SQLEXPRESS ; database=PROYECTOFC# ; integrated security = true");
        Form c;
        public Cita(Form s)
        {
            c = s;
            InitializeComponent();
        }

        private void btn_realizar_Click(object sender, EventArgs e)
        {
            string estado_activo = "ACTIVO";
            lbl_estadoCita.Text = $"{estado_activo}";

            SqlConnection conexion = new SqlConnection("server=localhost\\SQLEXPRESS ; database=PROYECTOFC# ; integrated security = true");
            string query = "INSERT INTO CITA (Id_visitante, Id_profesional, Estado_cita, Fecha_reservado) VALUES (@id_visitante, @id_profesional, @estado_cita, @fecha_reservado)";
            conexion.Open();
            SqlCommand c = new SqlCommand(query, conexion);
            c.Parameters.AddWithValue("@id_visitante", cmb_cliente.Text);
            c.Parameters.AddWithValue("@id_profesional", cmb_profesional.Text);
            c.Parameters.AddWithValue("@estado_cita", lbl_estadoCita.Text);
            c.Parameters.AddWithValue("@fecha_reservado", dp_cita.Text);
            c.ExecuteNonQuery();
            MessageBox.Show("Valores Insertados");
        }

        private void btn_seleccionar_Click(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand("Select * from CITA", conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataTable_cita.DataSource = tabla;
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Hide();
            c.Show();
        }

        private void cmb_cliente_MouseClick(object sender, MouseEventArgs e)
        {
            SqlCommand comando = new SqlCommand("Select * from VISITANTE", conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            cmb_cliente.DataSource = tabla;
            cmb_cliente.DisplayMember = "NOMBRE";
        }

        private void cmb_profesional_MouseClick(object sender, MouseEventArgs e)
        {
            SqlCommand comando = new SqlCommand("Select * from PROFESIONAL", conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            cmb_profesional.DataSource = tabla;
            cmb_profesional.DisplayMember = "NOMBRE";
        }
    }
}
