using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stuff_innit
{
    public partial class Form2 : Form
    {
        DateTime dt1 = DateTime.Now;
        float countDown = 50;
        float timer = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            Form3 form = new Form3();
            form.Show();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = dt1.ToString();
            DateTime dt2 = dt1.AddMinutes(30);
            textBox1.AppendText("\r\n" + dt2.ToString());

            dt2 = dt2.AddMinutes(30);
            textBox1.AppendText("\r\n" + dt2.ToString());


            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer += timer1.Interval * 0.1f;
            textBox1.Text = "Time Elapsed: " + timer.ToString("0,0");
            dt1 = dt1.AddMilliseconds(timer1.Interval);
            textBox1.Text = dt1.ToString();
            textBox1.AppendText("\r\n" + DateTime.Now.ToString());
            TimeSpan ts = DateTime.Now.Subtract(dt1);
            textBox1.AppendText("\r\n" + ts.ToString());



            
        }



        private void button2_Click(object sender, EventArgs e)
        {
            countDown = float.Parse(textBox1.Text);  //get the value from textBox
            timer1.Enabled = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            countDown -= timer2.Interval * 0.001f;
            textBox1.Text = countDown.ToString("0.00");
            if (countDown<5) //change colour of text box
            {
                textBox1.BackColor = Color.OrangeRed;
            }
            timer += timer1.Interval * 0.1f;
            textBox1.Text = timer.ToString();
        }

       

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            countDown = 300;
            textBox1.BackColor = Color.Wheat;
            textBox1.Text = countDown.ToString();
            timer = 0;
            textBox1.Text = timer.ToString();
        }
    }
}

























