using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class student : IComparable<student> // for soting(ascending order)
    {
        public int Sid { get; set; }
        public string Name { get; set; }
        public int Class { get; set; }
        public float Marks { get; set; }

        public int CompareTo(student other)
        {
            if (this.Sid > other.Sid)
                return 1;
            else if (this.Sid < other.Sid)
                return -1;
            else
                return 0;
        }

        class TestSudent
        {
            static void Main(string[] args)
            {
                student s1 = new student { Sid = 101, Name = "jay", Class = 10, Marks = 25.02f };
                student s2 = new student { Sid = 102, Name = "sanjay", Class = 11, Marks = 35.02f };
                student s3 = new student { Sid = 105, Name = "rudra", Class = 12, Marks = 45.02f };
                student s4 = new student { Sid = 106, Name = "shekhar", Class = 12, Marks = 56.58f };

                List<student> students = new List<student>() { s1, s2, s3, s4 };
                //  students.Sort(); this is not applicable
                foreach (student S in students)
                {
                    Console.WriteLine(S.Sid + " " + S.Name + " " + S.Class + " " + S.Marks);
                }
            }
        }
    }
}
