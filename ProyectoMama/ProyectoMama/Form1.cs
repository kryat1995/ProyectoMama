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
        private void Minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
        private void Picb_dashboard_Click(object sender, EventArgs e)
        {
            if (panel_sidebar.Width == 220)
            {
                panel_sidebar.Visible = false;
                panel_sidebarWrapper.Width = 90;
                panel_sidebar.Width = 68;
                separator_sideBar1.Width = 52;
                separator_sidebar2.Width = 52;
                transition_sidebarCerrar.Show(panel_sidebar);
            }
            else
            {
                panel_sidebar.Visible = false;
                panel_sidebarWrapper.Width = 250;
                panel_sidebar.Width = 220;
                separator_sideBar1.Width = 206;
                separator_sidebar2.Width = 206;
                transition_sidebarAbrir.Show(panel_sidebar);
            }
        }

        private void Btn_Empleadores_Click(object sender, EventArgs e)
        {
            if (panel_menuEmpleadores.Visible == true)
                panel_menuEmpleadores.Visible = false;
            else
                panel_menuEmpleadores.Visible = true;
        }

        private void Btn_Empleados_Click(object sender, EventArgs e)
        {
            if (panel_menuEmpleados.Visible == true)
                panel_menuEmpleados.Visible = false;
            else
                panel_menuEmpleados.Visible = true;

        }


    }
}
