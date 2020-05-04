using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ProyectoMama.Clases
{
    class GestionLocalidades
    {
        private DataTable ObtenerTabla(String Nombre, String Sql)
        {
            DataSet ds = new DataSet();
            AccesoDatos datos = new AccesoDatos();
            SqlDataAdapter adp = datos.ObtenerAdaptador(Sql);
            adp.Fill(ds, Nombre);

            return ds.Tables[Nombre];
        }

        public DataTable ObtenerLocalidadPorProvincia(string idprov_)
        {
            return ObtenerTabla("Localidades", "Select * from Localidades where IDProvincia_loc = " + idprov_);
        }
    }
}
