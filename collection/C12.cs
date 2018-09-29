using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections2
{
    public class student1 : IComparable<student1> // for soting(descending order)
    {
        public int Sid { get; set; }
        public string Name { get; set; }
        public int Class { get; set; }
        public float Marks { get; set; }

        public int CompareTo(student1 other)
        {
            if (this.Sid > other.Sid)
                return -1;
            else if (this.Sid < other.Sid)
                return 1;
            else
                return 0;
        }

        class TestSudent1
        {
            static void Main(string[] args)
            {
                student1 s1 = new student1 { Sid = 101, Name = "jay", Class = 10, Marks = 25.02f };
                student1 s2 = new student1 { Sid = 102, Name = "sanjay", Class = 11, Marks = 35.02f };
                student1 s3 = new student1 { Sid = 105, Name = "rudra", Class = 12, Marks = 45.02f };
                student1 s4 = new student1 { Sid = 106, Name = "shekhar", Class = 12, Marks = 56.58f };

                List<student1> students = new List<student1>() { s1, s2, s3, s4 };
                  students.Sort();
                  students.Reverse();
                foreach (student1 S in students)
                {
                    Console.WriteLine(S.Sid + " " + S.Name + " " + S.Class + " " + S.Marks);
                }
                Console.Read();
            }
        }
    }
}

