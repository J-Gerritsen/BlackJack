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

        public void Shuffle()
        {
            Random random = new Random();
            for (int i = 0; i < cards.Count; i++)
            {
                int randomPlace = random.Next(i, cards.Count);
                Card storedCard = cards[i];
                cards[i] = cards[randomPlace];
                cards[randomPlace] = storedCard;
            }
        }

        public void PrintDeck()
        {
            foreach (Card card in cards)
            {
                Console.WriteLine(card);
            }
        }

        public Card DrawCard()
        {
            if (cards.Count <= 0)
            {
                return null;
            }
            Card drawnCard = cards[0];
            cards.RemoveAt(0);
            return drawnCard;

        }
    }
}
