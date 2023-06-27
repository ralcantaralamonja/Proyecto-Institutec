using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proy_Institutec_ADO;
using Proy_InstitutecBE;
using Proy_InstitutecBl;
using Proy_InstitutecBL;
using System.IO;// para la clase File

namespace ProyInstitutec_GUI
{
    public partial class FrmInsertarProfesor : Form
    {
        ProfesoreBL objprofesoreBL = new ProfesoreBL();
        ProfesorBE objprofesorBE = new ProfesorBE();


        public FrmInsertarProfesor()
        {
            InitializeComponent();
        }

        private void FrmInsertarProfesor_Load(object sender, EventArgs e)
        {
            try
            {
                CargarUbigeo("14", "01", "01");
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void CargarUbigeo(String IdDepa, String IdProv, String IdDist)
        {

            UbigeoBL objUbigeoBL = new UbigeoBL();
            cboDep.DataSource = objUbigeoBL.Ubigeo_Departamentos();
            cboDep.ValueMember = "IdDepa";
            cboDep.DisplayMember = "Departamento";
            cboDep.SelectedValue = IdDepa;

            cboProvincia.DataSource = objUbigeoBL.Ubigeo_ProvinciasDepartamento(IdDepa);
            cboProvincia.ValueMember = "IdProv";
            cboProvincia.DisplayMember = "Provincia";
            cboProvincia.SelectedValue = IdProv;

            cboDistrito.DataSource = objUbigeoBL.Ubigeo_DistritosProvinciaDepartamento(IdDepa, IdProv);
            cboDistrito.ValueMember = "IdDist";
            cboDistrito.DisplayMember = "Distrito";
            cboDistrito.SelectedValue = IdDist;

        }

        private void cboProvincia_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarUbigeo(cboDep.SelectedValue.ToString(), cboProvincia.SelectedValue.ToString(), "01");
        }

        private void cboDep_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarUbigeo(cboDep.SelectedValue.ToString(), "01", "01");
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNomPro.Text.Trim() == String.Empty)
                {

                    throw new Exception("El Nombre del profesor es un campo obligatorio");
                }
                if (txtApePat.Text.Trim() == String.Empty)
                {
                    throw new Exception("El apellido paterno del profesor es un campo obligatorio");
                }
                if (txtApeMat.Text.Trim() == String.Empty)
                {
                    throw new Exception("El apellido Marteno del profesor es un campo obligatorio");
                }
                if (txtDni.Text.Trim() == String.Empty || txtDni.Text.Length != 8)
                {
                    throw new Exception("Dni vacio o no contiene 8 digitos");
                }
                if (txtTelf.Text.Trim() == String.Empty)
                {
                    throw new Exception("Numero de telefono invalido");
                }
                if (pcbFoto.Image == null)
                {
                    throw new Exception("Debe registrar la foto.");
                }
                objprofesorBE.Foto = File.ReadAllBytes(openFileDialog1.FileName);

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

                // Convertimos la foto en un arreglo de Bytes y lo almacenamos en su respectiva propiedad

                objprofesorBE.Foto = File.ReadAllBytes(openFileDialog1.FileName);
                objprofesorBE.Usu_Registro = clsCredenciales.Login_Usuario;


                DateTime fechaIng = dtpFecIng.Value;
                //Pasamos valores alas propiedades de la instancia...
                objprofesorBE.NomPro = txtNomPro.Text.Trim();
                objprofesorBE.ApeMat = txtApeMat.Text.Trim();
                objprofesorBE.ApePat = txtApePat.Text.Trim();
                objprofesorBE.Ndocum = txtDni.Text.Trim();
                objprofesorBE.TelPro = txtTelf.Text.Trim();
                objprofesorBE.Sexopr = Genero;
                objprofesorBE.Estado = activo;
                objprofesorBE.FecIng = fechaIng;
                objprofesorBE.Id_Ubi = cboDep.SelectedValue.ToString() + cboProvincia.SelectedValue.ToString() +
                    cboDistrito.SelectedValue.ToString();
                if (objprofesoreBL.InsertarProfesor(objprofesorBE) == true)
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

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8)
            {
                if (char.IsDigit(e.KeyChar) == false) // Ni tampoco es digito
                {

                    e.Handled = true; //Se atrapa el caracter y no se imprime 
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnImagen_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.FileName = String.Empty;
                openFileDialog1.Multiselect = false;
                openFileDialog1.ShowDialog();

                // Si se escogio una foto se carga en el picture Box
                if (openFileDialog1.FileName != String.Empty)
                {
                    pcbFoto.Image = Image.FromFile(openFileDialog1.FileName);
                }


            }
            catch (Exception)
            {

                throw;
            }
        }

        private void pcbFoto_Click(object sender, EventArgs e)
        {

        }
    }
}
