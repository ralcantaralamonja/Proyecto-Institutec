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
                ada.Fill(dts, "Carrera");

                return dts.Tables["Carrera"];


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
                    //-------------------FALTA CORREGIR 
                  //  objobjCarreraBE.Cod_pro = dtr["Cod_pro"].ToString();
                  //  objobjCarreraBE.Des_pro = dtr["Des_pro"].ToString() ;
                   // objobjCarreraBE.Pre_pro = Convert.ToSingle(dtr["Pre_pro"]);
                  //  objobjCarreraBE.Stk_act = Convert.ToInt16(dtr["Stk_act"]);
                  //  objobjCarreraBE.Stk_min = Convert.ToInt16(dtr["Stk_min"]);
                  //  objobjCarreraBE.Id_UM = Convert.ToInt16(dtr["Id_UM"]);
                  //  objobjCarreraBE.Id_Cat = Convert.ToInt16(dtr["Id_Cat"]);
                 //   objobjCarreraBE.Importado = Convert.ToInt16(dtr["Importado"]);
                  //  objobjCarreraBE.Est_pro = Convert.ToInt16(dtr["Est_pro"]);


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
                cmd.Parameters.AddWithValue("@CodCar", objCarreraBE.CodCard);
                cmd.Parameters.AddWithValue("@IdFacu", objCarreraBE.IdFacu);
                cmd.Parameters.AddWithValue("@vUsu_Registro", objCarreraBE.Usu_Registro);
                


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

                //---------------faltra corregir
            //    cmd.Parameters.AddWithValue("@vdes", objCarreraBE.Des_pro);
             //   cmd.Parameters.AddWithValue("@pre", objCarreraBE.Pre_pro);
             //   cmd.Parameters.AddWithValue("@vstka", objCarreraBE.Stk_act);
             //   cmd.Parameters.AddWithValue("@vstkm", objCarreraBE.Stk_min);
             //   cmd.Parameters.AddWithValue("@vld_UM", objCarreraBE.Id_UM);
             //   cmd.Parameters.AddWithValue("@vld_Cat", objCarreraBE.Id_Cat);
                

                cmd.Parameters.AddWithValue("@Usu_Ult_Mod", objCarreraBE.Usu_Ult_Mod); // ultimo usuario que cambio
                




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
                cmd.Parameters.AddWithValue("@vcod", strCodigo); //lo que boirrare

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
