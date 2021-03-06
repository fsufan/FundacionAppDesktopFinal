﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Capa_DTO.Usuario;


namespace CapaNegocio.NegocioUsuario
{
    public class NegocioRol
    {
        
        public int ingresarRol(Rol rol)
        {
           
            webServiceFundacion.webServiceFundacion webServFund = new webServiceFundacion.webServiceFundacion();
            String objeto = webServFund.ingresarRol(rol.IdRol, rol.NombreRol, rol.DescripcionRol);
            if (objeto!=null)
            {
                return 1;
            }
            else
            {
                return 0;
            }
            

        }
        public int ingresarRolMO(Rol rol)
        {

            webServiceMO.WebServiceModaOutlet wsMO = new webServiceMO.WebServiceModaOutlet();
            String objeto = wsMO.ingresarRol(rol.IdRol, rol.NombreRol, rol.DescripcionRol);
            if (objeto != null)
            {
                return 1;
            }
            else
            {
                return 0;
            }


        }
        public int modificarRolMO(Rol rol)
        {

            webServiceMO.WebServiceModaOutlet wsMO = new webServiceMO.WebServiceModaOutlet();
            String objeto = wsMO.modificarRol(rol.IdRol, rol.NombreRol, rol.DescripcionRol);
            if (objeto != null)
            {
                return 1;
            }
            else
            {
                return 0;
            }


        }
        public Array listarRoles()
        {
          
            try
            {

                webServiceFundacion.webServiceFundacion webServFund = new webServiceFundacion.webServiceFundacion();
                Array aux = webServFund.listadoRol();
                return aux;
            }
            catch (Exception)
            {
                Array aux = null;
                return aux;
            }
        }

        
        public int eliminarRol(int id_rol)
        {
           
            webServiceFundacion.webServiceFundacion webServFund = new webServiceFundacion.webServiceFundacion();
            String objeto = webServFund.eliminarRol(id_rol);
            if (objeto != null)
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }

        public int eliminarRolMO(int id_rol)
        {

            webServiceMO.WebServiceModaOutlet wsMO = new webServiceMO.WebServiceModaOutlet();
            String objeto = wsMO.eliminarRol(id_rol);
            if (objeto != null)
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }
        public int actualizarRol(Rol rol)
        {
          
            try
            {

                webServiceFundacion.webServiceFundacion webServFund = new webServiceFundacion.webServiceFundacion();
                String objeto = webServFund.modificarRol(rol.IdRol, rol.NombreRol, rol.DescripcionRol);
                if (objeto != null)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception)
            {
                return 0;
            }
        }

        
        public int consultaRol(String nombre_rol)
        {

                webServiceFundacion.webServiceFundacion webServFund = new webServiceFundacion.webServiceFundacion();
                if( webServFund.buscarRolPorNombre(nombre_rol) != null)
                {
                return 1;
                }
            else
                {
                    return 0;
                }
            
        }
        public int consultaRolMO(String nombre_rol)
        {

            
             try
             {
                 webServiceMO.WebServiceModaOutlet wsMO = new webServiceMO.WebServiceModaOutlet();
                 int id = 0;
                Array objeto = wsMO.buscarRolPorNombre(nombre_rol);
                foreach (webServiceMO.rol item in objeto)
                {
                     id = item.id_rol;
                }
                //String ver = Array.IndexOf(objeto, 0).ToString();
                return id;
            }
            catch (Exception)
            {
                int id = 0;
                return id;
            }

        }
        public Rol rolPorNombre(string nombre)
        {
            
            
                webServiceFundacion.webServiceFundacion webServFund = new webServiceFundacion.webServiceFundacion();
                Array objeto = webServFund.buscarRolPorNombre(nombre);
                Rol rol = new Rol();
                foreach (webServiceFundacion.rol item in objeto)
                {
                     rol.IdRol = item.id_rol;
                     rol.NombreRol = item.nombre_rol;
                     rol.DescripcionRol = item.descripcion_rol;
                }

                return rol;
            
        
        }
        public Rol rolPorNombreMO(string nombre)
        {
            Rol auxRol = new Rol();
            try
            {
                webServiceMO.WebServiceModaOutlet wsMO = new webServiceMO.WebServiceModaOutlet();
                Array objeto = wsMO.buscarRolPorNombre(nombre);

                foreach (webServiceMO.rol item in objeto)
                {
                    auxRol.IdRol = item.id_rol;
                    auxRol.NombreRol = item.nombre_rol;
                    auxRol.DescripcionRol = item.descripcion_rol;
                }
                return auxRol;
            }
            catch (Exception)
            {
                return auxRol;
            }

        }
        public Array rolPorId(int idR)
        {
            try
            {
                webServiceFundacion.webServiceFundacion webServFund = new webServiceFundacion.webServiceFundacion();
                Array objeto = webServFund.buscarRolPorId(idR);
                return objeto;
            }
            catch (Exception)
            {
                Array aux = null;
                return aux;
            }
	}
        public Rol rolId(int idR)
        {
            Rol auxRol = new Rol();
            try
            {
                webServiceFundacion.webServiceFundacion webServFund = new webServiceFundacion.webServiceFundacion();
                Array objeto = webServFund.buscarRolPorId(idR);
                
                foreach (webServiceFundacion.rol item in objeto)
                {
                    auxRol.IdRol = item.id_rol;
                    auxRol.NombreRol = item.nombre_rol;
                    auxRol.DescripcionRol = item.descripcion_rol;
                }
                return auxRol;
            }
            catch (Exception)
            {
                return auxRol;
            }
        }
        public Rol consultaRolporId(int idR)
        {
            Rol auxRol = new Rol();
            webServiceFundacion.webServiceFundacion webServFund = new webServiceFundacion.webServiceFundacion();
            Array objeto = webServFund.buscarRolPorId(idR);
            if (objeto != null)
            {
                foreach(webServiceFundacion.rol item in objeto)
                {
                    auxRol.IdRol = item.id_rol;
                    auxRol.NombreRol = item.nombre_rol;
                    auxRol.DescripcionRol = item.descripcion_rol;

                }
            }
            return auxRol;
            
        }

    }


}
