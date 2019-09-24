using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace JogoDeCartas
{
    class Program
    {
        private static List<Card> player1;
        private static List<Card> player2;
        private static List<Card> card;
        public static Random random;
        static void Main(string[] args)
        {
            random = new Random();
            player1 = new List<Card>();
            player2 = new List<Card>();
            card = new List<Card>();


            //-------------Ler Arquivo .txt ---------------------------------------------- 
            string[] lines = File.ReadAllLines("b.txt");
            

            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }
            //----------------------------------------------------------------------------   
            
            Console.WriteLine("\n#####################################################\n");
            Console.WriteLine("Press any key to start game ...");
            Console.WriteLine("-----------------------------------------------------\n");
            Console.ReadKey(true);


            Deck deck = new Deck();
            show_create(deck.get_list());
            deck.shuffle();

            show_shuffle(deck.get_deck());

            Console.WriteLine("#####################################################\n");
            Console.WriteLine("Press any key to Resume...");
            show_mesa(deck.get_list());
            Console.ReadKey(true);
        }

        public static void show_create(List<Card> cards)
        {
            Console.WriteLine("Show Create ...");
            Console.WriteLine("-----------------------------------------------------\n");

            for (int i = 0; i < cards.Count; i++)
            {
                Console.WriteLine("index: " + i + ") - " + cards[i].ToString());
            }

            Console.WriteLine("-----------------------------------------------------\n");
            Console.WriteLine("Press any key to continue ...");
            Console.ReadKey(true);
            // /Console.WriteLine("-----------------------------------------------------\n");
        }

        public static void show_shuffle(Stack<Card> cards)
        {
            Console.WriteLine("Shuffle Cards ...");
            Console.WriteLine("-----------------------------------------------------\n");
            for (int i = 0; i < 52; i++)
            {
                Card card_tmp = new Card(cards.Pop());
                Console.WriteLine("index: " + i + ") - " + card_tmp.ToString());
            }
            Console.WriteLine("-----------------------------------------------------\n");
            Console.WriteLine("Press any key to continue ...");
            Console.ReadKey(true);
        }

        public static void show_mesa(List<Card> cards)
        {

            Console.WriteLine("Player1");
            for (int i = 0; i < 2; i++)
            {
                int index = random.Next(0, cards.Count);
                player1.Add(cards[index]);
                Console.WriteLine(cards[index].ToString());
                cards.RemoveAt(index);
            }
            Console.WriteLine("________________________________________________________________");

            Console.WriteLine("Mesa");
            for (int i = 0; i < 5; i++)
            {
                int index = random.Next(0, cards.Count);
                card.Add(cards[index]);
                Console.WriteLine(cards[index].ToString());
                cards.RemoveAt(index);
            }
            Console.WriteLine("________________________________________________________________");

            Console.WriteLine("Player2");
            for (int i = 0; i < 2; i++)
            {
                int index = random.Next(0, cards.Count);
                player2.Add(cards[index]);
                Console.WriteLine(cards[index].ToString());
                cards.RemoveAt(index);
            }
        }
    }
}