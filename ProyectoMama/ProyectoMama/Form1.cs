using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoMama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //private void PictureBox1_Click(object sender, EventArgs e)
        //{
        //
        //}

        private void Picb_minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Picb_maximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            picb_maximizar.Visible = false;
            picb_restaurar.Visible = true;

        }

        private void Picb__salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Picb_restaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            picb_maximizar.Visible = true;
            picb_restaurar.Visible = false;
        }


    }
}
