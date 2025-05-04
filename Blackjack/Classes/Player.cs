using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace BlackJack.Classes
{
    class Player
    {
        private Hand hand = new Hand();

        bool hasStood = false;
        bool hasSplit = false;

        public bool HasBlackjack => hand.CalculateValue() == 21;
        public bool IsBust => hand.CalculateValue() > 21;

        public void Hit(Card card)
        {
            if (!hasStood)
                hand.AddCard(card);
        }

        public void Stand()
        {
            hasStood = true;
        }
    }
}
