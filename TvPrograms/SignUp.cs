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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            SqlPartController controller = new SqlPartController();
            if ((!string.IsNullOrEmpty(txtName.Text) || !string.IsNullOrWhiteSpace(txtName.Text)) &&
               (!string.IsNullOrEmpty(txtSurname.Text) || !string.IsNullOrWhiteSpace(txtSurname.Text)) &&
               (!string.IsNullOrEmpty(txtEmail.Text) || !string.IsNullOrWhiteSpace(txtEmail.Text)) &&
                (!string.IsNullOrEmpty(txtAge.Text) || !string.IsNullOrWhiteSpace(txtAge.Text)) &&
                (!string.IsNullOrEmpty(txtPassword.Text) || !string.IsNullOrWhiteSpace(txtPassword.Text))
            )
            {
                controller.SignUp(txtName.Text, txtSurname.Text, txtEmail.Text, Convert.ToInt32(txtAge.Text), txtPassword.Text);
                MessageBox.Show("User Added");
                this.Hide();
                Form1 form1 = new Form1();
                form1.ShowDialog();
            }

            else
            {
                MessageBox.Show("Please fill out all fields");
            }

        }
    }
}
