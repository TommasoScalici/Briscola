using System;
using System.Collections.Generic;

namespace Briscola.DataModel
{
    public sealed class Game
    {
        readonly List<Card> cards = new List<Card>();
        readonly Stack<Card> deck = new Stack<Card>();


        public Game()
        {
            CreateCards();
            cards.Shuffle();

            foreach (var card in cards)
                deck.Push(card);


            TrumpCard = FishCardFromDeck();

            Player2.FishCard(FishCardFromDeck());
            Player1.FishCard(FishCardFromDeck());

            Player2.FishCard(FishCardFromDeck());
            Player1.FishCard(FishCardFromDeck());

            Player2.FishCard(FishCardFromDeck());
            Player1.FishCard(FishCardFromDeck());
        }


        public int CardsLeft => deck.Count;
        public Card TrumpCard { get; }
        public Player Player1 { get; } = new RealPlayer();
        public Player Player2 { get; } = new CPUPlayer();


        public Card FishCardFromDeck() => deck.Pop();

        void CreateCards()
        {
            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                for (var i = 1; i < 11; i++)
                {
                    int score;

                    switch (i)
                    {
                        case 1:
                            score = 11;
                            break;
                        case 3:
                            score = 10;
                            break;
                        case 10:
                            score = 4;
                            break;
                        case 8:
                        case 9:
                            score = 3;
                            break;
                        default:
                            score = 0;
                            break;
                    }

                    cards.Add(new Card(suit, i, score));
                }
            }
        }
    }
}
