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
using Proy_InstitutecBl;
using Proy_InstitutecBL;
using System.IO;// para la clase File

namespace ProyInstitutec_GUI
{
    public partial class FrmActualizarAlumno : Form
    {
        AlumnoBL objAlumnoBL = new AlumnoBL();
        AlumnoBE objAlumnoBE = new AlumnoBE();
        FacultadBL objFacultadBL = new FacultadBL();
        CarreraBL objCarreraBL = new CarreraBL();

        public FrmActualizarAlumno()
        {
            InitializeComponent();
        }
        public String Codigo { get; set; }
        public byte[] FotoOriginal { get; private set; }

        public bool blnCambio { get; set; }


        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                if (mskDNIAlu.Text.Trim() == String.Empty || mskDNIAlu.Text.Length != 8)
                {
                    throw new Exception("Dni vacio o no contiene 8 digitos");
                }
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
                    throw new Exception("El apellido Materno del alumno es un campo obligatorio");
                }

                if (mskTelAlu.Text.Trim() == String.Empty)
                {
                    throw new Exception("Numero de telefono invalido");
                }
                if (txtCorreoAlu.Text.Trim() == String.Empty)
                {
                    throw new Exception("Correo es un campo obligatorio");
                }
                if (textDireccionAlum.Text.Trim() == String.Empty)
                {
                    throw new Exception("La direccion es un campo obligatorio");
                }
                if (pcbFoto.Image == null)
                {
                    throw new Exception("Debe registrar la foto.");
                }


                DateTime fechaNac = dtpFecNac.Value;

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



                // si cambio foto
                if (blnCambio == true)
                {
                    objAlumnoBE.Foto = File.ReadAllBytes(openFileDialog1.FileName);
                }
                else
                {
                    objAlumnoBE.Foto = FotoOriginal;
                }



                //Pasamos valores alas propiedades de la instancia...
                objAlumnoBE.IdAlum = lblCodigo.Text.Trim();
                objAlumnoBE.Ndocum = mskDNIAlu.Text.Trim();
                objAlumnoBE.NomAlu = txtNombre.Text.Trim();
                objAlumnoBE.ApePat = txtApePat.Text.Trim();
                objAlumnoBE.ApeMat = txtApeMat.Text.Trim();
                objAlumnoBE.SexoAl = Genero;
                objAlumnoBE.Estado = activo;
                objAlumnoBE.CorAlu = txtCorreoAlu.Text.Trim();
                objAlumnoBE.FecNac = fechaNac;
                objAlumnoBE.TelAlu = mskTelAlu.Text.Trim();
                objAlumnoBE.direccion = textDireccionAlum.Text.Trim();





                objAlumnoBE.IdFacu = cboFacultad.SelectedValue.ToString();
                objAlumnoBE.CodCar = cboCarrera.SelectedValue.ToString();





                objAlumnoBE.Id_Ubi = cboDep.SelectedValue.ToString() + cboProvincia.SelectedValue.ToString() +
                    cboDistrito.SelectedValue.ToString();



                //formulario de logeo 
                objAlumnoBE.Usu_Registro = clsCredenciales.Login_Usuario;


                if (objAlumnoBL.ActualizarAlumno(objAlumnoBE) == true)
                {
                    this.Close();
                }
                else
                {
                    throw new Exception("No se inserto el alumno ");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error : " + ex.Message);

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }



        private void FrmActualizarAlumno_Load(object sender, EventArgs e)
        {
            try
            {
                objAlumnoBE = objAlumnoBL.ConsultarAlumno(this.Codigo);




                if (objAlumnoBE.Foto == null || objAlumnoBE.Foto.Length == 0)
                {
                    pcbFoto.Image = null;
                }
                else
                {
                    MemoryStream fotoStream = new MemoryStream(objAlumnoBE.Foto);
                    pcbFoto.Image = Image.FromStream(fotoStream);
                    FotoOriginal = objAlumnoBE.Foto;
                }



                lblCodigo.Text = objAlumnoBE.IdAlum;
                txtNombre.Text = objAlumnoBE.NomAlu;
                txtApeMat.Text = objAlumnoBE.ApeMat;
                txtApePat.Text = objAlumnoBE.ApePat;
                mskTelAlu.Text = objAlumnoBE.TelAlu;
                mskDNIAlu.Text = objAlumnoBE.Ndocum;
                txtCorreoAlu.Text = objAlumnoBE.CorAlu;
                textDireccionAlum.Text = objAlumnoBE.direccion;
                dtpFecNac.Value = objAlumnoBE.FecNac;



                String Id_Ubigeo = objAlumnoBE.Id_Ubi;
                CargarUbigeo(Id_Ubigeo.Substring(0, 2), Id_Ubigeo.Substring(2, 2),
                    Id_Ubigeo.Substring(4, 2));



                //cargamos los combos
                DataTable dt2 = objCarreraBL.ListarCarrera();
                //instancia de datarow , instancia de fila
                DataRow dtr;
                dtr = dt2.NewRow(); // fila vacia
                dtr["CodCar"] = 0;
                dtr["DesCar"] = "--Seleccione--";
                //primera fila que se visualice:
                dt2.Rows.InsertAt(dtr, 0);
                cboCarrera.DataSource = dt2;
                cboCarrera.DisplayMember = "DesCar";
                cboCarrera.ValueMember = "CodCar";

                //combos 
                objAlumnoBE.CodCar = cboCarrera.SelectedValue.ToString();





                if (objAlumnoBE.Estado == true)
                {
                    chkActivo.Checked = true;
                }
                else
                {
                    chkActivo.Checked = false;
                }
                if (objAlumnoBE.SexoAl == "M")
                {
                    optM.Checked = true;
                }
                else
                {
                    optF.Checked = true;
                }
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

        private void CargarFacultades(string codCar)
        {
            DataTable dtFacultades = objFacultadBL.facultadCarrera(codCar);
            DataRow drFacultad;
            drFacultad = dtFacultades.NewRow();
            drFacultad["IdFacu"] = 0;
            drFacultad["DesFac"] = "--Seleccione--";
            dtFacultades.Rows.InsertAt(drFacultad, 0);

            cboFacultad.DataSource = dtFacultades;
            cboFacultad.DisplayMember = "DesFac";
            cboFacultad.ValueMember = "IdFacu";
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

        private void cboCarrera_SelectedIndexChanged(object sender, EventArgs e)
        {
            string codCar = cboCarrera.SelectedValue.ToString();
            CargarFacultades(codCar);
        }

        private void pcbFoto_Click(object sender, EventArgs e)
        {

        }

        private void btnFoto_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
