using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonProj
{
    class Student : Person
    {
        private string program;
        private int year;
        private double fee;

        public string Program
        {
            get
            {
                return program;
            }

            set
            {
                program = value;
            }
        }

        public int Year
        {
            get
            {
                return year;
            }

            set
            {
                year = value;
            }
        }

        public double Fee
        {
            get
            {
                return fee;
            }
            
            set
            {
                fee = value;
            }
        }

        //student class inherits from Person's class. A call to base class by passing in the name and address variable
        public Student(string name, string address, string program, int year, double fee): base(name,address)
        {
            this.Program = program;
            this.Year = year;
            this.Fee = fee;
        }
        public override string ToString()
        {
            return base.ToString()+" ," +"program is " + program + ", "+ "year is "+ year + ", "+ "fee is "+ fee ;
        }
    }
    }

