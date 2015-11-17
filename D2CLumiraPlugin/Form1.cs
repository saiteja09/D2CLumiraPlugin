using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;

namespace EloquaDataAccessPlugin
{
    public partial class Form1 : Form
    {
        private string UserId = null;
        private int size = -1;
        private string key = null;
        private string DSNName = null;
        private DataTable dtTables = null;
        private OdbcConnection eloquaConn = null;
        private string tableName = null;
        WritetoConsole objPreview = null;
        private string DDCDSNName = null;
        private string selectedDataStore = null;
        private Dictionary<int, string> datastores = null;
        private Dictionary<int, string> dataSources = null;
        public Form1(string userId, string password, Dictionary<int, string> datastores, Dictionary<int, string> dataSources, int size)
        {

            InitializeComponent();
            cbTableSelect.Enabled = false;
            btn_OK.Enabled = false;
            btn_Cancel.Enabled = false;
            dtTables = new DataTable();
            eloquaConn = new OdbcConnection();
            lbl_connect.Visible = false;
            this.size = size;
            this.UserId = userId;
            this.key = password;
            this.dataSources = dataSources;
            this.datastores = datastores;
            addDataSources();


        }

  
        private void addDataSources()
        {
            cb_DDCDSN.DataSource = new BindingSource(dataSources, null);
            cb_DDCDSN.DisplayMember = "Value";
            cb_DDCDSN.ValueMember = "Key";
        }

        private void Connect()
        {
            lbl_connect.Visible = true;
            DSNName = txt_DSNName.Text;
       
            DDCDSNName = cb_DDCDSN.Text;
            int selectedDataStoreId = (int)cb_DDCDSN.SelectedValue;
            selectedDataStore = datastores[selectedDataStoreId];

            eloquaConn = new OdbcConnection("DSN=" + DSNName + ";Uid=" + UserId + ";Pwd=" + key + ";DB=" + DDCDSNName + "");
            try
            {
                eloquaConn.Open();
                dtTables = eloquaConn.GetSchema("Tables");
                eloquaConn.Close();
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine("Exception: " + ex.Message);
                System.Environment.Exit(-1);
            }

            foreach (DataRow row in dtTables.Rows)
                cbTableSelect.Items.Add(row["TABLE_SCHEM"] + "." + row["TABLE_NAME"].ToString());
            lbl_connect.Text = "Connected.";
            txt_DSNName.Enabled = false;
            cb_DDCDSN.Enabled = false;
            btn_Connect.Enabled = false;
            cbTableSelect.Enabled = true;
            btn_OK.Enabled = true;
            btn_Cancel.Enabled = true;

        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            
            Connect();

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if(cbTableSelect.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an entity to proceed");
            }
            else
            {
                tableName = cbTableSelect.SelectedItem.ToString();
            }
            objPreview = new WritetoConsole(UserId, key, tableName, DSNName, selectedDataStore, DDCDSNName);
            objPreview.SendCSVData(size);
            Application.Exit();
        }

      
    }


}
