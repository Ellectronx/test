﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulatorDuzo
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {

                Console.WriteLine("0. Exit");
                Console.WriteLine("1. ADD");
                Console.WriteLine("2. DIFF");
                Console.WriteLine("3. MUL");
                Console.WriteLine("4. MDIV");

                int menuOption = Convert.ToInt32(Console.ReadLine());
                if (menuOption == 0)
                {
                    break;
                }


                
            }
        }
    }
}
