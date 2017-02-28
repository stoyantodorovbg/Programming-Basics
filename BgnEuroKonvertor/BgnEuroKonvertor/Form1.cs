using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BgnEuroKonvertor
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

        private void numericUpDownAmount_ValueChanged(object sender, EventArgs e)
            private void convertCurrency()
        {
            var amountBGN = this numericUpDownAmount.Value;
            var amountEUR = amountBGN * 1.95583m;
            this.lebelResult.Text = amountBGN + "BGN = " +
                Math.Round(amountEURO, 2) + "EUR";


        }
    }
}
