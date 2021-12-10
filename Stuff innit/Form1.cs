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
    public partial class Form1 : Form
    {
        float timer = 0;
        public Form1()
        {
            InitializeComponent();
        }


        private bool mouseDown;
        private Point lastLocation;




        private void timerTB_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void timerTB_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void timerTB_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();

            

            
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
        
            Form3 form = new Form3();
            form.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            timer1.Enabled = true;
            

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
