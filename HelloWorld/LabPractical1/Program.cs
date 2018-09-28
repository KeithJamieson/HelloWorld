using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabPractical1
{
    class Program
    {
        static void Main(string[] args)
        {
            int myNumber = 0;
            Console.WriteLine($"Please enter an integer number");
            myNumber = Convert.ToInt32 ( Console.ReadLine());
            Console.WriteLine($"The number entered was {myNumber} ");
            Console.ReadKey();
        }
    }
}
