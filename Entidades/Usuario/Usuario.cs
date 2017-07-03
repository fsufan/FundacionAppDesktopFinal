using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_DTO.Usuario
{
  public class Usuario
    {
        private int _id_usuario;
        private string _rut_usuario;
        private string _contrasena;
        private int _id_rol;


       
       
        
        public int IdRol
        {
            get { return _id_rol; }
            set { _id_rol = value; }
        }
        

        public string Contrasena
        {
            get { return _contrasena; }
            set { _contrasena = value; }
        }
        

        public string RutUsuario
        {
            get { return _rut_usuario; }
            set { _rut_usuario = value; }
        }
        

        public int IdUsuario
        {
            get { return _id_usuario; }
            set { _id_usuario = value; }
        }
        
    }
}
