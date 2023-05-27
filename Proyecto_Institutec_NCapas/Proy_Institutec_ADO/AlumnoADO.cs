using Proy_InstitutecBE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Proy_Institutec_ADO
{
    public class AlumnoADO
    {
        //CONEXION
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        AlumnoBE objAlumnoBE = new AlumnoBE();

        // METODOS DE LOS MANTENIMIENTOS
        public DataTable ListarAlumno()
        {
            try
            {
               
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_VerAlumno";
                cmd.Parameters.Clear();
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                DataSet dts = new DataSet();
                ada.Fill(dts, "Alumno");
                return dts.Tables["Alumno"];
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
        public AlumnoBE ConsultarAlumno(String strid)
        {            
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                AlumnoBE objAlumnoBE = new AlumnoBE();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ConsultarAlumno";
                cmd.Parameters.Clear();
                //Codifique
                cmd.Parameters.AddWithValue("@IdAlum", strid);
                cnx.Open();
                dr = cmd.ExecuteReader();

                if (dr.HasRows == true)
                {
                    dr.Read();
                    objAlumnoBE.IdAlum = dr["IdAlum"].ToString();
                    objAlumnoBE.Ndocum = dr["Ndocum"].ToString();
                    objAlumnoBE.NomAlu = dr["NomAlu"].ToString();
                    objAlumnoBE.ApePat = dr["ApePat"].ToString();
                    objAlumnoBE.ApeMat = dr["ApeMat"].ToString();
                    objAlumnoBE.SexoAl = dr["SexoAl"].ToString();
                    objAlumnoBE.Id_Ubi = dr["Id_Ubi"].ToString();
                    objAlumnoBE.TelAlu = dr["TelAlu"].ToString();
                    objAlumnoBE.FecNac = Convert.ToDateTime(dr["FecNac"]);
                    objAlumnoBE.Estado = Convert.ToBoolean(dr["Estado"]);


                }
                dr.Close();
                return objAlumnoBE;

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
        public Boolean InsertarAlumno(AlumnoBE objAlumnoBE) 
        {
           
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_InsertarAlumnos";
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@NomAlu", objAlumnoBE.NomAlu);
                cmd.Parameters.AddWithValue("@ApePat", objAlumnoBE.ApePat);
                cmd.Parameters.AddWithValue("@ApeMat", objAlumnoBE.ApeMat);
                cmd.Parameters.AddWithValue("@Ndocum", objAlumnoBE.Ndocum);
                cmd.Parameters.AddWithValue("@IdFacu", objAlumnoBE.IdFacu);
                cmd.Parameters.AddWithValue("@Id_Ubi", objAlumnoBE.Id_Ubi);
                cmd.Parameters.AddWithValue("@Sexoal", objAlumnoBE.SexoAl);
                cmd.Parameters.AddWithValue("@FecNac", objAlumnoBE.FecNac);
                cmd.Parameters.AddWithValue("@CorAlu", objAlumnoBE.CorAlu);
                cmd.Parameters.AddWithValue("@TelAlu", objAlumnoBE.TelAlu);
                cmd.Parameters.AddWithValue("@Usu_Regi", objAlumnoBE.Usu_Registro);
                cmd.Parameters.AddWithValue("@Estado", objAlumnoBE.Estado);
                cmd.Parameters.AddWithValue("@CodCar", objAlumnoBE.CodCar);
                

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
                if(cnx.State == ConnectionState.Open) 
                {
                    cnx.Close();
                }
            }

        }

        public Boolean ActualizarAlumno(AlumnoBE objAlumnoBE)
        {
            
            try 
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ActualizarAlumno";
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@IdAlum", objAlumnoBE.IdAlum);
                cmd.Parameters.AddWithValue("@NomAlu", objAlumnoBE.NomAlu);
                cmd.Parameters.AddWithValue("@ApeMat", objAlumnoBE.ApeMat);
                cmd.Parameters.AddWithValue("@ApePat", objAlumnoBE.ApePat);
                cmd.Parameters.AddWithValue("@TelAlu", objAlumnoBE.TelAlu);
                cmd.Parameters.AddWithValue("@Estado", objAlumnoBE.Estado);
                cmd.Parameters.AddWithValue("FecNac", objAlumnoBE.FecNac);
              
                
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
