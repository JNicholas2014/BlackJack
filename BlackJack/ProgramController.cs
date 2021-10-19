﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace BlackJack
{
    class ProgramController
    {
        
        public Player p;
        public Dealer d = new Dealer();
        string message = "";
        

        
        public void CreateDealer()
        {
            d.Name = "DEALER";

        }
       
        public void PlayerEnter()
        {
            Player _p = new Player();
            p = _p;
            p.Hand = new List<Card>();
            Console.Clear();
            Console.WriteLine("Enter your player name...");
            p.Name = Console.ReadLine();
            
        }
        public void Timing()
        {
            Console.WriteLine("Press Any Key To Continue...");
            Console.ReadKey();
        }

        public void GetChips()
        {
            bool hasCash = false;
            while(hasCash == false)
            {
                Console.WriteLine("Enter the amount of cash you would like to play with...");
                try
                {
                    string input = Console.ReadLine();
                    int num = int.Parse(input);
                    p.Cash = num;
                    if (p.Cash <= 0)
                    {
                        Console.WriteLine("You declined to buy chips, have a nice day!\nGame will now close...");
                        Timing();
                        Environment.Exit(0);
                    }
                    
                    Console.WriteLine("Welcome to the game " + p.Name + ", " + "you have " + p.Cash + " in chips...");
                    hasCash = true;
                   
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid entry");
                    
                }
            }
            
        }
        public int Wager()
        {
            Console.WriteLine("Enter the amount to wager...");
            try
            {
                string input = Console.ReadLine();
                int num = int.Parse(input);
                if ((num <= p.Cash) && (p.Cash > 0))
                {
                    p.Cash -= num;
                    return num;
                }
                else if (p.Cash <= 0)
                {
                    Console.WriteLine("It looks like you are out of chips");
                    num = 0;
                    return num;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid entry");
               
            }
            return 0;
        }

        public void GetCards(Card firstCard, Card secondCard)
        {
            p.HandValue = 0;
            p.Hand.Add(firstCard);
            p.Hand.Add(secondCard);
            
            for(int i = 0; i < p.Hand.Count; i++)
            {
                message += p.Hand[i].Holder + " " + p.Hand[i].Suit + " ";
                if (p.Hand[i].Holder.Equals("Ace"))
                {
                    p.HandValue += 11;
                }
                else
                {
                    p.HandValue += p.Hand[i].Value;
                }

                
                
            }
            Console.WriteLine(p.Name + ", your current hand is " + message + " value = " + p.HandValue);
        }
        
        
    }
}
