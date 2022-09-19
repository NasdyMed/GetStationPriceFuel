using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essence_Diesel.Entity
{
    public class Fuel
    {
        [Browsable(false)]
        public string Id { get; set; }


        [DisplayName("Nom de la station")]
        public string StationName { get; set; }


        [DisplayName("Prix diesel (Dh)")]
        public string PriceDiesel { get; set; }

        [DisplayName("Prix essence (Dh)")]
        public string PriceEssence { get; set; }


    }
}
