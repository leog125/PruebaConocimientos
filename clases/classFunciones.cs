using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using PruebaConocimiento.clases;

namespace PruebaConocimiento.clases
{
    public class classFunciones
    {
        public UsuarioModel Buscarusuario(int id) 
        {
            UsuarioModel usuarioModel = new UsuarioModel();
            classConectar classConectar = new classConectar();
            DataTable dt = classConectar.Sqldatatable("select * from Usuario where Id_prueba=" + id);
            if (dt.Rows.Count > 0)
            {
                usuarioModel.Id_prueba = Convert.ToInt32(dt.Rows[0][0].ToString());
                usuarioModel.Nombre = dt.Rows[0][1].ToString();
                usuarioModel.Apellido = dt.Rows[0][2].ToString();
                usuarioModel.Telefono = Convert.ToInt32(dt.Rows[0][3].ToString());
                usuarioModel.Fecha = Convert.ToDateTime(dt.Rows[0][4].ToString());
                return usuarioModel;
            }
            else
            {
                return null;
            }
            
        }
    }
}