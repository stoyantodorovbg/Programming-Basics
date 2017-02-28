using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace valutenConvertor
{
    public partial class FormConverter : Form
    {
        public FormConverter()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Result_KeyUp(object sender, KeyEventArgs e)
        {
        }

        private void Result_TextChanged(object sender, EventArgs e)
        {

        }

        private void Result_Click(object sender, EventArgs e)
        {
        }
            private void FormConverter_Load(object sender, EventArgs e)
        {
            ConverterCurrency();
        }
        private void ConverterCurrency()
        {
            var amountBGN = this.numericUpDownAmount.Value;
            var amountEUR = amountBGN * 1.95583m;
            this.Result.Text =
                amountBGN + "BGN = " +
                Math.Round(amountEUR, 2) + "EUR";

        }

        private void NumericUpDownAmount_Value(object sender, EventArgs e)
        {
            ConverterCurrency();
        }
    }
    }
