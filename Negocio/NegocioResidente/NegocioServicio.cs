using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_DTO.Residente;
using CapaNegocio.webServiceFundacion;

namespace CapaNegocio.NegocioResidente
{
    public class NegocioServicio
    {
       

        public int IngresarServicio(Servicio Serv)
        {
            webServiceFundacion.webServiceFundacion webservice = new webServiceFundacion.webServiceFundacion();
            String datos = webservice.ingresarServicio(Serv.IdServicio,Serv.NombreServicio,Serv.Descripcion,Serv.CostoServicio);
            if (datos != null)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public int EliminarServicio(int id)
        {
            webServiceFundacion.webServiceFundacion webService = new webServiceFundacion.webServiceFundacion();
            String datos = webService.eliminarServicio(id);
            if (datos !=null)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }


        public int ActualizarServicio(Servicio Serv)
        {
            try
            {
                webServiceFundacion.webServiceFundacion webService = new webServiceFundacion.webServiceFundacion();
                String datos = webService.modificarServicio(Serv.IdServicio, Serv.NombreServicio, Serv.Descripcion, Serv.CostoServicio);
                if (datos != null)
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

        public int consultarServicioPorId(int ID)
        {
          

            webServiceFundacion.webServiceFundacion web = new webServiceFundacion.webServiceFundacion();
            if (web.buscarServicioPorId(ID) != null)
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }

        public Array listarServicio()
        {
           
            try
            {
                webServiceFundacion.webServiceFundacion web = new webServiceFundacion.webServiceFundacion();
                Array lista = web.listadoServicio();

                return lista;
            }
            catch (Exception)
            {

                Array lista = null;
                return lista;
            }
        }

        public Servicio consultaporIdServicio(int id)
        {
            Servicio Servicio = new Servicio();
            webServiceFundacion.webServiceFundacion webServiceFund = new webServiceFundacion.webServiceFundacion();
            Array objeto = webServiceFund.buscarServicioPorId(id);
            if (objeto != null)
            {
                foreach (webServiceFundacion.servicio item in objeto)
                {

                    Servicio.IdServicio = item.id_servicio;
                    Servicio.NombreServicio = item.nombre_serv;
                    Servicio.Descripcion = item.descripcion;
                    Servicio.CostoServicio = item.costo_serv;
                    
                }


            }

            return Servicio;
        }

        
    }
}