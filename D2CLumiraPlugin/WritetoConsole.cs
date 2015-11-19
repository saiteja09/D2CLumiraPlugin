using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D2CLumiraPlugin
{
    class WritetoConsole
    {
        private string UserId = null;
        private string tableName = null;
        private string key = null;
        private string DSNName = null;
        private string selecedtDataStore = null;
        private string DDCDSName = null;
        private OdbcConnection eloquaConn = null;


        public WritetoConsole(string UserId, string key, string tableName, string DSNName, string dataStore, string DDCDSName)
        {
            this.UserId = UserId;
            this.tableName = tableName;
            this.key = key;
            this.DSNName = DSNName;
            this.selecedtDataStore = dataStore;
            this.DDCDSName = DDCDSName;
            eloquaConn = getOdbcConnection(UserId, key, DSNName);
        }

        public OdbcConnection getOdbcConnection(string UserID, string Password, string DSN)
        {
            return new OdbcConnection("DSN=" + DSN + ";Uid=" + UserID + ";Pwd=" + Password + ";DB=" +DDCDSName+ "");
        }

        public void SendCSVData(int size)
        {
            try
            {
                WriteDSInfoBlock();
                WriteDSDataBlock(size);
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine("Exception: " + ex.Message);
            }
        }


        private void WriteDSInfoBlock()
        {
            Console.WriteLine("beginDSInfo");
            Console.WriteLine("csv_first_row_has_column_names;true;true;");
            Console.WriteLine("tablename;" + tableName + ";true;");
            Console.WriteLine("Uid;" + UserId + ";true;");
            Console.WriteLine("key;" + key + ";true;");
            Console.WriteLine("DSN;" + DSNName + ";true;");
            Console.WriteLine("DataStore;" + selecedtDataStore + ";true;");
            Console.WriteLine("DDCDSN;" + DDCDSName + ";true;");
            Console.WriteLine("endDSInfo");
        }

        private void WriteDSDataBlock(int size)
        {
            StringBuilder columnNames = new StringBuilder();
            OdbcDataReader reader = null;
            Console.WriteLine("beginData");


            //Get Columns & data for the Selected Table
            OdbcCommand commandColumns = new OdbcCommand();
            if (size != 0)
            {

                commandColumns.CommandText = getCustumQueryforDataStore(size);
            }
            else
            {
                commandColumns.CommandText = getCustumQueryforDataStore(10000);
            }
                commandColumns.Connection = eloquaConn;
            eloquaConn.Open();
            try
            {
                reader = commandColumns.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine("Exception: " + ex.Message);
            }

            for (int i = 0; i < reader.FieldCount; i++)
            {
                columnNames.Append(reader.GetName(i) + ",");

            }
            //Printing ColumnNames to Console in CSV
            Console.WriteLine(columnNames.ToString().Substring(0, columnNames.ToString().Length - 1));

            int j = 0;
            while (reader.Read())
            {
                List<string> dataRow = new List<string>();
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    dataRow.Add(EscapeSpecialChars(reader[i].ToString()));
                }
                string temp = string.Join(",", dataRow);
                Console.WriteLine(temp);
                j++;
            }
            Console.WriteLine("endData");
            eloquaConn.Close();

        }

        protected string EscapeSpecialChars(Object obj)
        {
            if (obj == null)
            {
                return "";
            }
            string field = obj.ToString();
            field = field.Replace("\"", "\"\"");
            return "\"" + field + "\"";
        }

        private string getCustumQueryforDataStore(int top)
        {
            string query = null;
            if(selecedtDataStore.Equals("PostgreSQL") || selecedtDataStore.Equals("MySQL"))
            {
                query = "SELECT * FROM " + tableName + " LIMIT " + top;
            }
            else if(selecedtDataStore.Equals("Oracle"))
            {
                query = "SELECT * FROM " + tableName + " WHERE ROWNUM <= " + top;
            }
            else if(selecedtDataStore.Equals("DB2"))
            {
                query = "SELECT  * FROM " + tableName + " fetch first " + top + " rows only";
            }
            else if(selecedtDataStore.Equals("Informix"))
            {
                query = "SELECT FIRST " + top + " * FROM " + tableName + "";
            }
            else
            {
                query = "SELECT Top " + top + " * FROM " + tableName + "";
            }
            
            return query;
        }

    }
}
