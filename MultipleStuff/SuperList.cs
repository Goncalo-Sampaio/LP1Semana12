using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleStuff
{
    /// <summary>
    /// Class with multiple methods to return the minimum and the maximum of a
    /// list of doubles
    /// </summary>
    public class SuperList : List<double>
    {
        /// <summary>
        /// Internal class with Min and Max doubles
        /// </summary>
        public class MinMax
        {
            public double Min { get; set;}
            public double Max { get; set;}
            public MinMax(double min, double max){
                Min = min;
                Max = max;
            }
        }

        /// <summary>
        /// Method 1 of returning multiple values: uses out
        /// </summary>
        /// <param name="list"></param>
        /// <param name="minimum"></param>
        /// <returns></returns>
        public double GetMinMax1(List<double> list, out double minimum)
        {
            minimum = list[0];
            double maximum = list[0];
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] < minimum)
                {
                    minimum = list[i];
                }
            }
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] > maximum)
                {
                    maximum = list[i];
                }
            }
            return maximum;
        }

        /// <summary>
        /// Method 2 of returning multiple values: returns an internal struct
        /// with the needed values as instance variables
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public MinMax GetMinMax2(List<double> list)
        {
            double minimum = list[0];
            double maximum = list[0];
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] < minimum)
                {
                    minimum = list[i];
                }
            }
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] > maximum)
                {
                    maximum = list[i];
                }
            }

            return new MinMax(minimum, maximum);
        }

        /// <summary>
        /// Method 3 of returning multiple values: returns a reference tuple
        /// with the needed values
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public Tuple<double, double> GetMinMax3(List<double> list)
        {
            double minimum = list[0];
            double maximum = list[0];
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] < minimum)
                {
                    minimum = list[i];
                }
            }
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] > maximum)
                {
                    maximum = list[i];
                }
            }

            return new Tuple<double, double>(minimum,maximum);
        }

        /// <summary>
        /// Method 4 of returning multiple values: returns a value tuple
        /// with the needed values
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public (double Min, double Max) GetMinMax4(List<double> list)
        {
            double minimum = list[0];
            double maximum = list[0];
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] < minimum)
                {
                    minimum = list[i];
                }
            }
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] > maximum)
                {
                    maximum = list[i];
                }
            }

            return (minimum,maximum);
        }
    }
}