using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoMama.Clases;
using System.Data.SqlClient;

namespace ProyectoMama
{
    public partial class Form_Empleadores_Agregar : Form
    {
        private SqlConnection cnBase = new SqlConnection();
        private AccesoDatos cn = new AccesoDatos();
        private GestionProvincias gest_prov = new GestionProvincias();
        private DataTable dt_Prov;

        public Form_Empleadores_Agregar()
        {
            InitializeComponent();
        }
        private void Form_Empleadores_Agregar_Load(object sender, EventArgs e)
        {
            cnBase = cn.ObtenerConexion();
            dt_Prov = gest_prov.ObtenerTodoProvincias();
            cnBase.Close();

            cmb_provincias.ValueMember = "idprovincia_prov";
            cmb_provincias.DisplayMember = "NombreProvincia_prov";
            cmb_provincias.DataSource = dt_Prov;

            cmb_provincias.SelectedIndex = -1;
            cmb_localidades.SelectedIndex = -1;
        }

        private void BunifuMetroTextbox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '-'))
                e.Handled = true;
        }

        private void Cmb_provincias_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmb_provincias.SelectedIndex != -1)
            {
                GestionLocalidades gest_loc = new GestionLocalidades();
                DataTable dt_loc;

                string id_ = "0";

                cnBase = cn.ObtenerConexion();

                if (cmb_provincias.SelectedValue.ToString().Length == 1)
                    id_ += cmb_provincias.SelectedValue.ToString();
                else
                    id_ = cmb_provincias.SelectedValue.ToString();

                dt_loc = gest_loc.ObtenerLocalidadPorProvincia(id_);
                cmb_localidades.ValueMember = "idlocalidad_loc";
                cmb_localidades.DisplayMember = "NombreLocalidad_loc";
                cmb_localidades.DataSource = dt_loc;

                cnBase.Close();

            }
        }

        private void Btn_confirmar_Click(object sender, EventArgs e)
        {
            Empleadores emp = new Empleadores();
            emp.set_razonSocial(txt_razonSocial.Text);
            emp.set_domicilio(txt_domicilio.Text);
            emp.set_cuit(txt_cuit.Text);

            string idp_ = "0";

            if (cmb_provincias.SelectedValue.ToString().Length == 1)
                idp_ += cmb_provincias.SelectedValue.ToString();
            else
                idp_ = cmb_provincias.SelectedValue.ToString();

            emp.set_idprovincia(idp_);
            emp.set_idlocalidad(cmb_localidades.SelectedValue.ToString());



        }
    }
}
