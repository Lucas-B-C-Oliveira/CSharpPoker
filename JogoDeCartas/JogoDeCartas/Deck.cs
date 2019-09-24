using System;
using System.Linq;
using System.Collections.Generic;

namespace JogoDeCartas
{
    public class Deck
    {
        private List<Card> cards_list;
        private Stack<Card> cards_stack;
        private static Random random;
        
        public Deck()
        {
            random = new Random();
            this.creat_deck();
        }

        private void creat_deck()
        {
            this.cards_list = new List<Card>();
            

            for (int i = 0; i < 13; i++)
            {
                Card card = new Card();
                card.set_value (i+1);
                card.set_suit("Clubs");
                this.cards_list.Add(card);
            }
            
            for (int i = 0; i < 13; i++)
            {
                Card card = new Card();
                card.set_value(i+1);
                card.set_suit("Diamonds");
                this.cards_list.Add(card);
            }
                        
            for (int i = 0; i < 13; i++)
            {
                Card card = new Card();
                card.set_value(i+1);
                card.set_suit("Hearts");
                this.cards_list.Add(card);
            }
            
            for (int i = 0; i < 13; i++)
            {
                Card card = new Card();
                card.set_value(i+1);
                card.set_suit("Spades");
                this.cards_list.Add(card);
            }            
        }

        public void shuffle()
        {
            for (int i = 0 ; i < cards_list.Count()  ; i++)
            {
                Card temp = new Card(cards_list[i]);
                int index = random.Next(i, cards_list.Count());

                cards_list[i] = cards_list[index];
                cards_list[index] = temp;
            }

            cards_stack = new Stack<Card>();

            foreach (Card c in cards_list)
                cards_stack.Push(c);
        }
        
        public Stack<Card> get_deck()
        { return this.cards_stack; }

        public Card get_card()
        { return cards_stack.Pop(); }

        public List<Card> get_list()
        { return cards_list; }
    }
}