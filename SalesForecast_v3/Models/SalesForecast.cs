using System;
using System.Linq;

namespace SalesForecast_v3.Models
{
    delegate decimal Calculate(params decimal[] vals);
    public class SalesForecast
    {
        public int TicketsSold { get; set; }
        public int TVCover { get; set; }
        public int SportsVisitors { get; set; }
        public int FitnessSubscribers { get; set; }
        public int VisitorsAppear { get; set; }

        public string Date { get; set; }

        public decimal CalculateSales()
        {
            return SumUp(
              Mult(Constants.BILLET_PRIS_GENNEMSNIT, TicketsSold),
              Mult(Constants.TV_RETTIGHEDER_PR_KANAL, TVCover),
              Mult(SportsVisitors, Constants.SALG_SPORTS_VARE_GENNEMSNIT, Constants.SALG_FRA_BUTIK_BESOEG_PCT),
              Mult(Constants.ABONNEMENT_PRIS_6_MAANEDER, FitnessSubscribers),
              Mult(Constants.SALG_DRIKKEVARE_GENNEMSNIT, TicketsSold, (Convert.ToDecimal(VisitorsAppear) / 100))
            );
        }
        public decimal CalculateExpenses()
        {
            return CalculateSales() * Constants.TOTAL_OMK_I_PCT;

        }
        public decimal CalculateEarnings()
        {
            return  CalculateSales() - CalculateExpenses();
        }

        Calculate Mult = vals => vals.Aggregate((a, b) => a * b);
        Calculate SumUp = vals => vals.Sum();
    }
    public static class Constants
    {
        public const decimal SALG_FRA_BUTIK_BESOEG_PCT = 0.2M; // 20 %
        public const uint BILLET_PRIS_GENNEMSNIT = 175; // 175 kr
        public const uint SALG_DRIKKEVARE_GENNEMSNIT = 70; // 70 kr
        public const uint SALG_SPORTS_VARE_GENNEMSNIT = 245; // 245kr
        public const uint ABONNEMENT_PRIS_6_MAANEDER = 999; // 999kr
        public const uint TV_RETTIGHEDER_PR_KANAL = 1000000; // 1 mill kr
        public const decimal TOTAL_OMK_I_PCT = 0.64M; // 64 %    
    }
}
