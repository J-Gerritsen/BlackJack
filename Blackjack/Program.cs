using BlackJack.Classes;
using System.Numerics;

namespace Blackjack
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            //ApplicationConfiguration.Initialize();
            //Application.Run(new Form1());

            Deck deck = new Deck();
            deck.PrintDeck();
            Console.WriteLine("\n");
            deck.Shuffle();
            deck.PrintDeck();
            Player player1 = new Player();
            player1.Hit(deck.DrawCard());
            player1.Hit(deck.DrawCard());
        }
    }
}