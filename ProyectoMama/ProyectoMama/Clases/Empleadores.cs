using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMama
{
    class Empleadores
    {
        private string razonSocial;
        private string cuit;
        private string domicilio;
        private string idlocalidad;
        private string idprovincia;

        //Constructores
        public Empleadores() { }

        public Empleadores(string rs, string cuit, string dom, string loc, string prov)
        {
            this.razonSocial = rs;
            this.cuit = cuit;
            this.domicilio = dom;
            this.idlocalidad = loc;
            this.idprovincia = prov;
        }

        //Gets
        public string get_razonSocial(){ return this.razonSocial; }
        public string get_cuit() { return this.cuit; }
        public string get_domicilio() { return this.domicilio; }
        public string get_idlocalidad() { return this.idlocalidad; }
        public string get_idprovincia() { return this.idprovincia; }

        //Sets
        public void set_razonSocial(string a) { this.razonSocial = a; }
        public void set_cuit(string a) { this.cuit = a; }
        public void set_domicilio(string a) { this.domicilio = a; }
        public void set_idlocalidad(string a) { this.idlocalidad = a; }
        public void set_idprovincia(string a) { this.idprovincia = a; }

    }
}
