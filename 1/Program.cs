using System;
using System.Collections.Generic;

namespace _1
{
    public class Apple : IComparable<Apple>
    {

        private double weight;
        private string color;
        public int CompareTo(Apple A)
        {
            if (this.Weight < A.Weight)
                return -1;
            else if (this.Weight == A.Weight)
                return 0;
            else
                return 1;
        }

        public double Weight
        {
            get
            {
                return weight;
            }
            set
            {
                if (value <= 0 || value > 1000)
                {
                    throw new ArgumentException("Incorrect input");
                }
                weight = value;
            }
        }
        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                if ((value[1] >= 'A' && value[1] <= 'Z') || value.Length > 5)
                {
                    throw new ArgumentException("Incorrect input");
                }
                color = value;
            }
        }

        public override string ToString()
        {
            return $"{color} Apple. Weight = {weight:f2}g.";
        }
    }
    public class Worker
    {

        Apple[] arr;
        public Worker(Apple[] apples)
        {
            Array.Sort(apples);
            arr = apples;
        }

        public Apple[] GetSortedApples()
        {
            return arr;
        }
    }

    static class Program
        {
            private static void Main(string[] args)
            {
                int N = int.Parse(Console.ReadLine());
                var apples = new List<Apple>(N);

                for (int i = 0; i < N; i++)
                {
                    var words = Console.ReadLine().Split(' ');
                    try
                    {
                        apples.Add(new Apple()
                        {
                            Weight = double.Parse(words[0]),
                            Color = words[1]
                        });
                    }
                    catch (ArgumentException argumentException)
                    {
                        Console.WriteLine(argumentException.Message);
                    }
                }

                var worker = new Worker(apples.ToArray());

                foreach (var sortedApple in worker.GetSortedApples())
                {
                    Console.WriteLine(sortedApple);
                }
            }
        }
    
}
