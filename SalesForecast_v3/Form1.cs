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
using System.Runtime.InteropServices;

namespace SalesForecast_v3
{
    public partial class Form1 : Form, ISalesForecast
    {
        public Form1()
        {
            InitializeComponent();
            AllocConsole();
        }
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        public string TicketsSoldText { get => txtTicketsSold.Text; set => txtTicketsSold.Text = value; }
        public string TVCoverText { get => txtTVCover.Text; set => txtTVCover.Text = value; }
        public string SportsVisitorsText { get => txtSportsVisitors.Text; set => txtSportsVisitors.Text = value; }
        public string FitnessSubscribersText { get => txtFitnessSubscribers.Text; set => txtFitnessSubscribers.Text = value; }
        public string VisitorsAppearText { get => txtVisitorsAppear.Text; set => txtVisitorsAppear.Text = value; }

        public string error_TicketsSoldText { get => error_TicketsSold.Text; set => error_TicketsSold.Text = value; }
        public string error_TVCoverText { get => error_TVCover.Text; set => error_TVCover.Text = value; }
        public string error_SportsVisitorsText { get => error_SportsVisitors.Text; set => error_SportsVisitors.Text = value; }
        public string error_FitnessSubscribersText { get => error_FitnessSubscribers.Text; set => error_FitnessSubscribers.Text = value; }
        public string error_VisitorsAppearText { get => error_VisitorsAppear.Text; set => error_VisitorsAppear.Text = value; }

        public string TotalSalesText { get => TotalSalesLabel.Text; set => TotalSalesLabel.Text = value;  }
        public string TotalExpensesText { get => TotalExpensesLabel.Text; set => TotalExpensesLabel.Text = value; }
        public string TotalEarningsText { get => TotalEarningsLabel.Text; set => TotalEarningsLabel.Text = value; }

        private void button1_Click(object sender, EventArgs e)
        {
            SalesForecastPresenter presenter = new SalesForecastPresenter(this);
            presenter.Calculate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SalesForecastPresenter presenter = new SalesForecastPresenter(this);
            presenter.Reset();
            
        }

        private void onTextChange_TextChanged(object sender, EventArgs e)
        {
            SalesForecastPresenter presenter = new SalesForecastPresenter(this);
            presenter.ShowLabel();

           // this.Controls.OfType<Label>().Where(l => l.Name.ToString() == "error_" + ((TextBox)sender).Name).ToList().ForEach(l => l.Visible = false);
      
        }
    }
}
