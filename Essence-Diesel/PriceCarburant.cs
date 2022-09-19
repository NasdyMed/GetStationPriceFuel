using Essence_Diesel.Entity;
using Essence_Diesel.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Essence_Diesel
{
    public partial class PriceCarburant : Form
    {

        public Database database;
        public ApiFuels apiFuels;
        public PriceCarburant()
        {
            InitializeComponent();
            database = new Database();
            apiFuels = new ApiFuels();
        }

        private void PriceCarburant_Load(object sender, EventArgs e)
        {
            database.Fuels = new BindingList<Fuel>();
            apiFuels.setDataFuels(database.Fuels);
            dtgFuels.DataSource = database.Fuels;
        }

        private void RefreshData(object sender, EventArgs e)
        {
            dtgFuels.DataSource = null;
            database.Fuels = new BindingList<Fuel>();
            apiFuels.setDataFuels(database.Fuels);
            dtgFuels.DataSource = database.Fuels;

        }
    }
}
