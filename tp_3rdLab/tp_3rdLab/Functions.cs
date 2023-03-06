using System;
using Microsoft.Win32;

namespace tp_3rdLab
{
    public class Functions
    {
        private double tangenc(double x)
        {
            return Math.Tan(1.0 / x);
        }

        private double ln(double x)
        {
            return Math.Log(4.0 / (9.0 - Math.Pow(x, 3)));
        }

        private double sh(double x)
        {
            return Math.Sinh(Math.Log10(10.0 - Math.Pow(x, 3)));
        }

        private double Func4(double x)
        {
            var result = 0.0;
            var i = 1;
            while (i <= 1000000)
            {
                result += 1.0 / (x + Math.Sqrt(i));
                i++;
            }

            return result;
        }

        public double calculate_FXi(double begin, double end, int pointNumbers)
        {
            double step = Math.Abs((begin - end) / pointNumbers), counter = 0.0;
            var func_array = new double[pointNumbers + 1];
            var i = 0;
            var result = 0.0;
            while (counter < end)
            {
                counter = begin + step * i;
                func_array[i] = tangenc(counter) + ln(counter) + sh(counter) + sh(counter) + Func4(counter);
                i++;
            }

            result = return_result(func_array);
            return result;
        }

        private double return_result(double[] array)
        {
            var myResult = 0.0;
            foreach (int i in array)
            {
                myResult += i;
            }

            return myResult;
        }
    }
}