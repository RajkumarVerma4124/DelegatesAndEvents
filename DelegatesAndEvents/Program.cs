using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    // Delegate Definition  
    public delegate int Operations(int x, int y);
    public delegate void DelEventHandler();

    class Program
    {
        public static event DelEventHandler add;

        // Method that is passes as an Argument and it has same signature as Delegates  
        static int Addition(int a, int b)
        {
            return a + b;
        }
        public static void Main(string[] args)
        {
            // Delegate instantiation  
            Operations obj = new Operations(Addition);

            // Output  
            Console.WriteLine("Addition of number is {0}",obj(23, 27));
            Console.ReadLine();

            //MultiCast Delegate implmentation
            ArrayDelegates.ImplementDelegateUsingArray();
            ArrayDelegates.ImplementDelegate();

            //Events
            add += new DelEventHandler(USA);
            add += new DelEventHandler(India);
            add += new DelEventHandler(England);
            add.Invoke();
            Console.WriteLine("*************Event Handling****************");
            EventHandling.EventImplementation();
            Console.ReadLine();
        }

        static void USA()
        {
            Console.WriteLine("USA");
        }

        static void India()
        {
            Console.WriteLine("India");
        }

        static void England()
        {
            Console.WriteLine("England");
        }
    }
}
