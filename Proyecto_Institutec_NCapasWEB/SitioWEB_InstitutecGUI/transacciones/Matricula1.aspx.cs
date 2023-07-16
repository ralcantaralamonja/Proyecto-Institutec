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
                String carrera = objAlumnobe.CodCar;


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
            }
            catch (Exception exception)
            {
                btnMatricular.Enabled = false; // Alumno no válido, deshabilitar el botón
                lblMensajeError.ForeColor = System.Drawing.Color.Red;
                lblMensajeError.Text = "Mensaje: " + exception.Message;
            }
        }

        protected void btnMatricular_Click(object sender, EventArgs e)
        {   
            String carrera = objAlumnobe.CodCar.ToString();
            
            grvCursos.DataSource = objCursobeBL.PrematriculaCursos(carrera);
            grvCursos.DataBind();
            //objcursoBE.nrc = dtr["NRC"].ToString();
            //objcursoBE.NomCur = dtr["Curso"].ToString();
            //objcursoBE.CodCar = dtr["Codigo"].ToString();
            //objcursoBE.nomprof = dtr["NomPro"].ToString();
            //objcursoBE.apepatprof = dtr["ApePat"].ToString();
            //objcursoBE.apematprof = dtr["ApeMat"].ToString();
            //objcursoBE.estadoCurso = dtr["Estado"].ToString();
            //objcursoBE.centro = dtr["Local"].ToString();
            //objcursoBE.Dia = dtr["DIA"].ToString();
            //objcursoBE.HoraIni = Convert.ToDateTime(dtr["Inicio"]);
            //objcursoBE.HoraFin = Convert.ToDateTime(dtr["Fin"]);
            //objcursoBE.DesCar = dtr["Carrera"].ToString();
            //objcursoBE.vacante = Convert.ToInt16(dtr["Vacant"]);
        }
    }

    }

