using System;

namespace JogoDeCartas
{
    public class Card
    {
        private int value;
        private String suit;

        public Card()
        {
            this.value = 0;
            this.suit  = "";
        }
        public Card (Card card)
        {
            this.value = card.get_value();
            this.suit = card.get_suit();
        }

        public int get_value()
        { return this.value; }
        
        public void set_value(int v)
        { this.value = v; }

        public String get_suit()
        {
            return this.suit;
        }
        public void set_suit (String s)
        {
            this.suit = s;
        }

        public override string ToString()
        {
            string to_string = "Value: ";
            to_string += this.value;
            to_string += "\tSuit: ";
            to_string += this.suit;

            return to_string;
        }
    }
}
