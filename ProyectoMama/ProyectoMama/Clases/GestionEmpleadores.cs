using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ProyectoMama.Clases
{
    class GestionEmpleadores
    {
        AccesoDatos datos;
        private DataTable ObtenerTabla(String Nombre, String Sql)
        {
            DataSet ds = new DataSet();
            datos = new AccesoDatos();
            SqlDataAdapter adp = datos.ObtenerAdaptador(Sql);
            adp.Fill(ds, Nombre);

            return ds.Tables[Nombre];
        }

        public DataTable ObtenerEmpleadores()
        {
            return ObtenerTabla("Empleadores", "Select * from Empleadores");
        }

        public void ArmarParametrosAgregarEmpleador(ref SqlCommand comando, Empleadores emp)
        {
            SqlParameter sqlParametros = new SqlParameter();
            sqlParametros = comando.Parameters.Add("@RazonSocial", SqlDbType.VarChar, 255);
            sqlParametros.Value = emp.get_razonSocial();
            sqlParametros = comando.Parameters.Add("@Cuit", SqlDbType.VarChar, 13);
            sqlParametros.Value = emp.get_cuit();
            sqlParametros = comando.Parameters.Add("@Domicilio", SqlDbType.VarChar, 255);
            sqlParametros.Value = emp.get_domicilio();
            sqlParametros = comando.Parameters.Add("@Provincia", SqlDbType.Char, 4);
            sqlParametros.Value = emp.get_idprovincia();
            sqlParametros = comando.Parameters.Add("@Localidad", SqlDbType.Char, 2);
            sqlParametros.Value = emp.get_idlocalidad();
        }

        public int AgregarEmpleador(Empleadores emp)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosAgregarEmpleador(ref comando, emp);

            return datos.EjecutarProcedimientoAlmacenado(comando,"AgregarEmpleador"); ///solo para poder guardar el programa es esto.
        }

    }
}
