using System;

namespace SalesForecast_v3.Views
{
    public interface ISalesForecast
    {
        string TicketsSoldText { get; set; }
        string TVCoverText { get; set; }
        string SportsVisitorsText { get; set; }
        string FitnessSubscribersText { get; set; }
        string VisitorsAppearText { get; set; }

        string TotalSalesText { get; set; }
        string TotalExpensesText { get; set; }
        string TotalEarningsText { get; set; }

        string error_TicketsSoldText { set; }
        string error_TVCoverText { set; }
        string error_SportsVisitorsText { set; }
        string error_FitnessSubscribersText { set; }
        string error_VisitorsAppearText { set; }

        string DateText { get; set; }


    }
    public interface ISalesForecastEvents
    {
        event EventHandler<EventArgs> OnTextChange;
        event EventHandler<EventArgs> OnCalculate;
        event EventHandler<EventArgs> OnReset;
    }
}
