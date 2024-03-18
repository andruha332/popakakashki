using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class student
    {
        public string name;
        public int kurse;
        public bool sex;
        public student(string name, int kurse, bool sex)
        {
            this.name = name;
            this.kurse = kurse;
            this.sex = sex;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student student = new student(Console.ReadLine(), int.Parse(Console.ReadLine()), bool.Parse(Console.ReadLine()));

            Console.WriteLine(student.name);
            Console.WriteLine(student.kurse);
            Console.WriteLine(student.sex);
        }
    }
}
