using System;

namespace task1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Console.WriteLine("Hola " + name);
            string[] weatherArr = ["rainy", "cloudy", "sunny"];
            Console.WriteLine("It's currently " + weatherArr[new Random().Next(0, weatherArr.Length)]);
        }

        public float CalculateAverage(int[] values)
        {
            if (values.Length == 0)
            {
                return 0;
            }
            float sum = 0;
            foreach (int val in values)
            {
                sum += val;
            }
            return sum / values.Length;
        }
    }
}