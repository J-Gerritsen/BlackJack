using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Classes
{
    class Game
    {
        private List<Player> playerCount;
        private Deck deck;

        public Game()
        {
            playerCount = new List<Player>();
            deck = new Deck();
        }

        public void Start()
        {
            deck.Shuffle();

            Player player1 = new Player();
            player1.Hit(deck.DrawCard());
            player1.Hit(deck.DrawCard());

            playerCount.Add(player1);

            while (true)
            {
                player1.ShowHand();
                int total = player1.GetTotalValue();

                if (player1.IsBust)
                {
                    Console.WriteLine("You are busted");
                    break;
                }

                if (player1.HasBlackjack)
                {
                    Console.WriteLine("Blackjack!");
                    break;
                }

                Console.Write("Do you want to Hit or Stand? ");
                string input = Console.ReadLine().ToUpper();

                if (input == "HIT")
                {
                    player1.Hit(deck.DrawCard());
                }
                else if (input == "STAND")
                {
                    player1.Stand();
                    Console.WriteLine("You chose stand.");
                    break;
                }
                else
                {
                    Console.WriteLine("Choose either HIT or STAND.");
                }
            }
        }
    }
}
