
using Capa_DTO.Farmacia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.NegocioFarmacia
{
    public class NegocioBodegaP
    {
        

        public int ingresarBodegaProducto(BodegaProducto bodProd, int inventario)
        {
            webServiceFundacion.webServiceFundacion webServiceFund = new webServiceFundacion.webServiceFundacion();
            String objeto = webServiceFund.ingresarBodegaProd(bodProd.Id_bodega_prod, bodProd.Id_producto,bodProd.Stock, inventario);
            if (objeto!=null)
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }


        public int eliminarBodegaProducto(int id)
        {
            webServiceFundacion.webServiceFundacion webServiceFund = new webServiceFundacion.webServiceFundacion();
            String objeto = webServiceFund.eliminarBodegaProd(id);
            if (objeto != null)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }





        public int actualizarBodegaProducto(BodegaProducto bodProd)
        {
            webServiceFundacion.webServiceFundacion webServiceFund = new webServiceFundacion.webServiceFundacion();
            String objeto = webServiceFund.modificarBodegaProd(bodProd.Id_bodega_prod, bodProd.Id_producto, bodProd.Stock, bodProd.Id_inventario);
            if (objeto != null)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }


        public int consultarBodegaProducto(int producto)
        {
            webServiceFundacion.webServiceFundacion webServiceFund = new webServiceFundacion.webServiceFundacion();
            Array objeto = webServiceFund.buscarBodegaProdPorId(producto);
            if (objeto != null)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
               public Array listarBodegaProducto()
        {
            webServiceFundacion.webServiceFundacion webServiceFund = new webServiceFundacion.webServiceFundacion();
            Array objeto = webServiceFund.listadoBodegaProd();
            return objeto;
        }

        public Array bodegaProductoModificado(int id)
        {
            webServiceFundacion.webServiceFundacion webServiceFund = new webServiceFundacion.webServiceFundacion();
            Array objeto = webServiceFund.buscarBodegaProdPorId(id);
            return objeto;
        }
        public BodegaProducto consultarPorId(int id)
        {
            BodegaProducto auxBodProducto = new BodegaProducto();
            webServiceFundacion.webServiceFundacion webServiceFund = new webServiceFundacion.webServiceFundacion();
            Array objeto = webServiceFund.buscarBodegaProdPorId(id);
            if (objeto!= null)
            {
                foreach (webServiceFundacion.bodegaProd item in objeto)
                {
                    auxBodProducto.Id_bodega_prod = item.id_bodega_prod;
                    auxBodProducto.Id_inventario = item.id_inventario;
                    auxBodProducto.Id_producto = item.id_producto;
                    auxBodProducto.Stock = item.stock;
                }
            }
            return auxBodProducto;
        }
    }
}
