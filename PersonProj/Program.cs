using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonProj
{
    class Program
    {
        static void Main(string[] args)
        {
            Person toStr = new Person("Kamel",  "Detroit");
            Console.WriteLine(toStr.ToString());

            Student toStud = new Student("Lola", "Southfield",
                "C#.NET", 2015, 50.45);
            Console.WriteLine(toStud.ToString());

            Staff toStaf = new Staff("Tunde", "Westland", "Westland Elementary", 150.00 );
            Console.WriteLine(toStaf.ToString());

        }
    }
}
