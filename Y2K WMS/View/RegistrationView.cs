using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Y2K_WMS
{
    public partial class RegistrationView : Form
    {
        LoginView login = new LoginView();

        public RegistrationView()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            PersonModel person = new PersonModel();
            registerController controller = new registerController();

            if (IsValidEmail(txtEmail.Text) == false||txtEmail.Text == ""||txtFirstName.Text == ""||txtLastName.Text == "" || txtPassword.Text == "" || txtPhone.Text == "" || txtReenterPassword.Text == "")
            {
                MessageBox.Show("Please enter all the fields");
            }else if(txtPassword.Text != txtReenterPassword.Text)
            {
                MessageBox.Show("Passwords does not match!");
            }
            else
            {
                //adding values to model
                person.firstName = txtFirstName.Text.Trim();
                person.lastName = txtLastName.Text.Trim();
                person.email = txtEmail.Text.Trim();
                person.phone = txtPhone.Text.Trim();
                person.password = txtPassword.Text.Trim();
                if (adminRdoBtn.Checked == true)
                {
                    person.isAdmin = "true";
                }
                else
                {
                    person.isAdmin = "false";
                }

                //passing the model to the controller
                bool check = controller.registerUser(person);

                if (check == true)
                {
                    MessageBox.Show("User registered...");
                    login = new LoginView();
                    this.Hide();
                    login.Show();
                }
                else
                {
                    MessageBox.Show("Error registering user...");
                }
            }
        }

        private void RegistrationView_Load(object sender, EventArgs e)
        {

        }

        //code adapted from stack overflow to validate email address
        public bool IsValidEmail(string eMail)
        {
            bool Result = false;

            try
            {
                var eMailValidator = new System.Net.Mail.MailAddress(eMail);

                Result = (eMail.LastIndexOf(".") > eMail.LastIndexOf("@"));
            }
            catch
            {
                Result = false;
            };

            return Result;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            login.Show();
        }
    }
}
