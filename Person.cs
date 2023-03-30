using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4
{
    internal class Person
    {
        public string name { get; set; }
        public double gpa { get; set; }
        public int birth { get; set; }

        public Person(string name, double gpa, int birth)
        {
            this.name = name;
            this.gpa = gpa;
            this.birth = 2566 - birth;
        }
    }
}