using System;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class FormCliente : Form
    {
        Form c;
        public FormCliente(Form s)
        {
            c = s;
            InitializeComponent();

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var cn = Conexion.GetSqlWinAuthenticationConnetion();
            string query = "Select * from VISITANTE";
        }
    }
}
