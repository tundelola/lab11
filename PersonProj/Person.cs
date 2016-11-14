using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonProj
{
    class Person
    {
        private string name;
        private string address;

        public string Name
        {
            get
            {
                return name;
            }

          
        }

        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
         }



        public Person(string name, string address)//overloaded constructor
        {
            this.name = name;
            this.Address = address;
        }

        
        public override string ToString()
        {
           return "name = "+  name + ", "+ "address is " + address ;
            

        }
    }
}
