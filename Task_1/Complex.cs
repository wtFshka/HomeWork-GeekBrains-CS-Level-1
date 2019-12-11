using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Complex
    {
        double re;
        double im;
        public Complex()
        {
            this.re = 0;
            this.im = 0;
        }
        public Complex(double re, double im)
        {
            this.re = re;
            this.im = im;
        }

        public string Print() => $"{re:F2} + {im:F2}i";

        public static Complex Plus(Complex complexA, Complex complexB)
        {
            Complex complexC = new Complex();
            complexC.re = complexA.re + complexB.re;
            complexC.im = complexA.im + complexB.im;
            return complexC;
        }
        public static Complex Multi(Complex complexA, Complex complexB)
        {
            Complex complexC = new Complex();
            complexC.re = complexA.re * complexB.re - complexA.im * complexB.im;
            complexC.im = complexA.re * complexB.im + complexA.im * complexB.re;
            return complexC;
        }
        public static Complex Minus(Complex complexA, Complex complexB)
        {
            Complex complexC = new Complex();
            complexC.re = complexA.re - complexB.re;
            complexC.im = complexA.im - complexB.im;
            return complexC;
        }
        public static Complex Division(Complex complexA, Complex complexB)
        {
            Complex complexC = new Complex();
            complexC.re = (complexA.re * complexB.re + complexA.im * complexB.im) / (Math.Pow(complexB.re,2) + Math.Pow(complexB.im, 2));
            complexC.im = complexA.im * complexB.re - complexA.re * complexB.im / (Math.Pow(complexB.re, 2) + Math.Pow(complexB.im, 2));
            return complexC;
        }
    }
}
