using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    public class EventHandling
    {
        public delegate void EventHandler(string a);

        public class EventOperation
        {
            public event EventHandler xyz;

            public void Action(string a)
            {
                if (xyz != null)
                {
                    xyz(a);
                    Console.WriteLine(a);
                }
                else
                {
                    Console.WriteLine("Not Registered");
                }
            }
        }

        private static void CatchEvent(string s)
        {
            Console.WriteLine("Method Calling");
        }

        public static void EventImplementation()
        {
            EventOperation o = new EventOperation();

            o.Action("Event Calling");
            o.xyz += new EventHandler(CatchEvent);

            Console.ReadLine();
        }
    }
}
