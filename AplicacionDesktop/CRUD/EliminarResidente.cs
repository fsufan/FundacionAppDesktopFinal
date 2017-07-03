using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AplicacionDesktop.MENU;
using CapaNegocio.NegocioResidente;
using Capa_DTO.Residente;

namespace AplicacionDesktop.CRUDUsuario
{
    public partial class EliminarResidente : Form
    {
        public EliminarResidente()
        {
            InitializeComponent();
            Cargarcombo();
        }

        public void Cargarcombo()
        {
            NegocioInfoPersonal auxInfo = new NegocioInfoPersonal();
            try
            {
                if (auxInfo.listarInfoPersonal() != null)
                {
                    combrut.DataSource = auxInfo.listarInfoPersonal();
                    combrut.DisplayMember = "Rut";
                    combrut.ValueMember = "id_infopersonal";

                    combrut.SelectedIndex = -1;
                    if (combrut.SelectedIndex == -1)
                    {
                        combrut.Text = "Seleccione un rut";
                    }
                }
                else
                {
                    MessageBox.Show("No hay Residentes Ingresados");
                    btnEliminar.Enabled = false;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("No hay Residentes Ingresados");
                btnEliminar.Enabled = false;
            }
        }

        private void cboRol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
            try 
	        {
                InformacionPersonal infoP = new InformacionPersonal();
                NegocioInfoPersonal auxInforP = new NegocioInfoPersonal();
                Residente residente = new Residente();
                NegocioResidente auxresidente = new NegocioResidente();
                NegocioFamiliar auxFamiliar = new NegocioFamiliar();
                NegocioFichaResidente auxFicR = new NegocioFichaResidente();
                NegocioHistoMedico auxHistomedico = new NegocioHistoMedico();
                HistorialMedico histoMedico = new HistorialMedico();

                if (auxInforP.listarInfoPersonal()!= null)
                {

                    infoP.Id_InfoPersonal = int.Parse(combrut.SelectedValue.ToString());
                    residente = auxresidente.consultaResidenteporIDinfoP(infoP.Id_InfoPersonal);
                    
                        
                        DialogResult resultado = MessageBox.Show("Esta intentando eliminar. Si continua el proceso, se eliminaran TODOS los datos asociados a este Rut. Desea Continuar?","Atencion",MessageBoxButtons.YesNo);
                        
                        switch (resultado)
                        {
                            case DialogResult.Yes:
                               

                                    if (auxresidente.EliminarResidente(residente.IdResidente) > 0)
                                    {

                                        MessageBox.Show("Eliminado", "Informacion");
                                        Cargarcombo();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Error al eliminar");
                                    }
                               
                                
                                

                                break;
                            case DialogResult.No:
                                break;
                        }
                   
                }
                else
                {
                    MessageBox.Show("No hay datos Ingresados");
                }
		
	        }
	        catch (Exception)
	        {

                MessageBox.Show("Debe seleccionar un rut para eliminar");
	        }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuAdminResidentes MAR = new MenuAdminResidentes();
            MAR.Show();
            Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
