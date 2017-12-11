namespace evansCapstone
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
            this.hoursT = new System.Windows.Forms.TextBox();
            this.minutesT = new System.Windows.Forms.TextBox();
            this.secondsT = new System.Windows.Forms.TextBox();
            this.number = new System.Windows.Forms.TextBox();
            this.hoursP = new System.Windows.Forms.TextBox();
            this.minutesP = new System.Windows.Forms.TextBox();
            this.secondsP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.calcP = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.fromcombo1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // hoursT
            // 
            this.hoursT.Location = new System.Drawing.Point(12, 33);
            this.hoursT.Name = "hoursT";
            this.hoursT.Size = new System.Drawing.Size(30, 20);
            this.hoursT.TabIndex = 2;
            this.hoursT.TextChanged += new System.EventHandler(this.hoursT_TextChanged);
            // 
            // minutesT
            // 
            this.minutesT.Location = new System.Drawing.Point(74, 33);
            this.minutesT.Name = "minutesT";
            this.minutesT.Size = new System.Drawing.Size(29, 20);
            this.minutesT.TabIndex = 3;
            this.minutesT.TextChanged += new System.EventHandler(this.minutesT_TextChanged);
            // 
            // secondsT
            // 
            this.secondsT.Location = new System.Drawing.Point(136, 33);
            this.secondsT.Name = "secondsT";
            this.secondsT.Size = new System.Drawing.Size(27, 20);
            this.secondsT.TabIndex = 4;
            this.secondsT.TextChanged += new System.EventHandler(this.secondsT_TextChanged);
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(10, 26);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(30, 20);
            this.number.TabIndex = 6;
            this.number.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // hoursP
            // 
            this.hoursP.Location = new System.Drawing.Point(12, 151);
            this.hoursP.Name = "hoursP";
            this.hoursP.Size = new System.Drawing.Size(30, 20);
            this.hoursP.TabIndex = 9;
            this.hoursP.TextChanged += new System.EventHandler(this.hoursP_TextChanged);
            // 
            // minutesP
            // 
            this.minutesP.Location = new System.Drawing.Point(76, 151);
            this.minutesP.Name = "minutesP";
            this.minutesP.Size = new System.Drawing.Size(27, 20);
            this.minutesP.TabIndex = 10;
            // 
            // secondsP
            // 
            this.secondsP.Location = new System.Drawing.Point(139, 151);
            this.secondsP.Name = "secondsP";
            this.secondsP.Size = new System.Drawing.Size(27, 20);
            this.secondsP.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(9, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "hours";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "minutes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "seconds";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "number";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "hours";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(73, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "minutes";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(133, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "seconds";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(-1, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 18);
            this.label9.TabIndex = 22;
            this.label9.Text = "Time";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(-1, 149);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 18);
            this.label10.TabIndex = 23;
            this.label10.Text = "Distance";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(-1, 199);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 18);
            this.label11.TabIndex = 24;
            this.label11.Text = "Pace";
            // 
            // calcP
            // 
            this.calcP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcP.ForeColor = System.Drawing.Color.MediumBlue;
            this.calcP.Location = new System.Drawing.Point(255, 16);
            this.calcP.Name = "calcP";
            this.calcP.Size = new System.Drawing.Size(110, 23);
            this.calcP.TabIndex = 25;
            this.calcP.Text = "Calculate Pace";
            this.calcP.UseVisualStyleBackColor = true;
            this.calcP.Click += new System.EventHandler(this.button1_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(121, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(197, 29);
            this.label12.TabIndex = 26;
            this.label12.Text = "Pace Calculator";
            // 
            // fromcombo1
            // 
            this.fromcombo1.FormattingEnabled = true;
            this.fromcombo1.Items.AddRange(new object[] {
            "Select a unit",
            "Kilometers",
            "Miles"});
            this.fromcombo1.Location = new System.Drawing.Point(72, 26);
            this.fromcombo1.Margin = new System.Windows.Forms.Padding(2);
            this.fromcombo1.Name = "fromcombo1";
            this.fromcombo1.Size = new System.Drawing.Size(92, 21);
            this.fromcombo1.TabIndex = 27;
            this.fromcombo1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Select Metric";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.secondsP);
            this.panel1.Controls.Add(this.minutesP);
            this.panel1.Controls.Add(this.hoursP);
            this.panel1.Controls.Add(this.secondsT);
            this.panel1.Controls.Add(this.minutesT);
            this.panel1.Controls.Add(this.hoursT);
            this.panel1.Location = new System.Drawing.Point(79, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 198);
            this.panel1.TabIndex = 29;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.DarkGray;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(246, 13);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(146, 69);
            this.richTextBox1.TabIndex = 29;
            this.richTextBox1.Text = "Enter your time and distance, then click \"Calculate Pace\"";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.fromcombo1);
            this.panel2.Controls.Add(this.calcP);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.number);
            this.panel2.Location = new System.Drawing.Point(0, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(417, 59);
            this.panel2.TabIndex = 30;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(499, 262);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Name = "Form1";
            this.Text = "Pace Calculator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox hoursT;
        private System.Windows.Forms.TextBox minutesT;
        private System.Windows.Forms.TextBox secondsT;
        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.TextBox hoursP;
        private System.Windows.Forms.TextBox minutesP;
        private System.Windows.Forms.TextBox secondsP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button calcP;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox fromcombo1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel panel2;
    }
}

