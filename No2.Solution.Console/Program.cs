﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No2.Solution.Console
{
    using System.Threading;

    class Program
    {
        static void Main(string[] args)
        {
            var stock = new Stock();

            var bank = new Bank("Bank", stock);
            var broker = new Broker("Broker", stock);
            
            stock.Market();
            Thread.Sleep(1000);
            stock.Market();

            System.Console.ReadLine();
        }
    }
}
