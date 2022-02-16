using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    public class Operation
    {
        //Method for adding and multiplying two numbers
        public static void Add(int a, int b)
        {
            Console.WriteLine("Addition of two given number is : {0}", a + b);
        }

        public static void Multiply(int a, int b)
        {
            Console.WriteLine("Multiplication of two given number is : {0}", a * b);
        }
    }

    public class ArrayDelegates
    {
        public delegate void DelOp(int x, int y);

        public static void ImplementDelegateUsingArray()
        {
            // Delegate instantiation  
            DelOp[] obj =
           {
               new DelOp(Operation.Add),
               new DelOp(Operation.Multiply)
           };

            for (int i = 0; i < obj.Length; i++)
            {
                obj[i](2, 5);
                obj[i](8, 5);
                obj[i](4, 6);
            }
            Console.ReadLine();
        }

        public static void ImplementDelegate()
        {
            // Delegate instantiation  
            DelOp newObj = Operation.Add;
            newObj += Operation.Multiply;

            newObj(2,8);
            newObj(8,5);

            Console.ReadLine();
        }
    }
}
