using System;
using System.Collections.Generic;

namespace C
{
    public class RegularPolygon : Polygon
    {
        public double Side;
        public int NumberOfSides;
        public RegularPolygon(double side, int numberOfSides)
        {
            
            if (side <= 0 && numberOfSides <= 0)
            {
                throw new ArgumentException("Input parameters should be greater than zero.");
            }
            else if (side <= 0)
            {
                throw new ArgumentException("Side length value should be greater than zero.");
            }
            else if (numberOfSides <= 3)
            {
                throw new ArgumentException("Number of sides value should be greater than 3.");
            }
            else
            {
                Side = side;
                NumberOfSides = numberOfSides;
            }
            
        }

        public override double Perimeter => Side * NumberOfSides;

        public override double Area => Side*Side* NumberOfSides/ (4 * Math.Tan(Math.PI / NumberOfSides)) ;

        public override string ToString() => $"side: {Side}; numberOfSides: {NumberOfSides}; area: {Area:f3}; perimeter: {Perimeter:f3}"; 
    }

    public class Polygon
    {
        private double area;

        private double perimeter;

        public virtual double Area => area;

        public virtual double Perimeter => perimeter;

        protected Polygon()
        {

        }

        public Polygon(double area, double perimeter)
        {
            if (area <= 0 || perimeter <= 0)
            {
                throw new ArgumentException("Input parameters should be greater than zero.");
            }

            this.area = area;
            this.perimeter = perimeter;
        }

        public override string ToString() => $"area: {Area:f3}; perimeter: {Perimeter:f3}";
    }


    class Program
    {
        private static IEnumerable<Polygon> ReadPolygons()
        {
            string input;

            var polygons = new List<Polygon>();

            while (!string.IsNullOrEmpty(input = Console.ReadLine()))
            {
                string[] parameters = input.Split(' ');

                if (string.Equals(parameters[0], "P"))
                {
                    try
                    {
                        polygons.Add(new Polygon(double.Parse(parameters[1]), double.Parse(parameters[2])));
                    }
                    catch (ArgumentException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                else if (string.Equals(parameters[0], "RP"))
                {
                    try
                    {
                        polygons.Add(new RegularPolygon(double.Parse(parameters[1]), int.Parse(parameters[2])));
                    }
                    catch (ArgumentException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }

            return polygons;
        }

        public static void Main(string[] args)
        {
            var polygons = ReadPolygons();

            foreach (var polygon in polygons)
            {
                Console.WriteLine(polygon);
            }
        }
    }
}
