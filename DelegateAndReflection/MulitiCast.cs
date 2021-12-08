using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateAndReflection
{
    delegate void MultiDelegate();
   public class MulitiCast
    {
        static public void Display()
        {
            Console.WriteLine("MulitiCast => Display Method ");
        }
        static public void Display1()
        {
            Console.WriteLine("MulitiCast => Display Method 1");
        }
        static public void Display2()
        {
            Console.WriteLine("MulitiCast => Display Method 2");
        }
        static public void Display3()
        {
            Console.WriteLine("MulitiCast => Display Method 3");
        }
    }
}
