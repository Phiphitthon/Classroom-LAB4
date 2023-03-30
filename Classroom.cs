using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4
{
    internal class Classroom
    {
        private string name;
        private List<Person> _persons = new List<Person>();
        private List<double> _gpas = new List<double>();
        private List<string> _name = new List<string>();

        public Classroom(string name)
        {
            this.name = name;
        }
        public void AddPerson(Person person)
        {
            this._persons.Add(person);
        }
        public string ShowPerons()
        {
            string result = "";
            foreach (var person in this._persons)
            {
                result += person.name + "\t\t";
            }
            return result;
        }
        public void addGpa()
        {
            foreach (var person in _persons)
            {
                _gpas.Add(person.gpa);
                _name.Add(person.name);
            }
        }
        public int showAge()
        {
            int result = 0;
            foreach (var person in this._persons)
            {
                result = person.birth;
            }
            return result;
        }

        public double showMax()
        {
            double max = _gpas.Max(); return max;
        }
        public string showMaxName()
        {
            return _name[_gpas.IndexOf(_gpas.Max())];
        }
        public double showMin()
        {
            double min = _gpas.Min(); return min;
        }
        public string showMinName()
        {
            return _name[_gpas.IndexOf(_gpas.Min())];
        }
        public double showAvg()
        {
            double Avg = _gpas.Average(); return Avg;

        }

    }
}