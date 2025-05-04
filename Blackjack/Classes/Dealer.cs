using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Classes {
    class Dealer {
        private Hand hand = new Hand();

        bool hasStood = false;

        public bool HasBlackjack => hand.CalculateValue() == 21;
        public bool IsBust => hand.CalculateValue() > 21;


        public void Hit(Card card) {
            if (!hasStood)
                hand.AddCard(card);
        }

        public void Stand() {
            hasStood = true;
        }

        public int GetTotalValue() {
            return hand.CalculateValue();
        }

        public void ShowHand() {
            hand.ShowHand("Dealer");
        }

    }
}
