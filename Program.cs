using System;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck ();

            Player waseem = new Player("Waseem");

            deck.Shuffle();

            waseem.Draw(deck, waseem);

            deck.Shuffle();

            waseem.Draw(deck, waseem);

            Console.WriteLine(waseem.Hand);

        }
    }
}