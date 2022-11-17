using System;
namespace CA2
{
    public class Card
    {
        private object face;

        public Card(int face, string suit)
            {
                Face = face;
                Suit = suit;
            }

        public Card(object rank, string suit)
        {
            this.Face = (int)face;
            Suit = suit;
        }

        public int Face { get; }
        public string Suit { get; }

        
    }
}
