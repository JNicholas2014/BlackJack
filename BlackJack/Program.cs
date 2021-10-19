using System;
using System.Collections.Generic;
using System.IO;
using static System.Console;

namespace BlackJack
{
    class Program
    {
        
        static void Main(string[] args)
        {
            System.Console.BackgroundColor = ConsoleColor.Green;
            Clear();
            ForegroundColor = ConsoleColor.Black;

            WriteLine("\t\t\t\t\t\tWelcome to BlackJack\n");
            ProgramController pc = new ProgramController();
            pc.Timing();
            pc.PlayerEnter();
            pc.Timing();
            pc.GetChips();
            DeckController dc = new DeckController();
            dc.CreateShoe();
            dc.Shuffle();
            //List<Card> l = dc.shoe;
            
            DealerController dealControl = new DealerController();
            while(dc.shoe.Count > 13)
            {
                int wager = pc.Wager();
                if(wager <= 0)
                {
                    pc.GetChips();
                }
                pc.GetCards(dc.shoe[0], dc.shoe[1]);
                pc.Timing();
                dc.shoe.RemoveAt(0);
                dc.shoe.RemoveAt(0);
                dealControl.GetCards(dc.shoe[0], dc.shoe[1]);
                dc.shoe.RemoveAt(0);
                dc.shoe.RemoveAt(0);
                int choice = 0;
                //now player decides hit, split, etc.
                if(pc.p.Hand[0].Value == pc.p.Hand[1].Value)
                {
                    Console.WriteLine("Current options: 1:Stay\t2:Hit\t3:Split\t4:Double Down");
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
                                dealControl.Hit();
                                break;
                            case 3:
                                dealControl.Split();
                                break;
                            case 4:
                                dealControl.DoubleDown();
                                break;
                        }
                    }
                    
                }
                else
                {
                    Console.WriteLine("Current options: 1:Stay\t2:Hit\t4:Double Down");
                    bool chose = false;
                    while (chose == false)
                    {
                        Console.WriteLine("What would you like to do?");
                        try
                        {
                            string input = Console.ReadLine();
                            choice = int.Parse(input);
                            if ((choice > 0) && (choice < 5) && (choice != 3))
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
                                dealControl.Hit();
                                break;
                            case 4:
                                dealControl.DoubleDown();
                                break;
                        }
                    }
                }

                
            }

    }
    }
}
