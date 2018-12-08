using System;
using System.Collections.Generic;
using Briscola.DataModel;

namespace Briscola
{
    public static class ExtensionMethods
    {
        static readonly Random random = new Random();


        public static IList<T> Shuffle<T>(this IList<T> source)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            var count = source.Count;

            while (count > 1)
            {
                var i = random.Next(count--);
                var temp = source[count];
                source[count] = source[i];
                source[i] = temp;
            }

            return source;
        }

        public static string GetSuitItalianName(this Suit suit)
        {
            switch (suit)
            {
                case Suit.Clubs:
                    return "Bastoni";
                case Suit.Coins:
                    return "Denari";
                case Suit.Cups:
                    return "Coppe";
                case Suit.Swords:
                    return "Spade";
            }

            return string.Empty;
        }
    }
}
