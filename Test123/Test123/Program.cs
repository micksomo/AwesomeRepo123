﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test123
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            

            //Looping Feature
            for (int i = 0; i < 100; i++)
            {
                if (i%2 == 0)
                {
                    i--;
                }
            }
            
            Console.ReadKey(true);
        }
    }
}
