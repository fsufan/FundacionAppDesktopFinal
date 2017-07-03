using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_DTO.Medicamento;

namespace CapaNegocio.NegocioFarmacia
{
    public class NegocioMedicina
    {
        
        
        public int ingresarMedicina(Medicina medicina)
        {
          

            webServiceFundacion.webServiceFundacion webServiceFund = new webServiceFundacion.webServiceFundacion();
            String objeto = webServiceFund.ingresarMedicina(medicina.Id_medicina, medicina.Nom_comercial, medicina.Nom_generico, medicina.Contenido, medicina.Unidad_medida, medicina.Fec_fabricacion.ToShortDateString(), medicina.Fec_vencimiento.ToShortDateString(), medicina.Cantidad, medicina.Descripcion);
            if (objeto != null)
            {
                return 1;

            }
            else
            {
                return 0;
            }
            

        }


        public int eliminarMedicamento(int id_medicamento)
        {
            

            webServiceFundacion.webServiceFundacion webServiceFund = new webServiceFundacion.webServiceFundacion();
            String objeto = webServiceFund.eliminarMedicina(id_medicamento);
            if (objeto != null)
            {
                return 1;

            }
            else
            {
                return 0;
            }
        }


        public int actualizarMedicina(Medicina medicina)
        {
            
            try
            {
                webServiceFundacion.webServiceFundacion webServiceFund = new webServiceFundacion.webServiceFundacion();
                String objeto = webServiceFund.modificarMedicina(medicina.Id_medicina, medicina.Nom_comercial, medicina.Nom_generico, medicina.Contenido, medicina.Unidad_medida, medicina.Fec_fabricacion.ToShortDateString(), medicina.Fec_vencimiento.ToShortDateString(), medicina.Cantidad, medicina.Descripcion);

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


        public int consultarMedicina(String nom_comercial)
        {
            

            webServiceFundacion.webServiceFundacion webServiceFund = new webServiceFundacion.webServiceFundacion();

            if (webServiceFund.buscarMedicinaPorNombreComercial(nom_comercial) != null)
            {
                return 1;

            }
            else
            {
                return 0;
            }

        }

        public Array listarMedicinas()
        {
            
            try
            {
                webServiceFundacion.webServiceFundacion webServiceFund = new webServiceFundacion.webServiceFundacion();
                Array aux = webServiceFund.listadoMedicina();



                return aux;
            }
            catch (Exception)
            {
                Array aux = null;
                return aux;
            }

            
        }
         
       
         public Array medicinaPorId(int id)
         {

            
             try
             {
                 webServiceFundacion.webServiceFundacion webServiceFund = new webServiceFundacion.webServiceFundacion();
                 Array objeto = webServiceFund.buscarMedicinaPorId(id);

                 return objeto;
             }
             catch (Exception)
             {
                 Array aux = null;
                 return aux;
             }
             
               
         }
         
         public Medicina consultarPorIdMedicina(int id)
         {
                          
             Medicina auxMedicina = new Medicina();
             webServiceFundacion.webServiceFundacion webServiceFund = new webServiceFundacion.webServiceFundacion();
                 Array objeto = webServiceFund.buscarMedicinaPorId(id);
             if (objeto!=null)
	            {
	                foreach (webServiceFundacion.medicina item in objeto)
	                {

                         auxMedicina.Id_medicina = item.id_medicina;
                         auxMedicina.Nom_comercial = item.nom_comercial;
                         auxMedicina.Nom_generico = item.nom_generico;
                         auxMedicina.Unidad_medida = item.unidad_medida;
                         auxMedicina.Fec_fabricacion = item.fec_fabricacion;
                         auxMedicina.Fec_vencimiento = item.fec_vencimiento;
                         auxMedicina.Contenido = item.contenido;
                         auxMedicina.Cantidad = item.cantidad;
                         auxMedicina.Descripcion = item.descripcion;
	                }	 
	

             }
                     
             return auxMedicina;
         }


    }
    
}
