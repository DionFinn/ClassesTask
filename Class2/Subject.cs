using System;
using System.Collections.Generic;


namespace Class2
{
    public class Subject{
        public string Name;
        public int YearOfDelivery;

        public int Grade;

        public Subject(string name, int YearOfDelivery) {
            this.Name = name;
            this.YearOfDelivery = YearOfDelivery;
        }

        public void WriteSubject() {
            Console.WriteLine( $"Name: {Name}, Year: {YearOfDelivery}, Grade: {Grade}");
        }


    }
}
