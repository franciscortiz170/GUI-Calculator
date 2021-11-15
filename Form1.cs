using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIcalculator
{
    public partial class Form1 : Form
    {
        private Solver solving = new Solver();
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "" + Environment.NewLine + Environment.NewLine + "----------------------" + Environment.NewLine;
        }

        private void AC_Click(object sender, EventArgs e)
        {
            
        }

        private void plusOrminus_Click(object sender, EventArgs e)
        {
            
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox2.Text = textBox2.Text + button.Text;
        }

        private void operation_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Text == "x")
                textBox2.Text = textBox2.Text + "*";
            else
                textBox2.Text = textBox2.Text + button.Text;
            solving.Accumulate(textBox1.Text);
        }

        private void equals_Click(object sender, EventArgs e)
        {
            solving.Solve(textBox2.Text);
        }
    }
}
