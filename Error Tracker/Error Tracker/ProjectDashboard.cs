using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Update;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Error_Tracker
{
    public partial class ProjectDashboard : UserControl
    {
        public ProjectDashboard()
        {
            string username;
            InitializeComponent();
            using (var errortracker = new ErrortrackerContext())
            {
                username = errortracker.Accounts.Where(a => a.AccountId == Form1.Account_Id).First().Username;
            }

            this.Dock = DockStyle.Fill;
            logout_button.Click += Logout_button_Click;
            username_label.Text = username;
            SetProjects();
        }

        public void SetProjects(string filter = "")
        {
            project_panel.Controls.Clear();

            List<Project>? projects;
            using (ErrortrackerContext errortracker = new ErrortrackerContext())
            {
                var query = errortracker.Projects.Where(p => p.Accounts.Any(a => a.AccountId == Form1.Account_Id));
                if (filter != "")
                {
                    query = query.Where(p => p.Name.ToLower().Contains(filter.ToLower()));
                }
                projects = query.ToList();
            }

            int project_count = projects.Count;
            int count = 0;
            foreach (Project project in projects)
            {
                Panel panel = new Panel();
                panel.Dock = DockStyle.Top;
                panel.AutoSize = true;
                panel.BorderStyle = BorderStyle.FixedSingle;
                panel.Padding = new Padding(0, 0, 0, 0);
                panel.BackColor = Color.FromArgb(255, 192, 192);
                panel.Click += (sender, EventArgs) =>
                {
                    ProjectPage(sender, EventArgs, project.ProjectId);
                };

                Label project_name = new Label()
                { Text = project.Name, Padding = new Padding(10, 10, 0, 0), AutoSize = true, Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point) };
                project_name.Click += (sender, EventArgs) =>
                {
                    ProjectPage(sender, EventArgs, project.ProjectId);
                };
                project_name.Cursor = Cursors.Hand;
                panel.Controls.Add(project_name);

                Button open_button = new Button()
                {
                    Text = "Open Project",
                    Location = new Point(project_name.Right, project_name.Top + project_name.Padding.Top),
                    AutoSize = true,
                    BackColor = Color.White,
                    Cursor = Cursors.Hand
                };
                open_button.Click += (sender, EventArgs) =>
                {
                    ProjectPage(sender, EventArgs, project.ProjectId);
                };
                panel.Controls.Add(open_button);

                Button leave_button = new Button()
                {
                    Text = "Leave Project",
                    Location = new Point(open_button.Right + 20, open_button.Top),
                    AutoSize = true,
                    BackColor = Color.White,
                    Cursor = Cursors.Hand
                };
                leave_button.Click += (sender, EventArgs) =>
                {
                    leave_project(sender, EventArgs, project);
                };
                panel.Controls.Add(leave_button);


                Label project_description = new Label()
                {
                    Text = project.Description,
                    Padding = new Padding(10, 0, 0, 10),
                    AutoSize = true,
                    Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
                    Location = new Point(project_name.Left, project_name.Bottom),
                    MaximumSize = new Size(700, 0)
                };
                project_description.Click += (sender, EventArgs) =>
                {
                    ProjectPage(sender, EventArgs, project.ProjectId);
                };
                panel.Controls.Add(project_description);

                project_panel.Controls.Add(panel);
                project_panel.Controls.SetChildIndex(panel, 0);

                if (count >= 0 && count < project_count - 1)
                {
                    Panel spacer = new Panel();
                    spacer.Size = new Size(0, 10);
                    spacer.Dock = DockStyle.Top;
                    project_panel.Controls.Add(spacer);
                    project_panel.Controls.SetChildIndex(spacer, 0);
                }
                count++;
            }
        }

        public void ProjectPage(object? sender, EventArgs e, int project_id)
        {
            Panel Main = Parent as Panel;
            Main.Controls.Remove(this);

            Main.Controls.Add(new ProjectPage(project_id));
        }

        private void leave_project(object sender, EventArgs e, Project project)
        {
            var result = MessageBox.Show("Are you sure you want to leave this project?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (result == DialogResult.Cancel)
            {
                return;
            }
            try
            {
                using (var errortracker = new ErrortrackerContext())
                {
                    var account = errortracker.Accounts.Include(c => c.Projects).Where(a => Form1.Account_Id == a.AccountId).First();
                    var projects = account.Projects;
                    projects.Remove(projects.First(p => p.ProjectId == project.ProjectId));

                    var change = new Change()
                    {
                        ProjectId = project.ProjectId,
                        Change1 = $"{account.Username} : {account.Name} has been removed from this project."
                    };
                    errortracker.Changes.Add(change);
                    errortracker.SaveChanges();
                }
            }
            catch 
            {
                
            }
            SetProjects(filter.Text);
        }

        private void submit_button_Click(object sender, EventArgs e)
        {
            if (project_name.Text.Count() == 0)
            {
                project_submit_message.Text = "Error: Name is required";
                return;
            }
            if (project_name.Text.First() == ' ')
            {
                project_submit_message.Text = "Error: Name cannot start with space";
                return;
            }


            using (var errortracker = new ErrortrackerContext())
            {
                Project project = new Project();
                project.Name = project_name.Text;
                project.Description = project_description.Text;
                errortracker.Projects.Add(project);
                errortracker.SaveChanges();

                Account account = errortracker.Accounts.Where(a => Form1.Account_Id == a.AccountId).First();
                account.Projects.Add(project);
                Change change = new Change()
                {
                    ProjectId = project.ProjectId,
                    Change1 = $"Project created by {account.Username} : {account.Name}",

                };
                errortracker.Changes.Add(change);
                errortracker.SaveChanges();
            }
            project_submit_message.Text = $"Success: Project \"{project_name.Text}\" has been created";
            project_name.Clear();
            project_description.Clear();
            filter.Clear();
            SetProjects();
        }

        private void refresh_button_Click(object sender, EventArgs e)
        {
            SetProjects();
            filter.Clear();
        }

        private void Logout_button_Click(object? sender, EventArgs e)
        {
            Panel form1panel = this.Parent as Panel;
            form1panel.Controls.Remove(this);
            Login Login = new Login();
            form1panel.Controls.Add(Login);
        }

        private void filter_TextChanged(object sender, EventArgs e)
        {
            SetProjects(filter.Text);
        }


    }
}
