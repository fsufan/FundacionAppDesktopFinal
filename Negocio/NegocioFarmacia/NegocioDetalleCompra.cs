
using Capa_DTO.Farmacia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.NegocioFarmacia
{
    public class NegocioDetalleCompra
    {
        public int ingresarDetalleCompra(DetalleCompra dtCompra)
        {
            webServiceFundacion.webServiceFundacion webServiceFund = new webServiceFundacion.webServiceFundacion();
            String objeto = webServiceFund.ingresarDetCompra(dtCompra.Id_det_compra, dtCompra.Cantidad, dtCompra.Total, dtCompra.Descripcion, dtCompra.Id_producto,dtCompra.Id_compra);
            if (objeto!=null)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }


        public int eliminarDetalleCompra(int id)
        {
            webServiceFundacion.webServiceFundacion webServiceFund = new webServiceFundacion.webServiceFundacion();
            String objeto = webServiceFund.eliminarDetCompra(id);
            if (objeto != null)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }





        public int actualizarMedicina(DetalleCompra dtCompra )
        {
            webServiceFundacion.webServiceFundacion webServiceFund = new webServiceFundacion.webServiceFundacion();
            String objeto = webServiceFund.modificarDetCompra(dtCompra.Id_det_compra, dtCompra.Cantidad, dtCompra.Total, dtCompra.Descripcion, dtCompra.Id_producto,dtCompra.Id_compra);
            if (objeto != null)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }



        public Array listarDetalleCompras()
        {

            webServiceFundacion.webServiceFundacion webServiceFund = new webServiceFundacion.webServiceFundacion();
            Array objeto = webServiceFund.listadoDetCompra();
            return objeto;
        }
        public int consultarDetCompra(String descripcion, int producto)
        {
           
            try
            {
                webServiceFundacion.webServiceFundacion webServiceFund = new webServiceFundacion.webServiceFundacion();
                int objeto = webServiceFund.buscarDetCompraPorDescripcionYIdProd(descripcion, producto);
                return objeto;
            }
            catch (Exception)
            {

                return 0;
            }
            
        }
        public Array detallePorId(int id)
        {

            webServiceFundacion.webServiceFundacion webServiceFund = new webServiceFundacion.webServiceFundacion();
            Array objeto = webServiceFund.buscarDetCompraPorId(id);
            return objeto;
        }
        public DetalleCompra consultarPorId(int id)
        {

            DetalleCompra auxDetCompra = new DetalleCompra();
            webServiceFundacion.webServiceFundacion webServiceFund = new webServiceFundacion.webServiceFundacion();
            Array objeto = webServiceFund.buscarDetCompraPorId(id);
            if (objeto!=null)
            {
                foreach (webServiceFundacion.detCompra item in objeto)
                {
                    auxDetCompra.Id_det_compra = item.id_det_compra;
                    auxDetCompra.Id_producto = item.id_producto;
                    auxDetCompra.Cantidad = item.cantidad;
                    auxDetCompra.Descripcion = item.descripcion;
                    auxDetCompra.Total = item.total;
                }
            }
            return auxDetCompra;
        }
    }
}
