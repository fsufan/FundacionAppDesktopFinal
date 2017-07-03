using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Conexion;
using Capa_DTO.Residente;
using CapaNegocio.webServiceFundacion;

namespace CapaNegocio.NegocioResidente
{
    public class NegocioDetContrato
    {
        public int IngresarDetContrato(DetaContrato detcontrato)
        {
            
            webServiceFundacion.webServiceFundacion web = new webServiceFundacion.webServiceFundacion();
            string dato = web.ingresarDetContrato(detcontrato.IdDetContrato,detcontrato.IdServicio,detcontrato.CostoTotal);

            if (dato != null)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public int EliminarDetContrato(int id)
        {

            webServiceFundacion.webServiceFundacion web = new webServiceFundacion.webServiceFundacion();
            string dato = web.eliminarDetContrato(id);

            if (dato != null)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }


        public int ActualizarDetContrato(DetaContrato detcontra)
        {
            try
            {
                webServiceFundacion.webServiceFundacion web = new webServiceFundacion.webServiceFundacion();
                string dato = web.modificarDetContrato(detcontra.IdDetContrato, detcontra.IdServicio, detcontra.CostoTotal);

                if (dato != null)
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

  

        public String consultarCostototal(int c)
        {
            //webServiceFundacion.webServiceFundacion web = new webServiceFundacion.webServiceFundacion();
            //try
            //{
            //    Array dato = web.buscarDetContratoPorId);
            //    foreach (Fundacion.detContrato item in dato)
            //    {
            //        int id = item.id_det_contrato;
            //    }

            //    String ver = Array.IndexOf(dato, 0).ToString();
            //    return ver;
            //}
            //catch (Exception)
            //{

            //    
            //}

            //webServiceFundacion web = new webServiceFundacion();

            //Array dato = web.buscarContratoPorIdAsync(c);

            //if (dato != null)
            //{
            //    return 1;
            //}
            //else
            //{
            //    return 0;
            //}

            return null;
        }

        public Array listarDetContrato()
        {
           
            webServiceFundacion.webServiceFundacion web = new webServiceFundacion.webServiceFundacion();
            Array datos = web.listadoDetCompra();

            return datos;
        }

        public  DetaContrato consultaporIdDetContrato(int id)
        {
            DetaContrato DetalleC = new DetaContrato();
            webServiceFundacion.webServiceFundacion webServiceFund = new webServiceFundacion.webServiceFundacion();
            Array objeto = webServiceFund.buscarDetContratoPorId(id);
            if (objeto != null)
            {
                foreach (webServiceFundacion.detContrato item in objeto)
                {

                    DetalleC.IdDetContrato = item.id_det_contrato;
                    DetalleC.IdServicio = item.id_servicio;
                    DetalleC.CostoTotal = item.costo_total;
                    
                }


            }

            return DetalleC;
        }
    }
}
