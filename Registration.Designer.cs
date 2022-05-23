
namespace E_camp
{
    partial class Registration
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fname = new System.Windows.Forms.TextBox();
            this.ageBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gend = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cont = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.optrip = new System.Windows.Forms.ComboBox();
            this.dadfname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dadcont = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.regBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(278, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Register To Camp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(100, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Full Name";
            // 
            // fname
            // 
            this.fname.Location = new System.Drawing.Point(193, 114);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(125, 27);
            this.fname.TabIndex = 2;
            this.fname.TextChanged += new System.EventHandler(this.fname_TextChanged);
            // 
            // ageBox
            // 
            this.ageBox.Location = new System.Drawing.Point(193, 161);
            this.ageBox.Name = "ageBox";
            this.ageBox.Size = new System.Drawing.Size(125, 27);
            this.ageBox.TabIndex = 4;
            this.ageBox.TextChanged += new System.EventHandler(this.ageBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(100, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Age";
            // 
            // gend
            // 
            this.gend.FormattingEnabled = true;
            this.gend.Items.AddRange(new object[] {
            "male",
            "female",
            "apache helicopter"});
            this.gend.Location = new System.Drawing.Point(193, 211);
            this.gend.Name = "gend";
            this.gend.Size = new System.Drawing.Size(125, 28);
            this.gend.TabIndex = 5;
            this.gend.SelectedIndexChanged += new System.EventHandler(this.gend_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Gender";
            // 
            // cont
            // 
            this.cont.Location = new System.Drawing.Point(193, 262);
            this.cont.Name = "cont";
            this.cont.Size = new System.Drawing.Size(125, 27);
            this.cont.TabIndex = 8;
            this.cont.TextChanged += new System.EventHandler(this.cont_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(100, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Contact";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Optional Trips";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // optrip
            // 
            this.optrip.FormattingEnabled = true;
            this.optrip.Items.AddRange(new object[] {
            "op1",
            "op2"});
            this.optrip.Location = new System.Drawing.Point(193, 314);
            this.optrip.Name = "optrip";
            this.optrip.Size = new System.Drawing.Size(125, 28);
            this.optrip.TabIndex = 9;
            this.optrip.SelectedIndexChanged += new System.EventHandler(this.optrip_SelectedIndexChanged);
            // 
            // dadfname
            // 
            this.dadfname.Location = new System.Drawing.Point(549, 161);
            this.dadfname.Name = "dadfname";
            this.dadfname.Size = new System.Drawing.Size(125, 27);
            this.dadfname.TabIndex = 12;
            this.dadfname.TextChanged += new System.EventHandler(this.dadfname_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(395, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Guardian Full Name";
            // 
            // dadcont
            // 
            this.dadcont.Location = new System.Drawing.Point(549, 233);
            this.dadcont.Name = "dadcont";
            this.dadcont.Size = new System.Drawing.Size(125, 27);
            this.dadcont.TabIndex = 14;
            this.dadcont.TextChanged += new System.EventHandler(this.dadcont_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(395, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Guardian Contact";
            // 
            // regBtn
            // 
            this.regBtn.Location = new System.Drawing.Point(345, 384);
            this.regBtn.Name = "regBtn";
            this.regBtn.Size = new System.Drawing.Size(94, 29);
            this.regBtn.TabIndex = 15;
            this.regBtn.Text = "Register";
            this.regBtn.UseVisualStyleBackColor = true;
            this.regBtn.Click += new System.EventHandler(this.regBtn_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.regBtn);
            this.Controls.Add(this.dadcont);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dadfname);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.optrip);
            this.Controls.Add(this.cont);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gend);
            this.Controls.Add(this.ageBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Registration";
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Registration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fname;
        private System.Windows.Forms.TextBox ageBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox gend;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cont;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox optrip;
        private System.Windows.Forms.TextBox dadfname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox dadcont;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button regBtn;
    }
}