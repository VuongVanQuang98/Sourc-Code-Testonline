using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientApp
{
    public partial class ExamFinished : Form
    {
        public string name;
        public string examCode=null;
        public ExamFinished()
        {
            InitializeComponent();
        }

        private void ExamFinished_Load(object sender, EventArgs e)
        {
           
            lblName2.Text = "Full Name : " + name;
            lblExamCode2.Text = "Exam Code : " + examCode;
        }

        private void btnExitExam_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
