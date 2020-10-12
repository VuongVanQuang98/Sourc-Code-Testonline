namespace ClientApp
{
    partial class FormTest
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
            this.components = new System.ComponentModel.Container();
            this.lstQuestion = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBFinish = new System.Windows.Forms.CheckBox();
            this.rtA = new System.Windows.Forms.RichTextBox();
            this.btnFinish = new System.Windows.Forms.Button();
            this.rdD = new System.Windows.Forms.RadioButton();
            this.rdC = new System.Windows.Forms.RadioButton();
            this.rdB = new System.Windows.Forms.RadioButton();
            this.rdA = new System.Windows.Forms.RadioButton();
            this.rtD = new System.Windows.Forms.RichTextBox();
            this.rtC = new System.Windows.Forms.RichTextBox();
            this.rtB = new System.Windows.Forms.RichTextBox();
            this.rtContent = new System.Windows.Forms.RichTextBox();
            this.lblExamCode = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.Timeleft = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lstQuestion
            // 
            this.lstQuestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstQuestion.Cursor = System.Windows.Forms.Cursors.Default;
            this.lstQuestion.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstQuestion.FormattingEnabled = true;
            this.lstQuestion.ItemHeight = 17;
            this.lstQuestion.Location = new System.Drawing.Point(103, 208);
            this.lstQuestion.Name = "lstQuestion";
            this.lstQuestion.Size = new System.Drawing.Size(157, 461);
            this.lstQuestion.TabIndex = 0;
            this.lstQuestion.SelectedIndexChanged += new System.EventHandler(this.lstQuestion_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Question List :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBFinish);
            this.groupBox1.Controls.Add(this.rtA);
            this.groupBox1.Controls.Add(this.btnFinish);
            this.groupBox1.Controls.Add(this.rdD);
            this.groupBox1.Controls.Add(this.rdC);
            this.groupBox1.Controls.Add(this.rdB);
            this.groupBox1.Controls.Add(this.rdA);
            this.groupBox1.Controls.Add(this.rtD);
            this.groupBox1.Controls.Add(this.rtC);
            this.groupBox1.Controls.Add(this.rtB);
            this.groupBox1.Controls.Add(this.rtContent);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(266, 183);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(623, 501);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Question Content";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // checkBFinish
            // 
            this.checkBFinish.AutoSize = true;
            this.checkBFinish.Location = new System.Drawing.Point(32, 432);
            this.checkBFinish.Name = "checkBFinish";
            this.checkBFinish.Size = new System.Drawing.Size(178, 23);
            this.checkBFinish.TabIndex = 33;
            this.checkBFinish.Text = "I want to finish the exam ";
            this.checkBFinish.UseVisualStyleBackColor = true;
            this.checkBFinish.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            this.checkBFinish.CheckStateChanged += new System.EventHandler(this.checkBFinish_CheckStateChanged);
            this.checkBFinish.Click += new System.EventHandler(this.checkBFinish_Click);
            // 
            // rtA
            // 
            this.rtA.Font = new System.Drawing.Font("Gill Sans MT", 12F);
            this.rtA.Location = new System.Drawing.Point(112, 175);
            this.rtA.Name = "rtA";
            this.rtA.Size = new System.Drawing.Size(311, 36);
            this.rtA.TabIndex = 32;
            this.rtA.Text = "";
            this.rtA.TextChanged += new System.EventHandler(this.rtA_TextChanged_1);
            // 
            // btnFinish
            // 
            this.btnFinish.Enabled = false;
            this.btnFinish.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnFinish.FlatAppearance.BorderSize = 3;
            this.btnFinish.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnFinish.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnFinish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinish.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold);
            this.btnFinish.Location = new System.Drawing.Point(31, 461);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(85, 34);
            this.btnFinish.TabIndex = 31;
            this.btnFinish.Text = "&Finish";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // rdD
            // 
            this.rdD.AutoSize = true;
            this.rdD.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold);
            this.rdD.Location = new System.Drawing.Point(32, 366);
            this.rdD.Name = "rdD";
            this.rdD.Size = new System.Drawing.Size(41, 27);
            this.rdD.TabIndex = 30;
            this.rdD.TabStop = true;
            this.rdD.Text = "D";
            this.rdD.UseVisualStyleBackColor = true;
            this.rdD.CheckedChanged += new System.EventHandler(this.rdD_CheckedChanged_1);
            // 
            // rdC
            // 
            this.rdC.AutoSize = true;
            this.rdC.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold);
            this.rdC.Location = new System.Drawing.Point(31, 306);
            this.rdC.Name = "rdC";
            this.rdC.Size = new System.Drawing.Size(40, 27);
            this.rdC.TabIndex = 29;
            this.rdC.TabStop = true;
            this.rdC.Text = "C";
            this.rdC.UseVisualStyleBackColor = true;
            this.rdC.CheckedChanged += new System.EventHandler(this.rdC_CheckedChanged_1);
            // 
            // rdB
            // 
            this.rdB.AutoSize = true;
            this.rdB.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold);
            this.rdB.Location = new System.Drawing.Point(32, 248);
            this.rdB.Name = "rdB";
            this.rdB.Size = new System.Drawing.Size(39, 27);
            this.rdB.TabIndex = 28;
            this.rdB.TabStop = true;
            this.rdB.Text = "B";
            this.rdB.UseVisualStyleBackColor = true;
            this.rdB.CheckedChanged += new System.EventHandler(this.rdB_CheckedChanged_1);
            // 
            // rdA
            // 
            this.rdA.AutoSize = true;
            this.rdA.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold);
            this.rdA.Location = new System.Drawing.Point(31, 184);
            this.rdA.Name = "rdA";
            this.rdA.Size = new System.Drawing.Size(41, 27);
            this.rdA.TabIndex = 27;
            this.rdA.TabStop = true;
            this.rdA.Text = "A";
            this.rdA.UseVisualStyleBackColor = true;
            this.rdA.CheckedChanged += new System.EventHandler(this.rdA_CheckedChanged_1);
            // 
            // rtD
            // 
            this.rtD.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtD.Location = new System.Drawing.Point(112, 355);
            this.rtD.Name = "rtD";
            this.rtD.Size = new System.Drawing.Size(311, 33);
            this.rtD.TabIndex = 26;
            this.rtD.Text = "";
            // 
            // rtC
            // 
            this.rtC.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtC.Location = new System.Drawing.Point(112, 303);
            this.rtC.Name = "rtC";
            this.rtC.Size = new System.Drawing.Size(311, 31);
            this.rtC.TabIndex = 25;
            this.rtC.Text = "";
            // 
            // rtB
            // 
            this.rtB.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtB.Location = new System.Drawing.Point(112, 242);
            this.rtB.Name = "rtB";
            this.rtB.Size = new System.Drawing.Size(311, 34);
            this.rtB.TabIndex = 24;
            this.rtB.Text = "";
            // 
            // rtContent
            // 
            this.rtContent.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtContent.Location = new System.Drawing.Point(6, 25);
            this.rtContent.Name = "rtContent";
            this.rtContent.Size = new System.Drawing.Size(589, 130);
            this.rtContent.TabIndex = 23;
            this.rtContent.Text = "";
            // 
            // lblExamCode
            // 
            this.lblExamCode.AutoSize = true;
            this.lblExamCode.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExamCode.ForeColor = System.Drawing.Color.Black;
            this.lblExamCode.Location = new System.Drawing.Point(3, 17);
            this.lblExamCode.Name = "lblExamCode";
            this.lblExamCode.Size = new System.Drawing.Size(103, 19);
            this.lblExamCode.TabIndex = 14;
            this.lblExamCode.Text = "Exam Code :  ";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(4, 50);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(109, 18);
            this.lblName.TabIndex = 15;
            this.lblName.Text = "Full Name :  ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(359, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 26);
            this.label2.TabIndex = 16;
            this.label2.Text = "Final Test";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.lblExamCode);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Location = new System.Drawing.Point(5, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 147);
            this.panel1.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(7, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 18);
            this.label9.TabIndex = 19;
            this.label9.Text = "Total Mark : 10 ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(102, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 18);
            this.label3.TabIndex = 18;
            this.label3.Text = "40 minutes";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(4, 82);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 18);
            this.label11.TabIndex = 17;
            this.label11.Text = "Duration : ";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(608, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 18);
            this.label4.TabIndex = 18;
            this.label4.Text = "Time Left :  ";
            // 
            // Timeleft
            // 
            this.Timeleft.AutoSize = true;
            this.Timeleft.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Timeleft.ForeColor = System.Drawing.Color.Black;
            this.Timeleft.Location = new System.Drawing.Point(724, 153);
            this.Timeleft.Name = "Timeleft";
            this.Timeleft.Size = new System.Drawing.Size(121, 32);
            this.Timeleft.TabIndex = 18;
            this.Timeleft.Text = "40:00:00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Question 1 : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Question 2 : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Question 3 : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 259);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Question 4 : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(4, 276);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "Question 5 : ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ClientApp.Properties.Resources.Anh;
            this.pictureBox2.Location = new System.Drawing.Point(291, 41);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(208, 139);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ClientApp.Properties.Resources.Timer_2_icon;
            this.pictureBox1.Location = new System.Drawing.Point(693, 155);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // FormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(896, 685);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Timeleft);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstQuestion);
            this.Name = "FormTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstQuestion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rtA;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.RadioButton rdD;
        private System.Windows.Forms.RadioButton rdC;
        private System.Windows.Forms.RadioButton rdB;
        private System.Windows.Forms.RadioButton rdA;
        private System.Windows.Forms.RichTextBox rtD;
        private System.Windows.Forms.RichTextBox rtC;
        private System.Windows.Forms.RichTextBox rtB;
        private System.Windows.Forms.RichTextBox rtContent;
        private System.Windows.Forms.Label lblExamCode;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Timeleft;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckBox checkBFinish;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
    }
}

