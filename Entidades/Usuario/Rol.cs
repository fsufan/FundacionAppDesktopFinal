using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_DTO.Usuario
{
   public class Rol
    {
        private int _id_rol;
        private string _nombre_rol;
        private string _descripcion_rol;

        public string DescripcionRol
        {
            get { return _descripcion_rol; }
            set { _descripcion_rol = value; }
        }
        

        public string NombreRol
        {
            get { return _nombre_rol; }
            set { _nombre_rol = value; }
        }
        

        public int IdRol
        {
            get { return _id_rol; }
            set { _id_rol = value; }
        }
        
    }
}
