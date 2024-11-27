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
using Newtonsoft.Json;

namespace BitCoin_kalkulaator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Valivaluuta.SelectedItem.ToString() == "USD")
            {
                Tulemustekst.Visible = true;
                Tulemustekst.Visible = true;
                BitCoin_rates newbitcoinrate = GetRates();
                float result = float.Parse(Bitcoinkogus.Text) * (float)newbitcoinrate.Bpi.USD.rate_float;
                Tulemustekst.Text = $"{result} Bitcoini {newbitcoinrate.Bpi.USD.code}";
            }
            if (Valivaluuta.SelectedItem.ToString() == "GBP")
            {
                Tulemustekst.Visible = true;
                Tulemustekst.Visible = true;
                BitCoin_rates newbitcoinrate = GetRates();
                float result = float.Parse(Bitcoinkogus.Text) * (float)newbitcoinrate.Bpi.GBP.rate_float;
                Tulemustekst.Text = $"{result} Bitcoini {newbitcoinrate.Bpi.GBP.code}";
            }
            if (Valivaluuta.SelectedItem.ToString() == "EEK")
            {
                Tulemustekst.Visible = true;
                Tulemustekst.Visible = true;
                BitCoin_rates newbitcoinrate = GetRates();
                float result = float.Parse(Bitcoinkogus.Text) * (float)(newbitcoinrate.Bpi.EUR.rate_float*15.6466);
                Tulemustekst.Text = $"{result} EEK";
            }
   
        }

        public static BitCoin_rates GetRates()
        {
            string url = "https://api.coindesk.com/v1/bpi/currentprice.json";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";

            var webResponse = request.GetResponse();
            var webStream = webResponse.GetResponseStream();

            BitCoin_rates bitcoin;
            using (var responseReader = new StreamReader(webStream))
            {
                var data = responseReader.ReadToEnd();
                bitcoin = JsonConvert.DeserializeObject<BitCoin_rates>(data);
            }return bitcoin;

        }
    }
}
