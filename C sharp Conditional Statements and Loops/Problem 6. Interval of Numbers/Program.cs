﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6.Interval_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
      
                for(int i=a;i<=b;i++)
                {
                    Console.WriteLine(i);
                  
                }
           
                for (int i =b; i <= a; i++)
                {
                    Console.WriteLine(i);
                    
                }


        }
    }
}
