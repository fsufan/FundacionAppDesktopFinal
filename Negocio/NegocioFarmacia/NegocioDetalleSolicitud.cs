using Capa_DTO.Farmacia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.NegocioFarmacia
{
    public class NegocioDetalleSolicitud
    {

        public int ingresarDetSolicitud(DetalleSolicitud detSolicitud)
        {
            webServiceFundacion.webServiceFundacion WebService = new webServiceFundacion.webServiceFundacion();
            String Objeto = WebService.ingresarDetSolicitud(detSolicitud.Id_det_solicitud,detSolicitud.Fecha.ToShortDateString(),detSolicitud.Cantidad,detSolicitud.Id_medicina);
            if (Objeto != null)
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }


        public int eliminarDetSolicitud(int dtS)
        {
            webServiceFundacion.webServiceFundacion WebService = new webServiceFundacion.webServiceFundacion();
            String Objeto = WebService.eliminarDetSolicitud(dtS);
            if (Objeto !=  null)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }





        public int actualizarDetSolicirud(DetalleSolicitud dtS)
        {
            try
            {
                webServiceFundacion.webServiceFundacion WebService = new webServiceFundacion.webServiceFundacion();
                String Objeto = WebService.modificarDetSolicitud(dtS.Id_det_solicitud,dtS.Fecha.ToShortDateString(),dtS.Cantidad,dtS.Id_medicina);
                if (Objeto != null)
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


        public int consultarDetSolicitudporID(int id)
        {
            webServiceFundacion.webServiceFundacion WebService = new webServiceFundacion.webServiceFundacion();
            if (WebService.buscarDetSolicitudPorId(id) != null)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public Array listarDetSolicitud()
        {
            try
            {
                webServiceFundacion.webServiceFundacion WebService = new webServiceFundacion.webServiceFundacion();
                Array Lista = WebService.listadoDetSolicitud();
                return Lista;
            }
            catch (Exception)
            {
                Array aux = null;
                return aux;
            }
            
        }


        public DetalleSolicitud consultarPorIDMedicina(int id)
        {
             DetalleSolicitud DetaSoli = new DetalleSolicitud();
            webServiceFundacion.webServiceFundacion WebService = new webServiceFundacion.webServiceFundacion();
            Array Objeto = WebService.buscarDetSolicitudIDMedicina(id);
            if (Objeto != null)
            {
                foreach (webServiceFundacion.detSolicitud item in Objeto)
                {
                    DetaSoli.Id_det_solicitud = item.id_det_solicitud;
                    DetaSoli.Fecha = item.fecha;
                    DetaSoli.Cantidad = item.cantidad;
                    DetaSoli.Id_medicina = item.id_medicina;
                }
            }
            return DetaSoli;
            
        }
        


        public DetalleSolicitud consultarPorId(int id)
        {
            DetalleSolicitud DetaSoli = new DetalleSolicitud();
            webServiceFundacion.webServiceFundacion WebService = new webServiceFundacion.webServiceFundacion();
            Array Objeto = WebService.buscarDetSolicitudPorId(id);
            if (Objeto != null)
            {
                foreach (webServiceFundacion.detSolicitud item in Objeto)
                {
                    DetaSoli.Id_det_solicitud = item.id_det_solicitud;
                    DetaSoli.Fecha = item.fecha;
                    DetaSoli.Cantidad = item.cantidad;
                    DetaSoli.Id_medicina = item.id_medicina;
                }
            }
            return DetaSoli;
            
        }
    }
}
