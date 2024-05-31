using System;
using System.Collections.Generic;

namespace MultipleStuff
{
    /// <summary>
    /// Main class for MultipleStuff project
    /// </summary>
    class Program
    {
        /// <summary>
        /// Main method of the project. Initializes a new double list and
        /// instantiates a SuperList
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            List<double> doubles= new List<double>() {123, 0, -5, 1231234, 50};
            SuperList superList = new SuperList();

            //Using out to return multiple values
            double min;
            double max = superList.GetMinMax1(doubles, out min);
            Console.WriteLine(min);
            Console.WriteLine(max);

            //Using a struct to return multiple values
            Console.WriteLine(superList.GetMinMax2(doubles).Min);
            Console.WriteLine(superList.GetMinMax2(doubles).Max);

            //Using a reference tuple to return multiple values
            Console.WriteLine(superList.GetMinMax3(doubles).Item1);
            Console.WriteLine(superList.GetMinMax3(doubles).Item2);

            //Using a value tuple to return multiple values
            Console.WriteLine(superList.GetMinMax4(doubles).Min);
            Console.WriteLine(superList.GetMinMax4(doubles).Max);
        }
    }
}
