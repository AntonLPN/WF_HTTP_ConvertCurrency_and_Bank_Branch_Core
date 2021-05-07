using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Text.Json;
namespace WF_HTTP_ConvertCurrency
{
    public class CurrencyItem
    {
        [JsonPropertyName("ccy")]
        public string Ccy { get; set; }//USD RUB UAH

        [JsonPropertyName("base_ccy")]
        public string BaseCcy { get; set; }//UAH

        [JsonPropertyName("buy")]
        public string Buy { get; set; }

        [JsonPropertyName("sale")]
        public string Sale { get; set; }

        public string Description => $" {Ccy}={Sale} {BaseCcy}";
    }
}
