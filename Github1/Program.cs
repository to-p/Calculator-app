using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Github1
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstnum;
            double secondnum;
            double answer;
            string ops;

            Console.WriteLine("___________________________________");
            Console.WriteLine("|                                 |");
            Console.WriteLine("|           Aditya Wijaya         |");
            Console.WriteLine("|_________________________________|");

            Console.WriteLine("\t\t\tAplikasi Calculator  C#\r");
            Console.WriteLine("\t\t\t-------------------------\r");
            Console.WriteLine("\t\t\tkalkulator console\n");

            Console.WriteLine("\t\t\tEnter first number\n");
            firstnum = Double.Parse(Console.ReadLine());

            Console.WriteLine("\t\t\tSelect an operator: (+, -, *, /, %,)\n");
            ops = Console.ReadLine();

            Console.WriteLine("\t\t\tEnter second number\n");
            secondnum = Double.Parse("\t\t\t" + Console.ReadLine());

            if (ops == "+")
            {
                answer = firstnum + secondnum;
                Console.Write("\n" + answer);
            }
            else if (ops == "-")
            {
                answer = firstnum - secondnum;
                Console.Write("\n" + answer);
            }
            else if (ops == "*")
            {
                answer = firstnum * secondnum;
                Console.Write("\n" + answer);
            }
            else if (ops == "/")
            {
                answer = firstnum / secondnum;
                Console.Write("\n" + answer);
            }
            else if (ops == "%")
            {
                answer = firstnum % secondnum;
                Console.Write("\n" + answer);
            }
            {
                answer = firstnum % secondnum;
                Console.Write("\n" + answer);
            }
            Console.Write("\n" + "\t\t\t\t\t\t\t\tPress any key to exit>>>\n");
            Console.ReadKey();
        }

    }
}
