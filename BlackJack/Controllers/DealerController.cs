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
        public DealerController()
        {
            d.Name = "DEALER";
            d.Hand = new List<Card>();
        }

        public void GetCards(Card firstCard, Card upCard)
        {
            d.Hand.Add(firstCard);
            d.Hand.Add(upCard);
            Console.WriteLine("Dealer is showing " + upCard.Holder + " " + upCard.Suit);
            if (upCard.Holder.Equals("Ace"))
            {
                
            }
            
        }

        public void GetHandValue()
        {

            
        }
        public void Hit()
        {
            
        }
        public void Split()
        {

        }

        public void DoubleDown()
        {

        }
        public int GetInsurance(int _ins)
        {
            int ins;
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
                ins = _ins;
                return ins;
            }
            else
                ins = 0;
                return ins;
        }
    }
}
