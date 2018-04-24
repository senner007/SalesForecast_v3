using System;
using System.Windows.Forms;
using SalesForecast_v3.Views;
using SalesForecast_v3.Presenters;
using System.Runtime.InteropServices;

namespace SalesForecast_v3
{
    public partial class Form1 : Form, ISalesForecast, ISalesForecastEvents
    {
        public Form1()
        {
            InitializeComponent();
            AllocConsole();
            presenter = new SalesForecastPresenter(this, this);
        }

        public event EventHandler<EventArgs> OnTextChange;
        public event EventHandler<EventArgs> OnCalculate;
        public event EventHandler<EventArgs> OnReset;
        SalesForecastPresenter presenter;


        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();       

        public string TicketsSoldText { get => txtTicketsSold.Text; set => txtTicketsSold.Text = value; }       
        public string TVCoverText { get => txtTVCover.Text; set => txtTVCover.Text = value; }
        public string SportsVisitorsText { get => txtSportsVisitors.Text; set => txtSportsVisitors.Text = value; }
        public string FitnessSubscribersText { get => txtFitnessSubscribers.Text; set => txtFitnessSubscribers.Text = value; }
        public string VisitorsAppearText { get => txtVisitorsAppear.Text; set => txtVisitorsAppear.Text = value; }

        public string error_TicketsSoldText { set => error_TicketsSold.Text = value; }
        public string error_TVCoverText {  set => error_TVCover.Text = value; }
        public string error_SportsVisitorsText {  set => error_SportsVisitors.Text = value; }
        public string error_FitnessSubscribersText { set => error_FitnessSubscribers.Text = value; }
        public string error_VisitorsAppearText {set => error_VisitorsAppear.Text = value; }

        public string TotalSalesText { get => TotalSalesLabel.Text; set => TotalSalesLabel.Text = value;  }
        public string TotalExpensesText { get => TotalExpensesLabel.Text; set => TotalExpensesLabel.Text = value; }
        public string TotalEarningsText { get => TotalEarningsLabel.Text; set => TotalEarningsLabel.Text = value; }

        public string DateText { get => txtDate.Text; set => txtDate.Text = value; }

        private void beregn_Click(object sender, EventArgs e)
        {
            OnCalculate.Invoke(this, EventArgs.Empty);
            afslutOgBeregn.Enabled = presenter.ValidationCheck;
        }

        private void reset_Click(object sender, EventArgs e) 
        {        
            OnReset.Invoke(this, EventArgs.Empty);
        }

        private void onTextChange_TextChanged(object sender, EventArgs e)
        {
           
            OnTextChange.Invoke(this, EventArgs.Empty);       
            afslutOgBeregn.Enabled = false;   
        }

        private void afslutOgBeregn_Click(object sender, EventArgs e)
        {
            
            OnCalculate.Invoke(this, EventArgs.Empty);
            afslutOgBeregn.Enabled = false;

            dataGridView1.Rows.Add(
              DateText, TicketsSoldText, TVCoverText, SportsVisitorsText,
                      FitnessSubscribersText, VisitorsAppearText, TotalSalesText, TotalExpensesText, TotalEarningsText);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            txtDate.Text = Convert.ToDateTime(dateTimePicker1.Value).ToShortDateString();
            beregn.Enabled = true;
            DateLabel.Visible = false;
        }
    }
}
