using System;

namespace task1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string surname = Console.ReadLine();
            Console.WriteLine("Hola " + surname);
            string[] weatherArr = ["rainy", "cloudy", "sunny", "bad", "good"];
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

        public int CalculateMax(int[] values)
        {
            int max =  values[0];
            foreach (int val in values)
            {
                if (val > max)
                {
                    max = val;
                }
            }
            return max;
        }
        
        public int CalculateMin(int[] values)
        {
            int min =  values[0];
            foreach (int val in values)
            {
                if (val < min)
                {
                    min = val;
                }
            }
            return min;
        }
    }
}