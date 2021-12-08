using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateAndReflection
{
    public delegate string myDelegates(string FirstName, string LastName);
    public class SingleCast
    {
        public static string UserName(string FirstName, string LastName)
        {
            return FirstName + " " + LastName + "";
        }
    }
}
