using System;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (cbx_seccion.SelectedIndex == 0)
            {
                FormCliente ventana = new FormCliente(this);
                ventana.Show();
            }
            else if (cbx_seccion.SelectedIndex == 1)
            {
                this.Hide();
                FormProfesional ventana = new FormProfesional(this);
                ventana.Show();
            }
        }
    }
}
