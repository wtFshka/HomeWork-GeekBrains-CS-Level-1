using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class DecimalNumber
    {
        public int Numerator { private set; get; }
        public int Denumerator { private set; get; }
        double DecimalNum { get => Math.Round((double)Numerator / (double)Denumerator,2); }
        public DecimalNumber()
        {

        }
        public DecimalNumber(int numerator, int denumerator)
        {
            this.Numerator = numerator;
            this.Denumerator = denumerator;
        }
        public static DecimalNumber Plus(DecimalNumber a, DecimalNumber b)
        {
            DecimalNumber c = new DecimalNumber();
            c.Numerator = a.Numerator * b.Denumerator + b.Numerator * a.Denumerator;
            c.Denumerator = a.Denumerator * b.Denumerator;
            return c;
        }

        public static DecimalNumber Minus(DecimalNumber a, DecimalNumber b)
        {
            DecimalNumber c = new DecimalNumber();
            c.Numerator = a.Numerator * b.Denumerator - b.Numerator * a.Denumerator;
            c.Denumerator = a.Denumerator * b.Denumerator;
            return c;
        }
        public static DecimalNumber Multi(DecimalNumber a, DecimalNumber b)
        {
            DecimalNumber c = new DecimalNumber();
            c.Numerator = a.Numerator * b.Numerator;
            c.Denumerator = a.Denumerator * b.Denumerator;
            return c;
        }
        public static DecimalNumber Division(DecimalNumber a, DecimalNumber b)
        {
            DecimalNumber c = new DecimalNumber();
            c.Numerator = a.Numerator * b.Denumerator;
            c.Denumerator = a.Denumerator * b.Numerator;
            return c;
        }
        public void Simplifying()
        {
            int tempNumerator = Numerator;
            int tempDenumerator = Denumerator;
            int num = 0, divided = 2;
            List<int> numbers = new List<int>();
            if (tempNumerator > tempDenumerator)
            {
                num = (tempNumerator / tempDenumerator);
                tempNumerator -= tempDenumerator * num;
            }
            do
            {
                if (tempNumerator%divided==0)
                {
                    tempNumerator /= divided;
                    numbers.Add(divided);
                }
            } while (tempNumerator!=1);
        }
    }
}
