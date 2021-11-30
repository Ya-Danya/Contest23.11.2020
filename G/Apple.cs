using System;
using System.Collections.Generic;
using System.Text;


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
                if (!(value[0] >= 'A' && value[0] <= 'Z') || value.Length > 5)
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
