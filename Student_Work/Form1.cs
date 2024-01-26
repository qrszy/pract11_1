using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Work
{
    public partial class Form1 :Form
    {
        public Form1 ()
        {
            InitializeComponent();
        }

        private void label2_Click (object sender, EventArgs e)
        {

        }

        private void label1_Click (object sender, EventArgs e)
        {

        }
        public class Student
        {
            public string name;
            public double rost;
            private double ves = 40;
            public double eda;

            public double GetEat (double vs)
            {
                ves = vs;
                return ves ;
            }
            public double SetEat (double eda,double vs)
            {
                if (eda >= 5 && eda <= 10)
                {
                    vs = vs + ((eda * 1000 - 1600) * 0.7 / 1000);
                    rost--;
                }
                else if (eda > 10)
                {

                    rost = rost - 2;
                    vs = vs + ((eda * 1000 - 1800) * 0.5 / 1000);
                }
                return vs;
            }
        }

        private void button1_Click (object sender, EventArgs e)
        {
            Student student1 = new Student();
            student1.name = textBox1.Text;
            student1.rost = (double)numericUpDown1.Value;
            student1.eda = (double) numericUpDown3.Value;
            if (student1.eda >= 5 && student1.eda <= 10)
                student1.rost--;
            else
                student1.rost = student1.rost - 2;

            MessageBox.Show(string.Format("Студент: {0} \nРост: {1}\nВес {2}", student1.name, student1.rost, student1.SetEat(student1.eda, student1.GetEat((double) numericUpDown2.Value))));
        }
    }
}
