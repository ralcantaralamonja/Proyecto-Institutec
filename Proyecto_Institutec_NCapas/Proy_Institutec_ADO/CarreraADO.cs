using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Agregar....
using System.Data;
using System.Data.SqlClient;
using Proy_InstitutecBE;


namespace Proy_Institutec_ADO
{
    public  class CarreraADO
    {
        // Instancias.....
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;

        public DataTable ListarCarrera()
        {
            
            try
            {

                
                cnx.ConnectionString = MiConexion.GetCnx(); //cadena de conexion
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarCarrera";
                cmd.Parameters.Clear();


                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                DataSet dts = new DataSet();
                ada.Fill(dts, "Carreras");

                return dts.Tables["Carreras"];


            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public CarreraBE ConsultarCarrera (String strCodigo)
        {
            
            try
            {
                //declaro la instancia de carrera
                CarreraBE objCarreraBE = new CarreraBE();



                //Codifique
                cnx.ConnectionString = MiConexion.GetCnx(); //cadena de conexion
                cmd.Connection= cnx;
                cmd.CommandType= CommandType.StoredProcedure;
                cmd.CommandText = "usp_ConsultarCarrera";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@vcod", strCodigo);
                cnx.Open();
                dtr = cmd.ExecuteReader();

                //preguntamos
                if(dtr.HasRows == true)
                {
                    dtr.Read();
                 
                  objCarreraBE.CodCard = dtr["CodCard"].ToString();
                  objCarreraBE.IdFacu = dtr["IdFacu"].ToString();
                  objCarreraBE.DesCar = dtr["DesCar"].ToString() ;

                }
                dtr.Close();
                return objCarreraBE;

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

        public Boolean InsertarCarrera(CarreraBE objCarreraBE)
        {
          
            try
            {
                //Codifique
                cnx.ConnectionString = MiConexion.GetCnx(); //cadena de conexion
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_InsertarCarrera";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@vIdFacu", objCarreraBE.IdFacu);
                cmd.Parameters.AddWithValue("@vDesCar", objCarreraBE.DesCar);
                cmd.Parameters.AddWithValue("@vUsu_Regi", objCarreraBE.Usu_Registro);
                
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
        public Boolean ActualizarCarrera(CarreraBE objCarreraBE)
        {
            try
            {
                //Codifique
                cnx.ConnectionString = MiConexion.GetCnx(); //cadena de conexion
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ActualizarCarrera";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@vcod", objCarreraBE.CodCard); //que dato actualizare
                cmd.Parameters.AddWithValue("@vidfacu", objCarreraBE.IdFacu);
                cmd.Parameters.AddWithValue("@vdescar", objCarreraBE.DesCar);
                cmd.Parameters.AddWithValue("@vusu_ult_regis", objCarreraBE.Usu_Ult_Mod); // ultimo usuario que cambio
                

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

        public Boolean EliminarCarrera(String strCodigo)
        {
           

            try
            {
                //Codifique
                cnx.ConnectionString = MiConexion.GetCnx(); //cadena de conexion
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_BorrarCarrera";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@vcod", strCodigo); //lo que borrare

                cnx.Open() ;
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
