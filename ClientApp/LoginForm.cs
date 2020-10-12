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
    public partial class LoginForm : Form
    {
        public string username = null;
        public string codeExam = null;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            string user = txtUser.Text;
            string pass = txtPassword.Text;
            ClientModel cm = new ClientModel();
            username = user;
            codeExam = txtExamcode.Text;
            if (cm.CheckLogin(user, pass) == true)
            {
                if (cm.CheckExam(txtExamcode.Text))
                {
                    this.Hide();
                }
                else
                    MessageBox.Show("Exam not started ! ! !");
            }
            else
            {
                MessageBox.Show("Login Failed");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtExamcode_Leave(object sender, EventArgs e)
        {
          
            
            if (txtExamcode.Text== "")
            {
                txtExamcode.Text = "Exam Code";
                //txtExamcode.Text = Color.Black;
            }
        }

        private void txtExamcode_Click(object sender, EventArgs e)
        {

            if (txtExamcode.Text == "Exam Code")
            {
                txtExamcode.Text = "";
                //txtExamcode.Text = Color.Gray;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void txtExamcode_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
