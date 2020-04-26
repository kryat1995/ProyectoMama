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
                transition_sidebarCerrar.Show(panel_sidebar);
                panel_menuEmpleadores.Visible = false;
                panel_menuEmpleados.Visible = false;

            }
            else
            {
                panel_sidebar.Visible = false;
                panel_sidebarWrapper.Width = 250;
                panel_sidebar.Width = 220;
                separator_sideBar1.Width = 206;
                transition_sidebarAbrir.Show(panel_sidebar);
                panel_menuEmpleadores.Visible = true;
                panel_menuEmpleados.Visible = true;
            }
        }

        private void Btn_Empleadores_Click(object sender, EventArgs e)
        {
            if (panel_menuEmpleadores.Visible == false)
            {
                panel_menuEmpleadores.Visible = true;

                if (panel_sidebar.Width == 68)
                {
                    panel_sidebar.Visible = false;
                    panel_sidebarWrapper.Width = 250;
                    panel_sidebar.Width = 220;
                    separator_sideBar1.Width = 206;
                    transition_sidebarAbrir.Show(panel_sidebar);
                }
            }
            else
            {
                panel_menuEmpleadores.Visible = false;
            }
        }

        private void Btn_Empleados_Click(object sender, EventArgs e)
        {
            if (panel_menuEmpleados.Visible == false)
            {
                panel_menuEmpleados.Visible = true;

                if (panel_sidebar.Width == 68)
                {
                    panel_sidebar.Visible = false;
                    panel_sidebarWrapper.Width = 250;
                    panel_sidebar.Width = 220;
                    separator_sideBar1.Width = 206;
                    transition_sidebarAbrir.Show(panel_sidebar);

                }
            }
            else
            {
                panel_menuEmpleados.Visible = false;
            }
        }

        private void Txt_empleadorRazonSocial_Enter(object sender, EventArgs e)
        {
            if (txt_empleador_agregar_RazonSocial.text == "Razon Social")
                txt_empleador_agregar_RazonSocial.text = string.Empty;
        }

        private void Txt_empleadorRazonSocial_Leave(object sender, EventArgs e)
        {
            if (txt_empleador_agregar_RazonSocial.text == "")
                txt_empleador_agregar_RazonSocial.text = "Razon Social";
        }

        private void Txt_empleadorCuit_Enter(object sender, EventArgs e)
        {
            if (txt_empleador_agregar_Cuit.text == "xx-xxxxxxxx-x")
                txt_empleador_agregar_Cuit.text = string.Empty;
        }

        private void Txt_empleadorCuit_Leave(object sender, EventArgs e)
        {
            if (txt_empleador_agregar_Cuit.text == "")
                txt_empleador_agregar_Cuit.text = "xx-xxxxxxxx-x";
        }

        private void Txt_empeladorDomicilio_Enter(object sender, EventArgs e)
        {
            if (txt_empelador_agregar_Domicilio.text == "Domicilio")
                txt_empelador_agregar_Domicilio.text = string.Empty;
        }

        private void Txt_empeladorDomicilio_Leave(object sender, EventArgs e)
        {
            if (txt_empelador_agregar_Domicilio.text == "")
                txt_empelador_agregar_Domicilio.text = "Domicilio";
        }

        private void Btn_agregarEmpleador_Click(object sender, EventArgs e)
        {
            lbl_subtitulo.Text = "Agregar Empleador";
        }

        private void Txt_empleado_agregar_CUIL_Enter(object sender, EventArgs e)
        {
            if (txt_empleado_agregar_CUIL.text == "xx-xxxxxxxx-x")
                txt_empleado_agregar_CUIL.text = string.Empty;
        }

        private void Txt_empleado_agregar_CUIL_Leave(object sender, EventArgs e)
        {
            if (txt_empleado_agregar_CUIL.text == "")
                txt_empleado_agregar_CUIL.text = "xx-xxxxxxxx-x";
        }

    }
}
