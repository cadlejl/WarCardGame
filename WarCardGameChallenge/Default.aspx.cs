using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

namespace WarCardGameChallenge
{
    public partial class Default : System.Web.UI.Page
    {
        public Game Game { get; set; }
        //public ResultsDisplayBuilder Results { get; set; }

        public Default()
        {
            Game = new Game();
            //Results = new ResultsDisplayBuilder();
    }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void PlayButton_Click(object sender, EventArgs e)
        {
            //Deal = Game.Play();
            string result = Game.Play();
            ResultWriter(result);
            //ResultWriter(2);
            //Game.DetermineWinner();
            //ResultWriter(Game.Winner);
        }


        public void ResultWriter(string result)
        {
            //string result = "";
            //switch (key)
            //{
                //case 2: result += "<h2 style='font-weight: bold'>Begin battle ...</h2>\n\n";
                //    for (int i = 0; i < Deal.Player2Hand.Count; i++)
                //    {
                //        result += String.Format("Battle Cards: {0} versus {1}<br/>Bounty ...<br/> {0}<br/>{1}<br/>",
                //            Deal.Player1Hand.ElementAt(i).Value, Deal.Player2Hand.ElementAt(i).Value);
                //    }
                //    break;
                //case 3: result += "<Strong>" + Game.Player1 + " wins!</strong>";
                //    break;
                //case 4: result += "<Strong>" + Game.Player2 + " wins!</strong>";
                //    break;
                //case 5: result += "<Strong>**********WAR!**********</strong>";
                //    break;
            //}

            // Just for showing full deck
            //for (int i = 0; i < Game.ShuffledDeck.Count; i++ )
            //{
            //    ResultLabel.Text += String.Format("{0}<br/>", Game.ShuffledDeck.ElementAt(i));
            //}
            ResultLabel.Text += result;
        }
    }
}