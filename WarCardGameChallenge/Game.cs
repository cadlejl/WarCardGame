using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WarCardGameChallenge
{
    /*** Main Game Controller ***/
    public class Game
    {
        // Represent Secondary Classes
        public DeckBuilder DeckBuilder { get; set; }
        public Shuffle Shuffle { get; set; }
        public Dealer Deal { get; set; }
        public ResultsDisplayBuilder ResultsDisplayBuilder { get; set; }
        public RunBattleWarScenarios BattleWarScenarios { get; set; }

        // Represent the deck after it's built to send off for shuffling, then represent it after it's shuffled
        public Dictionary<int, string> UnshuffledDeck { get; set; }
        public Dictionary<int, string> ShuffledDeck { get; set; }

        public Game()
        {
            // Instantiate game classes
            DeckBuilder = new DeckBuilder();
            Shuffle = new Shuffle();
            Deal = new Dealer();
            ResultsDisplayBuilder = new ResultsDisplayBuilder();
            BattleWarScenarios = new RunBattleWarScenarios();

            // Instantiate empty decks
            UnshuffledDeck = new Dictionary<int, string>();
            ShuffledDeck = new Dictionary<int, string>();
        }

        // Called by Default.PlayButton_Click server control.
        // Prepere the deck for a game.
        // Send the shuffled deck out for dealing.
        // Return this instance of the Deal class to the caller for displaying hands.
        public string Play()
        {
            GamePrep();
            Deal.DealCards(ShuffledDeck);

            ResultsDisplayBuilder.PhaseCaller(1, Deal);


            return ResultsDisplayBuilder.DisplayString.ToString();
        }

        // Called by Play()
        // Fill the deck with cards in order, identified by keys. Retrieve the orderd deck.
        // Send the ordered deck out for shuffling. Retrieve the shuffled deck.
        private void GamePrep()
        {
            DeckBuilder.BuildDeck();
            UnshuffledDeck = DeckBuilder.UnshuffledDeck;

            Shuffle.ShuffleDeck(UnshuffledDeck);
            ShuffledDeck = Shuffle.ShuffledDeck;
        }

    }
}