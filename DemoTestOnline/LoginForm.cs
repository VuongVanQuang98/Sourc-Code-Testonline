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
    public partial class LoginForm : Form
    {
        public Staff currentUser = null;//khai bao tai khoan dang online
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)

        {
            //Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            

        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (MessageBox.Show("Do you want to exit the application?", "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.OK)
            //{
            //    e.Cancel = true;
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string user = txtUsername.Text;
            string password = txtPass.Text;
            AdminModel model = new AdminModel();
            currentUser = model.CheckLogin(user, password);
            if (currentUser == null)
            {
                MessageBox.Show("Login Failed");

            }

            else
            {
                //MessageBox.Show("Login Success");
                this.Dispose();
                txtUsername.Text = "";
                txtPass.Text = "";
                txtUsername.Focus();
            }
        }

        private void txtUsername_Click_1(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Username")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.Black;
            }
        }

        private void txtPass_Click_1(object sender, EventArgs e)
        {

        }

        private void txtUsername_Leave_1(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "Username";
                txtUsername.ForeColor = Color.Gray;
            }
        }

        private void txtPass_Leave_1(object sender, EventArgs e)
        {
         
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = panel1;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "Password";
                txtPass.ForeColor = Color.Gray;
            }
        }

        private void txtPass_Click(object sender, EventArgs e)
        {
            if (txtPass.Text == "Password")
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.Black;
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            //if (textBox1.Text == "admin")
            //{
            //    textBox1.Text = "";
               
            //}
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            //if (textBox1.Text == "")
            //{
            //    textBox1.Text = "admin";
            //    textBox1.ForeColor = Color.Gray;
            //}
        }
    }
}
