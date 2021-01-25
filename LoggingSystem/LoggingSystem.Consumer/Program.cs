using System;

namespace LoggingSystem.Consumer
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = ConsoleHelper.ReadVector();

            ConsoleHelper.PrintVector(array);
        }
    }
}
