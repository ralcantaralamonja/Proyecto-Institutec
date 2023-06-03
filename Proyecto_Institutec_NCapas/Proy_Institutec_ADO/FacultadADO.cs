using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace Proy_Institutec_ADO
{
    public  class FacultadADO
    {
        // Instancias.....
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;

        public DataTable ListarFacultad()
        {
            DataSet dts = new DataSet();
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ListarFacultad";
            try
            {

                cmd.Parameters.Clear();
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "Facultades");
                return dts.Tables["Facultades"];
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public DataTable facultadCarrera(String strIdFacu)
        {
            DataSet dts = new DataSet();
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_facultadCarrera";


            try
            {

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@CodCar", strIdFacu);
                SqlDataAdapter miada;
                miada = new SqlDataAdapter(cmd);
                miada.Fill(dts, "Facultades");
                return dts.Tables["Facultades"];
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }




    }


    
}
