using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace DelegateAndReflection
{
    public static class ReflectionExample
    {
        // Display method names of type.  
        public static void GetMethods(Type t)
        {
            MethodInfo[] mi = t.GetMethods();
            foreach (MethodInfo m in mi)
            {
                Console.Write("\nMethod Name : {0}", m.Name);
                Console.Write("\t\tIs Pubilc : {0}", m.IsPublic);
            }
        }
    }
}
