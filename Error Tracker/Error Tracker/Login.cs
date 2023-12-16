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
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();

            Dock = DockStyle.Fill;
            login_button.Click += Login_button_Click;
            create_account_button.Click += Create_account_button_Click;
        }

        private void Login_button_Click(object? sender, EventArgs e)
        {
            Panel form1panel = this.Parent as Panel;
            using (var errortracker = new ErrortrackerContext())
            {
                string username = username_textbox.Text;
                string password = password_textbox.Text;
                Account? account = errortracker.Accounts.Where(a => a.Username == username && a.Password == password).FirstOrDefault();
                if (account != null)
                {
                    Form1.Account_Id = account.AccountId;
                    form1panel.Controls.Remove(this);
                    ProjectDashboard ProjectDashboard = new ProjectDashboard();
                    form1panel.Controls.Add(ProjectDashboard);
                }
                else
                {
                    login_error_label.Visible = true;
                }
            }
        }

        private void Create_account_button_Click(object? sender, EventArgs e)
        {
            Panel form1panel = this.Parent as Panel;
            form1panel.Controls.Remove(this);
            CreateAccount CreateAccount = new CreateAccount();
            CreateAccount.Dock = DockStyle.Fill;
            form1panel.Controls.Add(CreateAccount);
        }

        private void password_textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                Login_button_Click(sender, e);
            }
        }
    }
}
