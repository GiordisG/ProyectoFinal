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
            SqlCommand comando = new SqlCommand("Select * from VISITANTE", conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            cmb_cliente.DataSource = tabla;

            for(int i = 0; i < 1; i++) {
                if (cmb_cliente.Text != (cmb_cliente.DisplayMember = "NOMBRE"))
                {
                    SqlConnection conexion2 = new SqlConnection("server=localhost\\SQLEXPRESS ; database=PROYECTOFC# ; integrated security = true");
                    string query2 = "INSERT INTO CITA (Id_visitante) VALUES (@id_visitante)";
                    conexion2.Open();
                    SqlCommand c2 = new SqlCommand(query2, conexion2);
                    c2.Parameters.AddWithValue("@id_visitante", i);
                    
                }
                    
            }
            SqlCommand comando2 = new SqlCommand("Select * from PROFESIONAL", conexion);
            SqlDataAdapter adaptador2 = new SqlDataAdapter();
            adaptador2.SelectCommand = comando2;
            DataTable tabla2 = new DataTable();
            adaptador2.Fill(tabla2);
            cmb_cliente.DataSource = tabla;
            for(int k = 0; k < 1; k++) {
                if (cmb_cliente.Text == (cmb_cliente.DisplayMember = "NOMBRE"))
                {
                    SqlConnection conexion3 = new SqlConnection("server=localhost\\SQLEXPRESS ; database=PROYECTOFC# ; integrated security = true");
                    string query3 = "INSERT INTO CITA (Id_profesional) VALUES (@id_profesional)";
                    conexion.Open();
                    SqlCommand c3 = new SqlCommand(query3, conexion3);
                    c3.Parameters.AddWithValue("@id_profesional", k);
                    c3.ExecuteNonQuery();
                }
                    
            }
            SqlConnection conexion4 = new SqlConnection("server=localhost\\SQLEXPRESS ; database=PROYECTOFC# ; integrated security = true");
            string query4 = "INSERT INTO CITA (Estado_cita, Fecha_reservado) VALUES (@estado_cita, @fecha_reservado)";
            conexion4.Open();
            SqlCommand c4 = new SqlCommand(query4, conexion4);
            c4.Parameters.AddWithValue("@estado_cita", lbl_estadoCita.Text);
            c4.Parameters.AddWithValue("@fecha_reservado", dp_cita.Text);
            c4.ExecuteNonQuery();
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
