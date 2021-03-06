﻿using CapaNegocio.NegocioFarmacia;
using AplicacionDesktop.MENU;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_DTO.Farmacia;

namespace AplicacionDesktop.CRUD
{
    public partial class EliminarInventario : Form
    {
        public EliminarInventario()
        {
            InitializeComponent();
            cargarCombobox();
            
        }
        public EliminarInventario(string rol)
        {
            InitializeComponent();
            cargarCombobox();
            
            lblRol.Text = rol;
            lblRol.Visible = false;
        }
        public void cargarCombobox()
        {
            NegocioInventario inven = new NegocioInventario();
            try
            {
                if (inven.listarInventarios() != null)
                {
                    cbxProducto.DataSource = inven.listarInventarios();
                    //validar q contenga datos
                    cbxProducto.DisplayMember = "observaciones";
                    cbxProducto.ValueMember = "id_inventario";

                    cbxProducto.SelectedIndex = -1;
                    if (cbxProducto.SelectedIndex == -1)
                    {
                        cbxProducto.Text = "Seleccione un Inventario";
                    }
                }
                else
                {
                    MessageBox.Show("No hay Inventarios ingresados");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("No hay Inventarios ingresados");
                btnEliminar.Enabled = false;
            }
           
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Inventario auxInv = new Inventario();
            NegocioInventario auxNInv = new NegocioInventario();
            try
            {
                if (auxNInv.listarInventarios() != null)
                {
                    auxInv.Id_inventario = int.Parse(cbxProducto.SelectedValue.ToString());
                    DialogResult result = MessageBox.Show("Está intentando eliminar. Si continua el proceso, se eliminaran TODOS los datos asociados a este. Desea continuar?", "Atención!. Lea cuidadosamente.", MessageBoxButtons.YesNo);

                    switch (result)
                    {
                        case DialogResult.Yes:

                            if (auxNInv.eliminarInventario(auxInv.Id_inventario) > 0)
                            {                                                             
                                MessageBox.Show("Inventario eliminado.", "Información");
                                cargarCombobox();                                
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
                    MessageBox.Show("No hay datos ingresados");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error intentelo nuevamente");
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            MenuAdministrarInventario inv = new MenuAdministrarInventario(lblRol.Text);
            inv.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuAdministrarInventario inv = new MenuAdministrarInventario(lblRol.Text);
            inv.Show();
            Hide();
        }
    }
}
