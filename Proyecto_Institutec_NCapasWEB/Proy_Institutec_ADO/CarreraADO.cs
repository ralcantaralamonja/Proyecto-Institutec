﻿// Agregar....
using Proy_InstitutecBE;
using System.Data;
using System.Data.SqlClient;
using System;

namespace Proy_Institutec_ADO
{
    public class CarreraADO
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
        public DataTable CarreraGenero()
        {

            try
            {


                cnx.ConnectionString = MiConexion.GetCnx(); //cadena de conexion
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_CarreraXGenero";
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


        public DataTable MatriculadosSeccion()
        {

            try
            {


                cnx.ConnectionString = MiConexion.GetCnx(); //cadena de conexion
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_MatriculadosSeccion";
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
        public CarreraBE ConsultarCarrera(String strCodigo)
        {

            try
            {
                //declaro la instancia de carrera
                CarreraBE objCarreraBE = new CarreraBE();



                //Codifique
                cnx.ConnectionString = MiConexion.GetCnx(); //cadena de conexion
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ConsultarCarrera";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@vcod", strCodigo);
                cnx.Open();
                dtr = cmd.ExecuteReader();

                //preguntamos
                if (dtr.HasRows == true)
                {
                    dtr.Read();

                    objCarreraBE.CodCar = dtr["CodCar"].ToString();
                    objCarreraBE.DesFac = dtr["DesFac"].ToString();
                    objCarreraBE.DesCar = dtr["DesCar"].ToString();
                    objCarreraBE.IdFacu = dtr["IdFacu"].ToString();
                    objCarreraBE.Est_carr = Convert.ToInt16(dtr["Est_carr_2"].ToString());


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
                cmd.Parameters.AddWithValue("@vUsu_regi", objCarreraBE.Usu_Registro);
                cmd.Parameters.AddWithValue("@vest_carr", objCarreraBE.Est_carr);

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
                cmd.Parameters.AddWithValue("@vdescar", objCarreraBE.DesCar);
                cmd.Parameters.AddWithValue("@vusu_ult_regis", objCarreraBE.Usu_Ult_Mod); // ultimo usuario que cambio
                cmd.Parameters.AddWithValue("@vest_carr", objCarreraBE.Est_carr);
                cmd.Parameters.AddWithValue("@vidfacu", objCarreraBE.IdFacu);
                cmd.Parameters.AddWithValue("@vdesFac", objCarreraBE.DesFac);

                cmd.Parameters.AddWithValue("@vcod", objCarreraBE.CodCar); //que dato actualizare

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
