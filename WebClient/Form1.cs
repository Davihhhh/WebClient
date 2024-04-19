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
        public Form1()
        {
            InitializeComponent();
            client = new HttpClient();
        }
        private string[] tabelle = new string[] { "prodotti", "case_produttrici", "dispositivi", "sedi" };
        private string urlBase = "http://localhost/metodi/php";
        private static HttpClient client;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void buttonGet_Click(object sender, EventArgs e)
        {
            try
            {
                string tabella = textBoxDataGet.Text;
                string id = textBoxIdGet.Text;
                string url = "";
                if (string.IsNullOrEmpty(tabella))
                {
                    MessageBox.Show("Inserisci almeno la tabella");
                }
                else if (string.IsNullOrEmpty(id))
                {
                    url = urlBase + '/' + tabella;
                }
                else
                {
                    url = urlBase + '/' + tabella + '/' + id;
                }
                MessageBox.Show(url);

                if (url == "")
                {
                    MessageBox.Show("URL invalido");
                }
                else if (CheckTabelle(tabella))
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    string responseBody = await response.Content.ReadAsStringAsync();
                    listView1.Items.Clear();
                    listView1.Columns.Clear();

                    JArray recordsArray = JArray.Parse(responseBody);

                    HashSet<string> uniqueKeys = new HashSet<string>();

                    // Ottieni tutte le chiavi uniche
                    foreach (JObject record in recordsArray)
                    {
                        foreach (var kvp in record)
                        {
                            uniqueKeys.Add(kvp.Key);
                        }
                    }

                    // Aggiungi le colonne alla listView1 utilizzando le chiavi uniche
                    foreach (string key in uniqueKeys)
                    {
                        listView1.Columns.Add(key);
                    }

                    // Aggiungi gli elementi alla listView1 utilizzando i valori dei record
                    foreach (JObject record in recordsArray)
                    {
                        string[] recordValues = uniqueKeys.Select(key => (string)record.GetValue(key)).ToArray();
                        ListViewItem item = new ListViewItem(recordValues);
                        listView1.Items.Add(item);
                    }
                    listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                    listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private async void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string tabella = textBoxTabDel.Text;
                string id = textBoxIdDel.Text;
                if (string.IsNullOrEmpty(tabella) || string.IsNullOrEmpty(id))
                {
                    MessageBox.Show("Inserisci tutti i campi");
                }
                else if (!CheckTabelle(tabella))
                {
                    MessageBox.Show("Tabella non accettata");
                }
                else
                {
                    string url = urlBase + '/' + tabella + '/' + id;
                    HttpResponseMessage response = await client.DeleteAsync(url);
                    string responseBody = await response.Content.ReadAsStringAsync();
                    MessageBox.Show(responseBody);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
       
        private async void buttonPut_Click(object sender, EventArgs e)
        {
            try
            {
                string tabella = textBoxTabellaPP.Text;
                string dati = textBoxDatiPP.Text;
                if (string.IsNullOrEmpty(tabella) || string.IsNullOrEmpty(dati))
                {
                    MessageBox.Show("Completa tutti i campi");
                }
                else if (!CheckTabelle(tabella))
                {
                    MessageBox.Show("Tabella non accettata");
                }
                else
                {
                    StringContent body = new StringContent(dati);
                    string url = urlBase + '/' + tabella;
                    HttpResponseMessage response = await client.PutAsync(url, body);
                    string responseBody = await response.Content.ReadAsStringAsync();
                    MessageBox.Show(responseBody);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private async void buttonPost_Click(object sender, EventArgs e)
        {
            try
            {
                string tabella = textBoxTabellaPP.Text;
                string dati = textBoxDatiPP.Text;

                if (string.IsNullOrEmpty(tabella) || string.IsNullOrEmpty(dati))
                {
                    MessageBox.Show("Completa tutti i campi");
                }
                else if (!CheckTabelle(tabella))
                {
                    MessageBox.Show("Tabella non accettata");
                }
                else
                {
                    string url = urlBase + '/' + tabella;
                    StringContent body = new StringContent(dati);
                    HttpResponseMessage response = await client.PostAsync(url, body);
                    string responseBody = await response.Content.ReadAsStringAsync();
                    MessageBox.Show(responseBody);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private bool CheckTabelle(string tabella)
        {
            foreach(string t in tabelle)
            {
                if (t.Equals(tabella))
                    return true;
            }
            return false;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

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

    }
}
