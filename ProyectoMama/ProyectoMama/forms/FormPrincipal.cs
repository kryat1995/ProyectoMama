﻿using System;
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

    public partial class FormPrincipal : Form
    {
        Form_Empleadores_Agregar form_empleadores_agregar = new Form_Empleadores_Agregar() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        Form_Empleadores_Editar form_empleadores_editar = new Form_Empleadores_Editar() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        Form_Empleados_Agregar form_empleados_agregar = new Form_Empleados_Agregar() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        Form_Empleados_Editar form_empleados_editar = new Form_Empleados_Editar() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };

        public FormPrincipal()
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

        private void Btn_agregarEmpleados_Click(object sender, EventArgs e)
        {
            panel_central.Controls.Clear();
            this.panel_central.Controls.Add(form_empleados_agregar);
            form_empleados_agregar.Show();
        }
        private void Btn_agregarEmpleador_Click(object sender, EventArgs e)
        {
            panel_central.Controls.Clear();
            this.panel_central.Controls.Add(form_empleadores_agregar);
            form_empleadores_agregar.Show();
        }

        private void Btn_editarEmpleador_Click(object sender, EventArgs e)
        {
            panel_central.Controls.Clear();
            this.panel_central.Controls.Add(form_empleadores_editar);
            form_empleadores_editar.Show();
        }

        private void Btn_editarEmpleados_Click(object sender, EventArgs e)
        {
            panel_central.Controls.Clear();
            this.panel_central.Controls.Add(form_empleados_editar);
            form_empleados_editar.Show();
        }
    }
}
