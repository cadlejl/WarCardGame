using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WarCardGameChallenge
{
    public class Shuffle
    {
        public Random Random { get; set; }
        public Dictionary<int, string> ShuffledDeck { get; set; }

        public Shuffle()
        {
            Random = new Random();
            ShuffledDeck = new Dictionary<int, string>();
        }

        // Called by Game.GamePrep()
        // Pulls random cards from UnshuffledDeck and places them in ShuffledDeck
        public void ShuffleDeck(Dictionary<int, string> UnshuffledDeck)
        {
            while (UnshuffledDeck.Count > 0)
            {
                int nextRandomCardIndex = Random.Next(UnshuffledDeck.Count);
                KeyValuePair<int, string> nextIndex = UnshuffledDeck.ElementAt(nextRandomCardIndex);
                ShuffledDeck.Add(nextIndex.Key, nextIndex.Value);
                UnshuffledDeck.Remove(nextIndex.Key);
            }
        }
    }
}