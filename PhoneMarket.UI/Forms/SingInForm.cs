using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneMarket.UI.Forms
{
    public partial class SingInForm : Form
    {
        public SingInForm()
        {
            InitializeComponent();
            PasswordTextBox.Size = new Size(LoginTextBox.Width, LoginTextBox.Width);
            this.LoginTextBox.Text = "Logini Kiriting";
            this.PasswordTextBox.Text = "Password kiriting";
            LoginTextBox.ForeColor = Color.Gray; PasswordTextBox.ForeColor = Color.Gray;
        }

        private void ExitApplicatonLable_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginTextBox_MouseLeave(object sender, EventArgs e)
        {
            if (LoginTextBox.Text == string.Empty)
            {
                this.LoginTextBox.Text = "Logini Kiriting";
                LoginTextBox.ForeColor = Color.Gray;
            }
        }

        private void PasswordTextBox_MouseEnter(object sender, EventArgs e)
        {
            if (PasswordTextBox.Text == "Password kiriting")
            {
                this.PasswordTextBox.Text = string.Empty;
                PasswordTextBox.ForeColor = Color.Black;
            }
        }

        private void PasswordTextBox_MouseLeave(object sender, EventArgs e)
        {
            if (PasswordTextBox.Text == string.Empty)
            {
                this.PasswordTextBox.Text = "Password kiriting";
                PasswordTextBox.ForeColor = Color.Gray;
            }
        }

       

        private void LoginTextBox_MouseEnter(object sender, EventArgs e)
        {
            if (LoginTextBox.Text == "Logini Kiriting")
            {
                this.LoginTextBox.Text = string.Empty;
                LoginTextBox.ForeColor = Color.Black;
            }
        }

        private void SingInButton_Click(object sender, EventArgs e)
        {
            if(this.PasswordTextBox.Text== "Password kiriting"&&
                this.LoginTextBox.Text== "Logini Kiriting")
            {

            }
        }
        private void ExitApplicatonLable_MouseEnter(object sender, EventArgs e)
        {
            this.ExitApplicatonLable.ForeColor = Color.Red;
        }

        private void ExitApplicatonLable_MouseLeave(object sender, EventArgs e)
        {
            this.ExitApplicatonLable.ForeColor = Color.Black;
        }
        Point lastPoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.CloseEyeForSingIn;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            
        }
        private void pictureBox2_DoubleClick(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.OpenEyeForSingIn;
            this.PasswordTextBox.UseSystemPasswordChar = false;
        }

        private void singUp_MouseEnter(object sender, EventArgs e)
        {
            singUp.ForeColor = Color.Purple;
        }

        private void singUp_MouseLeave(object sender, EventArgs e)
        {
            singUp.ForeColor = Color.Black;
        }

        private void singUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            SingUpForm singUpForm = new SingUpForm();
            singUpForm.Show();
        }
    }
}
