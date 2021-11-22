
namespace Contact_Tracing_Form_OOP
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
            this.lblTrace = new System.Windows.Forms.Label();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbfemale = new System.Windows.Forms.RadioButton();
            this.rbnotsay = new System.Windows.Forms.RadioButton();
            this.lblfulname = new System.Windows.Forms.Label();
            this.lblCTF = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblage = new System.Windows.Forms.Label();
            this.lblphnum = new System.Windows.Forms.Label();
            this.lbladdr = new System.Windows.Forms.Label();
            this.lblgndr = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.rbno1 = new System.Windows.Forms.RadioButton();
            this.lblq2 = new System.Windows.Forms.Label();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.lblq3 = new System.Windows.Forms.Label();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.radioButton11 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.lblq1 = new System.Windows.Forms.Label();
            this.rbyes1 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.pnl2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnl1.SuspendLayout();
            this.pnl2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTrace
            // 
            this.lblTrace.AutoSize = true;
            this.lblTrace.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrace.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblTrace.Location = new System.Drawing.Point(0, 0);
            this.lblTrace.Name = "lblTrace";
            this.lblTrace.Size = new System.Drawing.Size(204, 77);
            this.lblTrace.TabIndex = 1;
            this.lblTrace.Text = "Trace";
            this.lblTrace.Click += new System.EventHandler(this.label1_Click);
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMale.Location = new System.Drawing.Point(10, 27);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(57, 21);
            this.rbMale.TabIndex = 3;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbfemale
            // 
            this.rbfemale.AutoSize = true;
            this.rbfemale.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbfemale.Location = new System.Drawing.Point(10, 53);
            this.rbfemale.Name = "rbfemale";
            this.rbfemale.Size = new System.Drawing.Size(73, 21);
            this.rbfemale.TabIndex = 4;
            this.rbfemale.TabStop = true;
            this.rbfemale.Text = "Female";
            this.rbfemale.UseVisualStyleBackColor = true;
            // 
            // rbnotsay
            // 
            this.rbnotsay.AutoSize = true;
            this.rbnotsay.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnotsay.Location = new System.Drawing.Point(10, 79);
            this.rbnotsay.Name = "rbnotsay";
            this.rbnotsay.Size = new System.Drawing.Size(138, 21);
            this.rbnotsay.TabIndex = 5;
            this.rbnotsay.TabStop = true;
            this.rbnotsay.Text = "I prefer not to say";
            this.rbnotsay.UseVisualStyleBackColor = true;
            // 
            // lblfulname
            // 
            this.lblfulname.AutoSize = true;
            this.lblfulname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfulname.Location = new System.Drawing.Point(6, 0);
            this.lblfulname.Name = "lblfulname";
            this.lblfulname.Size = new System.Drawing.Size(92, 19);
            this.lblfulname.TabIndex = 6;
            this.lblfulname.Text = "Full Name:";
            this.lblfulname.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblCTF
            // 
            this.lblCTF.AutoSize = true;
            this.lblCTF.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCTF.ForeColor = System.Drawing.Color.Black;
            this.lblCTF.Location = new System.Drawing.Point(19, 68);
            this.lblCTF.Name = "lblCTF";
            this.lblCTF.Size = new System.Drawing.Size(175, 19);
            this.lblCTF.TabIndex = 11;
            this.lblCTF.Text = "Contact Tracing Form";
            this.lblCTF.Click += new System.EventHandler(this.label7_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(7, 26);
            this.textBox1.Margin = new System.Windows.Forms.Padding(7);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(285, 25);
            this.textBox1.TabIndex = 12;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // lblage
            // 
            this.lblage.AutoSize = true;
            this.lblage.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblage.Location = new System.Drawing.Point(6, 0);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(46, 19);
            this.lblage.TabIndex = 16;
            this.lblage.Text = "Age:";
            this.lblage.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // lblphnum
            // 
            this.lblphnum.AutoSize = true;
            this.lblphnum.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblphnum.Location = new System.Drawing.Point(0, 0);
            this.lblphnum.Name = "lblphnum";
            this.lblphnum.Size = new System.Drawing.Size(130, 19);
            this.lblphnum.TabIndex = 17;
            this.lblphnum.Text = "Phone Number:";
            // 
            // lbladdr
            // 
            this.lbladdr.AutoSize = true;
            this.lbladdr.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdr.Location = new System.Drawing.Point(6, 4);
            this.lbladdr.Name = "lbladdr";
            this.lbladdr.Size = new System.Drawing.Size(74, 19);
            this.lbladdr.TabIndex = 18;
            this.lbladdr.Text = "Address:";
            // 
            // lblgndr
            // 
            this.lblgndr.AutoSize = true;
            this.lblgndr.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgndr.Location = new System.Drawing.Point(3, 0);
            this.lblgndr.Name = "lblgndr";
            this.lblgndr.Size = new System.Drawing.Size(72, 19);
            this.lblgndr.TabIndex = 19;
            this.lblgndr.Text = "Gender:";
            this.lblgndr.Click += new System.EventHandler(this.label6_Click_1);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(10, 26);
            this.textBox2.Margin = new System.Windows.Forms.Padding(7);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(54, 25);
            this.textBox2.TabIndex = 23;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(4, 26);
            this.textBox3.Margin = new System.Windows.Forms.Padding(7);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(214, 25);
            this.textBox3.TabIndex = 24;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(7, 30);
            this.textBox4.Margin = new System.Windows.Forms.Padding(7);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(285, 25);
            this.textBox4.TabIndex = 25;
            // 
            // rbno1
            // 
            this.rbno1.AutoSize = true;
            this.rbno1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbno1.Location = new System.Drawing.Point(14, 59);
            this.rbno1.Name = "rbno1";
            this.rbno1.Size = new System.Drawing.Size(45, 21);
            this.rbno1.TabIndex = 28;
            this.rbno1.TabStop = true;
            this.rbno1.Text = "No";
            this.rbno1.UseVisualStyleBackColor = true;
            // 
            // lblq2
            // 
            this.lblq2.AutoSize = true;
            this.lblq2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblq2.Location = new System.Drawing.Point(10, 13);
            this.lblq2.Name = "lblq2";
            this.lblq2.Size = new System.Drawing.Size(375, 38);
            this.lblq2.TabIndex = 29;
            this.lblq2.Text = "Have you come into close contact with anyone \r\nwho has Covid-19?";
            this.lblq2.Click += new System.EventHandler(this.label9_Click);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton6.Location = new System.Drawing.Point(14, 77);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(45, 21);
            this.radioButton6.TabIndex = 30;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "No";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton7.Location = new System.Drawing.Point(14, 54);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(46, 21);
            this.radioButton7.TabIndex = 31;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "Yes";
            this.radioButton7.UseVisualStyleBackColor = true;
            this.radioButton7.CheckedChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
            // 
            // lblq3
            // 
            this.lblq3.AutoSize = true;
            this.lblq3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblq3.Location = new System.Drawing.Point(10, 12);
            this.lblq3.Name = "lblq3";
            this.lblq3.Size = new System.Drawing.Size(332, 38);
            this.lblq3.TabIndex = 32;
            this.lblq3.Text = "Do you currently have any of the following\r\nconditions during this time?";
            this.lblq3.Click += new System.EventHandler(this.label10_Click);
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton8.Location = new System.Drawing.Point(14, 53);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(60, 21);
            this.radioButton8.TabIndex = 33;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "Fever";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton9.Location = new System.Drawing.Point(14, 80);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(71, 21);
            this.radioButton9.TabIndex = 34;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "Cough";
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton10.Location = new System.Drawing.Point(120, 53);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(162, 21);
            this.radioButton10.TabIndex = 35;
            this.radioButton10.TabStop = true;
            this.radioButton10.Text = "Difficulty of Breathing";
            this.radioButton10.UseVisualStyleBackColor = true;
            // 
            // radioButton11
            // 
            this.radioButton11.AutoSize = true;
            this.radioButton11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton11.Location = new System.Drawing.Point(120, 80);
            this.radioButton11.Name = "radioButton11";
            this.radioButton11.Size = new System.Drawing.Size(61, 21);
            this.radioButton11.TabIndex = 36;
            this.radioButton11.TabStop = true;
            this.radioButton11.Text = "None";
            this.radioButton11.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(19, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 39);
            this.button1.TabIndex = 37;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lblq1
            // 
            this.lblq1.AutoSize = true;
            this.lblq1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblq1.Location = new System.Drawing.Point(10, 10);
            this.lblq1.Name = "lblq1";
            this.lblq1.Size = new System.Drawing.Size(377, 19);
            this.lblq1.TabIndex = 26;
            this.lblq1.Text = "Have you traveled outside the country anytime?";
            this.lblq1.Click += new System.EventHandler(this.label8_Click_1);
            // 
            // rbyes1
            // 
            this.rbyes1.AutoSize = true;
            this.rbyes1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbyes1.Location = new System.Drawing.Point(14, 32);
            this.rbyes1.Name = "rbyes1";
            this.rbyes1.Size = new System.Drawing.Size(46, 21);
            this.rbyes1.TabIndex = 27;
            this.rbyes1.TabStop = true;
            this.rbyes1.Text = "Yes";
            this.rbyes1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.rbno1);
            this.panel1.Controls.Add(this.rbyes1);
            this.panel1.Controls.Add(this.lblq1);
            this.panel1.Location = new System.Drawing.Point(326, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(402, 92);
            this.panel1.TabIndex = 38;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioButton7);
            this.panel2.Controls.Add(this.radioButton6);
            this.panel2.Controls.Add(this.lblq2);
            this.panel2.Location = new System.Drawing.Point(326, 207);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(402, 107);
            this.panel2.TabIndex = 39;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.radioButton11);
            this.panel3.Controls.Add(this.radioButton10);
            this.panel3.Controls.Add(this.radioButton9);
            this.panel3.Controls.Add(this.radioButton8);
            this.panel3.Controls.Add(this.lblq3);
            this.panel3.Location = new System.Drawing.Point(326, 311);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(402, 116);
            this.panel3.TabIndex = 40;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblgndr);
            this.panel4.Controls.Add(this.rbnotsay);
            this.panel4.Controls.Add(this.rbfemale);
            this.panel4.Controls.Add(this.rbMale);
            this.panel4.Location = new System.Drawing.Point(12, 281);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(203, 104);
            this.panel4.TabIndex = 41;
            // 
            // pnl1
            // 
            this.pnl1.Controls.Add(this.lblCTF);
            this.pnl1.Controls.Add(this.lblTrace);
            this.pnl1.Location = new System.Drawing.Point(12, 4);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(224, 97);
            this.pnl1.TabIndex = 42;
            // 
            // pnl2
            // 
            this.pnl2.Controls.Add(this.textBox1);
            this.pnl2.Controls.Add(this.lblfulname);
            this.pnl2.Location = new System.Drawing.Point(12, 104);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(299, 55);
            this.pnl2.TabIndex = 43;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.textBox2);
            this.panel7.Controls.Add(this.lblage);
            this.panel7.Location = new System.Drawing.Point(12, 162);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(69, 55);
            this.panel7.TabIndex = 44;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.textBox3);
            this.panel8.Controls.Add(this.lblphnum);
            this.panel8.Location = new System.Drawing.Point(86, 162);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(222, 57);
            this.panel8.TabIndex = 45;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.textBox4);
            this.panel9.Controls.Add(this.lbladdr);
            this.panel9.Location = new System.Drawing.Point(12, 216);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(297, 60);
            this.panel9.TabIndex = 46;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Contact_Tracing_Form_OOP.Properties.Resources.IMG_1466;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(767, 460);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.pnl2);
            this.Controls.Add(this.pnl1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            this.pnl2.ResumeLayout(false);
            this.pnl2.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTrace;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbfemale;
        private System.Windows.Forms.RadioButton rbnotsay;
        private System.Windows.Forms.Label lblfulname;
        private System.Windows.Forms.Label lblCTF;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblage;
        private System.Windows.Forms.Label lblphnum;
        private System.Windows.Forms.Label lbladdr;
        private System.Windows.Forms.Label lblgndr;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.RadioButton rbno1;
        private System.Windows.Forms.Label lblq2;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.Label lblq3;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.RadioButton radioButton11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblq1;
        private System.Windows.Forms.RadioButton rbyes1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.Panel pnl2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
    }
}

