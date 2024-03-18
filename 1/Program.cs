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

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student student = new student();
            student.name = Console.ReadLine();
            student.kurse = int.Parse(Console.ReadLine());
            student.sex = bool.Parse(Console.ReadLine());

            Console.WriteLine(student.name);
            Console.WriteLine(student.kurse);
            Console.WriteLine(student.sex);
        }
    }
}
