using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimesTable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*private void button1_Click(object sender, EventArgs e)
        {
            int loopStart;
            int loopEnd;
            int answer;
            answer = 0;

            loopStart = int.Parse(textBox1.Text);
            loopEnd = int.Parse(textBox2.Text);

            for (int i = loopStart; i < (loopEnd + 1); i++)
            {
                
                answer = answer + i;
            }

            MessageBox.Show(answer.ToString());
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }*/
        private void button1_Click(object sender, EventArgs e)
        {
            int loopStart;
            int loopEnd;
            int answer = 0;
            bool isNumber = false;

            isNumber = int.TryParse(textBox1.Text, out answer);
            isNumber = int.TryParse(textBox2.Text, out answer);
            isNumber = int.TryParse(textBox3.Text, out answer);
            if (!isNumber)
            {
                MessageBox.Show("Type numbers in the text boxes");
            }
            else
            {
            loopStart = int.Parse(textBox1.Text);
            loopEnd = int.Parse(textBox2.Text);
            int multiplyBy = int.Parse(textBox3.Text);

            listBox1.Items.Clear();
            int i = loopStart;
            
                /*for (int i = loopStart; i <= loopEnd; i++)
                {
                    answer = multiplyBy * i;

                    listBox1.Items.Add(i + " times " + multiplyBy + " = " + answer.ToString());
                }
                do
                {
                    answer = multiplyBy * i;
                    listBox1.Items.Add(i + " times " + multiplyBy + " = " + answer.ToString());
                    i++;
                } while (i <= loopEnd);*/
                while (i <= loopEnd)
                {
                    answer = multiplyBy * i;
                    listBox1.Items.Add(i + " times " + multiplyBy + " = " + answer.ToString());
                    i++;
                }
            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
