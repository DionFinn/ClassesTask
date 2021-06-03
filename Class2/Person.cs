using System;
using System.Collections.Generic;
namespace Class2 
{
    public class Person 
    {
        //attributes
        public string FirstName;
        public string Surname;
        public DateTime DOB;
        public int Height;
        public int ID;

        public List<Subject> Subjects = new List<Subject>();
       
        
        public Person(string FirstName, string Surname, DateTime DOB, int Height) {
            this.FirstName = FirstName;
            this.Surname = Surname;
            this.DOB = DOB;
            this.Height = Height;
            this.ID = CreateID();
           
        }
            public string GetFullName() { 
                return $"{FirstName} {Surname}";
                } 
        
            public int GetHeightDifference(Person other) {
                return other.Height - this.Height;
            }

            private int CreateID() {
                Random num = new Random();
                int rndIDCODE = num.Next(1000,9999);
                return rndIDCODE;
            }

           public void AddSubject(Subject subject) {
                this.Subjects.Add(subject);
            }

            public void GetSubjects() {
                foreach(var s in this.Subjects){
                    s.WriteSubject();
                }
            }

            public void SetGrade(string name, int grade) {
                foreach (var s in this.Subjects) {
                    if(s.Name == name){
                        s.Grade = grade; 
                    }
                }
                            
            }


            
           
            
            
        
    }

}
