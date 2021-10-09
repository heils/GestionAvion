using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrLab2.Data
{
    class DataB
    {
        OracleConnection ora_conn = new OracleConnection(@"Data Source=LOCALHOST;USER ID=bd3;Password=a");

        public Boolean reg_emp(int nit, String name, String date){
            try {
                ora_conn.Open();
                OracleCommand ora_cmd = new OracleCommand("bd3.reg_emp", ora_conn);
                ora_cmd.CommandType = System.Data.CommandType.StoredProcedure;
                ora_cmd.Parameters.Add("nit_emp", OracleDbType.Int64, nit, System.Data.ParameterDirection.Input);
                ora_cmd.Parameters.Add("nomb_emp", OracleDbType.Varchar2, name, System.Data.ParameterDirection.Input);
                ora_cmd.Parameters.Add("fecha_emp", OracleDbType.Varchar2, date, System.Data.ParameterDirection.Input);
                ora_cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e) {
                return false;
            }finally{
                if (ora_conn.State == ConnectionState.Open){
                    ora_conn.Close();
                }
            }
        }

        public Boolean reg_avion(int serial, String marca, String tipo, int longitud, String paisEns, String fechaEns, int idEmpresa){
            try{
                ora_conn.Open();
                OracleCommand ora_cmd = new OracleCommand("bd3.reg_avion", ora_conn);
                ora_cmd.CommandType = System.Data.CommandType.StoredProcedure;
                ora_cmd.Parameters.Add("avion_serial", OracleDbType.Int64, serial, System.Data.ParameterDirection.Input);
                ora_cmd.Parameters.Add("avion_marca", OracleDbType.Varchar2, marca, System.Data.ParameterDirection.Input);
                ora_cmd.Parameters.Add("avion_tipo", OracleDbType.Varchar2, tipo, System.Data.ParameterDirection.Input);
                ora_cmd.Parameters.Add("avion_long", OracleDbType.Int64, longitud, System.Data.ParameterDirection.Input);
                ora_cmd.Parameters.Add("avion_pais", OracleDbType.Varchar2, paisEns, System.Data.ParameterDirection.Input);
                ora_cmd.Parameters.Add("avion_fecha", OracleDbType.Varchar2, fechaEns, System.Data.ParameterDirection.Input);
                ora_cmd.Parameters.Add("id_empresa", OracleDbType.Int64, idEmpresa, System.Data.ParameterDirection.Input);
                ora_cmd.ExecuteNonQuery();
                return true;
            }catch (Exception e){
                Console.WriteLine(e.StackTrace);
                return false;
            }finally{
                if(ora_conn.State == ConnectionState.Open){
                    ora_conn.Close();
                }
            }
        }
        public DataSet query_aviones(int idEmpresa){
            try {
                ora_conn.Open();
                OracleCommand ora_cmd = new OracleCommand("bd3.quer_aviones", ora_conn);
                ora_cmd.Parameters.Add("avion_cursor", OracleDbType.RefCursor, ParameterDirection.Output);
                ora_cmd.Parameters.Add("id_empresa", OracleDbType.Int64, idEmpresa, System.Data.ParameterDirection.Input);
                ora_cmd.CommandType = CommandType.StoredProcedure;
                OracleDataAdapter da = new OracleDataAdapter(ora_cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "Aviones");
                return ds;
            } catch (Exception e) {

                Console.WriteLine(e);
                return null;
            } finally {
                if (ora_conn.State == ConnectionState.Open) {
                    ora_conn.Close();
                }
            }
        }
        public Boolean delete_avion(int serial){
            try{
                ora_conn.Open();
                OracleCommand ora_cmd = new OracleCommand("bd3.delet_avion", ora_conn);
                ora_cmd.CommandType = System.Data.CommandType.StoredProcedure;
                ora_cmd.Parameters.Add("avion_serial", OracleDbType.Int64, serial, System.Data.ParameterDirection.Input);
                ora_cmd.ExecuteNonQuery();
                return true;
            }catch (Exception e){
                return false;
            }finally{
                if (ora_conn.State == ConnectionState.Open){
                    ora_conn.Close();
                }
            }
        }
    }
}
