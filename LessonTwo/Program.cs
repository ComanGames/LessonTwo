using System;

namespace LessonTwo
{
    class Program
    {
        static void Main()
        {
            FirstAboutVariables();
            Console.ReadKey();
        }

        private static void FirstAboutVariables()
        {
            int x = 5;
            float y = 5.3f;
            char c = 'c';
            string s = "Hello";
            c = s[0];
            Console.WriteLine(c);
            c = s[1];
            Console.WriteLine(c);
            c = s[2];
            Console.WriteLine(c);
            c = s[3];
            Console.WriteLine(c);
        }
    }
}
