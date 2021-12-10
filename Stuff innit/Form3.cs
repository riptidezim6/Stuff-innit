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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int dice1 = rnd.Next(1, 6 + 1);
            textBox1.Text = dice1.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int dice1 = rnd.Next(1, 6 + 1);
            textBox1.Text = dice1.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
