using Essence_Diesel.Entity;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Essence_Diesel.Helpers
{
    public class ApiFuels
    {
        public HttpClient client;


        public ApiFuels()
        {
            client = new HttpClient();
        }
        public void setDataFuels(BindingList<Fuel> fuels)
        {
            var responseVille = client.GetAsync("https://total.smarteez.eu/submit/?ville=Casablanca");
            responseVille.Wait();

            var resultVille = responseVille.Result;

            if (resultVille.IsSuccessStatusCode)
            {
                var readResultVille = resultVille.Content.ReadAsStringAsync();
                readResultVille.Wait();

                var resu = JObject.Parse(readResultVille.Result).GetValue("stations");

                for (int i = 0; i < resu.Count(); ++i)
                {
                    var fuel = new Fuel();
                    fuel.Id = resu[i]["id_station"].ToString();
                    fuel.StationName = resu[i]["station"].ToString();

                    var responsePriceFuel = client.GetAsync("https://total.smarteez.eu/submit/?station=" + fuel.Id);
                    responsePriceFuel.Wait();

                    var resultFuel = responsePriceFuel.Result;

                    if (resultFuel.IsSuccessStatusCode)
                    {
                        var readResultFuel = resultFuel.Content.ReadAsStringAsync();
                        readResultFuel.Wait();

                        var resuFuel = JObject.Parse(readResultFuel.Result).GetValue("prix");

                        


                        fuel.PriceDiesel = (resuFuel.Count() != 0)? resuFuel["prix_diesel"].ToString():"---";
                        fuel.PriceEssence = (resuFuel.Count() != 0) ? resuFuel["prix_essence"].ToString() : "---";


                    }

                    fuels.Add(fuel);
                }
            }
        }
    }
}
