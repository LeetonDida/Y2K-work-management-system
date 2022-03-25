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
    public partial class LoginView : Form
    {
        View.DashboardView dashboard = new View.DashboardView();
        public LoginView()
        {
            InitializeComponent();
        }
        bool isAdmin;

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "" && txtPassword.Text == "")
            {
                MessageBox.Show("Please enter valid credential!s", "Login Error");
            }
            else
            {
                string email, pass;
                pass = txtPassword.Text.Trim();
                email = txtEmail.Text.Trim();
                Controller.loginController controller = new Controller.loginController();

                if (controller.login(email, pass))
                {
                    //logged in as what?
                    if(controller.verifyUser(email, pass))
                    {
                        MessageBox.Show("Logged in as Admin", "Login success!");
                        this.Hide();
                        dashboard.isAdmin = controller.isAdmin;
                        dashboard.Show();
                    }
                    else
                    {
                        //add code to log in as developer
                        MessageBox.Show("Logged in as Developer", "Login success!");
                        this.Hide();
                        View.DashboardView dashboard = new View.DashboardView();
                        dashboard.Show();
                    }
                    
                }
                else
                {
                    MessageBox.Show("Authentication failed. Please check your credentials!", "Error");
                }

            }

        }

        private void LoginView_Load(object sender, EventArgs e)
        {

        }

        private void lblRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationView registration = new RegistrationView();
            registration.Show();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
