using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Proy_Institutec_ADO;

namespace Proy_Institutec_ADO
{
    public class UbigeoADO
    {
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;
        Boolean blnexito = false;

        public DataTable Ubigeo_Departamentos()
        {
            DataSet dts = new DataSet();
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_Ubigeo_Departamentos";
                cmd.Parameters.Clear();
                SqlDataAdapter miada;
                miada = new SqlDataAdapter(cmd);
                miada.Fill(dts, "Departamentos");
                return dts.Tables["Departamentos"];
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

    public DataTable Ubigeo_ProvinciasDepartamento(String strIdDepartamento)
        {
            DataSet dts = new DataSet();
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_Ubigeo_ProvinciasDepartamento";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@IdDepartamento", strIdDepartamento);
                SqlDataAdapter miada;
                 miada = new SqlDataAdapter(cmd);
                 miada.Fill(dts, "Provincias");
                return dts.Tables["Provincias"];
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

    public DataTable Ubigeo_DistritosProvinciaDepartamento(String strIdDepartamento,String strIdProvincia)
         {
            DataSet dts = new DataSet();
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_Ubigeo_DistritosProvinciaDepartamento";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@IdDepartamento", strIdDepartamento);
                cmd.Parameters.AddWithValue("@IdProvincia", strIdProvincia);
                SqlDataAdapter miada;
                 miada = new SqlDataAdapter(cmd);
                miada.Fill(dts, "Distritos");
                return dts.Tables["Distritos"];
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
}
        }


    }
}
