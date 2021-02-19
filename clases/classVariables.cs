using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PruebaConocimiento.clases
{
    public class classVariables
    {
       public string stringconnection = @"Data Source=LAPTOP-5BUGCH90\SQLEXPRESS; Initial Catalog=Prueba; User=sa; Password=leosql; Persist Security Info=true";
    }

    public class UsuarioModel 
    {
        public int Id_prueba { get; set; }
        public string Nombre { get; set; }

        public string Apellido { get; set; }
        public int Telefono { get; set; }
        public DateTime Fecha{ get; set; }
    }
}