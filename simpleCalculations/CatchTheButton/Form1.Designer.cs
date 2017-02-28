namespace CatchTheButton
{
    partial class Form1
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
            this.catchMe = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // catchMe
            // 
            this.catchMe.AllowDrop = true;
            this.catchMe.Cursor = System.Windows.Forms.Cursors.Default;
            this.catchMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.catchMe.Location = new System.Drawing.Point(80, 49);
            this.catchMe.Name = "catchMe";
            this.catchMe.Size = new System.Drawing.Size(75, 77);
            this.catchMe.TabIndex = 0;
            this.catchMe.Text = "Catch me!";
            this.catchMe.UseVisualStyleBackColor = true;
            this.catchMe.Click += new System.EventHandler(this.button1_Click);
            this.catchMe.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MouseClick);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(266, 85);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(121, 97);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 253);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.catchMe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button catchMe;
        private System.Windows.Forms.ListView listView1;
    }
}

