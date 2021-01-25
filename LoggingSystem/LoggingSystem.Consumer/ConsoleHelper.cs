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
                // TODO: Log error: read string is not a number
                return new int[0];
            }

            if (result <= 0)
            {
                // TODO: Log error: number is negative or zero
                return new int[0];
            }

            int[] array = new int[result];

            for (int i = 0; i < result; i++)
            {
                Console.Write($"Element[{i}]=");
                string element = Console.ReadLine();
                if (!int.TryParse(element, out int elementValue))
                {
                    // TODO: Log error: read string is not a number
                }

                if (result < 0)
                {
                    // TODO: Log error: number is negative
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
                // TODO: Log error: array is null;
                return;
            }

            if (array.Length == 0)
            {
                // TODO: Log error: array is empty;
                return;
            }

            string elementsList = string.Join(", ", array);

            Console.WriteLine($"Array=[{elementsList}]");
        }
    }
}
