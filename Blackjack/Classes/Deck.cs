using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Classes
{
    internal class Deck
    {
        List<Card> cards = new List<Card>();

        public Deck()
        {

            // Create 52 unique cards
            int index = 0;
            foreach (Suits suit in Enum.GetValues(typeof(Suits)))
            {
                foreach (FaceValues faceValue in Enum.GetValues(typeof(FaceValues)))
                {
                    cards.Add(new Card(suit, faceValue));
                }
            }
        }
    }
}
