using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace BlackJack.Classes {
    class Hand {
        private List<Card> cards = new List<Card>();

        public void AddCard(Card card) {
            cards.Add(card);
        }

        public int CalculateValue() {
            int total = cards.Sum(card => card.Value);

            int aceCount = cards.Count(card => card.Value == 11);
            while (total > 21 && aceCount > 0) {
                total -= 10;
                aceCount--;
            }

            return total;
        }

        public void ShowHand(string ownerName) {
            Console.WriteLine($"{ownerName}'s Hand:");
            foreach (Card card in cards) {
                Console.WriteLine(card);
            }
            Console.WriteLine($"Total Value: {CalculateValue()}");
        }

        public List<Card> GetCards() => cards;
    }
}
