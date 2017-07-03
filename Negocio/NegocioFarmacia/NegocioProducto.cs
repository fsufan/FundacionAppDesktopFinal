using Capa_DTO.Farmacia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.NegocioFarmacia
{
    public class NegocioProducto
    {
        public int ingresarProducto(Producto producto)
        {
            webServiceFundacion.webServiceFundacion webServiceFund = new webServiceFundacion.webServiceFundacion();
            String objeto = webServiceFund.ingresarProducto(producto.Id_producto, producto.Nombre, producto.Categoria, producto.Tipo, producto.Precio, producto.Id_proveedor);

            if (objeto!=null)
            {
                return 1;
            }
            else
            {
                return 0;
            }
            

        }


        public int eliminarProducto(int producto)
        {
            webServiceFundacion.webServiceFundacion webServiceFund = new webServiceFundacion.webServiceFundacion();
            String objeto = webServiceFund.eliminarProducto(producto);

            if (objeto != null)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }





        public int actualizarProducto(Producto producto)
        {
            webServiceFundacion.webServiceFundacion webServiceFund = new webServiceFundacion.webServiceFundacion();
            String objeto = webServiceFund.modificarProducto(producto.Id_producto, producto.Nombre, producto.Categoria, producto.Tipo, producto.Precio, producto.Id_proveedor);

            if (objeto != null)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }


        public int consultarProducto(int id)
        {
            webServiceFundacion.webServiceFundacion webServiceFund = new webServiceFundacion.webServiceFundacion();
            Array objeto = webServiceFund.buscarProductoPorId(id);

            if (objeto != null)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public Array listarProductos()
        {
            webServiceFundacion.webServiceFundacion webServiceFund = new webServiceFundacion.webServiceFundacion();
            Array objeto = webServiceFund.listadoProducto();

            return objeto;
        }
        private void consultarProductoNombre(String nombre)
        {
            try
            {

            }
            catch (Exception)
            {
                
                //
            }
        }
        public Array productoPorId(int id)
        {
            webServiceFundacion.webServiceFundacion webServiceFund = new webServiceFundacion.webServiceFundacion();
            Array objeto = webServiceFund.buscarProductoPorId(id);
            return objeto;
        }
        public int consultarProductoPorNombre(string nombre)
        {
            webServiceFundacion.webServiceFundacion webServiceFund = new webServiceFundacion.webServiceFundacion();
            Array objeto = webServiceFund.buscarProductoPorNombre(nombre);
            if (objeto!=null)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public Producto consultarPorId(int id)
        {
                        
            Producto auxProducto = new Producto();
            webServiceFundacion.webServiceFundacion webServiceFund = new webServiceFundacion.webServiceFundacion();
            Array objeto = webServiceFund.buscarProductoPorId(id);
            if (objeto!=null)
            {
                foreach (webServiceFundacion.producto item in objeto)
                {
                    auxProducto.Id_producto = item.id_producto;
                    auxProducto.Nombre = item.nombre;
                    auxProducto.Categoria = item.categoria;
                    auxProducto.Tipo = item.tipo;
                    auxProducto.Precio = item.precio;
                    auxProducto.Id_proveedor = item.id_proveedor;
                }
            }
                                                        

            return auxProducto;
        }
    }
}
