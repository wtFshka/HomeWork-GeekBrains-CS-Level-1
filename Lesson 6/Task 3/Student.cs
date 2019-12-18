using System.Collections.Generic;

namespace Task_3
{
    class Student
    {
        public string LastName { private set; get; }
        public string FirstName { private set; get; }
        public string University { private set; get; }
        public string Faculty { private set; get; }
        public int Course { private set; get; }
        public string Department { private set; get; }
        public int Age { private set; get; }
        public int Group { private set; get; }
        public string City { private set; get; }
        public Student(string firstName, string lastName, string university,
            string faculty, string department, int age, int course, int group, string city)
        {
            LastName = lastName;
            FirstName = firstName;
            University = university;
            Faculty = faculty;
            Department = department;
            Course = course;
            Age = age;
            Group = group;
            City = city;
        }
        public static int GetCountStudentsCourse(List<Student> a, int course)
        {
            int count = 0;
            foreach (var s in a)
            {
                if (s.Course == course)
                {
                    count++;
                }
            }
            return count;
        }
        public static int[,] GetStatistic(List<Student> s, int startAge, int endAge)
        {
            List<int> courses = new List<int>();
            if (endAge < startAge)
            {
                endAge += startAge;
                startAge = endAge - startAge;
                endAge -= startAge;
            }
            for (int i = 0; i < s.Count; i++)
            {
                if (!courses.Contains(s[i].Course))
                {
                    courses.Add(s[i].Course);
                }
            }
            int[,] result = new int[courses.Count * (endAge - startAge + 1), 3];
            int rows = 0;
            courses.Sort();
            for (int i = 0; i < courses.Count; i++)
            {
                for (int j = 0; j <= endAge - startAge; j++)
                {
                    int count = 0;
                    for (int k = 0; k < s.Count - 1; k++)
                    {
                        if (s[k].Age == startAge + j && s[k].Course == i + 1)
                        {
                            count++;
                        }
                    }
                    result[rows, 0] = i + 1;
                    result[rows, 1] = startAge + j;
                    result[rows, 2] = count;
                    rows++;
                }
            }
            return result;
        }
        public static int AgeSort(Student a, Student b)
        {
            if (a.Age > b.Age) return 1;
            if (a.Age < b.Age) return -1;
            return 0;
        }
        public static int CourseAgeSort(Student a, Student b)
        {
            if (a.Course > b.Course) return 1;
            if (a.Course < b.Course) return -1;
            if (a.Course == b.Course)
            {
                if (a.Age > b.Age) return 1;
                if (a.Age < b.Age) return -1;
            }
            return 0;
        }

    }
}
