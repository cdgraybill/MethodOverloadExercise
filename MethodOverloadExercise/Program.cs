using System;

namespace MethodOverloadExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var cost = Add(0, 1, true);
            Console.WriteLine(cost);
            Console.ReadLine();
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static decimal Add(decimal a, decimal b)
        {
            return a + b;
        }

        public static string Add(int a, int b, bool x)
        {
            int answer = a + b;
            if (x && answer > 1)
            {
                return $"{answer} dollars";
            }

            if (x && answer == 1)
            {
                return $"{answer} dollar";
            }

            return "";
        }
    }
}
