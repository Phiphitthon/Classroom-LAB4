using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4
{
    public partial class Form1 : Form
    {
        Classroom classroom;
        public Form()
        {
            InitializeComponent();
            classroom = new Classroom("LAB4");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = this.tbListName.Text;
            string birthyear = this.tbBirthYear.Text;
            string grade = this.tbGrade.Text;

            Person newPerson = new Person(name, igpa, iByear);
            this.classroom.AddPerson(newPerson);
            this.classroom.addGpa();
            this.tbListName.Text = this.classroom.ShowPerons();


            this.tbAgeAll.Text = this.classroom.showAge().ToString();

            double newMax = this.classroom.showMax();
            this.tbMax.Text = newMax.ToString();
            this.tbMaxName.Text = this.classroom.showMaxName();

            double newMin = this.classroom.showMin();
            this.tbMin.Text = newMin.ToString();
            this.tbMinName.Text = this.classroom.showMinName();

            double newAvg = this.classroom.showAvg();
            this.GradeAvg.Text = newAvg.ToString("N2");

        }
    }
}