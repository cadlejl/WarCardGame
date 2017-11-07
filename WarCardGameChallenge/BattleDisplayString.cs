using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace WarCardGameChallenge
{
    public class BattleDisplayString
    {
        public StringBuilder DisplayBattleString { get; set; }

        public BattleDisplayString()
        {
            DisplayBattleString = new StringBuilder();
        }

        // Called by ResultsDisplayBuilder.PhaseCaller()
        public StringBuilder DisplayBuilder(Dealer Deal, string player1, string player2)
        {
            DisplayBattleString.Append("<h2 style='font-weight: bold'>Begin battle ...</h2><br/><br/>");
            for (int i = 0; i < Deal.Player2Hand.Count; i++)
            {
                //string winner = RunBattleWarScenarios.someMethod(); 
                DisplayBattleString.Append
                    (String.Format
                    ("Battle Cards: {0} versus {1}<br/>Bounty ...<br/>&nbsp;&nbsp;{0}<br/>&nbsp;&nbsp;{1}<br/><br/>",
                    Deal.Player1Hand.ElementAt(i).Value,
                    Deal.Player2Hand.ElementAt(i).Value));

            }
            return DisplayBattleString;


            //("Battle Cards: {0} versus {1}<br/>Bounty ...<br/>&nbsp;&nbsp;{0}<br/>&nbsp;&nbsp;{1}<br/><!--strong>{2} wins!!</strong><br/><br/-->",
            //        Deal.Player1Hand.ElementAt(i).Value,
            //        Deal.Player2Hand.ElementAt(i).Value/*,
            //        winner*/));
        }
    }
}