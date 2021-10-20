using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class DealerController
    {
        Dealer d = new Dealer();
        string message = "";
        bool insurance = false;
        DeckController dc = new DeckController();
        public List<Card> shoe = new List<Card>();
        public int ins = 0;
        
        
        public DealerController()
        {
            d.Name = "DEALER";
            d.Hand = new List<Card>();
            shoe = dc.CreateShoe();
            shoe = dc.Shuffle();
        }

        public void GetCards()
        {
            ins = 0;
            insurance = false;
            Card firstCard = shoe[0];
            Card upCard = shoe[1];
            d.Hand.Add(firstCard);
            d.Hand.Add(upCard);
            shoe.RemoveAt(0);
            shoe.RemoveAt(0);
            Console.WriteLine("Dealer is showing " + upCard.Holder + " " + upCard.Suit);
            if (upCard.Holder.Equals("Ace"))
            {
                ins = 1;
            }
            
        }

        public void CheckBlackJack()
        {
            if (d.Hand[0].Value == 10)
                Console.WriteLine("DEALER has BLACKJACK");
            
        }
        public void Hit(List<Card> _shoe)
        {

        }
        //public void GetValue(List<Card> _hand)
        //{
        //    List<Card> hand = new List<Card>();
        //    hand = _hand;
        //    bool hasAce = false;
        //    string message;
        //    int value = 0;
        //    for(int i = 0; i < hand.Count; i++)
        //    {
        //        Console.Write(hand[i].Holder + " " + hand[i].Suit);
        //        value += hand[i].Value;
        //        if (hand[i].Holder.Equals("Ace"))
        //        {
        //            hasAce = true;
        //        }
        //    }

        //}
        public void Split()
        {

        }

        public void DoubleDown()
        {

        }
        public int GetInsurance(int _insuranceAmt)
        {
            int insuranceAmt = _insuranceAmt / 2;
            bool loop = true;
            char response;
            do
            {
                Console.WriteLine("Would you like to purchase insurance?(y/n)");
                response = Console.ReadLine().ToUpper().FirstOrDefault();
                switch (response)
                {
                    case 'Y':
                        insurance = true;
                        loop = false;
                        
                        break;
                    case 'N':
                        insurance = false;
                        loop = false;
                        
                        break;
                    default:
                        Console.WriteLine("You must choose yes or no (y/n)");
                        break;

                }
            } while (loop == true);

            if (response == 'Y')
            {
                
                return 1;
            }
            else
                
                return 0;
        }

        
    }
}
