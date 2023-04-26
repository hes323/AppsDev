using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string setValueOne{
            set
            {
                textBox1.Text = value;
            }
        }

        public string setValueTwo
        {
            set
            {
                textBox2.Text = value;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            userControl11.Show();
            userControl21.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            userControl21.Show();
            userControl11.Hide();
        }
    }
}
