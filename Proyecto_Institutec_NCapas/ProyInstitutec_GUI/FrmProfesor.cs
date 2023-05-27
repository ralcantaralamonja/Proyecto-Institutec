﻿using Proy_InstitutecBL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proy_InstitutecBL;
namespace ProyInstitutec_GUI
{
    public partial class FrmProfesor : Form
    {
        ProfesoreBL objprofesorBL = new ProfesoreBL();
        DataView dtv;

        public FrmProfesor()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            FrmInsertarProfesor objInsertarProfesor = new FrmInsertarProfesor();
            objInsertarProfesor.ShowDialog();
            //Refrescamos datagrid
            CargarDatos(mskDNIProfesor.Text.Trim());

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmProfesor_Load(object sender, EventArgs e)
        {
            CargarDatos("");
        }
        private void CargarDatos(String strFiltro)
        {
            dtv = new DataView(objprofesorBL.ListarProfesor());
            dtv.RowFilter = "DNI like '" + strFiltro + "%'";
            dtgProfesor.DataSource = dtv;
            LblRegistros.Text = dtgProfesor.Rows.Count.ToString();

        }

        private void mskDNIProfesor_TextChanged(object sender, EventArgs e)
        {
            CargarDatos(mskDNIProfesor.Text.Trim());
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            FrmActualizarProfesor objfrmActulizarProfesor = new FrmActualizarProfesor();
            objfrmActulizarProfesor.Codigo = dtgProfesor.CurrentRow.Cells[0].Value.ToString();
            objfrmActulizarProfesor.ShowDialog();
            CargarDatos(mskDNIProfesor.Text.Trim());
        }

        private void mskDNIProfesor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8)
            {
                if (char.IsDigit(e.KeyChar) == false) // Ni tampoco es digito
                {

                    e.Handled = true; //Se atrapa el caracter y no se imprime 
                }
            }
        }
    }
}