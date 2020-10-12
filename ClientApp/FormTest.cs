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
    public partial class FormTest : Form
    {
        private int time = 40 * 60;
        
        public string name ;
        public string examCode = null;
        List<Question> listQuestion = null;
        List<string> qID = null;
        Question currentQuestion = null;
        public FormTest()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoginForm lg = new LoginForm();
            lg.ShowDialog();
            examCode = lg.codeExam;
            //this.Text = lg.username;
            // if (examCode != null)
            name = lg.username;
            //this.Text = "Welcome to : " + lg.username;
            LoadQuesionID(examCode);
            LoadQuesion();
            lblExamCode.Text = "Exam Code :" + examCode;
            //.ForeColor = Color.DarkBlue;

            lblName.Text = "Full Name :" + name;
            //lblName.ForeColor = Color.DarkBlue;
            //lblDate.Text = "Date : " + date;
            timer1.Start();
        }

        private void LoadQuesion()
        {
            listQuestion = new List<Question>();
            ClientModel model = new ClientModel();
            foreach (var item in qID)
            {
                listQuestion.Add(model.GetQuestionByID(item));
            }
        }

        private void LoadQuesionID(string examCode)
        {
            ClientModel model = new ClientModel();
            qID = model.GetQuestionByExam(examCode);
            foreach (var item in qID)
            {
                lstQuestion.Items.Add(item);
            }
        }

        private void lstQuestion_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = lstQuestion.SelectedItem.ToString();

            //Question q = null;
            foreach (var item in listQuestion)
            {
                if (item.ID.Equals(id))
                    currentQuestion = item;
            }
            rtContent.Text = currentQuestion.Content;
            rtA.Text = currentQuestion.A;
            rtB.Text = currentQuestion.B;
            rtC.Text = currentQuestion.C;
            rtD.Text = currentQuestion.D;
            if(currentQuestion.Choice==null)
            {
                rdA.Checked = false;
                rdB.Checked = false;
                rdC.Checked = false;
                rdD.Checked = false;
            }
            else
            {
                if (currentQuestion.Choice.Equals("_a"))
                    rdA.Checked = true;
                if (currentQuestion.Choice.Equals("_b"))
                    rdB.Checked = true;
                if (currentQuestion.Choice.Equals("_c"))
                    rdC.Checked = true;
                if (currentQuestion.Choice.Equals("_d"))
                    rdD.Checked = true;
            }
            
        }

        private void rdA_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rdB_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rdC_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rdD_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rtA_TextChanged(object sender, EventArgs e)
        {

        }

        private void rtB_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdA_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rdA.Checked)
                currentQuestion.Choice = "_a";
        }

        private void rtA_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void rdB_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rdB.Checked)
                currentQuestion.Choice = "_b";
        }

        private void rdC_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rdC.Checked)
                currentQuestion.Choice = "_c";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rdD_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rdD.Checked)
                currentQuestion.Choice = "_d";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBFinish.Checked)
            {
                btnFinish.Enabled = true;
            }
            else
            {
                btnFinish.Enabled = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time--;
            Timeleft.Text = +time / 60 + ":" + time % 60;
            if(time<39.9*60)
            {
                Timeleft.ForeColor = Color.Red;
            }
        }

        private void checkBFinish_Click(object sender, EventArgs e)
        {
        }

        private void checkBFinish_CheckStateChanged(object sender, EventArgs e)
        {

        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            ExamFinished ef = new ExamFinished();
            ef.ShowDialog();
                        

        }
    }
}
