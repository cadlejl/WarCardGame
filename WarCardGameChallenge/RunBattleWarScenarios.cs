using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WarCardGameChallenge
{
    public class RunBattleWarScenarios
    {
        public Dealer Dealer { get; set; }
        public Dictionary<int, string> Player1Hand { get; set; }
        public Dictionary<int, string> Player2Hand { get; set; }

        public RunBattleWarScenarios()
        {
            Dealer = new Dealer();
            Player1Hand = Dealer.Player1Hand;
            Player2Hand = Dealer.Player2Hand;
        }

    }
}