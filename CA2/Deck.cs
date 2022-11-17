using System;
using System.Collections.Generic;
using System.Linq;

namespace CA2
{

    internal class Deck
    {

        private Card[] cards;
        Random rnd = new Random();

        //Builds the deck
        public Deck()
        {
            cards =
                new[] { "Spades", "Hearts", "Clubs", "Diamonds", }
                    .SelectMany(
                        suit => Range(1, 13),
                        (suit, face) => new Card(face, suit))
                    .ToArray();
        }
        
        private IEnumerable<object> Range(int v1, int v2)
        {
            throw new NotImplementedException();
        }

        //getting a random card 
        public string GetRandomCard()
        {
            int i = rnd.Next(cards.Length);
            Card drawnCard = cards[i];
            string suit = drawnCard.Suit;
            var face = drawnCard.Face;
            cards = cards.Where((source, index) => index != i).ToArray();
            if (face == 11)
            {
                return "Jack of " + suit;
            }
            if (face == 12)
            {
                return "Queen of " + suit;
            }
            if (face == 13)
            {
                return "King of " + suit;
            }
            if (face == 1)
            {
                return "Ace of " + suit;
            }
            return face + " of " + suit;
        }
    }
}
