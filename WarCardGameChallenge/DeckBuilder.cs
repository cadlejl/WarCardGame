using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WarCardGameChallenge
{
    public class DeckBuilder
    {
        // A problem arose with the card deck when it came to scoring, as I need a way to differentiate suits,
        // but the deck only had keys numbered 0 - 51.  This possible solution was researched at 
        // https://www.codeproject.com/articles/30729/indexed-dictionary and at 
        // https://www.codeproject.com/answers/198455/dictionary-with-index#answer5. 
        // I'm unsure how it would be implemented. But as it is currently, the code still runs.
        public class IndexedDictionary<key, value> : Dictionary<key, value> { }
        //IndexedDictionary<string, int> dic = new IndexedDictionary<string, int>();

        public List<string> Suits { get; set; }
        public List<string> Values { get; set; }
        public Dictionary<int, string> Clubs { get; set; }
        public Dictionary<int, string> Spades { get; set; }
        public Dictionary<int, string> Hearts { get; set; }
        public Dictionary<int, string> Diamonds { get; set; }
        // public Dictionary<int, string> FullSuits { get; set; }

        // public IndexedDictionary<int, string> UnshuffledDeck { get; set; }
        public IndexedDictionary<string, string> UnshuffledDeck { get; set; }

        public DeckBuilder()
        {
            Suits = new List<string> { "Clubs", "Spades", "Hearts", "Diamonds" };
            Values = new List<string> { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };
            Clubs = new Dictionary<int, string>();
            Spades = new Dictionary<int, string>();
            Hearts = new Dictionary<int, string>();
            Diamonds = new Dictionary<int, string>();

            // UnshuffledDeck = new IndexedDictionary<int, string>();
            UnshuffledDeck = new IndexedDictionary<string, string>();
        }

        // Was this an attempt to solve a problem with BuildDeck()?
        public void BuildSuits()
        {
            // This loop was built as part of a possible solution to the scoring problem.
            // May be obviated by IndexedDictionary.
            //foreach (var value in Values)
            //{
            //    // Each suit keyed 0 - 12
            //    int key = 0;
            //    Clubs.Add(key, value + " of Clubs");
            //    Spades.Add(key, value + " of Spades");
            //    Hearts.Add(key, value + " of Hearts");
            //    Diamonds.Add(key, value + " of Diamonds");
            //}
        }

        // Called by Game.GamePrep()
        public void BuildDeck()
        {
            //string key = ;
            foreach (var suit in Suits)
            {
                foreach (var value in Values)
                {
                    UnshuffledDeck.Add(suit, value + " of " + suit); // I'm thinking this may turn into a problem later
                    //key++;
                }
            }
        }
    }
}