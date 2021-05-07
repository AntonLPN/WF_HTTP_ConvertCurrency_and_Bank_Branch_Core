using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json.Serialization;
using System.Text.Json;


//Задание №1
//Разработать Windows Forms приложение-конвертер валют. Курс брать с 
//официального сайта НБУ по адресу
//https://bank.gov.ua/NBUStatService/v1/statdirectory/exchange?json.

namespace WF_HTTP_ConvertCurrency
{
    public partial class Form1 : Form
    {

        double valueUAH;
        public Form1()
        {
            InitializeComponent();
            valueUAH = 0;
        }

     
        /// <summary>
        /// Метод обмена гривны в другую валюту
        /// </summary>
        private void ChangeUAH()
        {

            try
            {
                valueUAH = Convert.ToDouble(textBoxSumSale.Text);
              //Доллары
                string USDParse = textBoxUSD1.Text.Replace(".",",");  //так как из запроса в текст бокс приходит тоска в место запятой для значения дабл
                double USD=Convert.ToDouble(USDParse);
                double resUSD = valueUAH / USD;

                textBoxSaleUSD.Text = resUSD.ToString();


                //Евро
                string EURParse = textBoxEUR1.Text.Replace(".", ",");  //так как из запроса в текст бокс приходит тоска в место запятой для значения дабл
                double EUR = Convert.ToDouble(EURParse);
                double resEUR = valueUAH / EUR;

                textBoxEURSale.Text = resEUR.ToString();

                //Рубли
                string RURParse = textBoxRUR1.Text.Replace(".", ",");  //так как из запроса в текст бокс приходит тоска в место запятой для значения дабл
                double RUR = Convert.ToDouble(RURParse);
                double resRUR = valueUAH / RUR;

                textBoxRURSale.Text = resRUR.ToString();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
         
        }

        private async void buttonStart_Click(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())



            using (HttpRequestMessage message = new HttpRequestMessage())
            {
                message.Method = HttpMethod.Get;
                message.RequestUri = new Uri("https://api.privatbank.ua/p24api/pubinfo?json&exchange&coursid=5");
                HttpResponseMessage resp = await client.SendAsync(message);
               

                string body = await resp.Content.ReadAsStringAsync();
                textBoxValues.Text = body;

               

            }
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())



            using (HttpRequestMessage message = new HttpRequestMessage())
            {
                message.Method = HttpMethod.Get;
                message.RequestUri = new Uri("https://api.privatbank.ua/p24api/pubinfo?json&exchange&coursid=5");
                HttpResponseMessage resp = await client.SendAsync(message);
              
                string body = await resp.Content.ReadAsStringAsync();


                List<CurrencyItem> Currensy = JsonSerializer.Deserialize<List<CurrencyItem>>(body);

                foreach (var item in Currensy)
                {
                    if (item.Ccy=="USD")
                    {
                        textBoxUSD1.Text = item.Sale;
                    }
                    if (item.Ccy == "EUR")
                    {
                       textBoxEUR1.Text = item.Sale;
                    }
                    if (item.Ccy == "RUR")
                    {
                        textBoxRUR1.Text = item.Sale;
                    }
                }

            }
        }


        //запрет ввода букв
        private void textBoxSumSale_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) ||
           (!string.IsNullOrEmpty(textBoxSumSale.Text) && e.KeyChar == ',' || e.KeyChar == (char)Keys.Back))
            {
                return;
            }

            e.Handled = true;
        }

        private void buttonSaleUAH_Click(object sender, EventArgs e)
        {
            ChangeUAH();
        }
    }
    
}
