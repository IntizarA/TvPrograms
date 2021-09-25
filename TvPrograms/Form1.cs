using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TvPrograms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.SetStyle(System.Windows.Forms.ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = System.Drawing.Color.Transparent;


        }

       

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }

        

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            SqlPartController controlles = new SqlPartController();
            DataTable dt = controlles.LogInUser(txtUserName.Text, txtPassword.Text);
            if (dt.Rows.Count == 1)
            {
                ShowAllTabs shower = new ShowAllTabs();
                this.Hide();
                shower.ShowDialog();
            }
            else
            {
                txtUserName.BackColor = Color.Red;
                txtPassword.BackColor = Color.Red;
                MessageBox.Show("user not found");
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            this.Hide();
            signUp.ShowDialog();
        }

        private void lblUserName_Click(object sender, EventArgs e)
        {
            lblUserName.BackColor = Color.Transparent;
        }
    }
    }

