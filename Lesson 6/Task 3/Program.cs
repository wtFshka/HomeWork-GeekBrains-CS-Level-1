using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        //Переделать программу Пример использования коллекций для решения следующих задач:
        //а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
        //б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся(*частотный массив);
        //в) отсортировать список по возрасту студента;
        //г) *отсортировать список по курсу и возрасту студента;
        static void Main()
        {
            string[] arrStudents = File.ReadAllLines("students_1.csv");
            List<Student> students = new List<Student>();
            for (int i = 0; i < arrStudents.Length; i++)
            {
                string[] tempLineStudent = arrStudents[i].Split(';');
                students.Add(new Student(tempLineStudent[0], tempLineStudent[1], tempLineStudent[2], tempLineStudent[3], tempLineStudent[4], 
                    Convert.ToInt32(tempLineStudent[5]), Convert.ToInt32(tempLineStudent[6]), Convert.ToInt32(tempLineStudent[7]), tempLineStudent[8]));
            }
            Console.WriteLine($"На 5 и 6 курсе учится: {Student.GetCountStudentsCourse(students,5)+Student.GetCountStudentsCourse(students, 6)} студентов");
            int[,] douArrStudents = Student.GetStatistic(students, 18, 20);
            Console.WriteLine($"Статистика возраста студентов на курсах:");
            Console.WriteLine($" Курс | Возраст | Количество ");
            Console.WriteLine($"------|---------|------------");
            for (int i = 0; i < douArrStudents.GetLength(0); i++)
            {
                Console.WriteLine($"{douArrStudents[i,0],3}   |{douArrStudents[i, 1],5}    |{douArrStudents[i, 2],8}");
            }
            students.Sort(Student.AgeSort);
            students.Sort(Student.CourseAgeSort);
            Console.ReadKey();
        }
    }

}
