using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections2
{
    public class student2 : IComparer<student2> // for soting(descending order)
    {
        public int Sid { get; set; }
        public string Name { get; set; }
        public int Class { get; set; }
        public float Marks { get; set; }

        public int Compare(student2 x, student2 y)
        {
            if (x.Marks > y.Marks)
                return 1;
            else if (x.Marks < y.Marks)
                return -1;
            else
                return 0;
        }

        class TestSudent2
        {
            static void Main(string[] args)
            {
                student2 s1 = new student2 { Sid = 101, Name = "jay", Class = 10, Marks = 25.02f };
                student2 s2 = new student2 { Sid = 102, Name = "sanjay", Class = 11, Marks = 35.02f };
                student2 s3 = new student2 { Sid = 105, Name = "rudra", Class = 12, Marks = 45.02f };
                student2 s4 = new student2 { Sid = 106, Name = "shekhar", Class = 12, Marks = 56.58f };

                List<student2> students = new List<student2>() { s1, s2, s3, s4 };
                // if we would have int type instead of student then direct sorting was possible 
                //like students.sort();
                
                
                student2 obj = new student2();
                students.Sort(obj);
                // students.Reverse();
               // students.Sort(1, 4, obj); // another way for sorting
                foreach (student2 S in students)
                {
                    Console.WriteLine(S.Sid + " " + S.Name + " " + S.Class + " " + S.Marks);
                }
                Console.Read();
            }
        }
    }
}

