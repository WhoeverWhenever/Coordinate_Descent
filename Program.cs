using System;

namespace Lab4
{
    class Program
    {

        static public double TestFunc(double[] p)
        {
            return (1 - Math.Pow(p[0] * p[0] - p[1], 2) + p[0] * p[1] - 10 * Math.Pow(p[1], 2));
            //return 100 * Math.Pow(p[1] - p[0] * p[0], 2) + Math.Pow(1 - p[0], 2);
        }

        static void Main(string[] args)
        {
            var optimizationResult = CD.descent_method(TestFunc, new double[] { 0, 0 }, 0.01, 100);
            Console.WriteLine(optimizationResult[0]);
            Console.WriteLine(optimizationResult[1]);
            Console.WriteLine("F="+ (1 - Math.Pow(optimizationResult[0] * optimizationResult[0] - optimizationResult[1], 2) + 
                optimizationResult[0] * optimizationResult[1] - 10 * Math.Pow(optimizationResult[1], 2)));
        }
    }
}
