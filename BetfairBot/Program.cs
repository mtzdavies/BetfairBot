﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetfairBot
{
    class Program
    {
        static void Main(string[] args)
        {
            var betfair = new Betfair();
            betfair.Connect();
            Console.ReadLine();
        }
    }
}
