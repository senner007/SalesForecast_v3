using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SalesForecast_v3.Views;
using SalesForecast_v3.Presenters;

namespace SalesForecast_v3
{
    public partial class Form1 : Form, ISalesForecast
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        public string TicketsSoldText { get => txtTicketsSold.Text; set => txtTicketsSold.Text = value; }
        public string TVCoverText { get => txtTVCover.Text; set => txtTVCover.Text = value; }
        public string SportsVisitorsText { get => txtSportsVisitors.Text; set => txtSportsVisitors.Text = value; }
        public string FitnessSubscribersText { get => txtFitnessSubscribers.Text; set => txtFitnessSubscribers.Text = value; }
        public string VisitorsAppearText { get => txtVisitorsAppear.Text; set => txtVisitorsAppear.Text = value; }
        public string TotalSalesText { get => TotalSalesLabel.Text; set => TotalSalesLabel.Text = value;  }
        public string TotalExpensesText { get => TotalExpensesLabel.Text; set => TotalExpensesLabel.Text = value; }
        public string TotalEarningsText { get => TotalEarningsLabel.Text; set => TotalEarningsLabel.Text = value; }

        private void button1_Click(object sender, EventArgs e)
        {
            SalesForecastPresenter presenter = new SalesForecastPresenter(this);
            presenter.CalculateSales();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Controls.OfType<TextBox>().ToList().ForEach(t => t.Text = "");
            this.Controls.OfType<Label>().Where(l => l.Name.ToString().StartsWith("_error")).ToList().ForEach(l => l.Visible = false);
        }
    }
}
