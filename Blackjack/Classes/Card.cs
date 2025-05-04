using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Classes {
    public enum Suits {
        CLUBS,
        DIAMONDS,
        HEARTS,
        SPADES
    }

    public enum FaceValues {
        ACE = 1,
        TWO,
        THREE,
        FOUR,
        FIVE,
        SIX,
        SEVEN,
        EIGHT,
        NINE,
        TEN,
        JACK,
        QUEEN,
        KING
    }
    class Card {
        Suits suit;
        FaceValues faceValue;
        int value;
        //Image img;

        public Suits Suit { get { return suit; } }
        public int Value { get { return value; } }
        //public Image Image { get { return img; } }

        public Card(Suits suit, FaceValues faceValue) {
            this.suit = suit;
            this.faceValue = faceValue;
            switch (faceValue) {
                case FaceValues.ACE:
                    this.value = 11;
                    break;
                case FaceValues.TEN:
                case FaceValues.JACK:
                case FaceValues.QUEEN:
                case FaceValues.KING:
                    this.value = 10;
                    break;
                default:
                    this.value = (int)faceValue;
                    break;
            }
        }

        public override string ToString() {
            return this.faceValue + " Of " + this.suit;
        }

        internal void Add(Card card) {
            throw new NotImplementedException();
        }
    }
}
