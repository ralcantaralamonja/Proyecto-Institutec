using Proy_InstitutecBE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Net;
 
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Proy_Institutec_ADO
{
    public class CursoADO
    {
        //instancias....
        // Instancias
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;
        

        public DataTable ListarCurso()
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarCurso";
                cmd.Parameters.Clear();

                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                DataSet dts = new DataSet();
                ada.Fill(dts, "Curso");

                return dts.Tables["Curso"];
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }

        }

        public CursoBE ConsultarCurso(String strCodigo)
        {
            try
            {
                CursoBE objCursoBE = new CursoBE();
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ConsultarCurso";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@IdCurs", strCodigo);
                cnx.Open();
                dtr = cmd.ExecuteReader();

                if (dtr.HasRows == true)
                {
                    dtr.Read();
                    objCursoBE.IdCurs = dtr["ID"].ToString();
                    objCursoBE.NomCur = dtr["Curso"].ToString();
                    objCursoBE.Activo = Convert.ToInt32(dtr["Activo"]) == 1;
                    objCursoBE.CodCar = dtr["CodCar"].ToString();
                }
                dtr.Close();
                return objCursoBE;

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }
        }

        public DataTable ConsultaProfesorCurso(String strCodigo)
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ConsultaProfesor";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@cod", strCodigo);
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                DataSet dts = new DataSet();
                ada.Fill(dts, "CursoProfesor");

                return dts.Tables["CursoProfesor"];
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }
        }

        public DataTable ConsultaAlumnoCurso(String strCodigo, DateTime FecIni, DateTime FecFin)
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarCursosAlumnoFechas";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@IdAlum", strCodigo);
                cmd.Parameters.AddWithValue("@FecInc", FecIni);
                cmd.Parameters.AddWithValue("@FecFin", FecFin);

                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                DataSet dts = new DataSet();
                ada.Fill(dts, "CursosAlumnoFecha");

                return dts.Tables["CursosAlumnoFecha"];
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }
        }

        public Boolean InsertarCurso(CursoBE objCursoBE)
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_InserCurso";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@NomCur", objCursoBE.NomCur);
                cmd.Parameters.AddWithValue("@Activo", objCursoBE.Activo);
                cmd.Parameters.AddWithValue("@CodCar", objCursoBE.CodCar);
                cnx.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException x)
            {

                throw new Exception(x.Message);
               
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }
        }
        public bool ActualizarCurso(CursoBE objCursoBE)
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ActualizarCurso";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@IdCurs", objCursoBE.IdCurs);
                cmd.Parameters.AddWithValue("@NomCur", objCursoBE.NomCur);
                cmd.Parameters.AddWithValue("@Activo", objCursoBE.Activo);
                cmd.Parameters.AddWithValue("@CodCar", objCursoBE.CodCar);
                cmd.Parameters.AddWithValue("@Usu_Ult_Mod", objCursoBE.Usu_Ult_Mod);
                //cmd.Parameters.AddWithValue("@Fec_Ult_Mod", DateTime.Now);

                if (cnx.State != ConnectionState.Open)
                {
                    cnx.Open();
                }

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }
        }

        public Boolean EliminarCurso(String strCodigo)
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ActualizarCursoActivo";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@IdCurs", strCodigo);

                cnx.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException x)
            {

                throw new Exception(x.Message);
             
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }
        }

        public DataTable CursosDispobiblesAlumno(String dni) {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_CursosDisponiblesAlumno";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@dni", dni);
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                DataSet dts = new DataSet();
                ada.Fill(dts, "CursosAlumnoFecha");

                return dts.Tables["CursosDispobiblesCarrera"];
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }

        }


        public DataTable PrematriculaCursos(string codcar)
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_prematriculaCursos";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codcar", codcar);
                cnx.Open();
                dtr = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Columns.Add("NRC", typeof(string));
                dt.Columns.Add("Curso", typeof(string));
                dt.Columns.Add("Codigo", typeof(string));
                dt.Columns.Add("Profesor", typeof(string));
             
                dt.Columns.Add("Estado", typeof(string));
                dt.Columns.Add("Local", typeof(string));
                dt.Columns.Add("DIA", typeof(string));
                dt.Columns.Add("Inicio", typeof(TimeSpan));
                dt.Columns.Add("Fin", typeof(TimeSpan));
                dt.Columns.Add("Carrera", typeof(string));
                dt.Columns.Add("Vacant", typeof(int));

                while (dtr.Read())
                {
                    DataRow row = dt.NewRow();
                    row["NRC"] = dtr["NRC"].ToString();
                    row["Curso"] = dtr["Curso"].ToString();
                    row["Codigo"] = dtr["Codigo"].ToString();
                    row["Profesor"] = dtr["Profesor"].ToString();
                    row["Estado"] = dtr["Estado"].ToString();
                    row["Local"] = dtr["Local"].ToString();
                    row["DIA"] = dtr["DIA"].ToString();

                    TimeSpan horaIni;
                    if (TimeSpan.TryParse(dtr["Inicio"].ToString(), out horaIni))
                    {
                        row["Inicio"] = horaIni;
                    }

                    TimeSpan horaFin;
                    if (TimeSpan.TryParse(dtr["Fin"].ToString(), out horaFin))
                    {
                        row["Fin"] = horaFin;
                    }

                    row["Carrera"] = dtr["Carrera"].ToString();
                    row["Vacant"] = Convert.ToInt32(dtr["Vacant"]);

                    dt.Rows.Add(row);
                }

                dtr.Close();
                return dt;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }
        }



    }
}