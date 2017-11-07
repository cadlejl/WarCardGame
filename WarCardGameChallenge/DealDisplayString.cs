using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

namespace WarCardGameChallenge
{
    public class DealDisplayString
    {
        public StringBuilder DisplayDealString { get; set; }

        public DealDisplayString()
        {
            DisplayDealString = new StringBuilder();
        }

        // Called by ResultsDisplayBuilder.PhaseCaller()
        public StringBuilder DisplayBuilder(Dealer Deal, string player1, string player2)
        {
            DisplayDealString.Append("<h2 style='font-weight: bold'>Dealing cards ...</h2><br/><br/>");
            for (int i = 0; i < Deal.Player2Hand.Count; i++)
            {
                DisplayDealString.Append(String.Format("{0} is dealt the {1}<br/>{2} is dealt the {3}<br/>",
                    player1, Deal.Player1Hand.ElementAt(i).Value,
                    player2, Deal.Player2Hand.ElementAt(i).Value));
            }
            return DisplayDealString;
        }
    }
}