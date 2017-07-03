
using Capa_DTO.Farmacia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.NegocioFarmacia
{
    public class NegocioCompra
    {
        public int ingresarCompra(Compra compra)
        {
            webServiceFundacion.webServiceFundacion webServiceFund = new webServiceFundacion.webServiceFundacion();
            String objeto = webServiceFund.ingresarCompra(compra.Id_compra, compra.Descripcion, compra.MontoTotal, compra.Fecha.ToShortDateString());
            if (objeto != null)
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }


        public int eliminarCompra(int id)
        {
            webServiceFundacion.webServiceFundacion webServiceFund = new webServiceFundacion.webServiceFundacion();
            String objeto = webServiceFund.eliminarCompra(id);
            if (objeto != null)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }





        public int actualizarCompra(Compra compra)
        {
           
            webServiceFundacion.webServiceFundacion webServiceFund = new webServiceFundacion.webServiceFundacion();
            String objeto = webServiceFund.modificarCompra(compra.Id_compra, compra.Descripcion, compra.MontoTotal, compra.Fecha.ToShortDateString());
            if (objeto != null)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }


        public int consultarCompra(String fecha)
        {

            webServiceFundacion.webServiceFundacion webServiceFund = new webServiceFundacion.webServiceFundacion();
            Array objeto = webServiceFund.buscarCompraPorFecha(fecha);
            if (objeto != null)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public Array CompraPorId(int id)
        {
            webServiceFundacion.webServiceFundacion webServiceFund = new webServiceFundacion.webServiceFundacion();
            Array objeto = webServiceFund.buscarCompraPorId(id);
            return objeto;
        }

        public Array listarCompras()
        {
            webServiceFundacion.webServiceFundacion webServiceFund = new webServiceFundacion.webServiceFundacion();
            Array objeto = webServiceFund.listadoCompra();
            return objeto;
        }

      
        public Compra consultarPorId(int id)
        {

            

            Compra auxCompra = new Compra();

            webServiceFundacion.webServiceFundacion webServiceFund = new webServiceFundacion.webServiceFundacion();
            Array objeto = webServiceFund.buscarCompraPorId(id);
            if (objeto!=null)
            {
                foreach (webServiceFundacion.compra item in objeto)
                {
                    auxCompra.Id_compra = item.id_compra;
                    
                    auxCompra.Descripcion = item.descripcion;
                    auxCompra.Fecha = item.fecha;
                    auxCompra.MontoTotal = item.montototal;
                } 
            }
            return auxCompra;
        }
    }
}
