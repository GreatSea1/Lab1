using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_1_Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Number, RightPart, Digit, NewNumber;

            Console.Write("Type a Number ");
            Number = Console.ReadLine();

            RightPart = Number.Substring(2, Number.Length - 2);
            Digit = Number.Substring(1, (Number.Length - (Number.Length - 1)));
            NewNumber = RightPart + Digit;

            Console.WriteLine("Right Part of the Number is '{0}' ", RightPart);
            Console.WriteLine("Second Digit of the Number is '{0}' ", Digit);
            Console.WriteLine("New Number is '{0}' ", NewNumber);

            Console.ReadKey();
        }
    }
}
