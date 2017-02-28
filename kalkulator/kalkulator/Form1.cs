using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int a = int.Parse(Console.ReadLine());
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            int a = int.Parse(Console.ReadLine());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var num1 = decimal.Parse(this.textBox2.Text);
            var num2 = decimal.Parse(this.textBox3.Text);
            var sum = num1 + num2;
            textBoxSum.Text = sum.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
