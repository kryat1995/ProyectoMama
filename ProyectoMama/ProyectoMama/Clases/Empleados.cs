using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMama
{
    class Empleados
    {
        private String Nombre { set; get; }
        private String Apellido { set; get; }
        private String Dni { set; get; }
        //private String FechaDeInicio { set; get; }
        private String ObraSocial { set; get; }
        private String Legajo { set; get; }
        private String Categoria { set; get; }

        public Empleados() { }

        public Empleados(string nom, string ape, string dni, string os, string leg, string cat)
        {
            this.Nombre = nom;
            this.Apellido = ape;
            this.Dni = dni;
            this.ObraSocial = os;
            this.Legajo = leg;
            this.Categoria = cat;
        }
    }
}
