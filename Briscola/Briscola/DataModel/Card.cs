namespace Briscola.DataModel
{
    public enum Suit
    {
        Clubs,
        Coins,
        Cups,
        Swords
    }

    public sealed class Card
    {
        public Card(Suit suit, int number)
        {
            Number = number;
            Suit = suit;
        }

#pragma warning disable RECS0154
        public Card(Suit suit, int number, int score)
#pragma warning restore RECS0154
            : this(suit, number) => Score = score;


        public Suit Suit { get; }
        public int Number { get; }
        public int Score { get; }
    }
}
