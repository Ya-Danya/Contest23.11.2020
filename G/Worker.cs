using System;
using System.Collections.Generic;
using System.Text;


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

