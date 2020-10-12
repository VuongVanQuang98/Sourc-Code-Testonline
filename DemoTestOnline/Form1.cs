using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoTestOnline
{
    public partial class Form1 : Form
    {
        
        List<Question> list = null;
        public Staff user = null;
        private bool addFlag = false;
        private bool addCheck = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoginForm lg = new LoginForm(); 
            lg.ShowDialog();
            user = lg.currentUser;
            if(user!=null)
            this.Text = "Welcome to : " + user.UserName;
            
        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            string id = IdQuestionDetail.Text;
            AdminModel ad = new AdminModel();
            if(ad.CheckExist(id)==false)
            {
                MessageBox.Show(" ID Question Existed ", " Notification ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                addCheck = true;
                MessageBox.Show("This ID Question Can Use " , " Notification " , MessageBoxButtons.OK);
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if(!addFlag)
            {
                ResetControl();
                btnAddNew.Text = "Save";
            }
            else
            {
                if(addCheck)
                {
                    string id = IdQuestionDetail.Text;
                    string A = rtA.Text;
                    string B = rtB.Text;
                    string C = rtC.Text;
                    string D = rtD.Text;
                    string sid = cbSubject.SelectedItem.ToString();
                    string content = rtContent.Text;
                    string correct = "";
                    if (sid.Equals("Top notch1"))
                        sid = "TN1";
                    if (sid.Equals("Top notch2"))
                        sid = "TN2";
                    if (sid.Equals("Top notch3"))
                        sid = "TN3";
                    if (sid.Equals("Summit1"))
                        sid = "SM1";
                    if (rdA.Checked)
                        correct = "_a";
                    if (rdB.Checked)
                        correct = "_b";
                    if (rdC.Checked)
                        correct = "_c";
                    if (rdD.Checked)
                        correct = "_d";
                    AdminModel ad = new AdminModel();
                    if (ad.AddNewQuestion(id, content, A, B, C, D, correct, sid))
                        MessageBox.Show("Add New Success", " Notification ", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Add New Failed ", " Notification ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnAddNew.Text = "Add New ";
                    ResetControl();
                }
                
                
            }
            addFlag = !addFlag;
           
           
        }

        private void ResetControl()
        {
            IdQuestionDetail.Text = "";
            IdQuestionDetail.ReadOnly = false;
            rtContent.Text = "";
            rtA.Text = "";
            rtB.Text = "";
            rtC.Text = "";
            rtD.Text = "";
            cbSubject.Text = "";
            rdA.Checked = false;
            rdB.Checked = false;
            rdC.Checked = false;

            rdD.Checked = false;



        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            AdminModel ad = new AdminModel();
            dataGridView1.DataSource = ad.GetQuestions();
            ManageExam mn = new ManageExam();
            dataGridView2.DataSource = mn.GetExams();
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IdQuestionDetail.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            IdQuestionDetail.ReadOnly = true;
            cbSubject.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            rtContent.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            rtA.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            rtB.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            rtC.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            rtD.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            string asw = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            if (asw.Equals("_a"))
            {
                rdA.Checked = true;
            }
            if (asw.Equals("_b"))
            {
                rdB.Checked = true;
            }
            if (asw.Equals("_c"))
            {
                rdC.Checked = true;
            }
            if (asw.Equals("_d"))
            {
                rdD.Checked = true;
            }
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
            


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = IdQuestionDetail.Text;
            AdminModel ad = new AdminModel();
            if (ad.DeleteQuestion(id) == true)
            {
                dataGridView1.DataSource = ad.GetQuestions();
                ResetGUI();
                MessageBox.Show("Delete Question Success", " Notification ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Delete Question Failed ", " Notification ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            IdQuestionDetail.ReadOnly = false;
        }

        private void ResetGUI()
        {
            IdQuestionDetail.Text = "";
            rtContent.Text = "";
            rtA.Text = "";
            rtB.Text = "";
            rtC.Text = "";
            rtD.Text = "";
            cbSubject.Text = "";
            rdA.Checked = false;
            rdB.Checked = false;
            rdC.Checked = false;
            rdD.Checked = false;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string id = IdQuestionDetail.Text;
            string subject = cbSubject.Text;
            string content = rtContent.Text;
            string a = rtA.Text;
            string b = rtB.Text;
            string c = rtC.Text;
            string d = rtD.Text;
            string correct = "";
            if (rdA.Checked)
                correct = "_a";
            if (rdB.Checked)
                correct = "_b";
            if (rdC.Checked)
                correct = "_c";
            if (rdD.Checked)
                correct = "_d";


            AdminModel ad = new AdminModel();
            if (ad.UpdateQuestion(id, subject, content,correct, a, b, c, d))
            {
                dataGridView1.DataSource = ad.GetQuestions();
                ResetGUI();
                MessageBox.Show("Update Question Success", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
                MessageBox.Show("Update Question Failed ", " Notification ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnSearchId_Click(object sender, EventArgs e)
        {
            string id = txtIDquestionList.Text;
            AdminModel ad = new AdminModel();
            dataGridView1.DataSource = ad.SearchById(id);
        }

        private void rtContent_Leave(object sender, EventArgs e)
        {
            if (rtContent.Text == "")
            {
                rtContent.Text = "Content . . .";
                rtContent.ForeColor = Color.Gray;
            }
        }

        private void rtContent_Click(object sender, EventArgs e)
        {
            if (rtContent.Text == "Content . . .")
            {
                rtContent.Text = "";
                rtContent.ForeColor = Color.Black;

            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            //if (textBox1.Text == "")
            //{
            //    textBox1.Text = "admin";

            //}
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            //if (textBox1.Text == "admin")
            //{
            //    textBox1.Text = "";

            //}
        }

        private void button3_Click(object sender, EventArgs e)
        {
           

        }

        private void button2_Click(object sender, EventArgs e)
         
        {
          
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnCheckExam_Click(object sender, EventArgs e)
        {
            
        }

        private void tabControl1_DoubleClick(object sender, EventArgs e)
        {

          
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtExamcode2.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
            dtDate2.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            cbStatus.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
           
        }

        private void btnUpdate1_Click(object sender, EventArgs e)
        {
            string idExam = txtExamcode2.Text;
            string Date = dtDate2.Text;
            string Status = cbStatus.Text;
            ManageExam mn = new ManageExam();
            if (mn.UpdateExam(idExam, Date, Status))
            {
                dataGridView2.DataSource = mn.GetExams();
                ResetGUI();
                MessageBox.Show("Update Exam Success", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string result = "";
                result += "Exam Code : " + txtExamcode2.Text + "\n";
                result += "Date : " + dtDate2.Text + "\n";
                result += "Status : " + cbStatus.Text + "\n";
                MessageBox.Show(result, "Detail Exam After Update");
            }
            else
                MessageBox.Show("Update Exam  Failed  ", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string id = txtExamSearch.Text;
            ManageExam mn = new ManageExam();
            dataGridView2.DataSource = mn.SearchByIdExam(id);
        }

        private void txtIDquestionList_Leave(object sender, EventArgs e)
        {
            if (txtIDquestionList.Text == "")
            {
                txtIDquestionList.Text = "Search ID";
                txtIDquestionList.ForeColor = Color.Gray;
            }
        }

        private void txtIDquestionList_Click(object sender, EventArgs e)
        {
            if (txtIDquestionList.Text == "Search ID")
            {
                txtIDquestionList.Text = "";
                txtIDquestionList.ForeColor = Color.Black;
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txtExamSearch_Click(object sender, EventArgs e)
        {
            if (txtExamSearch.Text == "Search ID") 
            {
                txtExamSearch.Text = "";
                txtExamSearch.ForeColor = Color.Gray;
            }
        }

        private void txtExamSearch_Leave(object sender, EventArgs e)
        {
            if(txtExamSearch.Text=="")
            {
                txtExamSearch.Text = "Search ID";
                txtExamSearch.ForeColor = Color.Black;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            AdminModel ad = new AdminModel();
            dataGridView1.DataSource = ad.GetQuestions();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string examcode = txtExamcode.Text;
            string date = dtDate.Text;

            ManageExam model = new ManageExam();
            if (model.AddNewExam(examcode, date))
            {
                foreach (var item in list)
                {
                    model.AddExamDetail(examcode, item.ID);
                }
                string result = "";
                result += "Exam Code : " + txtExamcode.Text + "\n";
                result += "Date :  " + dtDate.Text + "\n";
                result += "Subject : " + cbsubject2.SelectedItem.ToString();
                MessageBox.Show("Add New Exam Sucess", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(result,"Detail Exam ");
            }
            else
                MessageBox.Show("Add New Exam Failed ", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error); 
        }

        private void btnCheckExam_Click_1(object sender, EventArgs e)
        {
            string id = txtExamcode.Text;
            ManageExam mn = new ManageExam();
            if (mn.CheckExist(id) == false)
            {
                MessageBox.Show(" ID Question Existed ", " Notification ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                addCheck = true;
                MessageBox.Show("This ID Question Can Use ", " Notification ", MessageBoxButtons.OK);
            }
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            ManageExam md = new ManageExam();
            string type = cbsubject2.SelectedItem.ToString();

            if (type.Equals("Top notch1"))
                type = "TN1";
            if (type.Equals("Top notch2"))
                type = "TN2";
            if (type.Equals("Top notch3"))
                type = "TN3";
            if (type.Equals("Summit1"))
                type = "SM1";
            list = md.GetRanDomQuestion(type);
            MessageBox.Show(" Load Question Success ", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnCreate.Enabled = true;
        }
    }
}
