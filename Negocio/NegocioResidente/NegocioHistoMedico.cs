using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Capa_DTO.Residente;
using CapaNegocio.webServiceFundacion;

namespace CapaNegocio.NegocioResidente
{
    public class NegocioHistoMedico
    {
       

        public int IngresarHistoMedico(HistorialMedico HMedico)
        { 

            webServiceFundacion.webServiceFundacion web = new webServiceFundacion.webServiceFundacion();
            string HM = web.ingresarHistoMedico(HMedico.IdHistoMedico, HMedico.Enfermedades, HMedico.Alergias, HMedico.TratamientoEspecial, HMedico.IdFicResidente);

            if (HM != null)
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }

        public int EliminarHistoMedico(int id)
        {
            webServiceFundacion.webServiceFundacion web = new webServiceFundacion.webServiceFundacion();
            String dato = web.eliminarHistoMedico(id);
            if (dato != null)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public HistorialMedico BuscaridHistoMporIdFichaR(int id)
        {
            webServiceFundacion.webServiceFundacion web = new webServiceFundacion.webServiceFundacion();
            Array Obj = web.buscarIdHistoMporIdficha(id);
            HistorialMedico auxhis = new HistorialMedico();
            if (Obj != null)
            {
                foreach (webServiceFundacion.histoMedico item in Obj)
                {
                    auxhis.IdHistoMedico = item.id_historialmed;
                    auxhis.Enfermedades = item.enfermedades;
                    auxhis.Alergias = item.alergias;
                    auxhis.TratamientoEspecial = item.tratam_especial;
                    auxhis.IdFicResidente = item.id_fic_residente;
                }
            }
            return auxhis;
        }
        

        public int ActualizarHistoMedico(HistorialMedico histoM)
        {
            try
            {
                webServiceFundacion.webServiceFundacion web = new webServiceFundacion.webServiceFundacion();
                String dato = web.modificarHistoMedico(histoM.IdHistoMedico, histoM.Enfermedades, histoM.Alergias, histoM.TratamientoEspecial,histoM.IdFicResidente);
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

        public Array consultarPorID(int id)
        {
            webServiceFundacion.webServiceFundacion web = new webServiceFundacion.webServiceFundacion();
            Array dato = web.buscarHistoMedicoPorId(id);

            return dato;

        }

        public Array listarHistoMedico()
        {
            webServiceFundacion.webServiceFundacion web = new webServiceFundacion.webServiceFundacion();
            Array dato = web.listadoHistoMedico();

            return dato;
        }

        public HistorialMedico consultaporIdHistoMed(int id)
        {
            HistorialMedico HM = new HistorialMedico();
            webServiceFundacion.webServiceFundacion web = new webServiceFundacion.webServiceFundacion();

            Array objeto = web.buscarHistoMedicoPorId(id);

            if (objeto != null)
            {
                foreach (webServiceFundacion.histoMedico item in objeto)
                {
                    HM.IdHistoMedico = item.id_historialmed;
                    HM.Enfermedades = item.enfermedades;
                    HM.Alergias = item.alergias;
                    HM.TratamientoEspecial = item.tratam_especial;
                    HM.IdFicResidente = item.id_fic_residente;
                }
            }
            return HM;
        }
    }
}
