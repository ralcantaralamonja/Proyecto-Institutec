using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Agregamos
using Proy_InstitutecBE;
using Proy_InstitutecBl;
using Proy_InstitutecBL;
namespace ProyInstitutec_GUI
{
    public partial class FrmActualizarProfesor : Form
    {
        ProfesoreBL objProfesorBL = new ProfesoreBL();
        ProfesorBE objProfesorBE = new ProfesorBE();
        public FrmActualizarProfesor()
        {
            InitializeComponent();
        }
        public String Codigo { get; set; }
        public byte[] FotoOriginal { get; private set; }

        public bool blnCambio { get; set; }
        private void FrmActualizarProfesor_Load(object sender, EventArgs e)
        {
            try
            {


                objProfesorBE = objProfesorBL.ConsultarProfesor(this.Codigo);
                if (objProfesorBE.Foto == null || objProfesorBE.Foto.Length == 0)
                {
                    pcbFoto.Image = null;
                }
                else
                {
                    MemoryStream fotoStream = new MemoryStream(objProfesorBE.Foto);
                    pcbFoto.Image = Image.FromStream(fotoStream);
                    FotoOriginal = objProfesorBE.Foto;
                }
                DateTime ingreso = objProfesorBE.FecIng;
                lblCodigo.Text = objProfesorBE.IdProf;
                txtNompro.Text = objProfesorBE.NomPro;
                txtApeMat.Text = objProfesorBE.ApeMat;
                txtApePat.Text = objProfesorBE.ApePat;
                txtTelf.Text = objProfesorBE.TelPro;
                txtNdocum.Text = objProfesorBE.Ndocum;
                dtpFecIng.Value = ingreso;
                if (objProfesorBE.Estado == true)
                {
                    optActivo.Checked = true;
                }
                else
                {
                    optInactivo.Checked = true;
                }
                if (objProfesorBE.Sexopr == "M")
                {
                    optMasculino.Checked = true;
                }
                else
                {
                    optFemenino.Checked = true;
                }

                String Id_Ubigeo = objProfesorBE.Id_Ubi;

                CargarUbigeo(Id_Ubigeo.Substring(0, 2), Id_Ubigeo.Substring(2, 2),
                    Id_Ubigeo.Substring(4, 2));


            }
            catch (Exception)
            {

                throw;
            }
        }
        private void cboProvincia_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string idDepa = cboDep.SelectedValue.ToString();
            string idProv = cboProvincia.SelectedValue.ToString();
            string idDist = cboDistrito.SelectedValue.ToString();

            CargarUbigeo(idDepa, idProv, idDist);
        }

        private void cboDep_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string idDepa = cboDep.SelectedValue.ToString();
            string idProv = "01"; // Valor predeterminado para la provincia
            string idDist = "01"; // Valor predeterminado para el distrito

            CargarUbigeo(idDepa, idProv, idDist);
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

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNompro.Text.Trim() == String.Empty)
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

                if (txtTelf.Text.Trim() == String.Empty)
                {
                    throw new Exception("Numero de telefono debe tener 9 digitos");
                }

                if (blnCambio == true)
                {
                    objProfesorBE.Foto = File.ReadAllBytes(openFileDialog1.FileName);
                }
                else
                {
                    objProfesorBE.Foto = FotoOriginal;
                }


                Boolean activo;
                if (optActivo.Checked == true)
                {
                    activo = true;
                }
                else
                {
                    activo = false;
                }
                String Sexo;
                if (optMasculino.Checked == true)
                {
                    Sexo = "M";
                }
                else
                {
                    Sexo = "F";
                }
                DateTime fechaIng = dtpFecIng.Value;
                //Pasamos valores alas propiedades de la instancia...
                objProfesorBE.Usu_Ult_Mod = clsCredenciales.Login_Usuario;
                objProfesorBE.IdProf = lblCodigo.Text.Trim();
                objProfesorBE.NomPro = txtNompro.Text.Trim();
                objProfesorBE.ApeMat = txtApeMat.Text.Trim();
                objProfesorBE.ApePat = txtApePat.Text.Trim();
                objProfesorBE.TelPro = txtTelf.Text.Trim();
                objProfesorBE.Estado = activo;
                objProfesorBE.FecIng = fechaIng;
                objProfesorBE.Sexopr = Sexo;
                objProfesorBE.Ndocum = txtNdocum.Text.Trim();
                objProfesorBE.Id_Ubi = cboDep.SelectedValue.ToString() + cboProvincia.SelectedValue.ToString() +
                          cboDistrito.SelectedValue.ToString();
                if (objProfesorBL.ActualizarProfesor(objProfesorBE) == true)
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

                MessageBox.Show("Error " + ex.Message);
            }


        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gbActulizar_Enter(object sender, EventArgs e)
        {

        }

        private void optActivo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtNdocum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8)
            {
                if (char.IsDigit(e.KeyChar) == false) // Ni tampoco es digito
                {

                    e.Handled = true; //Se atrapa el caracter y no se imprime 
                }
            }
        }

        private void btnFoto_Click(object sender, EventArgs e)
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
                    blnCambio = true;
                }
                else
                {
                    blnCambio = false;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error:" + ex.Message);
            }
        }
    }
}
