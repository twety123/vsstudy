using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace suggest7_枚举
{
    class Program
    {
        static void Main(string[] args)
        {
            Days aa = Days.Saturday;
            Colors bb = Colors.Black;
            Console.WriteLine(Days.Saturday.ToString());
            Console.ReadLine();
        }
    }

    enum Days
    {
        Saturday = 1, Sunday, Monday, Tuesday
    }

    enum Colors
    {
        Red = 'a', White = 'b', Black = 'c', Yellow = 'd'
    }
}
