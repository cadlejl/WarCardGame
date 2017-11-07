using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WarCardGameChallenge
{
    public class Dealer
    {
        public Dictionary<int, string> Player1Hand { get; set; }
        public Dictionary<int, string> Player2Hand { get; set; }

        public Dealer()
        {
            Player1Hand = new Dictionary<int, string>();
            Player2Hand = new Dictionary<int, string>();
        }

        // Called by Game.Play()
        // Places each successive card at element 0 into a players hand, removing that card so the next one is then at element 0
        public void DealCards(Dictionary<int, string> deck)
        {
            while (deck.Count > 0)
            {
                Player1Hand.Add(deck.ElementAt(0).Key, deck.ElementAt(0).Value);
                deck.Remove(deck.ElementAt(0).Key);
                Player2Hand.Add(deck.ElementAt(0).Key, deck.ElementAt(0).Value);
                deck.Remove(deck.ElementAt(0).Key);
            }
        }
    }
}