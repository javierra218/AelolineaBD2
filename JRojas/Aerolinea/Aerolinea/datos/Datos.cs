using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using System.Data;
using System.Windows.Forms;

namespace Aerolinea.datos
{
    class Datos
    {
        OracleConnection ora_conn = new OracleConnection(@"Data Source=LOCALHOST;User ID=finalbd;Password=finalbd");
        public Datos()
        {
            ora_conn = new OracleConnection(@"Data Source=LOCALHOST;User ID=finalbd;Password=finalbd");

        }
        #region avion

        public bool insertarAvion(int nitEmpresa, string serial, string marca, string tipo, float longitud, string pais, string fecha)
        {
            try
            {
                //abrimos la conexion
                ora_conn.Open();

                /*Creamos un comando el cual recibe el nombre
                 del procedimiento almacenado y la conexion 
                donde esta dicho procedimiento.*/
                OracleCommand ora_cmd = new OracleCommand("INSERTARAVION", ora_conn);
                ora_cmd.CommandType = CommandType.StoredProcedure;
                //indico cuales son los parametros y de que tipo(tipo de dato y direccion del parametro)
                ora_cmd.Parameters.Add("SERIAL", OracleDbType.Varchar2, 100, serial, ParameterDirection.Input);
                ora_cmd.Parameters.Add("IDAEROLINEA", OracleDbType.Decimal, nitEmpresa, ParameterDirection.Input);
                ora_cmd.Parameters.Add("MARCA", OracleDbType.Varchar2, 100, marca, ParameterDirection.Input);
                ora_cmd.Parameters.Add("TIPO", OracleDbType.Varchar2, 10, tipo, ParameterDirection.Input);
                ora_cmd.Parameters.Add("LONGITUD", OracleDbType.Double, longitud, ParameterDirection.Input);
                ora_cmd.Parameters.Add("PAIS", OracleDbType.Varchar2, 100, pais, ParameterDirection.Input);
                ora_cmd.Parameters.Add("FECHA", OracleDbType.Varchar2, 20, fecha, ParameterDirection.Input);
                //ejecuto el procedimiento almacenado
                ora_cmd.ExecuteNonQuery();
                return true;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
                return false;

            }
            finally
            {
                if (ora_conn.State == ConnectionState.Open)
                {
                    ora_conn.Close();
                }

            }


        }
        public bool eliminarAvion(string serial)
        {
            try
            {
                //abrimos la conexion
                ora_conn.Open();

                /*Creamos un comando el cual recibe el nombre
                 del procedimiento almacenado y la conexion 
                donde esta dicho procedimiento.*/
                OracleCommand ora_cmd = new OracleCommand("ELIMINARAVION", ora_conn);
                ora_cmd.CommandType = CommandType.StoredProcedure;
                //indico cuales son los parametros y de que tipo(tipo de dato y direccion del parametro)
                ora_cmd.Parameters.Add("SERIAL", OracleDbType.Varchar2, 100, serial, ParameterDirection.Input);
                //ejecuto el procedimiento almacenado
                ora_cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
                return false;

            }
            finally
            {
                if (ora_conn.State == ConnectionState.Open)
                {
                    ora_conn.Close();
                }

            }


        }

        public DataSet CONSULTARAVIONES(int nitEmpresa)
        {

            try
            {
                //abrimos la conexion
                ora_conn.Open();

                /*Creamos un comando el cual recibe el nombre
                 del procedimiento almacenado y la conexion 
                donde esta dicho procedimiento.*/
                OracleCommand ora_cmd = new OracleCommand("CONSULTARAVIONES", ora_conn);
                
                //indico cuales son los parametros y de que tipo(tipo de dato y direccion del parametro)
                ora_cmd.Parameters.Add("NIT_EMPRESA", OracleDbType.Decimal, nitEmpresa, ParameterDirection.Input);
                ora_cmd.Parameters.Add("o_cursor", OracleDbType.RefCursor, ParameterDirection.Output);
                ora_cmd.CommandType = CommandType.StoredProcedure;
                OracleDataAdapter da = new OracleDataAdapter(ora_cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "Aviones");
                //ejecuto el procedimiento almacenado

                return ds;



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
                return null;

            }
            finally
            {
                if (ora_conn.State == ConnectionState.Open)
                {
                    ora_conn.Close();
                }

            }


        }

#endregion
        #region Empresa

       

        public bool insertarEmpresa(int nit, string nombre, string fecha)
        {
            try
            {
                //abrimos la conexion
                ora_conn.Open();

                /*Creamos un comando el cual recibe el nombre
                 del procedimiento almacenado y la conexion 
                donde esta dicho procedimiento.*/
                OracleCommand ora_cmd = new OracleCommand("INSERTAREMPRESA", ora_conn);
                ora_cmd.CommandType = CommandType.StoredProcedure;
                //indico cuales son los parametros y de que tipo(tipo de dato y direccion del parametro)
                ora_cmd.Parameters.Add("NIT", OracleDbType.Decimal, nit, ParameterDirection.Input);
                ora_cmd.Parameters.Add("NOMBRE", OracleDbType.Varchar2, 256, nombre, ParameterDirection.Input);
                ora_cmd.Parameters.Add("FECHA", OracleDbType.Varchar2, 256, fecha, ParameterDirection.Input);
                //ejecuto el procedimiento almacenado
                ora_cmd.ExecuteNonQuery();
                return true;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
                
                return false;

            }
            finally
            {
                if (ora_conn.State == ConnectionState.Open)
                {
                    ora_conn.Close();
                }

            }


        }

        #endregion



    }
}