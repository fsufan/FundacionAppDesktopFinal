using Capa_DTO.Farmacia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.NegocioFarmacia
{
    public class NegocioDetalleSolictudMed
    {


        public int ingresarDtSolMed(DetalleSolicitudMedica dtSM)
        {
            webServiceFundacion.webServiceFundacion WebService = new webServiceFundacion.webServiceFundacion();
            String Objeto = WebService.ingresarDetSolicitudMed(dtSM.Id_det_solic_med,dtSM.Estado_solicitud,dtSM.Motivo,dtSM.Cuidados_espe);
            if (Objeto !=  null)
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }


        public int eliminarDtSolMed(int id)
        {
            webServiceFundacion.webServiceFundacion WebService = new webServiceFundacion.webServiceFundacion();
            String Objeto = WebService.eliminarDetSolicitudMed(id);
            if (Objeto != null)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }





        public int actualizarDtSolMed(DetalleSolicitudMedica dSM)
        {
            try
            {
                webServiceFundacion.webServiceFundacion WebService = new webServiceFundacion.webServiceFundacion();
                String Objeto = WebService.modificarDetSolicitudMed(dSM.Id_det_solic_med, dSM.Estado_solicitud, dSM.Motivo, dSM.Cuidados_espe);
                if (Objeto != null)
                {
                    return 1;
                }else
	            {
                    return 0;
	            }
            }
            catch (Exception)
            {
                return 0;
            }
        }


        public int consultarDtSolMed(int id)
        {
            webServiceFundacion.webServiceFundacion WebService = new webServiceFundacion.webServiceFundacion();
            if (WebService.buscarDetSolicitudMedPorId(id) != null)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public Array listarDtSolMed()
        {
            try
            {
                webServiceFundacion.webServiceFundacion WebService = new webServiceFundacion.webServiceFundacion();
                Array Lista = WebService.listadoDetSolicitudMed();

                return Lista;
            }
            catch (Exception)
            {
                Array aux = null;
                return aux;
            }
            
        
        }

        public DetalleSolicitudMedica ConsultaIDporMotyCuidados(string motivos, string Cuidados)
        {
            DetalleSolicitudMedica detSolMedi = new DetalleSolicitudMedica();
            webServiceFundacion.webServiceFundacion WebService = new webServiceFundacion.webServiceFundacion();
            Array Objeto = WebService.buscarDetSolicitudMedpormotcuida(motivos,Cuidados);
            if (Objeto != null)
            {
                foreach (webServiceFundacion.detSolicitudMed item in Objeto)
                {
                    detSolMedi.Id_det_solic_med = item.id_det_solic_med;
                    detSolMedi.Estado_solicitud = item.estado_solicitud;
                    detSolMedi.Motivo = item.motivo;
                    detSolMedi.Cuidados_espe = item.cuidados_espe;
                }

            }
            return detSolMedi;
        }

        public DetalleSolicitudMedica consultarPorId(int id)
        {
            DetalleSolicitudMedica detSolMedi = new DetalleSolicitudMedica();
            webServiceFundacion.webServiceFundacion WebService = new webServiceFundacion.webServiceFundacion();
            Array Objeto = WebService.buscarDetSolicitudMedPorId(id);
            if (Objeto != null)
            {
                foreach (webServiceFundacion.detSolicitudMed item in Objeto)
                {
                    detSolMedi.Id_det_solic_med = item.id_det_solic_med;
                    detSolMedi.Estado_solicitud = item.estado_solicitud;
                    detSolMedi.Motivo = item.motivo;
                    detSolMedi.Cuidados_espe = item.cuidados_espe;
                }
                
            }
            return detSolMedi;
        }
    }
}
