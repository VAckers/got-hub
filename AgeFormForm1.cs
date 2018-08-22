using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgeForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int age;

            age = int.Parse(textBox1.Text);

            if (age < 17)
            {
                MessageBox.Show("You're still a youngster.");
            }

            if (age >= 17 && age < 25)
            {
                MessageBox.Show("Fame beckons!");
            }

            if (age >= 25 && age < 40)
            {
                MessageBox.Show("There's still time.");
            }

            if (age >= 40)
            {
                MessageBox.Show("Oh dear, you've probably missed it!");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
