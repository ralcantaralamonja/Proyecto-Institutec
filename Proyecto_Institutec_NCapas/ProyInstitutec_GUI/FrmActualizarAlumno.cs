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
    public partial class FrmActualizarAlumno : Form
    {
        AlumnoBE objAlumnoBE = new AlumnoBE();
        AlumnoBL objAlumnoBL = new AlumnoBL();
        // FacultadBL objFacultadBL = new FacultadBL();
        //CarreraBL objCarreraBL = new CarreraBL();

        public FrmActualizarAlumno()
        {
            InitializeComponent();
        }
        public String Codigo
        {
            get; set;
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnGrabar_Click(object sender, EventArgs e)
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
                if (mskDNIAlumno.Text.Trim() == String.Empty || mskDNIAlumno.Text.Length != 8)
                {
                    throw new Exception("Dni vacio o no contiene 8 digitos");
                }
                if (mskTelAlu.Text.Trim() == String.Empty)
                {
                    throw new Exception("Numero de telefono invalido");
                }
                if (txtCoreAlu.Text.Trim() == String.Empty)
                {
                    throw new Exception("Correo es un campo obligatorio");
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
             
                //Pasamos valores alas propiedades de la instancia...
                objAlumnoBE.NomAlu = txtNombre.Text.Trim();
                objAlumnoBE.ApeMat = txtApeMat.Text.Trim();
                objAlumnoBE.ApePat = txtApePat.Text.Trim();
                objAlumnoBE.Ndocum = mskDNIAlumno.Text.Trim();
                objAlumnoBE.TelAlu = mskTelAlu.Text.Trim();
                objAlumnoBE.CorAlu = txtCoreAlu.Text.Trim();
                objAlumnoBE.Estado = activo;
                //objAlumnoBE.IdFacu = cboFacultad.SelectedValue.ToString();
                //objAlumnoBE.CodCar = cboCarrera.SelectedValue.ToString();

                //formulario de logeo 
                objAlumnoBE.Usu_Ult_Mod = clsCredenciales.Login_Usuario;

                if (objAlumnoBL.ActualizarAlumno(objAlumnoBE) == true)
                {
                    this.Close();
                }
                else
                {
                    throw new Exception("No se actualizo ");
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
                try
                {
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


                    //dt2 = objCarreraBL.ListarCarrera();


                    //instancia de datarow , instancia de fila

                    //dr = dt2.NewRow(); // fila vacia
                    //dr["CodCar"] = 0;
                    //dr["DesCar"] = "--Seleccione--";
                    //primera fila que se visualice:
                    //dt2.Rows.InsertAt(dr, 0);
                    //cboCarrera.DataSource = dt2;
                    //cboCarrera.DisplayMember = "DesFac";
                    //cboCarrera.ValueMember = "CodCar";

                    objAlumnoBE = objAlumnoBL.ConsultarAlumno(this.Codigo);

                    LblCodAlu.Text = objAlumnoBE.IdAlum;
                    txtNombre.Text = objAlumnoBE.NomAlu;
                    txtApePat.Text = objAlumnoBE.ApePat;
                    txtApeMat.Text = objAlumnoBE.ApeMat;
                    mskDNIAlumno.Text = objAlumnoBE.Ndocum;
                    txtCoreAlu.Text = objAlumnoBE.CorAlu;
                    mskTelAlu.Text = objAlumnoBE.TelAlu;

                    //combos Facultad y Carrera
                    cboFacultad.SelectedValue = objAlumnoBE.IdFacu;
                    cboCarrera.SelectedValue = objAlumnoBE.CodCar;


                    //estado , convierto a booleqan para activar
                    chkActivo.Checked = Convert.ToBoolean(objAlumnoBE.Estado);



                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }


        }



    }
}
