using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COVEN.Util
{
    class UtilGeral
    {
        public static string decimalToMoeda(decimal d) { return d.ToString("R$ #,##0.00"); }
        public static string strToMoeda(string s) { return Decimal.Parse(s).ToString("R$ #,##0.00"); }
        public static decimal moedaToDecimal(string s) { return Decimal.Parse(s.Replace("R$ ", "")); }

        public static DataTable GetData(string sql)
        {
            DataTable table = new DataTable();
            try
            {
                string strConn = getConnectionString();
                OleDbConnection conn = new OleDbConnection(strConn);
                conn.ConnectionString = strConn;
                try
                {
                    conn.Open();
                }
                catch (Exception ex)
                {
                    string mensagemAmigacel = "Não foi possível conectar ao banco de dados. Favor anotar os passos executados até este erro e entre em contato com o administrador do sistema.";
                    escreverLog(mensagemAmigacel, ex.Message);
                    return null;
                }
                finally
                {
                    conn.Close();
                }

                // Create a new data adapter based on the specified query.
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sql, conn);
                
                // Populate a new data table and bind it to the BindingSource.
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);
            }
            catch (SqlException ex)
            {
                string mensagemAmigacel = "Não foi possível recuperar as informações no banco de dados. Favor anotar os passos executados até este erro e entre em contato com o administrador do sistema.";
                escreverLog(mensagemAmigacel, ex.Message);
                return null;
            }

            return table;
        }

        public static void executeCommand(string queryString, List<OleDbParameter> listaParametros = null)
        {
            using (OleDbConnection conn = new OleDbConnection(getConnectionString()))
            {
                OleDbCommand command = new OleDbCommand(queryString, conn);

                if (listaParametros != null)
                    command.Parameters.AddRange(listaParametros.ToArray());

                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public static DataTable executeCommandReader(string queryString, List<OleDbParameter> listaParametros = null)
        {
            using (OleDbConnection conn = new OleDbConnection(getConnectionString()))
            {
                OleDbCommand command = new OleDbCommand(queryString, conn);

                if (listaParametros != null)
                    command.Parameters.AddRange(listaParametros.ToArray());

                command.Connection.Open();
                OleDbDataReader dataReader = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dataReader);

                return dt;
            }
        }

        public static string getConnectionString()
        {
            System.Xml.XmlTextReader reader = new System.Xml.XmlTextReader("COVEN.exe.config");
            string contents = "";
            while (reader.Read())
            {
                reader.MoveToContent();
                if (reader.NodeType == System.Xml.XmlNodeType.Element && reader.Name == "add")
                {
                    reader.MoveToAttribute("connectionString");
                    contents = reader.Value;
                }

            }
            return contents;
        }

        public static void escreverLog(string mensagemAmigavel, string mensagemErroSistema)
        {
            System.IO.File.AppendAllText(@"COVEN.log", DateTime.Now.ToString() + " - Mensagem Amigavel: " + mensagemAmigavel + " - Mensagem de Erro do Sistema: " + mensagemErroSistema);
        }
    }
}
