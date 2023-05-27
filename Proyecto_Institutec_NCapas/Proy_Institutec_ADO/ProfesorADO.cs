using Proy_InstitutecBE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Proy_Institutec_ADO
{
    public class ProfesorADO
    {
        //Intancias de ConexionADO
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;
        ProfesorBE objProfesorBE = new ProfesorBE();
        public DataTable ListarProfesor()
        {
           
            try
            {
                cnx.ConnectionString=MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_VerProfesor";
                cmd.Parameters.Clear();
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                DataSet dts = new DataSet();
                ada.Fill(dts, "Profesores");
                return dts.Tables["Profesores"];
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
        public ProfesorBE ConsultarProfesor(String strid) {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                ProfesorBE objProfesorBE = new ProfesorBE();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarProfesor";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", strid);
                cnx.Open();
                dtr=cmd.ExecuteReader();
                if (dtr.HasRows == true) { 
                dtr.Read();
                objProfesorBE.IdProf =dtr["IdProf"].ToString();
                objProfesorBE.NomPro = dtr["NomPro"].ToString();
                objProfesorBE.ApePat = dtr["ApePat"].ToString();
                objProfesorBE.ApeMat = dtr["ApeMat"].ToString();
                objProfesorBE.Estado = Convert.ToBoolean(dtr["Estado"]);
                objProfesorBE.TelPro = dtr["TelPro"].ToString();
                objProfesorBE.FecIng = Convert.ToDateTime(dtr["FecIng"]);
                
                
                }
                dtr.Close();
                return objProfesorBE;
            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message);
            }
            finally {
                if (cnx.State == ConnectionState.Open) { 
                cnx.Close();
                }
                    
                        }
        }

        public Boolean InsertarProfesor (ProfesorBE objProfesorBE) {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_InsertarProfesor";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Ndocum", objProfesorBE.Ndocum);
                cmd.Parameters.AddWithValue("@NomPro", objProfesorBE.NomPro);
                cmd.Parameters.AddWithValue("@ApePat", objProfesorBE.ApePat);
                cmd.Parameters.AddWithValue("@ApeMat", objProfesorBE.ApeMat);
                cmd.Parameters.AddWithValue("@Id_Ubi", objProfesorBE.Id_Ubi);
                cmd.Parameters.AddWithValue("@Sexopr", objProfesorBE.Sexopr);
                cmd.Parameters.AddWithValue("@TelPro", objProfesorBE.TelPro);
                cmd.Parameters.AddWithValue("@Estado", objProfesorBE.Estado);
                cmd.Parameters.AddWithValue("@FecIng", objProfesorBE.FecIng);
                //
                cnx.Open();
                cmd.ExecuteNonQuery();
                return true;

            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message);
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
        public Boolean ActualizarProfesor(ProfesorBE objProfesorBE)
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ActulizarProfesor";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@IdProf", objProfesorBE.IdProf);
                cmd.Parameters.AddWithValue("@NomPro", objProfesorBE.NomPro);
                cmd.Parameters.AddWithValue("@ApePat", objProfesorBE.ApePat);
                cmd.Parameters.AddWithValue("@ApeMat", objProfesorBE.ApeMat);
                cmd.Parameters.AddWithValue("@Estado", objProfesorBE.Estado);
                cmd.Parameters.AddWithValue("@TelPro", objProfesorBE.TelPro);
                cmd.Parameters.AddWithValue("@FecIng", objProfesorBE.FecIng);
                
            


                cnx.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
        //crear actualizar cnx.ConnectionString = MiConexion.GetCnx();
    }
}
