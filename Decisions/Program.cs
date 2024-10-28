// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;

namespace Decisions
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Bob's Big Giveaway");
            Console.Write("Choose a door: 1, 2 or 3: ");
            string userValue = Console.ReadLine();

            string message;

            if (userValue == "1")
            {
                message = "You won a CAR!";                   
            }
            else if (userValue == "2")
            {
                 message = "You won a BOAT!";                
            }
            else if (userValue == "3")
            {
                message = "You won a CAT!";               
            }
            else
            {
                message = " Please choose from 1, 2 or 3";             
            }
            Console.WriteLine(message);
            Console.ReadLine();
        }
    }
}


