using System.Xml.Linq;
using System;
using System.Net.Http;
using System.Windows.Forms;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Net;
using System.Text.Json;
using System.Data;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace WebClient
{
    public partial class Form1 : Form
    {
        public class Prodotto
        {
            public int Numero_Serie { get; set; }
            public int Dispositivo { get; set; }
        }
        public class Casa_Produttrice
        {
            public string Nome { get; set; }
            public int Data_Fondazione { get; set; }
        }
        public class Dispositivo
        {
            public int Id { get; set; }
            public string Nome { get; set; }
            public string Data_Rilascio { get; set; }
            public string Marca { get; set; }
            public string Modello { get; set; }
            public string Casa_Produttrice { get; set; }
        }
        public class Sede
        {
            public int Id { get; set; }
            public int Nome { get; set; }
            public string Casa_Produttrice { get; set; }
            public string Indirizzo { get; set; }
        }

        public Form1()
        {
            InitializeComponent();
            client = new HttpClient();
        }
        string[] tabelle = new string[] { "prodotti", "case_produttrici", "dispositivi", "sedi" };
        string url, data;
        string urlBase = "localhost/metodi/index.php";
        static HttpClient client;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void buttonGet_Click(object sender, EventArgs e)
        {
            data = textBoxDataGet.Text;
            HttpResponseMessage response = await client.GetAsync(url);
            string responseBody = await response.Content.ReadAsStringAsync();

            listView1.Items.Clear();
            listView1.Columns.Clear();

            JObject jsonObject = JObject.Parse(responseBody);

            HashSet<string> uniqueKeys = new HashSet<string>();

            int numCampi = 0;
            foreach (var property in jsonObject.Properties())
            {
                if (uniqueKeys.Contains(property.Name))
                {
                    break;
                }
                uniqueKeys.Add(property.Name);
                listView1.Columns.Add(property.Name);
                numCampi++;
            }

            int count = 0;
            string value = "";
            List<string> stringList = new List<string>();

            // Estrae le coppie chiave-valore dall'oggetto JObject
            foreach (var property in jsonObject.Properties())
            {
                value = property.Value.ToString();
                stringList.Add(value);
                if (count % numCampi == 0)
                {
                    ListViewItem item = new ListViewItem(stringList.ToArray());
                    listView1.Items.Add(item);
                }
            }

            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void buttonDelete_Click(object sender, EventArgs e)
        {
            string tab = textBoxTabDel.Text;
            string id = textBoxIdDel.Text;
            string url = urlBase + '/' + tab + '/' + id;
            HttpResponseMessage response = await client.DeleteAsync(url);
            string responseBody = await response.Content.ReadAsStringAsync();
            MessageBox.Show(responseBody);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelIdDel_Click(object sender, EventArgs e)
        {

        }

        private async void buttonPut_Click(object sender, EventArgs e)
        {
            string tabella = textBoxTabellaPP.Text;
            StringContent body = new StringContent(textBoxDatiPP.Text);
            string url = urlBase + '/' + tabella + '/' + body;
            HttpResponseMessage response = await client.PutAsync(url, body);
            string responseBody = await response.Content.ReadAsStringAsync();
            MessageBox.Show(responseBody);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void buttonPost_Click(object sender, EventArgs e)
        {
            string tabella = textBoxTabellaPP.Text;
            StringContent body = new StringContent(textBoxDatiPP.Text);
            string url = urlBase + '/' + tabella + '/' + body;
            HttpResponseMessage response = await client.PutAsync(url, body);
            string responseBody = await response.Content.ReadAsStringAsync();
            MessageBox.Show(responseBody);
        }

    }
}
