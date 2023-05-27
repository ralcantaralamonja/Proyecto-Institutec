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

        // METODOS DE LOS MANTENIMIENTOS

        public Boolean InsertarAlumno(AlumnoBE objAlumnoBE) 
        {
           
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_InsertarAlumno";
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@NamAlu", objAlumnoBE.NomAlu);
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
                cmd.Parameters.AddWithValue("@DirecAlu", objAlumnoBE.direccion);

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
                cmd.CommandText = "usp_ActualizaAlumnoNdocum";
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@IdAlum", objAlumnoBE.Estado);
                cmd.Parameters.AddWithValue("@NomAlu", objAlumnoBE.NomAlu);
                cmd.Parameters.AddWithValue("@ApeMat", objAlumnoBE.ApeMat);
                cmd.Parameters.AddWithValue("@ApePat", objAlumnoBE.ApePat);
                cmd.Parameters.AddWithValue("@TelAlu", objAlumnoBE.TelAlu);
                cmd.Parameters.AddWithValue("@CorAlu", objAlumnoBE.CorAlu);
                cmd.Parameters.AddWithValue("@Ndocum", objAlumnoBE.Ndocum);
                cmd.Parameters.AddWithValue("@Estado", objAlumnoBE.Estado);
                cmd.Parameters.AddWithValue("@CodCar", objAlumnoBE.CodCar);
                cmd.Parameters.AddWithValue("@Usu_Registro", objAlumnoBE.Usu_Ult_Mod);
                
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

        public Boolean BorrarAlumno(String strcod) 
        {
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_BorrarAlumno";
            cmd.Parameters.Clear();
            try 
            {
                cmd.Parameters.AddWithValue("@IdAlum", strcod);
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
                if(cnx.State == ConnectionState.Open)
                {
                    cnx.Close(); 
                }
            }
        }

        public DataTable ListarAlumno()
        {
            DataSet dts = new DataSet();
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ListarAlumno";
            cmd.Parameters.Clear();
            try
            {

                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "Alumno");

                return dts.Tables["Alumno"];
            }
            catch (SqlException ex) 
            {
                throw new Exception(ex.Message);
            }
          

        }

        public AlumnoBE ConsultarAlumno(String strCod)
        {
            AlumnoBE objAlumnoBE = new AlumnoBE();
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ConsultarAlumno";
            cmd.Parameters.Clear();
            try
            {
                //Codifique
                cmd.Parameters.AddWithValue("@IdAlum", strCod);

                // Abrimos la conexion y ejecutamos...
                cnx.Open();
                dr = cmd.ExecuteReader();

                if (dr.HasRows == true)
                {
                    dr.Read();
                    objAlumnoBE.IdAlum = dr["id"].ToString();
                    objAlumnoBE.NomAlu = dr["Alumno"].ToString();
                    objAlumnoBE.SexoAl = dr["genero"].ToString();
                    objAlumnoBE.Ndocum = dr["DNI"].ToString();
                    objAlumnoBE.CorAlu = dr["correo"].ToString();
                    objAlumnoBE.DescCar = dr["carrera"].ToString();
                    objAlumnoBE.DescFacu = dr["Facultad"].ToString();
                    objAlumnoBE.Estado = Convert.ToBoolean(dr["Estado"]);
                    objAlumnoBE.distrito = dr["Distrito"].ToString();
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


       

    }
}
