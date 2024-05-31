using System;
using System.Collections.Generic;

namespace MultipleStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> doubles= new List<double>() {123, 0, -5, 1231234, 50};
            SuperList superList = new SuperList();

            double min;
            double max = superList.GetMinMax1(doubles, out min);
            Console.WriteLine(min);
            Console.WriteLine(max);
        }
    }
}
