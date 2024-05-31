using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleStuff
{
    public class SuperList : List<double>
    {
        public class MinMax
        {
            public double Min { get; set;}
            public double Max { get; set;}
            public MinMax(double min, double max){
                Min = min;
                Max = max;
            }
        }

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

        GetMinMax3()
        {

        }
        GetMinMax4()
        {

        }
    }
}