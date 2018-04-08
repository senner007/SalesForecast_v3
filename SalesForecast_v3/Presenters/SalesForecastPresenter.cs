using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesForecast_v3.Views;
using SalesForecast_v3.Models;

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
        public void CalculateSales()
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
    }
}
