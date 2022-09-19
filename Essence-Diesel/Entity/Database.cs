using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essence_Diesel.Entity
{
    public class Database
    {
        public BindingList<Fuel> Fuels { get; set; }

        public Database()
        {
            Fuels = new BindingList<Fuel>();
        }
    }
}
