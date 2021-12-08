using System;
using CalculatorFn;

namespace DelegateAndReflection
{
    public static class ThoreyAns
    {
        public static void Q1()
        {
            Console.WriteLine("1. What is a Delegate in C#?");
            Console.WriteLine("\t- A delegate in C# is similar to a function pointer in C or C++.\n\t- It's a new type of object in C#.\n\t" +
                              "- Delegate is very special type of object as earlier the entire the object we used to defined contained data\n\t" +
                              "  but delegate just contains the details of a method.");
        }
        public static void Q2()
        {
            Console.WriteLine("2. Why do we need delegates in C#?");
            Console.WriteLine("\t- A delegate is a class that encapsulates a method signature.\n\t" +
                              "- Example :-public delegate int DelegateMethod(int x, int y);\n\t" +
                              "- Any method that matches the delegate's signature, which consists of the return type and parameters,.\n\t" +
                              "  can be assigned to the delegate.");
        }
        public static void Q3()
        {
            Console.WriteLine("3. What are the benefits of delegates?");
            Console.WriteLine("\t- Delegates are object oriented and type-safe and very secure.\n\t" +
                              "- Delegates makes event handling simple and easy.");

        }
        public static void Q4()
        {
            Console.WriteLine("4. What are types of delegates in C#?");
            Console.WriteLine("\t- i)singlecast\n" +
                              "\t- ii)multiplecast");

        }
        public static void Q5()
        {
            Console.WriteLine("5. How to define a delegates in C#?");
            Console.WriteLine("\t-  i) Declaration    : [attributes] [modifiers] delegate ReturnType Name ([formal-parameters]);  \n" +
                              "\t      Example        : public delegate void DelegateExample(); \n" +
                              "\t- ii) Instantiation  : DelegateExample d1 = new DelegateExample(Display);\n" +
                              "\t iii) Invocation     : d1();  ");

        }
        public static void Q6()
        {
            Console.WriteLine("6. What is a Singlecast delegate in C#?");
            Console.WriteLine("\t- Delegate that can refer to single method at one time");
       
            SingleCast singleCast = new SingleCast();
            myDelegates myDelegates = new myDelegates(SingleCast.UserName);
            
            Console.WriteLine("Single Cast Delegate  : {0}", myDelegates("Omkar", "Pawar"));
        }
        public static void Q7()
        {
            Console.WriteLine("7. What is a Multicast delegate in C#? ");
            Console.WriteLine("\t- Delegate that can refer to multiple method");
          
            MultiDelegate multiDelegate = new MultiDelegate(MulitiCast.Display);
            MultiDelegate multiDelegate1 = new MultiDelegate(MulitiCast.Display1);
            MultiDelegate multiDelegate2 = new MultiDelegate(MulitiCast.Display2);
            MultiDelegate multiDelegate3 = new MultiDelegate(MulitiCast.Display3);
           
            multiDelegate = multiDelegate2 + multiDelegate3;
          
            multiDelegate();
            multiDelegate1();
            multiDelegate2();
            multiDelegate3();
        }
        delegate void NumberChanger(int n);
        public static void Q8()
        {
            Console.WriteLine("8. What are Anonymous Delegates in C#? ");
            Console.WriteLine("\t- An anonymous method is a method without a name");
            
            NumberChanger nc = delegate (int x) {
                Console.WriteLine("Anonymous Method: {0}", x);
            };
           
            nc(10);
        }
        public static void Q9()
        {
            Console.WriteLine("9. How to Use Events and Delegates in C#? ");
            Console.WriteLine("\t- when an event is raised, a delegate is called");
           
            EventsandDelegates eventsandDelegates = new EventsandDelegates();
           
            //register for OnChange event - Subscriber 1
            eventsandDelegates.OnChange += () => Console.WriteLine("Events and Delegates => Subscriber 1!");
            
            //register for OnChange event - Subscriber 2
            eventsandDelegates.OnChange += () => Console.WriteLine("Events and Delegates => Subscriber 2!");
            
            //raise the event
            eventsandDelegates.Raise();
        }
        public static void Q10()
        {
            Console.WriteLine("10. How to Use Events and Delegates in C#? ");
            Console.WriteLine("\t- Describing the metadata of types, methods and fields in a code");
           
            Type t = typeof(FnClassLibrary);
            ReflectionExample.GetMethods(t);
        }
    }	 
}
