using System;
using System.IO;

namespace Task_2
{
    public delegate double Func(double x);
    public class MinFunc
    {
        public static double Func_1(double x)
        {
            return x * x - 50 * x + 10;
        }
        public static double Func_2(double x)
        {
            return x / x - 75 * x + 30;
        }
        public static double Func_3(double x)
        {
            return x * 50 - x * x + 10;
        }
        public static double Func_4(double x)
        {
            return x * x - 10 * x * -x;
        }
        public static void SaveFunc(string fileName, double a, double b, double h, Func F)
        {
            StreamWriter sw = new StreamWriter(fileName);
            double x = a;
            while (x <= b)
            {
                sw.WriteLine(F(x));
                x += h;
            }
            sw.Close();
        }
        public static double[] Load(string fileName, out double min)
        {
            double[] a = new double[File.ReadAllLines(fileName).Length];
            StreamReader sr = new StreamReader(fileName);
            min = double.MaxValue;
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = Convert.ToDouble(sr.ReadLine());
                if (a[i] < min) min = a[i];
            }
            sr.Close();
            return a;
        }
    }
}
