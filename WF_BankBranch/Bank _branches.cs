using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Text.Json;
namespace WF_BankBranch
{

     //"name":"Южное отд., Отделение №30",
     //               "state":"Днепропетровская",
     //               "id":"2943",
     //               "country":"Украина",
     //               "city":"Днепропетровск",
     //               "index":"49000",
     //               "phone":"8(056)373-33-54, 373-33-56",
     //               "email":"julija.tverdokhlebova@pbank.com.ua",
     //               "address":"ул Титова 29-М"




   public class Bank__branches
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }//номер отделения

        [JsonPropertyName("state")]
        public string State { get; set; }//область

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("country")]
        public string Country { get; set; }

        [JsonPropertyName("city")]
        public string City { get; set; }

        [JsonPropertyName("index")]
        public string Index { get; set; }

        [JsonPropertyName("phone")]
        public string Phone { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("address")]
        public string Address { get; set; }

        public string Info => $"{City} {Address}  {Name}";


         //   public string Description => $" {Ccy}={Sale} {BaseCcy}";


    }
}
