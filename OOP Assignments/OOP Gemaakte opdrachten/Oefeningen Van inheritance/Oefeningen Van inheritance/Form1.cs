using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oefeningen_Van_inheritance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked) 
            {
                Professor professor = new Professor(textBoxName.Text, Convert.ToInt32(textBoxPhoneNumber.Text), textBoxEmail.Text, Convert.ToInt32(textBoxSalary.Text));
                listBox1.Items.Add(professor.ToString());
            }

            if (checkBox2.Checked) 
            {
                Student student = new Student(textBoxName.Text, Convert.ToInt32(textBoxPhoneNumber.Text), textBoxEmail.Text, Convert.ToInt32(textBoxStudentNumber.Text));
                listBox1.Items.Add(student.ToString());
                listBox1.Items.Add(student.LongerPhoneNumber(student.PhoneNumber));
            }


        }
    }
}
