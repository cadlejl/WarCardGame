using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

namespace WarCardGameChallenge
{
    public class ResultsDisplayBuilder
    {
        public DealDisplayString DealDisplayString { get; set; }
        public BattleDisplayString BattleDisplayString { get; set; }
        public StringBuilder DisplayString { get; set; }
        public string Player1 { get; set; }
        public string Player2 { get; set; }

        public ResultsDisplayBuilder()
        {
            DealDisplayString = new DealDisplayString();
            BattleDisplayString = new BattleDisplayString();
            DisplayString = new StringBuilder();
            Player1 = "Player 1";
            Player2 = "Player 2";
        }

        // Called by Game.Play()
        public void PhaseCaller(int key, Dealer deal)
        {
            DisplayString.Append(DealDisplayString.DisplayBuilder(deal, Player1, Player2));
            DisplayString.Append(BattleDisplayString.DisplayBuilder(deal, Player1, Player2));
            //switch (key)
            //{
            //    case 1: DisplayString.Append(DealDisplayString.DisplayBuilder(deal, Player1, Player2)); break;

            //    case 2: DisplayString.Append(BattleDisplayString.DisplayBuilder(deal, Player1, Player2)); break;
            //}
        }
    }
}