using System;

namespace Unit_7._5
{
    class Obj
    {
        public string Name;
        public string Description;
        public static string Parent;
        public static int DaysInWeek;
        public static int MaxValue;

        static Obj()
        {
            Parent = "System.Object";
            DaysInWeek = 7;
            MaxValue = 2000;
        }
    }
    class Helper
    {
        public static void Swap(ref int a, ref int b)
        {
            int c = a;
            a = b;
            b = c;
        }
    }
    static class IntExtensions
    {
        public static int GetNegative(this int a)
        {
            if (a > 0)
            {
                return -a;
            }
            else
            {
                return a;
            }
        }
        public static int GetPositive(this int b)
        {
            if (b < 0)
            {
                return -b;
            }
            else
            {
                return b;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 3;
            int num2 = 58;
            Helper.Swap(ref num1, ref num2);
            Console.WriteLine(num1);
            Console.WriteLine(num2);

            int num3 = 7;
            int num4 = -13;
            int num5 = 0;

            Console.WriteLine(num3.GetNegative());
            Console.WriteLine(num3.GetPositive());
            Console.WriteLine(num4.GetNegative());
            Console.WriteLine(num4.GetPositive());
            Console.WriteLine(num5.GetNegative());
            Console.WriteLine(num5.GetPositive());
        }
    }
}
