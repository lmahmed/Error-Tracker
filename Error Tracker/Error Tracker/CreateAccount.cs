using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Error_Tracker
{
    public partial class CreateAccount : UserControl
    {
        public CreateAccount()
        {
            InitializeComponent();

            login_button.Click += Cancel_Create_Account;
            cancel_button.Click += Cancel_Create_Account;
            submit_button.Click += Submit_button_Click;
        }

        private void Submit_button_Click(object? sender, EventArgs e)
        {
            string name = name_textbox.Text;
            string username = username_textbox.Text;
            string password = password_textbox.Text;
            if (name.Length == 0 || username.Length == 0 || password.Length == 0)
            {
                create_account_error_label.Text = "Name, Username, and Password must all contain at least one character.";
                return;
            }
            if (username.Contains(" ") || password.Contains(" "))
            {
                create_account_error_label.Text = "Username and/or password contain spaces. Remove the spaces and try again.";
                return;
            }
            using (var errortracker = new ErrortrackerContext())
            {
                // Check for matching username
                if (errortracker.Accounts.Any(c => c.Username == username))
                {
                    create_account_error_label.Text = "Username is already taken. Enter a new username and try again.";
                    return;
                }
                Account account = new Account();
                account.Name = name;
                account.Username = username;
                account.Password = password;
                errortracker.Accounts.Add(account);
                errortracker.SaveChanges();

                // Get account_id 
                Form1.Account_Id = account.AccountId;
            }
            Panel form1panel = this.Parent as Panel;
            form1panel.Controls.Remove(this);
            ProjectDashboard ProjectDashboard= new ProjectDashboard();
            form1panel.Controls.Add(ProjectDashboard);
        }

        private void Cancel_Create_Account(object? sender, EventArgs e)
        {
            Panel form1panel = this.Parent as Panel;
            form1panel.Controls.Remove(this);
            Login Login = new Login();
            form1panel.Controls.Add(Login);
        }

    }
}
