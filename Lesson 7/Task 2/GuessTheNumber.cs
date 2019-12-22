using System;
using System.Windows.Forms;

namespace Task_2
{
    public class GuessTheNumber
    {
        public int Value { private set; get; }
        public int Count { private set; get; }
        public bool EndGame { private set; get; }

        public GuessTheNumber()
        {
            Random rnd = new Random();
            this.Value = rnd.Next(1, 101);
            this.EndGame = false;
        }
        public void Attempt(int number)
        {
            Count++;
            if (number == Value)
            {
                int minCount = 0, tempValue = 0;
                int maxValue = 100, minValue = 0;
                while (tempValue != Value)
                {
                    minCount++;
                    tempValue = minValue + (maxValue - minValue) / 2;
                    if (tempValue > Value)
                    {
                        maxValue = tempValue;
                    }
                    else
                    {
                        minValue = tempValue;
                    }
                }
                if (minCount == Count)
                {
                    MessageBox.Show($"Поздравляю Вы угадали число " +
                        $"за минимальное количество попыток ({Count})");
                }
                else if (minCount < Count)
                {
                    MessageBox.Show($"Поздравляю Вы угадали число, " +
                        $"но данную задачу можно было решить на {Count - minCount} попыток меньше");
                }
                else
                {
                    MessageBox.Show($"Поздравляю Вы угадали число, за {Count} попыток, это невероятно!" +
                        $"Это лучше на {minCount - Count} попыток чем могу я!");
                }
                EndGame = true;
            } else if (number > Value)
            {
                MessageBox.Show($"Загаданное число меньше");
            } else
            {
                MessageBox.Show($"Загаданное число больше");
            }
        }
    }
}
