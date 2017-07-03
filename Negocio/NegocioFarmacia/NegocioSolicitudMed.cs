using Capa_DTO.Farmacia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.NegocioFarmacia
{
    public class NegocioSolicitudMed
    {

        public int ingresarSolicitudMedica(SolicitudMedica solMed)
        {

            webServiceFundacion.webServiceFundacion WebService = new webServiceFundacion.webServiceFundacion();
            String Objeto = WebService.ingresarSolicMed(solMed.Id_solic_med,solMed.Id_det_solic_med,solMed.Id_fic_residente,solMed.Id_enfermera,solMed.Id_paramedico,solMed.Id_det_solicitud);
            if (Objeto != null)
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }


        public int eliminarSolicitudMedica(int id)
        {
            webServiceFundacion.webServiceFundacion WebService = new webServiceFundacion.webServiceFundacion();
            String Objeto = WebService.eliminarSolicMed(id);
            if (Objeto != null)
            {
                return 1;
            }
            else
            {
                return 0;
            }
            
        }





        public int actualizarSolicitudMedica(SolicitudMedica slMed)
        {
            try
            {
                webServiceFundacion.webServiceFundacion WebService = new webServiceFundacion.webServiceFundacion();
                String Objeto = WebService.modificarSolicMed(slMed.Id_solic_med, slMed.Id_det_solic_med, slMed.Id_fic_residente, slMed.Id_enfermera, slMed.Id_paramedico, slMed.Id_det_solicitud);
                if (Objeto != null)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }catch(Exception)
            {
                return 0;
            }
        }


        public int consultarSolicitudMedica(int id)
        {
            webServiceFundacion.webServiceFundacion WebService = new webServiceFundacion.webServiceFundacion();
            if (WebService.buscarSolicMedPorId(id) != null)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public Array listarSolicitudMedica()
        {
            try
            {
                webServiceFundacion.webServiceFundacion WebService = new webServiceFundacion.webServiceFundacion();
                Array Lista = WebService.listadoSolicMed();

                return Lista;
            }
            catch (Exception)
            {
                Array aux = null;
                return aux;
            }
        }


        public SolicitudMedica consultarPorIdSolMedica(int id)
        {
            SolicitudMedica SolicitudMedica = new SolicitudMedica();
            webServiceFundacion.webServiceFundacion WebService = new webServiceFundacion.webServiceFundacion();
            Array Objeto = WebService.buscarSolicMedPorId(id);
            if (Objeto != null)
            {
                foreach (webServiceFundacion.solicMed item in Objeto)
                {
                    SolicitudMedica.Id_solic_med = item.id_solic_med;
                    SolicitudMedica.Id_det_solic_med = item.id_det_solic_med;
                    SolicitudMedica.Id_fic_residente = item.id_fic_residente;
                    SolicitudMedica.Id_enfermera = item.id_enfermera;
                    SolicitudMedica.Id_paramedico = item.id_paramedico;
                    SolicitudMedica.Id_det_solicitud = item.id_det_solicitud;
                }
            }
            return SolicitudMedica;
        }
    }
}
