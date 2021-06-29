using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Questionario
{
    public static class Banco
    {
        public static string Servidor { get; set; }
        public static SqlConnection abrir() 
        {
            string strcon = @"Data Source="+Banco.Servidor+";Initial Catalog=QuestionarioClientes;Integrated Security=True;";
            SqlConnection con = new SqlConnection(strcon);
            con.Open();
            return con;
        }

        public static DataTable Consulta(string sqlCommand) 
        {
            SqlDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = abrir();
                cmd.CommandText = sqlCommand;
                da = new SqlDataAdapter(cmd.CommandText, cmd.Connection);
                da.Fill(dt);
                cmd.Connection.Close();
                return dt;
            }
            catch (Exception E)
            {
                throw E;
            }
        }   
    }
}
