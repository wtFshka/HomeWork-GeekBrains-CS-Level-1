using System;
using System.Collections.Generic;

namespace Task_3
{
    class DecimalNumber
    {
        public int Numerator { private set; get; }
        public int Denumerator { private set; get; }
        public double DecimalNum { get => Math.Round((double)Numerator / (double)Denumerator,2); }
        public DecimalNumber()
        {

        }
        public DecimalNumber(int numerator, int denumerator)
        {
            if (denumerator == 0)
            {
                throw new ArgumentException("Знаменатель не может быть равен 0");
            }
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
        public string Print() => $"{Numerator}/{Denumerator}";
        public void Simplifying()
        {
            int tempNumerator = Numerator;
            int tempDenumerator = Denumerator;
            int num = 0, divided = 2, FTS = 1;
            string result;
            List<int> numbers = new List<int>();
            if (tempNumerator > tempDenumerator)
            {
                num = (tempNumerator / tempDenumerator);
                tempNumerator -= tempDenumerator * num;
            }
            if (tempNumerator != 0)
            {
                do
                {
                    if (tempNumerator % divided == 0)
                    {
                        tempNumerator /= divided;
                        numbers.Add(divided);
                    }
                    else
                    {
                        divided++;
                    }
                } while (tempNumerator!=1);
                divided = 2;
                do
                {
                    if (tempDenumerator % divided == 0)
                    {
                        tempDenumerator /= divided;
                        for (int i = 0; i < numbers.Count; i++)
                        {                            
                            if (numbers[i] == divided)
                            {
                                FTS *= divided;
                                numbers.RemoveAt(i);
                                break;
                            }
                        }
                    }
                    else
                    {
                        divided++;
                    }
                } while (tempDenumerator != 1);
                result = $"{(num > 0 ? $"{num} {(Numerator - Denumerator * num) / FTS}/{Denumerator / FTS}" : $"{Numerator / FTS}/{Denumerator / FTS}")}";
            }
            else
            {
                result = $"{num}";
            }
            Console.WriteLine($"Дробь {Numerator}/{Denumerator} имеет наибольший общий делитель {FTS} и упрощена до: {result}");
        }
    }
}
