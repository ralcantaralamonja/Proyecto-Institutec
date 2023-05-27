using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Proy_InstitutecBE;
using Proy_InstitutecBL;

namespace ProyInstitutec_GUI
{
    public partial class FrmInsertarAlumno : Form
    {
        AlumnoBL objAlumnoBL = new AlumnoBL();
        AlumnoBE objAlumnoBE = new AlumnoBE();
        // FacultadBL objFacultadBL = new FacultadBL();
        //CarreraBL objCarreraBL = new CarreraBL();

        public FrmInsertarAlumno()
        {
            InitializeComponent();
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text.Trim() == String.Empty)
                {

                    throw new Exception("El Nombre del alumno es un campo obligatorio");
                }
                if (txtApePat.Text.Trim() == String.Empty)
                {
                    throw new Exception("El apellido paterno del alumno es un campo obligatorio");
                }
                if (txtApeMat.Text.Trim() == String.Empty)
                {
                    throw new Exception("El apellido Marteno del alumno es un campo obligatorio");
                }
                if (mskDNIAlu.Text.Trim() == String.Empty || mskDNIAlu.Text.Length != 8)
                {
                    throw new Exception("Dni vacio o no contiene 8 digitos");
                }
                if (mskTelAlu.Text.Trim() == String.Empty)
                {
                    throw new Exception("Numero de telefono invalido");
                }
                if (txtCorreoAlu.Text.Trim() == String.Empty)
                {
                    throw new Exception("Correo es un campo obligatorio");
                }

                String Genero = "";
                if (optM.Checked == true)
                {
                    Genero = "M";
                }
                else
                {
                    Genero = "F";
                }
                Boolean activo;
                if (chkActivo.Checked == true)
                {
                    activo = true;
                }
                else
                {
                    activo = false;
                }
                DateTime fechaNac = dtpFecha_Nac.Value;
                //Pasamos valores alas propiedades de la instancia...
                objAlumnoBE.NomAlu = txtNombre.Text.Trim();
                objAlumnoBE.ApeMat = txtApeMat.Text.Trim();
                objAlumnoBE.ApePat = txtApePat.Text.Trim();
                objAlumnoBE.Ndocum = mskDNIAlu.Text.Trim();
                objAlumnoBE.TelAlu = mskTelAlu.Text.Trim();
                objAlumnoBE.SexoAl = Genero;
                objAlumnoBE.Estado = activo;
                objAlumnoBE.FecNac = fechaNac;
                //objAlumnoBE.IdFacu = cboFacultad.SelectedValue.ToString();
                //objAlumnoBE.CodCar = cboCarrera.SelectedValue.ToString();
                // objAlumnoBE.Id_Ubi = cboDep.SelectedValue.ToString() + cboProvincia.SelectedValue.ToString() +
                //    cboDistrito.SelectedValue.ToString();
                //formulario de logeo 
                //objAlumnoBE.Usu_Registro = clsCredenciales.Login_Usuario;
                if (objAlumnoBL.InsertarAlumno(objAlumnoBE) == true)
                {
                    this.Close();
                }
                else
                {
                    throw new Exception("No se inserto ");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error : " + ex.Message);

            }




        }
        private void mskDNIAlu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8)
            {
                if (char.IsDigit(e.KeyChar) == false) // Ni tampoco es digito
                {

                    e.Handled = true; //Se atrapa el caracter y no se imprime 
                }
            }
        }
        private void CargarUbigeo(String IdDepa, String IdProv, String IdDist)
        {

            //UbigeoBL objUbigeoBL = new UbigeoBL();
            //cboDep.DataSource = objUbigeoBL.Ubigeo_Departamentos();
            //cboDep.ValueMember = "IdDepa";
            //cboDep.DisplayMember = "Departamento";
            //cboDep.SelectedValue = IdDepa;

            //cboProvincia.DataSource = objUbigeoBL.Ubigeo_ProvinciasDepartamento(IdDepa);
            //cboProvincia.ValueMember = "IdProv";
            //cboProvincia.DisplayMember = "Provincia";
            //cboProvincia.SelectedValue = IdProv;

            //cboDistrito.DataSource = objUbigeoBL.Ubigeo_DistritosProvinciaDepartamento(IdDepa, IdProv);
            //cboDistrito.ValueMember = "IdDist";
            //cboDistrito.DisplayMember = "Distrito";
            //cboDistrito.SelectedValue = IdDist;

        }

        private void cboProvincia_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // CargarUbigeo(cboDep.SelectedValue.ToString(), cboProvincia.SelectedValue.ToString(), "01");
        }

        private void cboDep_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // CargarUbigeo(cboDep.SelectedValue.ToString(), "01", "01");
        }
        private void FrmInsertarAlumno_Load(object sender, EventArgs e)
        {

            try
            {
                //CargarUbigeo("14", "01", "01");

                // Codifique
                //cargamos los combos
                // DataTable dt = objFacultadBL.ListarFacultad();


                //instancia de datarow , instancia de fila
                //DataRow dr;
                //dr = dt.NewRow(); // fila vacia
                //dr["IdFacu"] = 0;
                //dr["DesFac"] = "--Seleccione--";
                //primera fila que se visualice:
                //dt.Rows.InsertAt(dr, 0);
                //cboFacultad.DataSource = dt;
                //cboFacultad.DisplayMember = "DesFac";
                //cboFacultad.ValueMember = "IdFacu";


                // DataTable dt2 = objCarreraBL.ListarCarrera();


                //instancia de datarow , instancia de fila
                //DataRow dr;
                //dr = dt2.NewRow(); // fila vacia
                //dr["CodCar"] = 0;
                //dr["DesCar"] = "--Seleccione--";
                //primera fila que se visualice:
                //dt2.Rows.InsertAt(dr, 0);
                //cboCarrera.DataSource = dt2;
                //cboCarrera.DisplayMember = "DesFac";
                //cboCarrera.ValueMember = "CodCar";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }



        }

        private void chkActivo_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
