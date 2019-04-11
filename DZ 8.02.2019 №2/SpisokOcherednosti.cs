using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Struct
{
    public class FD
    {
        public void dz2()
        {
            int counter = 1;
            int minimalSalary = 42500;
            List<Student> students = new List<Student>(5)
            {
                new Student() { FIO = "Александр Александров Александрович", AvgMark = 4, FormOfStudy = FormOfStudy.Заочно, Gender = Gender.Мужской, Group = "SEP-181", SalaryForPerson = 40000 },
                new Student() { FIO = "Саша Александров Александрович", AvgMark = 2, FormOfStudy = FormOfStudy.Заочно, Gender = Gender.Мужской, Group = "SEP-181", SalaryForPerson = 90000 },
                new Student() { FIO = "Петя Александров Александрович", AvgMark = 3, FormOfStudy = FormOfStudy.Заочно, Gender = Gender.Мужской, Group = "SEP-181", SalaryForPerson = 20000 },
                new Student() { FIO = "Алёша Александров Александрович", AvgMark = 5, FormOfStudy = FormOfStudy.Заочно, Gender = Gender.Мужской, Group = "SEP-181", SalaryForPerson = 150000 }
            };
            List<Student> studentsFirstQueue = students.Cast<Student>().Where(x => x.SalaryForPerson < minimalSalary * 2).ToList();//отбираем бедных в одну очередь
            studentsFirstQueue.Sort();//сортируем их по баллам
            List<Student> studentsSecondQueue = students.Cast<Student>().Where(x => x.SalaryForPerson > minimalSalary * 2).ToList();//отбираем побогаче в другую очередь
            studentsSecondQueue.Sort();//сортируем их по баллам
            students = studentsFirstQueue.Concat(studentsSecondQueue).ToList();//Объединяем в одну очередь
            foreach (Student s in students)
            {
                Console.WriteLine($"{counter}.{s.FIO}");
                counter++;
            }
        }
    }
}
