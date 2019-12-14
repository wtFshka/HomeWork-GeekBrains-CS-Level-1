namespace MyLibrary
{
    //а) Дописать класс для работы с одномерным массивом. 
    //Реализовать конструктор, создающий массив определенного размера и заполняющий массив числами от начального значения с заданным шагом.
    //Создать свойство Sum, которое возвращает сумму элементов массива, метод Inverse, возвращающий новый массив с измененными знаками у
    //всех элементов массива (старый массив, остается без изменений), метод Multi, умножающий каждый элемент массива на определённое число,
    //свойство MaxCount, возвращающее количество максимальных элементов.
    //б)** Cоздать библиотеку содержащую класс для работы с массивом.
    //Продемонстрировать работу библиотеки 
    public class MyArray
    {
        int[] _arr;
        public int Sum
        {
            get
            {
                int sum = 0;
                foreach (var item in _arr)
                {
                    sum += item;
                }
                return sum;
            }
        }
        public int MaxCount
        {
            get
            {
                int max = _arr[0], count = 1;
                if (_arr.Length > 1)
                {
                    for (int i = 1; i < _arr.Length; i++)
                    {
                        if (max == _arr[i])
                        {
                            count++;
                        }
                        if (max < _arr[i])
                        {
                            max = _arr[i];
                            count = 1;
                        }
                    }
                }
                return count;
            }
        }
        public MyArray(int n, int startElement, int step)
        {
            _arr = new int[n];
            for (int i = 0; i < _arr.Length; i++)
            {
                _arr[i] = startElement;
                startElement += step;
            }
        }

        public int[] Inverse()
        {
            int[] tempArr = new int[_arr.Length];
            for (int i = 0; i < tempArr.Length; i++)
            {
                tempArr[i] = -_arr[i];
            }
            return tempArr;
        }

        public void Multi(int multiplier)
        {
            for (int i = 0; i < _arr.Length; i++)
            {
                _arr[i] *= multiplier;
            }
        }

        public override string ToString()
        {
            string strArr = "";
            foreach (var a in _arr)
            {
                strArr += $" {a}";
            }
            return strArr;
        }
    }
}
