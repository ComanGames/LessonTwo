using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            SomeNewMethod();
            SomeNewMethod();
        }

        private static void SomeNewMethod()
        {
            Console.WriteLine("Hello Yura   ");
            Console.WriteLine("Hello Sasha");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("hello");
            }
        }
    }
}
