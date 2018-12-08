using System.Collections.Generic;

namespace Briscola.DataModel
{
    public abstract class Player
    {
        readonly IList<Card> cardsTaken = new List<Card>();
        readonly IList<Card> hand = new List<Card>();


        public IReadOnlyList<Card> Hand => (IReadOnlyList<Card>)hand;
        public int TotalScore { get; }


        public void DropCard(Card card) => hand.Remove(card);
        public void FishCard(Card card) => hand.Add(card);
        public void TakeCard(Card card) => cardsTaken.Add(card);
    }
}
