using System;
using System.Collections.Generic;

namespace MethodsScratchpad
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int x = 1;

            // DoSomething(x);
            int y = x;
            // public static DoSomething(int y)
            // {
            y = 72;

            // }

            Console.WriteLine(x);   // Still prints 1. int is a value type, and also we didn't mutate it.


            List<int> listX = new List<int> { 1, 3, 5, 7 };

            List<int> listY = listX;

            listY = new List<int> { 90, 80 };    // ASSIGNMENT

            Console.WriteLine(listX[0]);   // Still prints 1. Did not mutate.



            List<int> listP = new List<int> { 1, 3, 5, 7 };
            List<int> listQ = listP;

            listQ[0] = 90;  // MUTATION! Same List, but changed something that is held *inside* the List.

            Console.WriteLine(listP[0]);    // Prints 90!




            int a = 1;
            //int b = a;

            //b = 2;
            //Console.WriteLine(a);
            //Console.WriteLine(b);


            List<int> listA = new List<int> { 1, 2, 3, 4, 5 };
            List<int> listB = listA;

            //listB = new List<int> { 5, 4, 3, 2, 1 };

            listB[0] = 7;

            Console.WriteLine(listA[0]);
            Console.WriteLine(listB[0]);

            int n = 50;
            DoSomething(n);
            Console.WriteLine(n);
            DoSomethingWithRefInt(ref n);
            Console.WriteLine(n);

            List<int> reassignedList = new List<int> { 9, 8, 7, 6 };
            ReassignList(reassignedList);

            MutateList(reassignedList);

            int myNewInteger;
            DoSomethingWithOutInt(out myNewInteger);
            Console.WriteLine(myNewInteger);


            GreetUser("Eric");
            GreetUser("Jess");
            GreetUser("Damon");
            GreetUser("Andres", "Welcome");
            GreetUser();



            Console.ReadKey();
        }


        public static void GreetUser(string user = "Gilbert Godfrey", string greeting = "Hello", int repeatCount = 1, string extraInfo = "")
        {
            Console.WriteLine(greeting + ", " + user + "!");
        }


        public static void DoSomething(int n)
        {
            // Change does not persist after return because:
            // A:   int is a value type, so n is a COPY of the
            //      value from the caller's scope.
            // B:   Assigning a new value, not mutating.
            n = n * 2;
        }

        public static void DoSomething(double n)
        {
            Console.WriteLine(n);
        }

        public static void ReassignList(List<int> list)
        {
            // Change does not persist after return because
            // we're assigning a new value, not mutating
            // (even though List is a reference type, so
            // list originally is a reference to the same
            // List from the caller's scope)
            list = new List<int> { 2, 4, 6, 8 };
        }

        public static void MutateList(List<int> list)
        {
            // Change persists because:
            // A:   List is a reference type, so list is a
            //      reference to the same List from the caller's
            //      scope. AND
            // B:   Mutating the actual List, not reassigning
            //      a different List into the list variable.
            list.Clear();
            list.Add(2);
            list.Add(4);
            list.Add(6);
            list.Add(8);
        }



        public static void DoSomethingWithRefInt(ref int i)
        {
            i *= 2;
        }

        public static void DoSomethingWithOutInt(out int i)
        {
            i = 97;
        }
    }
}
