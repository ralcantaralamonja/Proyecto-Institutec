using Proy_InstitutecBE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
 
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
        SqlDataReader drt;
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
                cmd.CommandText = "usp_consultarAlumno";
                cmd.Parameters.Clear();
                //Codifique
                cmd.Parameters.AddWithValue("@IdAlum", strid);
                cnx.Open();
                drt = cmd.ExecuteReader();

                if (drt.HasRows == true)
                {
                    drt.Read();
                    objAlumnoBE.IdAlum = drt["IdAlum"].ToString();
                    objAlumnoBE.Ndocum = drt["Ndocum"].ToString();
                    objAlumnoBE.NomAlu = drt["NomAlu"].ToString();
                    objAlumnoBE.ApePat = drt["ApePat"].ToString();
                    objAlumnoBE.ApeMat = drt["ApeMat"].ToString();
                    objAlumnoBE.SexoAl = drt["SexoAl"].ToString();
                    objAlumnoBE.Id_Ubi = drt["Id_Ubi"].ToString();
                    objAlumnoBE.TelAlu = drt["TelAlu"].ToString();
                    objAlumnoBE.CorAlu = drt["CorAlu"].ToString();
                    objAlumnoBE.direccion = drt["direccion"].ToString();
                    objAlumnoBE.FecNac = Convert.ToDateTime(drt["FecNac"]);
                    objAlumnoBE.Estado = Convert.ToBoolean(drt["Estado"]);
                    if (drt["Foto"] != DBNull.Value)
                    {
                        objAlumnoBE.Foto = (byte[])drt["Foto"];
                    }
                    else
                    {
                        objAlumnoBE.Foto = null;
                    }


                }
                drt.Close();
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

        //Consultar Alumno
        public AlumnoBE PreMatricula(String dni)
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                AlumnoBE objAlumnoBE = new AlumnoBE();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_PreMatricula";
                cmd.Parameters.Clear();
                //Codifique
                cmd.Parameters.AddWithValue("@dni ", dni);
                cnx.Open();
                drt = cmd.ExecuteReader();

                if (drt.HasRows == true)
                {
                    drt.Read();
                    objAlumnoBE.NomAlu = drt["NomAlu"].ToString();
                    objAlumnoBE.ApePat = drt["ApePat"].ToString();
                    objAlumnoBE.ApeMat = drt["ApeMat"].ToString();
                    objAlumnoBE.DescCar = drt["DesCar"].ToString();
                    objAlumnoBE.EstadoAl = drt["Estado"].ToString();
                    objAlumnoBE.EstMat = drt["Matricula"].ToString();
                    objAlumnoBE.CodCar = drt["CodCar"].ToString();
                    objAlumnoBE.NroMat = drt["NroMat"].ToString();
                }
                drt.Close();
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

                cmd.Parameters.AddWithValue("@Ndocum", objAlumnoBE.Ndocum);
                cmd.Parameters.AddWithValue("@NomAlu", objAlumnoBE.NomAlu);
                cmd.Parameters.AddWithValue("@ApePat", objAlumnoBE.ApePat);
                cmd.Parameters.AddWithValue("@ApeMat", objAlumnoBE.ApeMat);
                cmd.Parameters.AddWithValue("@Sexoal", objAlumnoBE.SexoAl);
                cmd.Parameters.AddWithValue("@Estado", objAlumnoBE.Estado);
                cmd.Parameters.AddWithValue("@CodCar", objAlumnoBE.CodCar);
                cmd.Parameters.AddWithValue("@Id_Ubi", objAlumnoBE.Id_Ubi);
                cmd.Parameters.AddWithValue("@CorAlu", objAlumnoBE.CorAlu);
                cmd.Parameters.AddWithValue("@FecNac", objAlumnoBE.FecNac);
                cmd.Parameters.AddWithValue("@TelAlu", objAlumnoBE.TelAlu);
                cmd.Parameters.AddWithValue("@direcc", objAlumnoBE.direccion);
                cmd.Parameters.AddWithValue("@FotoAlum", objAlumnoBE.Foto);
                cmd.Parameters.AddWithValue("@Usu_Regi", objAlumnoBE.Usu_Registro);


                cnx.Open();
                cmd.ExecuteNonQuery();

                return true;
               
            }
            catch (SqlException ex) 
            {
                throw new Exception(ex.Message);
                
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
                cmd.Parameters.AddWithValue("@Ndocum", objAlumnoBE.Ndocum);
                cmd.Parameters.AddWithValue("@NomAlu", objAlumnoBE.NomAlu);
                cmd.Parameters.AddWithValue("@ApePat", objAlumnoBE.ApePat);
                cmd.Parameters.AddWithValue("@ApeMat", objAlumnoBE.ApeMat);
                cmd.Parameters.AddWithValue("@Sexoal", objAlumnoBE.SexoAl);
                cmd.Parameters.AddWithValue("@Estado", objAlumnoBE.Estado);
                cmd.Parameters.AddWithValue("@IdFacu", objAlumnoBE.IdFacu);
                cmd.Parameters.AddWithValue("@DescFacu", objAlumnoBE.DescFacu);
                cmd.Parameters.AddWithValue("@CodCar", objAlumnoBE.CodCar);
                cmd.Parameters.AddWithValue("@DescCar", objAlumnoBE.DescCar);
                cmd.Parameters.AddWithValue("@Id_Ubi", objAlumnoBE.Id_Ubi);
                cmd.Parameters.AddWithValue("@CorAlu", objAlumnoBE.CorAlu);
                cmd.Parameters.AddWithValue("@FecNac", objAlumnoBE.FecNac);
                cmd.Parameters.AddWithValue("@TelAlu", objAlumnoBE.TelAlu);
                cmd.Parameters.AddWithValue("@direcc", objAlumnoBE.direccion);
                cmd.Parameters.AddWithValue("@Usu_Regi", objAlumnoBE.Usu_Registro);
                if (objAlumnoBE.Foto != null)
                {
                    cmd.Parameters.AddWithValue("@FotoAlum", objAlumnoBE.Foto);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@FotoAlum", DBNull.Value);
                }
                


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


        public Boolean EliminarAlumno(String strCodigo)
        {


            try
            {
                //Codifique
                cnx.ConnectionString = MiConexion.GetCnx(); //cadena de conexion
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_BorrarAlumno";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@IdAlum", strCodigo); //lo que borrare

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

        public String ObtenerFacultadAlumno(string idAlumno)
        {
            try
            {
                string idFacultad = string.Empty;

                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ObtenerFacultadAlumno";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@IdAlum", idAlumno);

                cnx.Open();
                idFacultad = cmd.ExecuteScalar().ToString();

                return idFacultad;
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


        public String ObtenerCarreraAlumno(string idAlumno)
        {
            try
            {
                string idCarrera = string.Empty;

                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ObtenerCarreraAlumno";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@IdAlum", idAlumno);

                cnx.Open();
                object result = cmd.ExecuteScalar();
                idCarrera = cmd.ExecuteScalar().ToString();

                return idCarrera;
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


        public AlumnoBE ConsultarWebAlumno(String strid)
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                AlumnoBE objAlumnoBE = new AlumnoBE();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ConsultaWebAlumno";
                cmd.Parameters.Clear();
                //Codifique
                cmd.Parameters.AddWithValue("@idAlu", strid);
                cnx.Open();
                drt = cmd.ExecuteReader();

                if (drt.HasRows == true)
                {
                    drt.Read();
                    objAlumnoBE.IdAlum = drt["IdAlum"].ToString();
                    objAlumnoBE.Ndocum = drt["Ndocum"].ToString();
                    objAlumnoBE.NomAlu = drt["NomAlu"].ToString();
                    objAlumnoBE.ApePat = drt["ApePat"].ToString();
                    objAlumnoBE.ApeMat = drt["ApeMat"].ToString();
                    objAlumnoBE.TelAlu = drt["TelAlu"].ToString();
                    objAlumnoBE.CorAlu = drt["CorAlu"].ToString();
                    objAlumnoBE.Estado = Convert.ToBoolean(drt["Estado"]);
                    objAlumnoBE.departamento = drt["Departamento"].ToString();
                    objAlumnoBE.provincia = drt["Provincia"].ToString();
                    objAlumnoBE.distrito = drt["Distrito"].ToString();
                    objAlumnoBE.DescCar = drt["DesCar"].ToString();
                    objAlumnoBE.DescFacu = drt["DesFac"].ToString();


                }
                drt.Close();
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
