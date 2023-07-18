using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proy_InstitutecBL;
using Proy_InstitutecBE;

namespace SitioWEB_InstitutecGUI.transacciones
{
    
    public partial class Matricula1 : System.Web.UI.Page
    {
        AlumnoBL objAlumnobl = new AlumnoBL();
        AlumnoBE objAlumnobe = new AlumnoBE();
        CursoBE objCursobe = new CursoBE();
        CursoBL objCursobeBL = new CursoBL();

        protected void Page_Load(object sender, EventArgs e)

        {
            if (Page.IsPostBack == false) { 
            btnMatricular.Enabled = false;
            }
        }

        protected void btnDatos_Click(object sender, EventArgs e)



        {
           
            try
            {
                // Limpiar mensaje de éxito
                lblExito.Text = "";

                // Obtener los datos del alumno
                objAlumnobe = objAlumnobl.PreMatricula(txtDni.Text.Trim());
                txtNombre.Text = objAlumnobe.NomAlu + " " + objAlumnobe.ApePat + " " + objAlumnobe.ApeMat;
                txtCarrera.Text = objAlumnobe.DescCar;
                txtCodCarrera.Text = objAlumnobe.CodCar;
                txtMatricula.Text = objAlumnobe.NroMat;

                // Validar si el alumno es apto para matricularse
                if (txtDni.Text.Trim() == String.Empty || txtDni.Text.Trim().Length != 8)
                {
                    throw new Exception("El DNI está vacío o incorrecto");
                }

                if (objAlumnobe.EstadoAl == "Inactivo")
                {
                    throw new Exception("Alumno inactivo");
                }

                if (objAlumnobe.EstMat != "Matriculado")
                {
                    throw new Exception("Matrícula no válida");
                }

                // Si el código llega hasta aquí, el alumno es válido y se habilita el botón
                btnMatricular.Enabled = true;
                lblMensajeError.ForeColor = System.Drawing.Color.Black;
                lblMensajeError.Text = "";
                lblExito.ForeColor = System.Drawing.Color.Blue;
                lblExito.Text = "Alumno apto para matrícula";
                PopMensaje.Show();

            }
            catch (Exception exception)
            {
                btnMatricular.Enabled = false; // Alumno no válido, deshabilitar el botón
                lblMensajeError.ForeColor = System.Drawing.Color.Red;
                lblMensajeError.Text = "Mensaje: " + exception.Message;
                PopMensaje.Show();
            }
        }

        protected void btnMatricular_Click(object sender, EventArgs e)
        {
            
            string curso = txtCodCarrera.Text;
            DataTable dt = objCursobeBL.PrematriculaCursos(curso);

            grvCursos.DataSource = dt;
            grvCursos.DataBind();




        }

        protected void grvCursos_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblShowNRC.Text = txtMatricula.Text;
        }

        protected void grvCursos_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int fila = Convert.ToInt32(e.CommandArgument);
            string nrc = grvCursos.Rows[fila].Cells[1].Text;
            String mat = txtMatricula.Text;
            objAlumnobl.MatriculaAlumno(mat, nrc);


        }
    }

    }

