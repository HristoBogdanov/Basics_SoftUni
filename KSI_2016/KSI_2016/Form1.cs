using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KSI_2016
{
    public partial class Form1 : Form
    {
        List<Student> students = new List<Student>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student student = new Student(textBox1.Text, textBox2.Text, double.Parse(textBox3.Text), textBox4.Text);
            students.Add(student);

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var sorted_students = students.OrderBy(x => x.Speciality).ThenByDescending(x => x.CalculateBal());
            foreach (Student x in sorted_students) listBox1.Items.Add(x.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<Student> students_speciality = new List<Student>();

            foreach (Student x in students) if (x.Speciality == textBox5.Text && x.Form == textBox6.Text) students_speciality.Add(x);

            var sorted_students_2 = students_speciality.OrderBy(x => x.Name_student);

            foreach (Student x in sorted_students_2) listBox1.Items.Add(x.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<Student> students_speciality = new List<Student>();

            foreach (Student x in students) if (x.Speciality == textBox5.Text && x.Form == textBox6.Text) students_speciality.Add(x);

            double sum = 0;
            foreach (Student x in students_speciality) sum += x.CalculateBal();
            listBox1.Items.Add($"{(sum / students_speciality.Count):f2}");
        }
    }
}
