using Proy_InstitutecBE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Reflection.Metadata.Ecma335;
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
                cmd.CommandText = "usp_VerCursoActivo";
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
                cmd.Parameters.AddWithValue("@IdCurso", strCodigo);
                cnx.Open();
                dtr = cmd.ExecuteReader();

                if (dtr.HasRows == true)
                {
                    dtr.Read();
                    objCursoBE.IdCurs = dtr["IdCurs"].ToString();
                    objCursoBE.NomCur = dtr["NomCur"].ToString();
                    objCursoBE.Activo = Convert.ToBoolean(dtr["Activo"]);
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
                return false;
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }
        }
        public Boolean ActualizarCurso(CursoBE objCursoBE)
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
                cmd.Parameters.AddWithValue("@Fec_Ult_Mod", objCursoBE.Fec_Ult_Mod);


                cnx.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {

                throw;
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
                return false;
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