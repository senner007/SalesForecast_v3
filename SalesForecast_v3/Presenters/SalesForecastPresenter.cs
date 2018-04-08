using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesForecast_v3.Views;
using SalesForecast_v3.Models;
using System.Reflection;

namespace SalesForecast_v3.Presenters
{
    public class SalesForecastPresenter
    {
        ISalesForecast salesForecastView;
        public bool ValidationCheck { get; set; } = true;

        public SalesForecastPresenter(ISalesForecast view)
        {
            salesForecastView = view;

        }
        int Validate(string inputText)
        {

            int parsed = 0;
            if (Int32.TryParse(inputText, out parsed) && parsed > -1 || inputText == "")
            {
                return parsed;
            }
            else
            {
                ValidationCheck = false;              
                return parsed;
            }
        }
        string DetermineLabel (string input) 
        {
            return Int32.TryParse(input, out int parsed) && parsed > -1 || input == "" ? "" : input + " is not valid input";
        }

        public void Calculate()
        {
            SalesForecast salesForecast = new SalesForecast();

            salesForecast.TicketsSold = Validate(salesForecastView.TicketsSoldText);
            salesForecast.TVCover = Validate(salesForecastView.TVCoverText);
            salesForecast.SportsVisitors = Validate(salesForecastView.SportsVisitorsText);
            salesForecast.FitnessSubscribers = Validate(salesForecastView.FitnessSubscribersText);
            salesForecast.VisitorsAppear = Validate(salesForecastView.VisitorsAppearText);

            salesForecastView.TotalSalesText = ValidationCheck ? "Total Sales: " + salesForecast.CalculateSales().ToString() : "";
            salesForecastView.TotalExpensesText = ValidationCheck ? "Total Expenses: " + salesForecast.CalculateExpenses().ToString() : "";
            salesForecastView.TotalEarningsText = ValidationCheck ? "Total Earnings " + salesForecast.CalculateEarnings().ToString() : "";

        }
        public void Reset(string s = "")
        {     
            salesForecastView.TicketsSoldText = s;
            salesForecastView.TVCoverText = s;
            salesForecastView.SportsVisitorsText = s;
            salesForecastView.FitnessSubscribersText = s;
            salesForecastView.VisitorsAppearText = s;
        }
        public void ShowLabel()
        {
            salesForecastView.error_TicketsSoldText = DetermineLabel(salesForecastView.TicketsSoldText);
            salesForecastView.error_TVCoverText = DetermineLabel(salesForecastView.TVCoverText);
            salesForecastView.error_SportsVisitorsText = DetermineLabel(salesForecastView.SportsVisitorsText);
            salesForecastView.error_FitnessSubscribersText = DetermineLabel(salesForecastView.FitnessSubscribersText);
            salesForecastView.error_VisitorsAppearText = DetermineLabel(salesForecastView.VisitorsAppearText);
        }
    }
}
