using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var enter1 = textBox1.Text;
            var enter2 = textBox2.Text;

            var usercontrol1 = this.Parent as Form1;

            usercontrol1.setValueOne = enter1;
            usercontrol1.setValueTwo = enter1;
        }
    }
}
