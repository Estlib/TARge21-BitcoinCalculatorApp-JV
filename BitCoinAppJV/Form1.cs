using System;
using Newtonsoft.Json;
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

namespace BitCoinAppJV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetRates_Click(object sender, EventArgs e)
        {
            CheckUserInput();
            if (currencyselectionBox.SelectedItem.ToString() == "EUR")
            {
                MakeVisible();
                BitCoinRates bitcoin = ArvutaVäärtus();
                float result = Int32.Parse(bitcoinamountbox.Text) * bitcoin.bpi.EUR.rate_float;
                conversionresultbox.Text = $"{result.ToString()} {bitcoin.bpi.EUR.code}";
            }
            //if (currencyselectionBox.SelectedItem.ToString() == "EEK")
            //{
            //    MakeVisible();
            //    BitCoinRates bitcoin = ArvutaVäärtus();
            //    float result = (Int32.Parse(bitcoinamountbox.Text) * bitcoin.bpi.EUR.rate_float);
            //    float eekrate = double.Parse(result) * double.Parse(15.6466);
            //    conversionresultbox.Text = $"{eekrate.ToString()} EEK";
            //}
            // i tried :T
            if (currencyselectionBox.SelectedItem.ToString() == "GBP")
            {
                MakeVisible();
                BitCoinRates bitcoin = ArvutaVäärtus();
                float result = Int32.Parse(bitcoinamountbox.Text) * bitcoin.bpi.GBP.rate_float;
                conversionresultbox.Text = $"{result.ToString()} {bitcoin.bpi.GBP.code}";
            }
            if (currencyselectionBox.SelectedItem.ToString() == "USD")
            {
                MakeVisible();
                BitCoinRates bitcoin = ArvutaVäärtus();
                float result = Int32.Parse(bitcoinamountbox.Text) * bitcoin.bpi.USD.rate_float;
                conversionresultbox.Text = $"{result.ToString()} {bitcoin.bpi.USD.code}";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public static BitCoinRates ArvutaVäärtus()
        {
            string url = "https://api.coindesk.com/v1/bpi/currentprice.json";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";

            var webResponse = request.GetResponse();
            var webStream = webResponse.GetResponseStream();

            BitCoinRates bitcoin;
            using (var responseReader = new StreamReader(webStream))
            {
                var response = responseReader.ReadToEnd();
                bitcoin = JsonConvert.DeserializeObject<BitCoinRates>(response);
            }
            return bitcoin;
        }
        public void MakeVisible()
        {
            conversionlabel.Visible = true;
            conversionresultbox.Visible = true;
        }
        public void CheckUserInput()
        {
            if (currencyselectionBox.SelectedItem.ToString() == "")
            {

            }
        }
    }
}
