﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class global
    {
        public int textroadline1;
        public int textroadlineeffect1;
        public int textroad1 = 1;
        public int textroadcounter1 = 1 ;
       
        public double monsterhp1 = 100 ;
        public int battlesentaku=1;
        public int playermana = 100;
        public int playerhp = 100;
        public int turn = 1;
        public int monsterdamage=5;
        public int playerdamage = 5;
        public int playermanadamage = 20;
        public int playermanacost = 30;
        

    }
    public static class Randomglobal
    {
       public static double attackcriticalrate;
       public static void Attackcriticalrate()
       {
       Random randomglobal = new Random();
       attackcriticalrate = Convert.ToDouble(randomglobal.Next(1, 100).ToString());
       attackcriticalrate = (attackcriticalrate / 100) + 1;
       Console.WriteLine("{0:0.00}", attackcriticalrate);
       if (attackcriticalrate >= 1.5)
       {
           Console.WriteLine("lucky Critical Hits! ");
       }
       else
       {
           Console.WriteLine("unlucky Critical Hits!");
       }
          
           
       }
    }


}
    
       



