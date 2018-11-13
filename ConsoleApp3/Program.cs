using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write n to find the sum of the first n fibonacci sequence");
            Functions functions = new Functions();
            String input = Console.ReadLine();
            int element;
            bool checkInt = false;

            do
            {
                try
                {
                    int test = int.Parse(input);
                    checkInt = true;
                }
                catch (System.FormatException ex)
                {
                    Console.WriteLine("Please enter an integer");
                    input = Console.ReadLine();
                }
            } while (checkInt == false);

            element = int.Parse(input);

            var firstNEven = new List<int>();

            for (int i = 0; firstNEven.Count<element; i++)
            {               
                if (functions.fib(i)%2 == 0)
                {
                    firstNEven.Add(functions.fib(i)); 
                } 
            }

           int sum = 0;
            for (int i = 0; i < firstNEven.Count; i++)
            {
                int next = firstNEven[i];
                sum = sum + next;
            }
            Console.WriteLine("sum = " + sum);            
        }

        class Functions
        {
            public int fib(int input)
            {
                var nToReturn = -99999; // obvious if carried through
                int x = 0;
                int y = 1;
                int counter = input - 1;

                if (input == 0)
                {
                    return 0;
                }
                else if (input  == 1)
                {
                    return 1;
                }
                else
                {
                    for (int j = 0; j < counter; j++)
                    {
                        nToReturn = y + x;
                        x = y;
                        y = nToReturn;
                    }
                    return nToReturn;
                }
            }
        }
    }
}

