using System;

namespace MethodsRefOut2
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int value = 0;
            SetValue(3, ref value);
            Console.WriteLine(value);
        }

        static void SetValue (int newValue, ref int value)
        {
            value = newValue;
        }
    }
}
