using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classes_OOP_Opdracht
{
    public partial class Form1 : Form
    {
        Dice dice = new Dice();
        Student student = new Student();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int resultThrow = dice.Throw();
            if (resultThrow == 0)
            {
                MessageBox.Show("Please have 3 sides or more");
            }
            else {
                MessageBox.Show(resultThrow.ToString());
                textBox3.Text = resultThrow.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dice.ResetStatistics();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int setSides = Convert.ToInt32(domainUpDown1.Text);
            dice.Sides = setSides;
            student.name = textBox1.Text;
            student.address = textBox2.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(textBox4.Text);
            int count = dice.CheckNmbrsTimeThrown(number);
            MessageBox.Show(count.ToString());
        }
    }
}
