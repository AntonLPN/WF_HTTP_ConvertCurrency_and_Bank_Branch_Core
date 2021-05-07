using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_BankBranch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void buttonStart_Click(object sender, EventArgs e)
        {

            
            using (HttpClient client = new HttpClient())



            using (HttpRequestMessage message = new HttpRequestMessage())
            {
                message.Method = HttpMethod.Get;
                message.RequestUri = new Uri("https://api.privatbank.ua/p24api/pboffice?json&city=%D0%94%D0%BD%D0%B5%D0%BF%D1%80%D0%BE%D0%BF%D0%B5%D1%82%D1%80%D0%BE%D0%B2%D1%81%D0%BA&address");
                HttpResponseMessage resp = await client.SendAsync(message);
               

                string body = await resp.Content.ReadAsStringAsync();


                List<Bank__branches> Currensy = JsonSerializer.Deserialize<List<Bank__branches>>(body);

                foreach (var item in Currensy)
                {
                    textBox1.AppendText($"{item.City}  {item.Address}  {item.Name}" + Environment.NewLine);
                }

            }


        }
    }
}
