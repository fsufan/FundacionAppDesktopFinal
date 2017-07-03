using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_DTO.Usuario;

namespace CapaNegocio.NegocioUsuario
{
    public class NegocioParamedico
    {
        public int IngresarParamedico(Paramedico paramedico)
        {
            webServiceFundacion.webServiceFundacion WebService = new webServiceFundacion.webServiceFundacion();
            String objeto = WebService.IngresarParamedico(paramedico.Id_paramedico, paramedico.Turno, paramedico.Especialidad, paramedico.Descripcion, paramedico.FechaIngreso.ToShortDateString(), paramedico.Id_infopersonal, paramedico.Id_usuario);

            if (objeto != null)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public int EliminarParamedico(int id)
        {
            webServiceFundacion.webServiceFundacion WebService = new webServiceFundacion.webServiceFundacion();
            String Objeto = WebService.eliminarParamedico(id);
            if (Objeto != null)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public int ActualizarParamedico(Paramedico paramedico)
        {

            try
            {
                webServiceFundacion.webServiceFundacion WebService = new webServiceFundacion.webServiceFundacion();
                String objeto = WebService.modificarParamedico(paramedico.Id_paramedico, paramedico.Turno, paramedico.Especialidad, paramedico.Descripcion, paramedico.FechaIngreso.ToShortDateString(), paramedico.Id_infopersonal, paramedico.Id_usuario);
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

        public Array listarParamedico()
        {
            try
            {
                webServiceFundacion.webServiceFundacion WebService = new webServiceFundacion.webServiceFundacion();
                Array lista = WebService.listadoParamedico();

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
            if (WebService.buscarParamedicoPorId(id) != null)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public Paramedico consultarParamedicoporID(int id)
        {
            webServiceFundacion.webServiceFundacion WebService = new webServiceFundacion.webServiceFundacion();
            Array Objeto = WebService.buscarParamedicoPorId(id);
            Paramedico paramedico = new Paramedico();
            if (Objeto != null)
            {
                foreach (webServiceFundacion.paramedico item in Objeto)
                {
                    paramedico.Id_paramedico = item.id_paramedico;
                    paramedico.Turno = item.turno;
                    paramedico.Especialidad = item.especialidad;
                    paramedico.Descripcion = item.descripcion;
                    paramedico.FechaIngreso = item.fechaIngreso;
                    paramedico.Id_infopersonal = item.id_infoPersonal;
                    paramedico.Id_usuario = item.id_usuario;
                }
            }
            return paramedico;
        }

        public Paramedico consultarParamedicoporIDinfoP(int id)
        {
            webServiceFundacion.webServiceFundacion WebService = new webServiceFundacion.webServiceFundacion();
            Array Objeto = WebService.buscarParamedicoPorIdInfoP(id);
            Paramedico paramedico = new Paramedico();
            if (Objeto != null)
            {
                foreach (webServiceFundacion.paramedico item in Objeto)
                {
                    paramedico.Id_paramedico = item.id_paramedico;
                    paramedico.Turno = item.turno;
                    paramedico.Especialidad = item.especialidad;
                    paramedico.Descripcion = item.descripcion;
                    paramedico.FechaIngreso = item.fechaIngreso;
                    paramedico.Id_infopersonal = item.id_infoPersonal;
                    paramedico.Id_usuario = item.id_usuario;
                }
            }
            return paramedico;
        }


    }
}
