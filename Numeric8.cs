using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Numeric8
    {
        public static int From8To10(string num)
        {
            int result = 0;
            int exp = 1;
            bool negative = num[0] == '-';
            for (int i = num.Length - 1; i >= (negative ? 1 : 0); i--)
                if (num[i] >= '0' && num[i] <= '7')
                {
                    result += (num[i] - '0') * exp;
                    exp *= 8;
                }
                else
                    throw new ArgumentException();
            if (negative)
                result = -result;
            return result;
        }

        public static string From10To8(int num)
        {
            string result = "";
            bool negative = num < 0;
            num = Math.Abs(num);
            while (num != 0)
            {
                result = result.Insert(0, (num % 8).ToString());
                num /= 8;
            }
            if (result == "")
                result = "0";
            if (negative)
                result = result.Insert(0, "-");
            return result;
        }

        public static string Sum(int a, int b)
        {
            return From10To8(a + b);
        }

        public static string Sum(string a, string b)
        {
            return From10To8(From8To10(a) + From8To10(b));
        }

        public static string Sum(string a, int b)
        {
            return From10To8(From8To10(a) + b);
        }

        public static string Sum(int a, string b)
        {
            return From10To8(a + From8To10(b));
        }

        public static string Sub(int a, int b)
        {
            return From10To8(a - b);
        }

        public static string Sub(string a, string b)
        {
            return From10To8(From8To10(a) - From8To10(b));
        }

        public static string Sub(string a, int b)
        {
            return From10To8(From8To10(a) - b);
        }

        public static string Sub(int a, string b)
        {
            return From10To8(a - From8To10(b));
        }

        public static string And(int a, int b)
        {
            if (a < 0 || b < 0)
                throw new ArithmeticException();
            return From10To8(a & b);
        }

        public static string And(string a, string b)
        {
            int ch1 = From8To10(a);
            int ch2 = From8To10(b);
            if (ch1 < 0 || ch2 < 0)
                throw new ArithmeticException();
            return From10To8(ch1 & ch2);
        }

        public static string And(string a, int b)
        {
            int ch1 = From8To10(a);
            if (ch1 < 0 || b < 0)
                throw new ArithmeticException();
            return From10To8(ch1 & b);
        }

        public static string And(int a, string b)
        {
            int ch2 = From8To10(b);
            if (a < 0 || ch2 < 0)
                throw new ArithmeticException();
            return From10To8(a & ch2);
        }

        public static string Or(int a, int b)
        {
            if (a < 0 || b < 0)
                throw new ArithmeticException();
            return From10To8(a | b);
        }

        public static string Or(string a, string b)
        {
            int ch1 = From8To10(a);
            int ch2 = From8To10(b);
            if (ch1 < 0 || ch2 < 0)
                throw new ArithmeticException();
            return From10To8(ch1 | ch2);
        }

        public static string Or(string a, int b)
        {
            int ch1 = From8To10(a);
            if (ch1 < 0 || b < 0)
                throw new ArithmeticException();
            return From10To8(ch1 | b);
        }

        public static string Or(int a, string b)
        {
            int ch2 = From8To10(b);
            if (a < 0 || ch2 < 0)
                throw new ArithmeticException();
            return From10To8(a | ch2);
        }
    }
}
