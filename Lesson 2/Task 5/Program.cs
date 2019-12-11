using System;

namespace Task_5
{
    class Program
    {
        //а) Написать программу, которая запрашивает массу и рост человека, 
        //вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
        //б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
        static void Main(string[] args)
        {
            double weight, height, BMI;
            Console.WriteLine("Программа вычисления ИМТ (Индекса массы тела)");
            Console.Write("Введите вашу массу (вес в кг.): ");
            weight = Convert.ToDouble(Console.ReadLine().Replace('.', ','));
            Console.Write("Введите ваш рост: ");
            height = Convert.ToDouble(Console.ReadLine().Replace('.', ','));
            BMI = Math.Round(weight / Math.Pow(height > 3 ? height / 100 : height, 2),2);
            Console.WriteLine($"Ваше ИМТ равно {BMI} вы попадаете в категорию: ");
            if (BMI <= 16)
            {
                Console.WriteLine("Выраженный дефицит массы тела");
            }
            else if (BMI > 16 && BMI < 18.5)
            {
                Console.WriteLine("Недостаточная (дефицит) масса тела");
            }
            else if (BMI >= 18.5 && BMI < 25)
            {
                Console.WriteLine("Норма");
            }
            else if (BMI >= 25 && BMI < 30)
            {
                Console.WriteLine("Избыточная масса тела (предожирение)");
            }
            else if (BMI >= 30 && BMI < 35)
            {
                Console.WriteLine("Ожирение");
            }
            else if (BMI >= 35 && BMI < 40)
            {
                Console.WriteLine("Ожирение резкое");
            }
            else if (BMI >= 40)
            {
                Console.WriteLine("Очень резкое ожирение");
            }
            else
            {
                Console.WriteLine("Извините произошло что-то не понятное...");
            }
            if (BMI < 18.5 || BMI >= 25)
            {
                Console.WriteLine($"Для того что войти в категорью \"Норма\" Вам нужно " +
                    $"{(BMI < 18.5 ? "набрать" : "похудеть на")} {MathBMI(BMI,weight,height)} кг.");
            }
            Console.ReadKey();
        }
        static double MathBMI(double BMI, double weight, double height)
        {
            if (BMI < 18.5)
            {
                return Math.Round(18.5 * Math.Pow(height > 3 ? height / 100 : height, 2) - weight, 2);
            }
            else
            {
                return  Math.Round(weight - 24.99 * Math.Pow(height > 3 ? height / 100 : height, 2), 2);
            }
        }
    }
}
