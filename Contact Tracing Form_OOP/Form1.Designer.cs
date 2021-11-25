
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblTrace = new System.Windows.Forms.Label();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbfemale = new System.Windows.Forms.RadioButton();
            this.rbnotsay = new System.Windows.Forms.RadioButton();
            this.lblfulname = new System.Windows.Forms.Label();
            this.lblCTF = new System.Windows.Forms.Label();
            this.tbFN = new System.Windows.Forms.TextBox();
            this.lblage = new System.Windows.Forms.Label();
            this.lblphnum = new System.Windows.Forms.Label();
            this.lbladdr = new System.Windows.Forms.Label();
            this.lblgndr = new System.Windows.Forms.Label();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.tbPN = new System.Windows.Forms.TextBox();
            this.tbAddr = new System.Windows.Forms.TextBox();
            this.rbno1 = new System.Windows.Forms.RadioButton();
            this.lblq2 = new System.Windows.Forms.Label();
            this.rbno2 = new System.Windows.Forms.RadioButton();
            this.rbyes2 = new System.Windows.Forms.RadioButton();
            this.lblq3 = new System.Windows.Forms.Label();
            this.rbfvr = new System.Windows.Forms.RadioButton();
            this.rbcgh = new System.Windows.Forms.RadioButton();
            this.rbdob = new System.Windows.Forms.RadioButton();
            this.rbnon = new System.Windows.Forms.RadioButton();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblq1 = new System.Windows.Forms.Label();
            this.rbyes1 = new System.Windows.Forms.RadioButton();
            this.pnl7 = new System.Windows.Forms.Panel();
            this.pnl8 = new System.Windows.Forms.Panel();
            this.pnl9 = new System.Windows.Forms.Panel();
            this.pnl6 = new System.Windows.Forms.Panel();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.pnl2 = new System.Windows.Forms.Panel();
            this.pnl3 = new System.Windows.Forms.Panel();
            this.pnl4 = new System.Windows.Forms.Panel();
            this.pnl5 = new System.Windows.Forms.Panel();
            this.lblhstag = new System.Windows.Forms.Label();
            this.pnl7.SuspendLayout();
            this.pnl8.SuspendLayout();
            this.pnl9.SuspendLayout();
            this.pnl6.SuspendLayout();
            this.pnl1.SuspendLayout();
            this.pnl2.SuspendLayout();
            this.pnl3.SuspendLayout();
            this.pnl4.SuspendLayout();
            this.pnl5.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTrace
            // 
            this.lblTrace.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.rbMale.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbMale.AutoSize = true;
            this.rbMale.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMale.Location = new System.Drawing.Point(10, 27);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(57, 21);
            this.rbMale.TabIndex = 3;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            this.rbMale.CheckedChanged += new System.EventHandler(this.rbMale_CheckedChanged);
            // 
            // rbfemale
            // 
            this.rbfemale.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbfemale.AutoSize = true;
            this.rbfemale.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbfemale.Location = new System.Drawing.Point(10, 53);
            this.rbfemale.Name = "rbfemale";
            this.rbfemale.Size = new System.Drawing.Size(73, 21);
            this.rbfemale.TabIndex = 4;
            this.rbfemale.TabStop = true;
            this.rbfemale.Text = "Female";
            this.rbfemale.UseVisualStyleBackColor = true;
            this.rbfemale.CheckedChanged += new System.EventHandler(this.rbfemale_CheckedChanged);
            // 
            // rbnotsay
            // 
            this.rbnotsay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbnotsay.AutoSize = true;
            this.rbnotsay.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnotsay.Location = new System.Drawing.Point(10, 79);
            this.rbnotsay.Name = "rbnotsay";
            this.rbnotsay.Size = new System.Drawing.Size(138, 21);
            this.rbnotsay.TabIndex = 5;
            this.rbnotsay.TabStop = true;
            this.rbnotsay.Text = "I prefer not to say";
            this.rbnotsay.UseVisualStyleBackColor = true;
            this.rbnotsay.CheckedChanged += new System.EventHandler(this.rbnotsay_CheckedChanged);
            // 
            // lblfulname
            // 
            this.lblfulname.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.lblCTF.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            // tbFN
            // 
            this.tbFN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbFN.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFN.Location = new System.Drawing.Point(7, 26);
            this.tbFN.Margin = new System.Windows.Forms.Padding(7);
            this.tbFN.Multiline = true;
            this.tbFN.Name = "tbFN";
            this.tbFN.Size = new System.Drawing.Size(285, 25);
            this.tbFN.TabIndex = 12;
            this.tbFN.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            this.tbFN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFN_KeyPress);
            // 
            // lblage
            // 
            this.lblage.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.lblphnum.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.lbladdr.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.lblgndr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblgndr.AutoSize = true;
            this.lblgndr.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgndr.Location = new System.Drawing.Point(3, 0);
            this.lblgndr.Name = "lblgndr";
            this.lblgndr.Size = new System.Drawing.Size(72, 19);
            this.lblgndr.TabIndex = 19;
            this.lblgndr.Text = "Gender:";
            this.lblgndr.Click += new System.EventHandler(this.label6_Click_1);
            // 
            // tbAge
            // 
            this.tbAge.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbAge.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAge.Location = new System.Drawing.Point(10, 26);
            this.tbAge.Margin = new System.Windows.Forms.Padding(7);
            this.tbAge.Multiline = true;
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(54, 25);
            this.tbAge.TabIndex = 23;
            this.tbAge.TextChanged += new System.EventHandler(this.tbAge_TextChanged);
            this.tbAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAge_KeyPress);
            // 
            // tbPN
            // 
            this.tbPN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbPN.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPN.Location = new System.Drawing.Point(4, 26);
            this.tbPN.Margin = new System.Windows.Forms.Padding(7);
            this.tbPN.Multiline = true;
            this.tbPN.Name = "tbPN";
            this.tbPN.Size = new System.Drawing.Size(214, 25);
            this.tbPN.TabIndex = 24;
            this.tbPN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPN_KeyPress);
            // 
            // tbAddr
            // 
            this.tbAddr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbAddr.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddr.Location = new System.Drawing.Point(7, 30);
            this.tbAddr.Margin = new System.Windows.Forms.Padding(7);
            this.tbAddr.Multiline = true;
            this.tbAddr.Name = "tbAddr";
            this.tbAddr.Size = new System.Drawing.Size(285, 25);
            this.tbAddr.TabIndex = 25;
            this.tbAddr.TextChanged += new System.EventHandler(this.tbAddr_TextChanged);
            // 
            // rbno1
            // 
            this.rbno1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbno1.AutoSize = true;
            this.rbno1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbno1.Location = new System.Drawing.Point(14, 67);
            this.rbno1.Name = "rbno1";
            this.rbno1.Size = new System.Drawing.Size(45, 21);
            this.rbno1.TabIndex = 28;
            this.rbno1.TabStop = true;
            this.rbno1.Text = "No";
            this.rbno1.UseVisualStyleBackColor = true;
            this.rbno1.CheckedChanged += new System.EventHandler(this.rbno1_CheckedChanged);
            // 
            // lblq2
            // 
            this.lblq2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblq2.AutoSize = true;
            this.lblq2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblq2.Location = new System.Drawing.Point(13, 13);
            this.lblq2.Name = "lblq2";
            this.lblq2.Size = new System.Drawing.Size(375, 38);
            this.lblq2.TabIndex = 29;
            this.lblq2.Text = "Have you come into close contact with anyone \r\nwho has Covid-19?";
            this.lblq2.Click += new System.EventHandler(this.label9_Click);
            // 
            // rbno2
            // 
            this.rbno2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbno2.AutoSize = true;
            this.rbno2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbno2.Location = new System.Drawing.Point(17, 83);
            this.rbno2.Name = "rbno2";
            this.rbno2.Size = new System.Drawing.Size(45, 21);
            this.rbno2.TabIndex = 30;
            this.rbno2.TabStop = true;
            this.rbno2.Text = "No";
            this.rbno2.UseVisualStyleBackColor = true;
            this.rbno2.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // rbyes2
            // 
            this.rbyes2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbyes2.AutoSize = true;
            this.rbyes2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbyes2.Location = new System.Drawing.Point(17, 56);
            this.rbyes2.Name = "rbyes2";
            this.rbyes2.Size = new System.Drawing.Size(46, 21);
            this.rbyes2.TabIndex = 31;
            this.rbyes2.TabStop = true;
            this.rbyes2.Text = "Yes";
            this.rbyes2.UseVisualStyleBackColor = true;
            this.rbyes2.CheckedChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
            // 
            // lblq3
            // 
            this.lblq3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblq3.AutoSize = true;
            this.lblq3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblq3.Location = new System.Drawing.Point(13, 12);
            this.lblq3.Name = "lblq3";
            this.lblq3.Size = new System.Drawing.Size(332, 38);
            this.lblq3.TabIndex = 32;
            this.lblq3.Text = "Do you currently have any of the following\r\nconditions during this time?";
            this.lblq3.Click += new System.EventHandler(this.label10_Click);
            // 
            // rbfvr
            // 
            this.rbfvr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbfvr.AutoSize = true;
            this.rbfvr.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbfvr.Location = new System.Drawing.Point(17, 53);
            this.rbfvr.Name = "rbfvr";
            this.rbfvr.Size = new System.Drawing.Size(60, 21);
            this.rbfvr.TabIndex = 33;
            this.rbfvr.TabStop = true;
            this.rbfvr.Text = "Fever";
            this.rbfvr.UseVisualStyleBackColor = true;
            this.rbfvr.CheckedChanged += new System.EventHandler(this.rbfvr_CheckedChanged);
            // 
            // rbcgh
            // 
            this.rbcgh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbcgh.AutoSize = true;
            this.rbcgh.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbcgh.Location = new System.Drawing.Point(17, 80);
            this.rbcgh.Name = "rbcgh";
            this.rbcgh.Size = new System.Drawing.Size(71, 21);
            this.rbcgh.TabIndex = 34;
            this.rbcgh.TabStop = true;
            this.rbcgh.Text = "Cough";
            this.rbcgh.UseVisualStyleBackColor = true;
            this.rbcgh.CheckedChanged += new System.EventHandler(this.rbcgh_CheckedChanged);
            // 
            // rbdob
            // 
            this.rbdob.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbdob.AutoSize = true;
            this.rbdob.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbdob.Location = new System.Drawing.Point(120, 53);
            this.rbdob.Name = "rbdob";
            this.rbdob.Size = new System.Drawing.Size(162, 21);
            this.rbdob.TabIndex = 35;
            this.rbdob.TabStop = true;
            this.rbdob.Text = "Difficulty of Breathing";
            this.rbdob.UseVisualStyleBackColor = true;
            this.rbdob.CheckedChanged += new System.EventHandler(this.rbdob_CheckedChanged);
            // 
            // rbnon
            // 
            this.rbnon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbnon.AutoSize = true;
            this.rbnon.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnon.Location = new System.Drawing.Point(120, 80);
            this.rbnon.Name = "rbnon";
            this.rbnon.Size = new System.Drawing.Size(61, 21);
            this.rbnon.TabIndex = 36;
            this.rbnon.TabStop = true;
            this.rbnon.Text = "None";
            this.rbnon.UseVisualStyleBackColor = true;
            this.rbnon.CheckedChanged += new System.EventHandler(this.rbnon_CheckedChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSubmit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(19, 399);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(106, 39);
            this.btnSubmit.TabIndex = 37;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblq1
            // 
            this.lblq1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblq1.AutoSize = true;
            this.lblq1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblq1.Location = new System.Drawing.Point(10, 18);
            this.lblq1.Name = "lblq1";
            this.lblq1.Size = new System.Drawing.Size(377, 19);
            this.lblq1.TabIndex = 26;
            this.lblq1.Text = "Have you traveled outside the country anytime?";
            this.lblq1.Click += new System.EventHandler(this.label8_Click_1);
            // 
            // rbyes1
            // 
            this.rbyes1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbyes1.AutoSize = true;
            this.rbyes1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbyes1.Location = new System.Drawing.Point(14, 40);
            this.rbyes1.Name = "rbyes1";
            this.rbyes1.Size = new System.Drawing.Size(46, 21);
            this.rbyes1.TabIndex = 27;
            this.rbyes1.TabStop = true;
            this.rbyes1.Text = "Yes";
            this.rbyes1.UseVisualStyleBackColor = true;
            this.rbyes1.CheckedChanged += new System.EventHandler(this.rbyes1_CheckedChanged);
            // 
            // pnl7
            // 
            this.pnl7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnl7.BackColor = System.Drawing.SystemColors.Control;
            this.pnl7.Controls.Add(this.rbno1);
            this.pnl7.Controls.Add(this.rbyes1);
            this.pnl7.Controls.Add(this.lblq1);
            this.pnl7.Location = new System.Drawing.Point(326, 46);
            this.pnl7.Name = "pnl7";
            this.pnl7.Size = new System.Drawing.Size(402, 109);
            this.pnl7.TabIndex = 38;
            this.pnl7.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl7_Paint);
            // 
            // pnl8
            // 
            this.pnl8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnl8.Controls.Add(this.rbyes2);
            this.pnl8.Controls.Add(this.rbno2);
            this.pnl8.Controls.Add(this.lblq2);
            this.pnl8.Location = new System.Drawing.Point(323, 140);
            this.pnl8.Name = "pnl8";
            this.pnl8.Size = new System.Drawing.Size(402, 107);
            this.pnl8.TabIndex = 39;
            this.pnl8.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl8_Paint);
            // 
            // pnl9
            // 
            this.pnl9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnl9.Controls.Add(this.rbnon);
            this.pnl9.Controls.Add(this.rbdob);
            this.pnl9.Controls.Add(this.rbcgh);
            this.pnl9.Controls.Add(this.rbfvr);
            this.pnl9.Controls.Add(this.lblq3);
            this.pnl9.Location = new System.Drawing.Point(323, 250);
            this.pnl9.Name = "pnl9";
            this.pnl9.Size = new System.Drawing.Size(402, 116);
            this.pnl9.TabIndex = 40;
            this.pnl9.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl9_Paint);
            // 
            // pnl6
            // 
            this.pnl6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnl6.Controls.Add(this.lblgndr);
            this.pnl6.Controls.Add(this.rbnotsay);
            this.pnl6.Controls.Add(this.rbfemale);
            this.pnl6.Controls.Add(this.rbMale);
            this.pnl6.Location = new System.Drawing.Point(12, 281);
            this.pnl6.Name = "pnl6";
            this.pnl6.Size = new System.Drawing.Size(203, 104);
            this.pnl6.TabIndex = 41;
            this.pnl6.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl6_Paint);
            // 
            // pnl1
            // 
            this.pnl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnl1.Controls.Add(this.lblCTF);
            this.pnl1.Controls.Add(this.lblTrace);
            this.pnl1.Location = new System.Drawing.Point(12, 4);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(224, 97);
            this.pnl1.TabIndex = 42;
            this.pnl1.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl1_Paint);
            // 
            // pnl2
            // 
            this.pnl2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnl2.Controls.Add(this.tbFN);
            this.pnl2.Controls.Add(this.lblfulname);
            this.pnl2.Location = new System.Drawing.Point(12, 104);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(299, 55);
            this.pnl2.TabIndex = 43;
            this.pnl2.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl2_Paint);
            // 
            // pnl3
            // 
            this.pnl3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnl3.Controls.Add(this.tbAge);
            this.pnl3.Controls.Add(this.lblage);
            this.pnl3.Location = new System.Drawing.Point(12, 162);
            this.pnl3.Name = "pnl3";
            this.pnl3.Size = new System.Drawing.Size(69, 55);
            this.pnl3.TabIndex = 44;
            this.pnl3.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl3_Paint);
            // 
            // pnl4
            // 
            this.pnl4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnl4.Controls.Add(this.tbPN);
            this.pnl4.Controls.Add(this.lblphnum);
            this.pnl4.Location = new System.Drawing.Point(86, 162);
            this.pnl4.Name = "pnl4";
            this.pnl4.Size = new System.Drawing.Size(222, 57);
            this.pnl4.TabIndex = 45;
            this.pnl4.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl4_Paint);
            // 
            // pnl5
            // 
            this.pnl5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnl5.Controls.Add(this.tbAddr);
            this.pnl5.Controls.Add(this.lbladdr);
            this.pnl5.Location = new System.Drawing.Point(12, 216);
            this.pnl5.Name = "pnl5";
            this.pnl5.Size = new System.Drawing.Size(297, 60);
            this.pnl5.TabIndex = 46;
            this.pnl5.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl5_Paint);
            // 
            // lblhstag
            // 
            this.lblhstag.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblhstag.AutoSize = true;
            this.lblhstag.BackColor = System.Drawing.Color.Transparent;
            this.lblhstag.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhstag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblhstag.Location = new System.Drawing.Point(323, 386);
            this.lblhstag.Name = "lblhstag";
            this.lblhstag.Size = new System.Drawing.Size(238, 50);
            this.lblhstag.TabIndex = 47;
            this.lblhstag.Text = "#StayHomeSaveLives\r\n#WearMask #StaySafe";
            this.lblhstag.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Contact_Tracing_Form_OOP.Properties.Resources.IMG_1477;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(767, 460);
            this.Controls.Add(this.lblhstag);
            this.Controls.Add(this.pnl5);
            this.Controls.Add(this.pnl4);
            this.Controls.Add(this.pnl9);
            this.Controls.Add(this.pnl8);
            this.Controls.Add(this.pnl3);
            this.Controls.Add(this.pnl2);
            this.Controls.Add(this.pnl1);
            this.Controls.Add(this.pnl6);
            this.Controls.Add(this.pnl7);
            this.Controls.Add(this.btnSubmit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnl7.ResumeLayout(false);
            this.pnl7.PerformLayout();
            this.pnl8.ResumeLayout(false);
            this.pnl8.PerformLayout();
            this.pnl9.ResumeLayout(false);
            this.pnl9.PerformLayout();
            this.pnl6.ResumeLayout(false);
            this.pnl6.PerformLayout();
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            this.pnl2.ResumeLayout(false);
            this.pnl2.PerformLayout();
            this.pnl3.ResumeLayout(false);
            this.pnl3.PerformLayout();
            this.pnl4.ResumeLayout(false);
            this.pnl4.PerformLayout();
            this.pnl5.ResumeLayout(false);
            this.pnl5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTrace;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbfemale;
        private System.Windows.Forms.RadioButton rbnotsay;
        private System.Windows.Forms.Label lblfulname;
        private System.Windows.Forms.Label lblCTF;
        private System.Windows.Forms.TextBox tbFN;
        private System.Windows.Forms.Label lblage;
        private System.Windows.Forms.Label lblphnum;
        private System.Windows.Forms.Label lbladdr;
        private System.Windows.Forms.Label lblgndr;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.TextBox tbPN;
        private System.Windows.Forms.TextBox tbAddr;
        private System.Windows.Forms.RadioButton rbno1;
        private System.Windows.Forms.Label lblq2;
        private System.Windows.Forms.RadioButton rbno2;
        private System.Windows.Forms.RadioButton rbyes2;
        private System.Windows.Forms.Label lblq3;
        private System.Windows.Forms.RadioButton rbfvr;
        private System.Windows.Forms.RadioButton rbcgh;
        private System.Windows.Forms.RadioButton rbdob;
        private System.Windows.Forms.RadioButton rbnon;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblq1;
        private System.Windows.Forms.RadioButton rbyes1;
        private System.Windows.Forms.Panel pnl7;
        private System.Windows.Forms.Panel pnl8;
        private System.Windows.Forms.Panel pnl9;
        private System.Windows.Forms.Panel pnl6;
        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.Panel pnl2;
        private System.Windows.Forms.Panel pnl3;
        private System.Windows.Forms.Panel pnl4;
        private System.Windows.Forms.Panel pnl5;
        private System.Windows.Forms.Label lblhstag;
    }
}

