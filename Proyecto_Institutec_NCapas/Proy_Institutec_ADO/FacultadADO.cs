using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public string ConsultarFacultad(string idFacultad)
        {
            string nombreFacultad = string.Empty;
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ConsultarFacultad";
            try
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@IdFacu", idFacultad);
                cmd.Parameters.Add("@NombreFacultad", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output;

                cnx.Open();
                cmd.ExecuteNonQuery();

                nombreFacultad = cmd.Parameters["@NombreFacultad"].Value.ToString();

                return nombreFacultad;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cnx.Close();
            }
        }


    }
}
