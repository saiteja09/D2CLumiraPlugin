using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Json;
using System.Web;

namespace EloquaDataAccessPlugin
{
    public partial class LoginDDC : Form
    {
        private int size = -1;
        public LoginDDC(int size)
        {
            InitializeComponent();
            this.size = size;
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            String username = txtBox_UserId.Text;
            String password = txt_Password.Text;
            String encoded = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(username + ":" + password));
            String dataStoresURL = "https://service.datadirectcloud.com/api/mgmt/datastores";
            String dataSourcesURL = "https://service.datadirectcloud.com/api/mgmt/datasources";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(dataSourcesURL);
            request.Timeout = 5000;
            request.Headers.Add("Authorization", "Basic " + encoded);
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                if((int)response.StatusCode != 200)
                {
                    MessageBox.Show("Login Failed!");
                }
                else
                {
                   Dictionary<int, string> dataStores =  GetDataStores(dataStoresURL, encoded);
                    Dictionary<int, string> dataSources =  GetDataSources(dataSourcesURL, encoded);
                   this.Hide();
                    Form1 form1 = new Form1(username, password, dataStores, dataSources, size);
                    this.Hide();
                    form1.Show();
                }
            }
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://pacific.progress.com/console/register?productName=d2c&ignoreCookie=true");
        }

        private Dictionary<int, string> GetDataStores(string storesURL, string encoded)
        {
            Dictionary<int, string> dataStoresDict = new Dictionary<int, string>();
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(storesURL);
            request.Timeout = 5000;
            request.Headers.Add("Authorization", "Basic " + encoded);
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(DataStoresJSON));
                object objResponse = jsonSerializer.ReadObject(response.GetResponseStream());
                DataStoresJSON jsonResponse
                = objResponse as DataStoresJSON;
                int dataStoreNum = jsonResponse.ResourceSets.Length;
                for(int i = 0; i< dataStoreNum; i++)
                {
                    dataStoresDict.Add((int)jsonResponse.ResourceSets[i].DataStoreId, jsonResponse.ResourceSets[i].DataStoreName.ToString());
                }
            }

            return dataStoresDict;
        }

        private Dictionary<int, string> GetDataSources(string dataSourcesURL, string encoded)
        {
            Dictionary<int, string> dataSourcesList = new Dictionary<int, string>();
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(dataSourcesURL);
            request.Timeout = 5000;
            request.Headers.Add("Authorization", "Basic " + encoded);
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(DataSourcesJSON));
                object objResponse = jsonSerializer.ReadObject(response.GetResponseStream());
                DataSourcesJSON jsonResponse
                = objResponse as DataSourcesJSON;
                int dataStoreNum = jsonResponse.ResourceSets.Length;
                for (int i = 0; i < dataStoreNum; i++)
                {
                    dataSourcesList.Add(jsonResponse.ResourceSets[i].DataSourceId,jsonResponse.ResourceSets[i].DataSourceName.ToString());

                }
            }

            return dataSourcesList;
        }
    }
}
