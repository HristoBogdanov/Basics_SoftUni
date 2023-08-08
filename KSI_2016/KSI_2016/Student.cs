using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSI_2016
{
    public class Student
    {
        private string name_student;
        private string speciality;
        private double grade;
        private string form;

        public string Name_student
        {
            get { return this.name_student; }
            set
            {
                if (value.Length > 30) throw new ArgumentException("Invalid data");
                else this.name_student = value;
            }
        }

        public string Speciality
        {
            get { return this.speciality; }
            set 
            {
                if (value.Length > 20) throw new ArgumentException("Invalid data");
                else this.speciality = value;
            }
        }

        public double Grade
        {
            get { return this.grade; }
            set {
                if (value < 2.0 || value > 6.0) throw new ArgumentException("Invalid data");
                else this.grade = value;
            }
        }

        public string Form
        {
            get { return this.form; }
            set
            {
                if (value.Length > 15) throw new ArgumentException("Invalid data");
                else this.form = value;
            }
        }

        public Student(string name, string speciality,double grade,string form)
        {
            this.Name_student = name;
            this.Speciality = speciality;
            this.Grade = grade;
            this.Form = form;
        }

        public double CalculateBal()
        {
            return this.Grade * 6;
        }
        public override string ToString()
        {
            return $"{this.Name_student}; {this.Speciality}; {this.Form}; {this.CalculateBal()}";
        }
    }
}
