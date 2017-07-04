using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Capa_DTO.Usuario;

namespace CapaNegocio.NegocioUsuario
{
    public class NegocioUsuario
    {

        public int ingresarUsuario(Usuario usuario)
        {

            webServiceFundacion.webServiceFundacion webServfund = new webServiceFundacion.webServiceFundacion();
            String objeto = webServfund.ingresarUsuario(usuario.IdUsuario, usuario.RutUsuario, usuario.Contrasena, usuario.IdRol);
            if (objeto != null)
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }
        
        public int ingresarUsuarioMO(Usuario usuario)
        {

            webServiceMO.WebServiceModaOutlet wsMO = new webServiceMO.WebServiceModaOutlet();
            String objeto = wsMO.ingresarUsuario(usuario.IdUsuario, usuario.RutUsuario, usuario.Contrasena, usuario.IdRol);
            if (objeto != null)
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }
        public int modificarUsuarioMO(Usuario usuario)
        {

            webServiceMO.WebServiceModaOutlet wsMO = new webServiceMO.WebServiceModaOutlet();
            String objeto = wsMO.modificarUsuario(usuario.IdUsuario, usuario.RutUsuario, usuario.Contrasena, usuario.IdRol);
            if (objeto != null)
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }
        public int eliminarUsuarioMO(Usuario usuario)
        {

            webServiceMO.WebServiceModaOutlet wsMO = new webServiceMO.WebServiceModaOutlet();
            String objeto = wsMO.eliminarUsuario(usuario.IdUsuario);
            if (objeto != null)
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }
        public Usuario usuarioMORut(String rut)
        {

            webServiceMO.WebServiceModaOutlet wsMO = new webServiceMO.WebServiceModaOutlet();
            Array objeto = wsMO.buscarUsuarioPorRut(rut);
            Usuario auxUsu = new Usuario();
            if (objeto != null)
            {
                foreach (webServiceFundacion.usuario item in objeto)
                {
                    auxUsu.IdRol = item.id_rol;
                    auxUsu.IdUsuario = item.id_usuario;
                    auxUsu.RutUsuario = item.rut_usuario;
                    auxUsu.Contrasena = item.contrasena;
                }

            }

            return auxUsu;

        }
        public Array listarUsuarios()
        {
            try
            {
                webServiceFundacion.webServiceFundacion webServfund = new webServiceFundacion.webServiceFundacion();
                Array aux = webServfund.listadoUsuario();

                return aux;
            }
            catch (Exception)
            {
                Array aux = null;
                return aux;
            }
        }

        public int eliminarUsuario(int id_usuario)
        {

            webServiceFundacion.webServiceFundacion webServfund = new webServiceFundacion.webServiceFundacion();
            String objeto = webServfund.eliminarUsuario(id_usuario);
            if (objeto != null)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public int actualizarUsuario(Usuario usu)
        {
            try
            {

                webServiceFundacion.webServiceFundacion webServfund = new webServiceFundacion.webServiceFundacion();
                String objeto = webServfund.modificarUsuario(usu.IdUsuario, usu.RutUsuario, usu.Contrasena, usu.IdRol);
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



        public int consultaUsuario(int id_usuario)
        {

            webServiceFundacion.webServiceFundacion webServfund = new webServiceFundacion.webServiceFundacion();
            if (webServfund.buscarUsuarioPorId(id_usuario) != null)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }


        public Usuario buscarUsuarioporRut(String usu)
        {

            webServiceFundacion.webServiceFundacion webServfund = new webServiceFundacion.webServiceFundacion();
            


            Array objeto = webServfund.buscarUsuarioPorRutUsuario(usu);
            Usuario auxUsu = new Usuario();
            if (objeto != null)
            {
                foreach (webServiceFundacion.usuario item in objeto)
                {
                    auxUsu.IdRol = item.id_rol;
                    auxUsu.IdUsuario = item.id_usuario;
                    auxUsu.RutUsuario = item.rut_usuario;
                    auxUsu.Contrasena = item.contrasena;
                }
                
            }

            return auxUsu;
        }

        public Array usuarioPorId(int idU)
        {
            try
            {
                webServiceFundacion.webServiceFundacion webServfund = new webServiceFundacion.webServiceFundacion();
                Array objeto = webServfund.buscarUsuarioPorId(idU);
                return objeto;

            }
            catch (Exception)
            {

                Array aux = null;
                return aux;
            }


        }


        public Usuario consultaUsuariporId(int idUsu)
        {

            Usuario auxUsuario = new Usuario();
            webServiceFundacion.webServiceFundacion webServfund = new webServiceFundacion.webServiceFundacion();
            Array objeto = webServfund.buscarUsuarioPorId(idUsu);
            if (objeto != null)
            {
                foreach (webServiceFundacion.usuario item in objeto)
                {
                    auxUsuario.IdRol = item.id_rol;
                    auxUsuario.IdUsuario = item.id_usuario;
                    auxUsuario.RutUsuario = item.rut_usuario;
                    auxUsuario.Contrasena = item.contrasena;
                }
                
            }
            return auxUsuario;
        }
    }


}
