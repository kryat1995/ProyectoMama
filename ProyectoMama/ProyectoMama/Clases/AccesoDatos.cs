using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace ProyectoMama.Clases
{
    class AccesoDatos
    {
        String rutaBase =
            "Data Source=localhost\\sqlexpress;Initial Catalog=basemama;Integrated Security=True";

        public SqlConnection ObtenerConexion()
        {
            SqlConnection cn = new SqlConnection(rutaBase);
            try
            {
                cn.Open();
                return cn;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public SqlDataAdapter ObtenerAdaptador(String consultaSql)
        {
            SqlDataAdapter adaptador;
            try
            {
                adaptador = new SqlDataAdapter(consultaSql, rutaBase);
                return adaptador;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public SqlConnection CerrarConexion()
        {
            SqlConnection cn = new SqlConnection(rutaBase);
            try
            {
                cn.Close();
                return cn;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public int EjecutarProcedimientoAlmacenado(SqlCommand Comando, String NombreSP)
        {
            int FilasCambiadas;

            SqlConnection conexion = ObtenerConexion();
            SqlCommand cmd = new SqlCommand();
            cmd = Comando;
            cmd.Connection = conexion;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = NombreSP;
            FilasCambiadas = cmd.ExecuteNonQuery();
            conexion.Close();

            return FilasCambiadas;
        }

    }
}
