using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ClassLibrary1

{
    public class Class1
    {

        public static DataSet Ejecutar(string cmd)
        {
            SqlConnection connection = new SqlConnection("server=DESKTOP-RMUN493\\SQLEXPRESS;database=Tienda;integrated security=true");
            connection.Open();
            DataSet DB = new DataSet();
            SqlDataAdapter DP = new SqlDataAdapter(cmd, connection);
            DP.Fill(DB);
            connection.Close();
            return DB;
        } 
        public static String Ejecutars(string id,string  nombre, String Description,String Estado, String forkey)
        {
            SqlConnection connection = new SqlConnection("server=DESKTOP-RMUN493\\SQLEXPRESS;database=Tienda;integrated security=true");
            connection.Open();
            SqlCommand da = new SqlCommand("insertsubcate", connection);
            da.CommandType = CommandType.StoredProcedure;
            da.Parameters.AddWithValue("@id", id);
            da.Parameters.AddWithValue("@Nombre", nombre);
            da.Parameters.AddWithValue("@Description", Description);
            da.Parameters.AddWithValue("@Estado", Estado);
            da.Parameters.AddWithValue("@forkey", forkey);
            da.Parameters.Add("@New_id", SqlDbType.Int).Direction = ParameterDirection.Output;
            da.ExecuteNonQuery();
            String documentoId = Convert.ToString(da.Parameters["@New_id"].Value);
            connection.Close();
            return documentoId;                      
        }
        public static Boolean ValidarForm(Control Objeto,ErrorProvider error)
        {
            Boolean errores = false;
            foreach(Control ITem in Objeto.Controls)
            {
                if(ITem is Usertext)
                {
                    Usertext ob = (Usertext)ITem;
                    if (ob.Validar == true)
                    {
                        if (string.IsNullOrEmpty(ob.Text.Trim()))
                        {
                            error.SetError(ob, "vacio");
                            errores = true;
                        }

                    }
                    else
                    {
                        error.SetError(ob, "");
                    }
                }
            }
            return errores;
        }
        
        
    }
}
