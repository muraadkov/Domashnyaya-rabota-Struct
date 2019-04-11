using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Struct
{
    public enum Gender
    {
        Мужской,
        Женский
    }
    public enum FormOfStudy
    {
        Очно,
        Заочно
    }
    public class Student : IComparable<Student>
    {
        public string FIO { get; set; }
        public string Group { get; set; }
        public double AvgMark { get; set; }
        public int SalaryForPerson { get; set; }
        public Gender Gender { get; set; }
        public FormOfStudy FormOfStudy { get; set; }

        public int CompareTo(Student other)
        {
            if (this.AvgMark < other.AvgMark) return 1;
            if (this.AvgMark > other.AvgMark) return -1;
            else return 0;
        }
    }
}
