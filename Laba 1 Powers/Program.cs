using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_1_Powers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Number; int Power;

            Console.WriteLine("Type a Number ");
            Number = Convert.ToInt32(Console.ReadLine());
            int Result = Number;

            Console.WriteLine("Type a Power ");
            Power = Convert.ToInt32(Console.ReadLine());

            for (int CountPower = 1; CountPower < Power; ++CountPower)
            {
                Result = Result * Number;
            }
            Console.WriteLine("Result is " + Result);
            Console.ReadKey();
        }
    }
}
