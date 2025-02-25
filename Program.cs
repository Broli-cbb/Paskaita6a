using System;
using System.Linq;
using Microsoft.VisualBasic;

namespace Ciklai

{
    public class Program

    {

        public static void Main()

        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            int[] masyvas = { a, b, c, d, e };
//crumbles with big data

            Console.WriteLine("Vidurkis yra: " + CalculateAverage(masyvas));
            int max = masyvas.Max();
            Console.WriteLine("Didziausia reiksme yra: " + max);
            int min = masyvas.Min();
            Console.WriteLine("Didziausia reiksme yra: " + min);
//bit of a cheat
            if (CalculateAverage(masyvas)<5)
            {
                Console.WriteLine("Grupes pazymiai prasti");
            }
            
            if (CalculateAverage(masyvas) >= 5 && CalculateAverage(masyvas)< 8)
            {
                Console.WriteLine("Grupes pazymiai geri");
            }
            
            if (CalculateAverage(masyvas) >= 8)
            {
                Console.WriteLine("Grupes pazymiai puikus");
            }
        }

        public static double CalculateAverage(int[] numbers)

        {

            double sum = 0;

            for(int i = 0; i < numbers.Length; i++)

            {

                sum += numbers[i];

            }

            double average = sum / numbers.Length;



            return average;

        }
        
    }

}