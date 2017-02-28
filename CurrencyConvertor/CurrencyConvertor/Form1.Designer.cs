namespace CurrencyConvertor
{
    partial class FormConvertor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.numericUpDownAmount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxCurrency = new System.Windows.Forms.ComboBox();
            this.LabelResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownAmount
            // 
            this.numericUpDownAmount.DecimalPlaces = 2;
            this.numericUpDownAmount.Location = new System.Drawing.Point(19, 65);
            this.numericUpDownAmount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDownAmount.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDownAmount.Name = "numericUpDownAmount";
            this.numericUpDownAmount.Size = new System.Drawing.Size(99, 30);
            this.numericUpDownAmount.TabIndex = 0;
            this.numericUpDownAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownAmount.ValueChanged += new System.EventHandler(this.NumericUpDownAmount_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "BGN\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "->\r\n";
            // 
            // comboBoxCurrency
            // 
            this.comboBoxCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCurrency.Items.AddRange(new object[] {
            "EUR",
            "USD",
            "GBG"});
            this.comboBoxCurrency.Location = new System.Drawing.Point(11, 202);
            this.comboBoxCurrency.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxCurrency.Name = "comboBoxCurrency";
            this.comboBoxCurrency.Size = new System.Drawing.Size(180, 33);
            this.comboBoxCurrency.TabIndex = 3;
            this.comboBoxCurrency.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCurrency_SelectedIndexChanged);
            // 
            // LabelResult
            // 
            this.LabelResult.BackColor = System.Drawing.Color.PaleGreen;
            this.LabelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelResult.Location = new System.Drawing.Point(238, 70);
            this.LabelResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelResult.Name = "LabelResult";
            this.LabelResult.Size = new System.Drawing.Size(173, 27);
            this.LabelResult.TabIndex = 4;
            this.LabelResult.Text = "\r\n";
            this.LabelResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormConvertor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 395);
            this.Controls.Add(this.LabelResult);
            this.Controls.Add(this.comboBoxCurrency);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownAmount);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConvertor";
            this.Text = "Currency convertor";
            this.Load += new System.EventHandler(this.FormConvertor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxCurrency;
        private System.Windows.Forms.Label LabelResult;
    }
}

