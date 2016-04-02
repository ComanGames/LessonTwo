using System;
namespace LessonTwo
{

    class Program
    {
        static void Main()
        {
            //  a=5;
            // a== 5 ;
            //(ture)&&(false) == false;
            bool b = true; // and 
            bool d = false;
            int x = 5;
            double y = 5.0;
            Console.WriteLine( (b==d)||((b&&d)&&(b==true)));
            //a!=b  Are not equals !(a==b)
            //== are equals
            //true false &&  false
            //false false &&  false
            //false true &&  false
            //true true &&  false
            //true || false  true
            //false || true  true
            //true || true true 
            //false || false false
            
//            Console.WriteLine(b);
//
//            Console.WriteLine(5.0.GetType());

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

namespace MyNamespace
{
    public static class Math
{
        public static void SomeOperation()
        {
            
        } 
}
    public static class Console
    {
        public static int MathOperation(int x, int y)
        {
            return x + y;
        }

        public static void WriteLine(char type)
        {
            System.Console.Write("It is done by Yura");
            System.Console.WriteLine(type.ToString());
            
        }

        internal static void WriteLine(Type type)
        {
            System.Console.Write("It is done by Yura");
            System.Console.WriteLine(type.ToString());

        }

        public static void ReadKey()
        {
            System.Console.ReadKey();
        }
    }

}
