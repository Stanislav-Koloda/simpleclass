using System;

namespace ArrayOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayProcessor arrayProcessor = new ArrayProcessor();

            int[] userInputArray = arrayProcessor.GetUserInputArray();
            int arrayLength = arrayProcessor.CalculateArrayLength(userInputArray);

            Console.WriteLine($"The length of the entered array is: {arrayLength}");
        }
    }

    public class ArrayProcessor
    {
        public int[] GetUserInputArray()
        {
            Console.WriteLine("Enter the length of the array:");
            int length;
            while (!int.TryParse(Console.ReadLine(), out length) || length <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive integer:");
            }

            int[] array = new int[length];
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine($"Enter element {i + 1}:");
                while (!int.TryParse(Console.ReadLine(), out array[i]))
                {
                    Console.WriteLine("Invalid input. Please enter an integer:");
                }
            }

            return array;
        }

        public int CalculateArrayLength(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array), "Array cannot be null");
            }

            return array.Length;
        }
    }
}
