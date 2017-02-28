using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatchTheButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            var maxWidth = this.ClientSize.Width - catchMe.ClientSize.Width;
            var maxHeight = this.ClientSize.Height - catchMe.ClientSize.Height;
            this.catchMe.Location = new Point(rand.Next(maxWidth), rand.Next(maxHeight));
        }

        private void MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
