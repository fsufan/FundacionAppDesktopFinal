using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_DTO.Farmacia
{
    public class SolicitudMedica
    {
        private int id_solic_med;
        private int id_det_solic_med;
        private int id_fic_residente;
        private int id_enfermera;
        private int id_paramedico;
        private int id_det_solicitud;

        public int Id_det_solicitud
        {
            get { return id_det_solicitud; }
            set { id_det_solicitud = value; }
        }

        public int Id_paramedico
        {
            get { return id_paramedico; }
            set { id_paramedico = value; }
        }

        public int Id_enfermera
        {
            get { return id_enfermera; }
            set { id_enfermera = value; }
        }
        
        

        public int Id_fic_residente
        {
            get { return id_fic_residente; }
            set { id_fic_residente = value; }
        }
        


        public int Id_det_solic_med
        {
            get { return id_det_solic_med; }
            set { id_det_solic_med = value; }
        }
        

        public int Id_solic_med
        {
            get { return id_solic_med; }
            set { id_solic_med = value; }
        }
        
    }
}
