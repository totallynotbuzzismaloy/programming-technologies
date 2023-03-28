using System;

namespace tp_5Lab
{
    public class myFuncCalculate
    {
        private double currX;
        private int currY;
        
        private double? func(double x, int y)
        {
            try
            {
                if (x - 1 <= 0) throw new ArithmeticException();
                return Math.Round(y * Math.Pow(2, Math.Log(x - 1)), 3);
            }
            catch (ArithmeticException)
            {
                return null;
            }
        }

        public double?[,] calculateMyFunc(double x0, int amountX, double step, int amountY)
        {
            try
            {
                var myReturnArray = new double?[amountX, amountY];
                for (var i = 0; i < amountX; ++i)
                {
                    var currentNumb = x0 + step * i;
                    for (var j = 0; j < amountY; j++)
                    {
                        if (func(currentNumb, j + 1) == null)
                        {
                            myReturnArray[i, j] = null;
                        }
                        else
                        {
                            myReturnArray[i, j] = func(currentNumb, j + 1);
                        }
                    }

                }

                return myReturnArray;
            }
            catch (OverflowException)
            {
                throw new OverflowException("OverflowException");
            }
            catch (Exception error)
            {
                throw new SystemException(error.ToString());
            }
        }
    }
}