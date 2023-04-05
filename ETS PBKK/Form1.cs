using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;

namespace ETS_PBKK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String CurrencyJSON = "{IDR_IDR: 1,IDR_USD: 6.8620757e-05,IDR_EUR: 5.8495421e-05,IDR_JPY: 0.007595,IDR_CAD: 8.6489945e-05,IDR_GBP: 4.9835482e-05,USD_IDR: 14572.85,USD_USD: 1,USD_EUR: 0.852275,USD_JPY: 110.652051,USD_CAD: 1.260325,USD_GBP: 0.726295,EUR_IDR: 17095.120506,EUR_USD: 1.173096,EUR_EUR: 1,EUR_JPY: 129.823011,EUR_CAD: 1.478512,EUR_GBP: 0.851768,JPY_IDR: 131.672467,JPY_USD: 0.009035,JPY_EUR: 0.007702,JPY_JPY: 1,JPY_CAD: 0.011388,JPY_GBP: 0.006562,CAD_IDR: 11562.642568,CAD_USD: 0.793421,CAD_EUR: 0.676348,CAD_JPY: 87.80707,CAD_CAD: 1,CAD_GBP: 0.576139,GBP_IDR: 20070.170848,GBP_USD: 1.377249,GBP_EUR: 1.174029,GBP_JPY: 152.416008,GBP_CAD: 1.735816,GBP_GBP: 1}";
            var CurrencyObject = JObject.Parse(CurrencyJSON);

            textBox2.Text = (Double.Parse(CurrencyObject[$"{comboBox1.Text}_{comboBox2.Text}"].ToString()) * Double.Parse(textBox1.Text)).ToString();
            if (CurrencyObject[$"{comboBox1.Text}_{comboBox2.Text}"] == null)
            {
                MessageBox.Show("Currency not found!");
                return;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
