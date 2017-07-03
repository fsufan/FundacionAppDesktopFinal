using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_DTO.Usuario;

namespace CapaNegocio.NegocioUsuario
{
    public class NegocioEnfermera
    {
        public int IngresarEnfermera(Enfermera enfermera)
        {
            webServiceFundacion.webServiceFundacion WebService = new webServiceFundacion.webServiceFundacion();
            String objeto = WebService.IngresarEnfermera(enfermera.Id_enfermera,enfermera.Turno,enfermera.Especialidad,enfermera.Descripcion,enfermera.FechaIngreso.ToShortDateString(),enfermera.Id_infopersonal,enfermera.Id_usuario);

            if (objeto !=null)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public int EliminarEnfermera(int id)
        {
            webServiceFundacion.webServiceFundacion WebService = new webServiceFundacion.webServiceFundacion();
            String Objeto = WebService.eliminarEnfermera(id);
            if (Objeto != null)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public int ActualizarEnfermera(Enfermera enfermera)
        {
            
            try
            {
                webServiceFundacion.webServiceFundacion WebService = new webServiceFundacion.webServiceFundacion();
                String objeto = WebService.modificarEnfermera(enfermera.Id_enfermera,enfermera.Turno,enfermera.Especialidad,enfermera.Descripcion,enfermera.FechaIngreso.ToShortDateString(),enfermera.Id_infopersonal,enfermera.Id_usuario);
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

        public Array listarEnfermera()
        {
            try
            {
                webServiceFundacion.webServiceFundacion WebService = new webServiceFundacion.webServiceFundacion();
                Array lista = WebService.listadoEnfermera();

                return lista;
            }
            catch (Exception)
            {
                Array aux = null;
                return aux;
            }
        }

        public int consultarporID(int id)
        {
            webServiceFundacion.webServiceFundacion WebService = new webServiceFundacion.webServiceFundacion();
            if (WebService.buscarEnfermeraPorId(id)!= null)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public Enfermera consultarEnfermeraporID(int id)
        {
            webServiceFundacion.webServiceFundacion WebService = new webServiceFundacion.webServiceFundacion();
            Array Objeto = WebService.buscarEnfermeraPorId(id);
            Enfermera enfermera = new Enfermera();
            if (Objeto != null)
            {
                foreach (webServiceFundacion.enfermera item in Objeto)
                {
                    enfermera.Id_enfermera = item.id_enfermera;
                    enfermera.Turno = item.turno;
                    enfermera.Especialidad = item.especialidad;
                    enfermera.Descripcion = item.descripcion;
                    enfermera.FechaIngreso = item.fechaIngreso;
                    enfermera.Id_infopersonal = item.id_infoPersonal;
                    enfermera.Id_usuario = item.id_usuario;
                }
            }
            return enfermera;
        }

        public Enfermera consultarEnfermeraporIDinfoP(int id)
        {
            webServiceFundacion.webServiceFundacion WebService = new webServiceFundacion.webServiceFundacion();
            Array Objeto = WebService.buscarEnfermeraPorIdInfoP(id);
            Enfermera enfermera = new Enfermera();
            if (Objeto != null)
            {
                foreach (webServiceFundacion.enfermera item in Objeto)
                {
                    enfermera.Id_enfermera = item.id_enfermera;
                    enfermera.Turno = item.turno;
                    enfermera.Especialidad = item.especialidad;
                    enfermera.Descripcion = item.descripcion;
                    enfermera.FechaIngreso = item.fechaIngreso;
                    enfermera.Id_infopersonal = item.id_infoPersonal;
                    enfermera.Id_usuario = item.id_usuario;
                }
            }
            return enfermera;
        }

    }
}
