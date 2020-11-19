using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
