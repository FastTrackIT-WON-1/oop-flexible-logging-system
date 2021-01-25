using LoggingSystem.Loggers;
using System;

namespace LoggingSystem.Consumer
{
    public static class ConsoleHelper
    {
        public static int[] ReadVector()
        {
            Console.Write("Please enter vector size=");
            string size = Console.ReadLine();

            if (!int.TryParse(size, out int result))
            {
                ApplicationLogger.WriteLog(LogLevel.Warning, "Read string is not a number");
                return new int[0];
            }

            if (result <= 0)
            {
                ApplicationLogger.WriteLog(LogLevel.Warning, "Read number is negative or zero");

                return new int[0];
            }

            int[] array = new int[result];

            for (int i = 0; i < result; i++)
            {
                Console.Write($"Element[{i}]=");
                string element = Console.ReadLine();
                if (!int.TryParse(element, out int elementValue))
                {
                    ApplicationLogger.WriteLog(LogLevel.Warning, "Read string is not a number");
                }

                if (result < 0)
                {
                    ApplicationLogger.WriteLog(LogLevel.Warning, "Read number is negative");
                    result = 0;
                }

                array[i] = elementValue;
            }

            return array;
        }

        public static void PrintVector(int[] array)
        {
            if (array is null)
            {
                ApplicationLogger.WriteLog(LogLevel.Warning, "Array is null");
                return;
            }

            if (array.Length == 0)
            {
                ApplicationLogger.WriteLog(LogLevel.Warning, "Array is empty");
                return;
            }

            string elementsList = string.Join(", ", array);

            Console.WriteLine($"Array=[{elementsList}]");
        }
    }
}
