using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DevSkill.BitCoinDemo.Library
{
    public class BitCoinServiceBroker
    {
        private const string _apiUrl = "http://api.coindesk.com/v1/bpi/currentprice.json";

        public BitCoinPrice GetBitCoinPrices()
        {
            BitCoinPrice price = null;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(_apiUrl);
            request.Timeout = 100000;
            request.Method = "GET";
            request.ContentType = "application/json";

            try
            {
                using (var res = (HttpWebResponse)request.GetResponse())
                {
                    using (var stream = res.GetResponseStream())
                    {
                        var reader = new StreamReader(stream);
                        var response = reader.ReadToEnd();
                        price = JsonConvert.DeserializeObject<BitCoinPrice>(response);
                    }
                }
                return price;
            }
            catch
            {
                return null;
            }
        }
    }
}
