using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        string error_TicketsSoldText { get; set; }
        string error_TVCoverText { get; set; }
        string error_SportsVisitorsText { get; set; }
        string error_FitnessSubscribersText { get; set; }
        string error_VisitorsAppearText { get; set; }
    }
}
