using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace BlackJack
{
    public class DeckController
    {
        
        public List<Card> shoe = new List<Card>();
        public List<Card> unshuffled = new List<Card>();
        

        public List<Card> CreateShoe()
        {
            Card[] tempArr = new Card[208];
           
            WriteLine("Please wait while I shuffle the shoe. Today we are using a 4 deck shoe.");
            Card c;
            for (int i = 0; i < 13; i++)
            {
                c = new Card();
                c.Suit = "HEARTS";
                switch (i)
                {
                    case 0:
                        c.Holder = "Ace";
                        c.Value = i + 1;
                        break;
                    case 1:
                        c.Holder = "Two";
                        c.Value = i + 1;
                        break;
                    case 2:
                        c.Holder = "Three";
                        c.Value = i + 1;
                        break;
                    case 3:
                        c.Holder = "Four";
                        c.Value = i + 1;
                        break;
                    case 4:
                        c.Holder = "Five";
                        c.Value = i + 1;
                        break;
                    case 5:
                        c.Holder = "Six";
                        c.Value = i + 1;
                        break;
                    case 6:
                        c.Holder = "Seven";
                        c.Value = i + 1;
                        break;
                    case 7:
                        c.Holder = "Eight";
                        c.Value = i + 1;
                        break;
                    case 8:
                        c.Holder = "Nine";
                        c.Value = i + 1;
                        break;
                    case 9:
                        c.Holder = "Ten";
                        c.Value = i + 1;
                        break;
                    case 10:
                        c.Holder = "Jack";
                        c.Value = 10;
                        break;
                    case 11:
                        c.Holder = "Queen";
                        c.Value = 10;
                        break;
                    case 12:
                        c.Holder = "King";
                        c.Value = 10;
                        break;

                }
                tempArr[i] = c;
                tempArr[i + 52] = c;
                tempArr[i + 104] = c;
                tempArr[i + 156] = c;
                
            }
            for (int i = 13; i < 26; i++)
            {
                c = new Card();
                c.Suit = "DIAMONDS";
                switch (i)
                {
                    case 13:
                        c.Holder = "Ace";
                        c.Value = 1;
                        break;
                    case 14:
                        c.Holder = "Two";
                        c.Value = 2;
                        break;
                    case 15:
                        c.Holder = "Three";
                        c.Value = 3;
                        break;
                    case 16:
                        c.Holder = "Four";
                        c.Value = 4;
                        break;
                    case 17:
                        c.Holder = "Five";
                        c.Value = 5;
                        break;
                    case 18:
                        c.Holder = "Six";
                        c.Value = 6;
                        break;
                    case 19:
                        c.Holder = "Seven";
                        c.Value = 7;
                        break;
                    case 20:
                        c.Holder = "Eight";
                        c.Value = 8;
                        break;
                    case 21:
                        c.Holder = "Nine";
                        c.Value = 9;
                        break;
                    case 22:
                        c.Holder = "Ten";
                        c.Value = 10;
                        break;
                    case 23:
                        c.Holder = "Jack";
                        c.Value = 10;
                        break;
                    case 24:
                        c.Holder = "Queen";
                        c.Value = 10;
                        break;
                    case 25:
                        c.Holder = "King";
                        c.Value = 10;
                        break;

                }
                tempArr[i] = c;
                tempArr[i + 52] = c;
                tempArr[i + 104] = c;
                tempArr[i + 156] = c;
                
            }
            for (int i = 26; i < 39; i++)
            {
                c = new Card();
                c.Suit = "CLUBS";
                switch (i)
                {
                    case 26:
                        c.Holder = "Ace";
                        c.Value = 1;
                        break;
                    case 27:
                        c.Holder = "Two";
                        c.Value = 2;
                        break;
                    case 28:
                        c.Holder = "Three";
                        c.Value = 3;
                        break;
                    case 29:
                        c.Holder = "Four";
                        c.Value = 4;
                        break;
                    case 30:
                        c.Holder = "Five";
                        c.Value = 5;
                        break;
                    case 31:
                        c.Holder = "Six";
                        c.Value = 6;
                        break;
                    case 32:
                        c.Holder = "Seven";
                        c.Value = 7;
                        break;
                    case 33:
                        c.Holder = "Eight";
                        c.Value = 8;
                        break;
                    case 34:
                        c.Holder = "Nine";
                        c.Value = 9;
                        break;
                    case 35:
                        c.Holder = "Ten";
                        c.Value = 10;
                        break;
                    case 36:
                        c.Holder = "Jack";
                        c.Value = 10;
                        break;
                    case 37:
                        c.Holder = "Queen";
                        c.Value = 10;
                        break;
                    case 38:
                        c.Holder = "King";
                        c.Value = 10;
                        break;

                }
                tempArr[i] = c;
                tempArr[i + 52] = c;
                tempArr[i + 104] = c;
                tempArr[i + 156] = c;
               
            }
            for (int i = 39; i < 52; i++)
            {
                c = new Card();
                c.Suit = "SPADES";
                switch (i)
                {
                    case 39:
                        c.Holder = "Ace";
                        c.Value = 1;
                        break;
                    case 40:
                        c.Holder = "Two";
                        c.Value = 2;
                        break;
                    case 41:
                        c.Holder = "Three";
                        c.Value = 3;
                        break;
                    case 42:
                        c.Holder = "Four";
                        c.Value = 4;
                        break;
                    case 43:
                        c.Holder = "Five";
                        c.Value = 5;
                        break;
                    case 44:
                        c.Holder = "Six";
                        c.Value = 6;
                        break;
                    case 45:
                        c.Holder = "Seven";
                        c.Value = 7;
                        break;
                    case 46:
                        c.Holder = "Eight";
                        c.Value = 8;
                        break;
                    case 47:
                        c.Holder = "Nine";
                        c.Value = 9;
                        break;
                    case 48:
                        c.Holder = "Ten";
                        c.Value = 10;
                        break;
                    case 49:
                        c.Holder = "Jack";
                        c.Value = 10;
                        break;
                    case 50:
                        c.Holder = "Queen";
                        c.Value = 10;
                        break;
                    case 51:
                        c.Holder = "King";
                        c.Value = 10;
                        break;

                }
                tempArr[i] = c;
                tempArr[i + 52] = c;
                tempArr[i + 104] = c;
                tempArr[i + 156] = c;
                
            }
            unshuffled = tempArr.ToList<Card>();
            
            return unshuffled;
           
        }
    
        public List<Card> Shuffle()
        {
            Random r = new Random();
            for(int n = unshuffled.Count; n > 0; n--)
            {
                int z = r.Next(n);
                Card temp = unshuffled[z];
                shoe.Add(temp);
                unshuffled.RemoveAt(z);
            }
            
            return shoe;
        }
    }
}

