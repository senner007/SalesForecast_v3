using System;
using SalesForecast_v3.Views;
using SalesForecast_v3.Models;
using System.Globalization;
using System.Reflection;
using System.Linq;

namespace SalesForecast_v3.Presenters
{
    public class SalesForecastPresenter
    {
        ISalesForecast salesForecastView;
        ISalesForecastEvents salesForecastEvents;
        public bool ValidationCheck { get; set; } = true;

        public SalesForecastPresenter(ISalesForecast view, ISalesForecastEvents viewEvents)
        {
            Console.WriteLine("Hello");
            salesForecastView = view;
            salesForecastEvents = viewEvents;
            salesForecastEvents.OnTextChange += ShowLabel;
            salesForecastEvents.OnCalculate += Calculate;
            salesForecastEvents.OnReset += Reset;

        }
        int Validate(string inputText)
        {

            int parsed = 0;
            if (Int32.TryParse(inputText, out parsed) && parsed >= 0 || inputText == "")
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
            return Int32.TryParse(input, out int parsed) && parsed >= 0 || input == "" ? "" : input + " is not valid input";
        }
        string ValidateDate(string date)
        {
            ValidationCheck = date == "" ? false : true;
            return date;
        }

        public void Calculate(object Sender, EventArgs e)
        {
            SalesForecast salesForecast = new SalesForecast();
            Console.WriteLine("Hello from calculate");

            salesForecast.Date = ValidateDate(salesForecastView.DateText);
            salesForecast.TicketsSold = Validate(salesForecastView.TicketsSoldText);
            salesForecast.TVCover = Validate(salesForecastView.TVCoverText);
            salesForecast.SportsVisitors = Validate(salesForecastView.SportsVisitorsText);
            salesForecast.FitnessSubscribers = Validate(salesForecastView.FitnessSubscribersText);
            salesForecast.VisitorsAppear = Validate(salesForecastView.VisitorsAppearText);

          
            

            salesForecastView.TotalSalesText = ValidationCheck ? 
                salesForecast.CalculateSales().ToString("C2", CultureInfo.CreateSpecificCulture("da-DK")) : "";
            salesForecastView.TotalExpensesText = ValidationCheck ? 
                salesForecast.CalculateExpenses().ToString("C2", CultureInfo.CreateSpecificCulture("da-DK")) : "";
            salesForecastView.TotalEarningsText = ValidationCheck ? 
                salesForecast.CalculateEarnings().ToString("C2", CultureInfo.CreateSpecificCulture("da-DK")) : "";

        }
        public void Reset(object Sender, EventArgs e)
        {
            Console.WriteLine("Hello from reset");
            salesForecastView.GetType().GetProperties().Where(st => st.PropertyType == typeof(string)).ToList().ForEach(x => Console.WriteLine(x));

            string s = "";
            salesForecastView.TicketsSoldText = s;
            salesForecastView.TVCoverText = s;
            salesForecastView.SportsVisitorsText = s;
            salesForecastView.FitnessSubscribersText = s;
            salesForecastView.VisitorsAppearText = s;
            salesForecastView.DateText = s;
            salesForecastView.TotalSalesText = s;
            salesForecastView.TotalExpensesText = s;
            salesForecastView.TotalEarningsText = s;



        }
        public void ShowLabel(object Sender, EventArgs e)
        {
            Console.WriteLine("Hello from showlabel");

            salesForecastView.error_TicketsSoldText = DetermineLabel(salesForecastView.TicketsSoldText);
            salesForecastView.error_TVCoverText = DetermineLabel(salesForecastView.TVCoverText);
            salesForecastView.error_SportsVisitorsText = DetermineLabel(salesForecastView.SportsVisitorsText);
            salesForecastView.error_FitnessSubscribersText = DetermineLabel(salesForecastView.FitnessSubscribersText);
            salesForecastView.error_VisitorsAppearText = DetermineLabel(salesForecastView.VisitorsAppearText);

        }
    }
}
