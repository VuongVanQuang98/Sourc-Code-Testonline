namespace ClientApp
{
    partial class ExamFinished
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblExamCode2 = new System.Windows.Forms.Label();
            this.lblName2 = new System.Windows.Forms.Label();
            this.lblYourScore = new System.Windows.Forms.Label();
            this.btnExitExam = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblYourScore);
            this.panel1.Controls.Add(this.lblExamCode2);
            this.panel1.Controls.Add(this.lblName2);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 167);
            this.panel1.TabIndex = 18;
            // 
            // lblExamCode2
            // 
            this.lblExamCode2.AutoSize = true;
            this.lblExamCode2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExamCode2.ForeColor = System.Drawing.Color.Black;
            this.lblExamCode2.Location = new System.Drawing.Point(3, 17);
            this.lblExamCode2.Name = "lblExamCode2";
            this.lblExamCode2.Size = new System.Drawing.Size(103, 19);
            this.lblExamCode2.TabIndex = 14;
            this.lblExamCode2.Text = "Exam Code :  ";
            // 
            // lblName2
            // 
            this.lblName2.AutoSize = true;
            this.lblName2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName2.ForeColor = System.Drawing.Color.Black;
            this.lblName2.Location = new System.Drawing.Point(4, 55);
            this.lblName2.Name = "lblName2";
            this.lblName2.Size = new System.Drawing.Size(109, 18);
            this.lblName2.TabIndex = 15;
            this.lblName2.Text = "Full Name :  ";
            // 
            // lblYourScore
            // 
            this.lblYourScore.AutoSize = true;
            this.lblYourScore.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.lblYourScore.ForeColor = System.Drawing.Color.Black;
            this.lblYourScore.Location = new System.Drawing.Point(3, 97);
            this.lblYourScore.Name = "lblYourScore";
            this.lblYourScore.Size = new System.Drawing.Size(135, 18);
            this.lblYourScore.TabIndex = 19;
            this.lblYourScore.Text = "Your score is  :  ";
            // 
            // btnExitExam
            // 
            this.btnExitExam.Location = new System.Drawing.Point(319, 212);
            this.btnExitExam.Name = "btnExitExam";
            this.btnExitExam.Size = new System.Drawing.Size(78, 31);
            this.btnExitExam.TabIndex = 19;
            this.btnExitExam.Text = "Exit";
            this.btnExitExam.UseVisualStyleBackColor = true;
            this.btnExitExam.Click += new System.EventHandler(this.btnExitExam_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(2, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "Exam Finished Successfully";
            // 
            // ExamFinished
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 347);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExitExam);
            this.Controls.Add(this.panel1);
            this.Name = "ExamFinished";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExamFinished";
            this.Load += new System.EventHandler(this.ExamFinished_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblExamCode2;
        private System.Windows.Forms.Label lblName2;
        private System.Windows.Forms.Label lblYourScore;
        private System.Windows.Forms.Button btnExitExam;
        private System.Windows.Forms.Label label2;
    }
}