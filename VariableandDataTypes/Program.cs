﻿using System;

namespace VariableandDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite number?");
            string favoriteNumber = Console.ReadLine();
            Console.WriteLine("Your favorite number is: " + favoriteNumber);
            Console.ReadLine();
            int favNum = Convert.ToInt32(favoriteNumber);
            int total = favNum + 5;
            Console.WriteLine("Your favorite number plus 5 is: " + total);
            Console.ReadLine();

            //Console.WriteLine("What is your name?");
            //string yourName = Console.ReadLine();
            //Console.WriteLine("Your name is: " + yourName);
            //Console.ReadLine();
        }
    }
}
