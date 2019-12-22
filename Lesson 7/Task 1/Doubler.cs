using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Task_1
{
    public class Doubler
    {
        private int _value;
        public string Value { get => _value.ToString(); }
        public int GoalValue { private set; get; }
        public int Count { private set; get; }
        public bool EndGame { private set; get; }
        public Stack<int> course;

        public Doubler()
        {
            Random rnd = new Random();
            GoalValue = rnd.Next(1, 101);
            Count = 0;
            MessageBox.Show($"Это игра удвоитель, попробуйте за минимальное " +
                $"количесвто действий достигнуть числа {this.GoalValue}");
            course = new Stack<int>();
            EndGame = false;
        }
        public void Plus() 
        { 
            course.Push(_value);  
            _value++;
            Count++;
            FinishChek();
        }
        public void Multi() 
        {
            course.Push(_value);
            _value *= 2;
            Count++;
            FinishChek();
        }
        public void Clear()
        {
            course.Clear();
            _value = 0;
            Count = 0;
        }
        public void Cancel()
        {
            if (course.Count > 0)
            {
                _value = course.Pop();
                Count--;
            }
            else
            {
                _value = 0;
                Count = 0;
            }
        }
        private void FinishChek()
        {
            if (GoalValue == _value)
            {
                int tempValue = GoalValue;
                int minCount = 0;

                while (tempValue != 0)
                {
                    if (tempValue%2==0)
                    {
                        tempValue /= 2;
                    }
                    else
                    {
                        tempValue--;
                    }
                    minCount++;
                }
                if (minCount == Count)
                {
                    MessageBox.Show($"Поздравляю Вы достигли нужного результата " +
                        $"за минимальное количество попыток ({Count})");
                }
                else
                {
                    MessageBox.Show($"Поздравляю Вы достигли нужного результата, " +
                        $"но данную задачу можно было решить на {Count-minCount} попыток меньше");
                }
                EndGame = true;
            }
        }
    }
}
