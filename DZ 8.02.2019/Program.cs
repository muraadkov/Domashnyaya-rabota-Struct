using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_02_2019_HW_1
{
    enum Vacancies
    {
        Менеджер, Босс, Клерк, Продавец
    }
    class Program
    {

        static void Main(string[] args)
        {
                            float d = 0;
                int cnt = 0;
            Console.WriteLine("Введите количество сотрудников: ");
            int countOfEmployee = int.Parse(Console.ReadLine());
            Employee[] employee = new Employee[countOfEmployee];
            for (int i = 0; i < countOfEmployee; i++)
            {
                Console.WriteLine("Введите имя сотрудника: ");
                employee[i].name = Console.ReadLine();
                Console.WriteLine("Введите должность сотрудника: " +
                    "\n0.Менеджер" +
                    "\n1.Босс" +
                    "\n2.Клерк" +
                    "\n3.Продавец");
                int position = int.Parse(Console.ReadLine());
                if (position == 0)
                {
                    employee[i].vacancy = Vacancies.Менеджер;
                }
                else if (position == 1)
                {
                    employee[i].vacancy = Vacancies.Босс;
                }
                else if (position == 2)
                {
                    employee[i].vacancy = Vacancies.Клерк;
                }
                else if (position == 3)
                {
                    employee[i].vacancy = Vacancies.Продавец;
                }
                else
                {
                    Console.WriteLine("Такой должности нет.");
                }
                Console.WriteLine("Введите зарплату: ");
                employee[i].salary = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите дату приёма на работу: ");
                employee[i].date = Convert.ToInt32(Console.ReadLine());
                DateTime date = DateTime.Parse(Convert.ToString(employee[i].date));
            }
            Console.WriteLine("-----------------------------------------------------");
                for (int i = 0; i < employee.Length; i++)
                {
                    for (int j = 0; j < employee.Length - 1; j++)
                    {
                    var s = employee[j];
                    employee[j] = employee[j + 1];
                    employee[j + 1] = s;
                }
                }
            foreach (Employee emp in employee)
            {
                Console.WriteLine("Имя сотрудника: " + emp.name);
                Console.WriteLine("Должность сотрудника: " + emp.vacancy);
                Console.WriteLine("Заработная плата сотрудника: " + emp.salary);
            }
            foreach (Employee emp in employee)
            {
                if (emp.vacancy == Vacancies.Клерк)
                {
                    cnt++;
                    d += emp.salary;
                    d /= cnt;
                }
            }
            Console.WriteLine("-----------------------------------------------------");
            foreach (Employee emp in employee)
            {
                if (emp.vacancy == Vacancies.Менеджер && emp.salary > d)
                {
                    
                    Console.WriteLine("Имя сотрудника: " + emp.name);
                    Console.WriteLine("Должность сотрудника: " + emp.vacancy);
                    Console.WriteLine("Заработная плата сотрудника: " + emp.salary);
                }
            }
            Console.Read();
        }
    }

    struct Employee
    {

        public string name;
        public Vacancies vacancy;
        public int salary;
        public int date;
    }
}