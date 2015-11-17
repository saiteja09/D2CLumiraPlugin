using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;

namespace EloquaDataAccessPlugin
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string mode = null, parameters = null, locale = null;
            int size = -1;
            string[] argsList = Environment.GetCommandLineArgs();

            using (IEnumerator<string> iter = ((IEnumerable<string>)argsList).GetEnumerator())
            {
                while (iter.MoveNext())
                {
                    string arg = iter.Current;
                    if (arg == "-mode")
                    {
                        iter.MoveNext();
                        mode = iter.Current;
                    }
                    else if (arg == "-size")
                    {
                        iter.MoveNext();
                        size = Int32.Parse(iter.Current);
                    }
                    else if (arg == "-locale")
                    {
                        iter.MoveNext();
                        locale = iter.Current;
                    }
                    else if (arg == "-params")
                    {
                        iter.MoveNext();
                        parameters = iter.Current;
                    }
                }
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            

            if (mode.Equals("preview"))
           {
                Application.Run(new LoginDDC(size));
            }
            else if(mode.Equals("refresh"))
            {
                refresh(mode, parameters);
           }

        }

        public static void refresh(string mode, string parameters)
        {
            string UserId = null, key = null, DSN = null, tableName = null, dataStore = null, DDCDSN = null ;
            char[] split = new char[2];
            split[0] = ';';
            split[1] = '=';
            string[] individualParams = parameters.Split(split);
            using (IEnumerator<string> iter = ((IEnumerable<string>)individualParams).GetEnumerator())
            {
                while (iter.MoveNext())
                {
                    string arg = iter.Current;
                    if (arg.Equals("tablename"))
                    {
                        iter.MoveNext();
                        tableName = iter.Current;
                    }
                    if (arg.Equals("Uid"))
                    {
                        iter.MoveNext();
                        UserId = iter.Current;
                    }
                    if (arg.Equals("key"))
                    {
                        iter.MoveNext();
                        key = iter.Current;
                    }
                    if (arg.Equals("DSN"))
                    {
                        iter.MoveNext();
                        DSN = iter.Current;
                    }
                    if (arg.Equals("DataStore"))
                    {
                        iter.MoveNext();
                        dataStore = iter.Current;
                    }
                    if (arg.Equals("DDCDSN"))
                    {
                        iter.MoveNext();
                        DDCDSN = iter.Current;
                    }

                }
            }

            WritetoConsole objWrite = new WritetoConsole(UserId, key, tableName, DSN, dataStore, DDCDSN);
            objWrite.SendCSVData(0);
        }
    }

    
}
