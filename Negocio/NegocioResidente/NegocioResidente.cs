using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_DTO.Residente;
using CapaNegocio.webServiceFundacion;

namespace CapaNegocio.NegocioResidente
{
    public class NegocioResidente
    {
        
        public int IngresarResidente(Residente residente)
        { 

            webServiceFundacion.webServiceFundacion web = new webServiceFundacion.webServiceFundacion();

            String RESI = web.ingresarResidente(residente.IdResidente, residente.IdInfoPersonal, residente.Edad, residente.IdFamiliar, residente.IdFicResidente);

            if (RESI != null)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public int EliminarResidente(int id)
        {
    
            webServiceFundacion.webServiceFundacion web = new webServiceFundacion.webServiceFundacion();

            string dato = web.eliminarResidente(id);

            if (dato != null)
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }


        public int ActualizarResidente(Residente residente)
        {
            try
            {
                webServiceFundacion.webServiceFundacion webServiceFund = new webServiceFundacion.webServiceFundacion();
                String objeto = webServiceFund.modificarResidente(residente.IdResidente, residente.IdInfoPersonal, residente.Edad, residente.IdFamiliar, residente.IdFicResidente); ;

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

        public int consultarPorId(int ID)
        {
            webServiceFundacion.webServiceFundacion webServiceFund = new webServiceFundacion.webServiceFundacion();

            if (webServiceFund.buscarResidentePorId(ID) != null)
            {
                return 1;

            }
            else
            {
                return 0;
            }


        }

        public Array listarResidenteALL()
        {
          

            webServiceFundacion.webServiceFundacion webService = new webServiceFundacion.webServiceFundacion();

            Array Objeto = webService.listadoResidente();

            return Objeto;

        }

        public Residente consultaResidenteporIDinfoP(int id)
        {
            Residente residente = new Residente();
            webServiceFundacion.webServiceFundacion webServiceFund = new webServiceFundacion.webServiceFundacion();
            Array objeto = webServiceFund.buscarResidentePorIdInforPersonal(id);
            if (objeto != null)
            {
                foreach (webServiceFundacion.residente item in objeto)
                {

                    residente.IdResidente = item.id_residente;
                    residente.IdInfoPersonal = item.id_infopersonal;
                    residente.Edad = item.edad;
                    residente.IdFamiliar = item.id_familiar;
                    residente.IdFicResidente = item.id_ficresidente;

                }


            }

            return residente;
        }

        public Residente consultaResidenteporIDFichaR(int id)
        {
            Residente residente = new Residente();
            webServiceFundacion.webServiceFundacion webServiceFund = new webServiceFundacion.webServiceFundacion();
            Array objeto = webServiceFund.buscarResidentePorIdFichaR(id);
            if (objeto != null)
            {
                foreach (webServiceFundacion.residente item in objeto)
                {

                    residente.IdResidente = item.id_residente;
                    residente.IdInfoPersonal = item.id_infopersonal;
                    residente.Edad = item.edad;
                    residente.IdFamiliar = item.id_familiar;
                    residente.IdFicResidente = item.id_ficresidente;

                }


            }

            return residente;
        }
     

        public Residente consultaporIdResidente(int id)
        {
            Residente residente = new Residente();
            webServiceFundacion.webServiceFundacion webServiceFund = new webServiceFundacion.webServiceFundacion();
            Array objeto = webServiceFund.buscarResidentePorId(id);
            if (objeto != null)
            {
                foreach (webServiceFundacion.residente item in objeto)
                {

                    residente.IdResidente = item.id_residente;
                    residente.IdInfoPersonal = item.id_infopersonal;
                    residente.Edad = item.edad;
                    residente.IdFamiliar = item.id_familiar;
                    residente.IdFicResidente  = item.id_ficresidente;
                                        
                }


            }

            return residente;
        }
    }
}
