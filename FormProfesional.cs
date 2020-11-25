using System;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class FormProfesional : Form
    {
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
    }
}
