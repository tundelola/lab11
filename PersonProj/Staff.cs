using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonProj
{
    class Staff : Person
    {
        private string school;
        private double pay;

        public string School
        {
            get
            {
                return school;
            }

            set
            {
                school = value;
            }
        }

        public double Pay
        {
            get
            {
                return pay;
            }

            set
            {
                pay = value;
            }
        }

        public Staff(string name, string address, string school, double pay) :base(name,address )
        {
            this.School = school;
            this.Pay = pay;
        }
        public override string ToString()

        {
               
            return base.ToString()+", " +"school is " + school + ", " + "Pay is "+ pay ;
        }
    }
}
