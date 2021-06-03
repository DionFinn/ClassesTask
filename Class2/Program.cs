using System;
using System.Collections.Generic;

namespace Class2
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Person("dion", "finnerty", new DateTime(2000,05,23), 180);
            var p2 = new Person("john", "doe", new DateTime(2003, 07, 20), 190);
            var p3 = new Person("jimmy", "longshlong", new DateTime(2004, 12, 10), 160);

            // Step 2
            Console.WriteLine(p1.GetHeightDifference(p2));
            Console.WriteLine(p1.GetHeightDifference(p3));

            // Step 5
            p1.AddSubject(new Subject("Dev", 2021));
            p1.AddSubject(new Subject("Math", 2018));
            p2.AddSubject(new Subject("Math", 2018));
            p3.AddSubject(new Subject("Math", 2018));
            p1.GetSubjects();
             //p2.GetSubjects();

            // Step 6
            p1.SetGrade("Math", 78);
            p1.GetSubjects();

        }
    }
}
