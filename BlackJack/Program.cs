using System;
using System.Collections.Generic;
using System.IO;
using static System.Console;
using System.Text;
using System.Linq;
namespace BlackJack
{
    class Program
    {
        public static ProgramController pc;
        public static DeckController dc;
        public static DealerController dealControl;
        public static List<Card> Shoe = new List<Card>();
        public static double PlayerCash;
       
        static void Main(string[] args)
        {
            System.Console.BackgroundColor = ConsoleColor.Green;
            Clear();
            ForegroundColor = ConsoleColor.Black;
            WriteLine("\t\t\t\t\t\tWelcome to BlackJack\n");
            pc = new ProgramController();
            dealControl = new DealerController();
            pc.Timing();
            pc.PlayerEnter();
            pc.GetChips();
            PlayerCash = pc.p.Cash;
            WriteLine(pc.p.Cash + " is player Cash");
            Shoe = dealControl.shoe;
            //dc = new DeckController();
            
            
            char response;
            if (dealControl.shoe.Count <= 13)
            {
                dealControl = new DealerController();
            }
            while (dealControl.shoe.Count > 13)
            {
                pc.Wager();
                                
                while (pc.p.Wager <= 0)
                {
                    WriteLine("You must bet to play!");
                    pc.Timing();
                    Console.WriteLine("Would you like continue?(y/n)");
                    response = Console.ReadLine().ToUpper().FirstOrDefault();
                    switch (response)
                    {
                        case 'Y':
                            pc.Wager();
                            break;
                        default:
                            WriteLine("Game Closing");
                            Environment.Exit(0);
                            break;

                    }


                }
                pc.GetCards(dealControl.shoe[0], dealControl.shoe[1]);
                pc.Timing();
                dealControl.shoe.RemoveAt(0);
                dealControl.shoe.RemoveAt(0);
                dealControl.GetCards();
                
                if (dealControl.ins == 1)
                {
                    int purchased = dealControl.GetInsurance(pc.p.Wager);
                    if (purchased == 1)
                        pc.p.Cash -= pc.p.Wager / 2;
                    dealControl.CheckBlackJack();
                }
                int choice = 0;

                //now player decides hit, split, etc.
                Decisions();
                
                
            }
            

        }
        public static void GetValue()
        {
            int sum = 0;
            bool hasAce = false;
            for (int i = 0; i < pc.p.Hand.Count; i++)
            {
                if (pc.p.Hand[i].Holder.Equals("Ace"))
                {
                    hasAce = true;
                    sum += 10;
                }
                sum += pc.p.Hand[i].Value;
            }
            if ((sum > 21) && (hasAce == true))
            {
                sum -= 9;
            }
        }
        public static void Hit()
        {
            
            pc.p.Hand.Add(dealControl.shoe[0]);
            dealControl.shoe.RemoveAt(0);
            Console.WriteLine(pc.p.Name + "'s hand:");
            string message = "";
            for (int i = 0; i < pc.p.Hand.Count; i++)
            {
                message += (pc.p.Hand[i].Holder + "" + pc.p.Hand[i].Suit + " ");
            }
            Console.WriteLine(message);
            
            
            Decisions();


        }
        public static void Result()
        {
            int pBJ = pc.CheckBlackJack();
            if (pBJ == 1)
                pc.p.Cash += (1.5 * pc.p.Wager);
            
        }
        public static void Decisions()
        {
            int choice = 0;
            
            if ((pc.p.Hand.Count == 2) && (pc.p.Hand[0].Value == pc.p.Hand[1].Value))
            {
                Console.WriteLine("Current options: 1:Stay\t2:Hit\t3:Split");
                bool chose = false;
                while (chose == false)
                {
                    Console.WriteLine("What would you like to do?");
                    try
                    {
                        string input = Console.ReadLine();
                        choice = int.Parse(input);
                        if ((choice > 0) && (choice < 5))
                        {
                            chose = true;
                        }
                        else
                        {
                            chose = false;
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Invalid entry");

                    }
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Staying...");
                            break; //do nothing
                        case 2:
                            Hit();
                            break;
                        case 3:
                            //Split();
                            break;
                        case 4:
                            //DoubleDown();
                            break;
                    }
                }
                
            }
            else
            {
                Console.WriteLine("Current options: 1:Stay\t2:Hit");
                bool chose = false;
                while (chose == false)
                {
                    Console.WriteLine("What would you like to do?");
                    try
                    {
                        string input = Console.ReadLine();
                        choice = int.Parse(input);
                        if ((choice > 0) && (choice < 5) && (choice != 3)&& (choice != 4))
                        {
                            chose = true;
                        }
                        else
                        {
                            chose = false;
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Invalid entry");

                    }
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Staying...");
                            break; //do nothing
                        case 2:
                            Hit();
                            break;
                    }
                }
                
            }
        }
    }
}
