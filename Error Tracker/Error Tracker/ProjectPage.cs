using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Security;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Error_Tracker
{
    public partial class ProjectPage : UserControl
    {
        public int Project_id;
        bool name_filled = false;
        bool description_filled = false;
        bool type_filled = false;
        bool status_filled = false;
        bool priority_filled = false;
        bool severity_filled = false;
        string Filter = "";

        public ProjectPage(int project_id)
        {
            InitializeComponent();
            Project_id = project_id;
            this.Dock = DockStyle.Fill;
            logout_button.Click += Logout_button_Click;
            SetPage();

            description_changed_panel.Visible = false;
        }

        public void SetPage()
        {
            string username;
            Project project;
            using (var errortracker = new ErrortrackerContext())
            {
                username = errortracker.Accounts.Where(a => a.AccountId == Form1.Account_Id).First().Username;

                project = errortracker.Projects.First(p => p.ProjectId == Project_id);
            }
            username_label.Text = username;
            project_name_label.Text = project.Name;
            project_description_textbox.Text = project.Description;
            SetProjectComment();
            SetError();
            SetCollaborator();
            SetChanges();
        }

        private void SetChanges()
        {
            List<Change> changes;
            using (var errortracker = new ErrortrackerContext())
            {
                changes = errortracker.Changes.Where(c => c.ProjectId == Project_id).OrderByDescending(c => c.Timestamp).ToList();
            }

            foreach (var change in changes)
            {
                Label change_label = new Label()
                {
                    Text = $"{change.Timestamp.ToLocalTime()} : {change.Change1}",
                    AutoSize = true,
                    Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
            };
                Panel panel = new Panel()
                {
                    AutoSize = true,
                    Dock = DockStyle.Top,
                    BorderStyle = BorderStyle.FixedSingle
                };
                panel.SizeChanged += (sender, e) => SetChangeLabelMaxWidth(sender, e, change_label);
                panel.Controls.Add(change_label);

                change_panel.Controls.Add(panel);
                change_panel.Controls.SetChildIndex(panel, 0);
            }
        }

        private void SetChangeLabelMaxWidth(object sender, EventArgs e, Label change_label)
        {
            change_label.MaximumSize = new Size((sender as Panel).Width, 0);
        }

        private void SetCollaborator()
        {
            List<Account> accounts;
            using (var errortracker = new ErrortrackerContext())
            {
                accounts = errortracker.Accounts.Where(a => a.Projects.Any(a => a.ProjectId == Project_id)).ToList();
            }
            collaborator_list_box.DataSource = accounts;
            collaborator_list_box.DisplayMember = "FullDescription";
            collaborator_list_box.ClearSelected();
            removeCollaborator.Enabled = false;

        }

        public void SetProjectComment()
        {
            actual_comment_panel.Controls.Clear();
            List<Projectcomment> projectcomments;
            using (var errortracker = new ErrortrackerContext())
            {
                projectcomments = errortracker.Projectcomments.Include(p => p.Account).Where(p => p.ProjectId == Project_id).OrderByDescending(p => p.Timestamp).ToList();
            }

            foreach (Projectcomment projectcomment in projectcomments)
            {
                Panel temp = new Panel()
                {
                    Dock = DockStyle.Top,
                    Size = new Size(Width, 5)
                };
                actual_comment_panel.Controls.Add(temp);
                actual_comment_panel.Controls.SetChildIndex(temp, 0);

                Panel single_comment_panel = new Panel()
                {
                    Dock = DockStyle.Top,
                    AutoSize = true,
                    BackColor = Color.FromArgb(255, 192, 192),
                };

                Label comment = new Label()
                {
                    MaximumSize = new Size(210, 0),
                    Text = $"{projectcomment.Timestamp.ToLocalTime()} by {projectcomment.Account.Username}: {projectcomment.Comment}",
                    AutoSize = true
                };
                single_comment_panel.Controls.Add(comment);

                actual_comment_panel.Controls.Add(single_comment_panel);
                actual_comment_panel.Controls.SetChildIndex(single_comment_panel, 0);
            }
        }

        public void SetError()
        {
            error_panel.Controls.Clear();
            List<Error> errors;
            using (var errortracker = new ErrortrackerContext())
            {
                var query = errortracker.Errors.Include(e => e.Errorcomments).ThenInclude(e => e.Account).Where(e => e.ProjectId == Project_id);
                if (Filter != "")
                {
                    query = query.Where(p => p.Name.ToLower().Contains(Filter.ToLower()));
                }
                errors = query.ToList();
            }

            for (int i = 0; i < errors.Count; i++)
            {
                Error error = errors[i];
                SingleError singleError = new SingleError(error);
                error_panel.Controls.Add(singleError);
                error_panel.Controls.SetChildIndex(singleError, 0);

                if (i != errors.Count - 1)
                {
                    Panel spacer = new Panel()
                    {
                        Dock = DockStyle.Top,
                        Size = new Size(0, 5),
                        BackColor = Color.Turquoise,
                    };
                    error_panel.Controls.Add(spacer);
                    error_panel.Controls.SetChildIndex(spacer, 0);
                }
            }
        }

        private void Logout_button_Click(object? sender, EventArgs e)
        {
            Panel form1panel = this.Parent as Panel;
            form1panel.Controls.Remove(this);
            Login Login = new Login();
            form1panel.Controls.Add(Login);
        }

        private void project_dashboard_button_Click(object sender, EventArgs e)
        {
            Panel form1panel = this.Parent as Panel;
            form1panel.Controls.Remove(this);
            form1panel.Controls.Add(new ProjectDashboard());
        }

        private void project_comment_button_Click(object sender, EventArgs e)
        {
            if (project_comment.Text.Length == 0)
            {
                return;
            }
            using (var errortracker = new ErrortrackerContext())
            {
                Projectcomment projectcomment = new Projectcomment()
                {
                    Comment = project_comment.Text,
                    ProjectId = Project_id,
                    AccountId = Form1.Account_Id
                };
                errortracker.Projectcomments.Add(projectcomment);
                errortracker.SaveChanges();
            }
            project_comment.Clear();
            SetProjectComment();
        }

        private void refresh_comments_Click(object sender, EventArgs e)
        {
            SetProjectComment();
        }

        private void refresh_page_button_Click(object sender, EventArgs e)
        {
            Panel panel = this.Parent as Panel;
            panel.Controls.Remove(this);
            panel.Controls.Add(new ProjectPage(this.Project_id));
        }

        private void project_description_textbox_TextChanged(object sender, EventArgs e)
        {
            description_changed_panel.Visible = true;
        }

        private void cancel_description_button_Click(object sender, EventArgs e)
        {
            Project project;
            using (var errortracker = new ErrortrackerContext())
            {
                project = errortracker.Projects.Where(p => p.ProjectId == Project_id).First();
            }
            project_description_textbox.Text = project.Description;
            description_changed_panel.Visible = false;
        }

        private void save_description_button_Click(object sender, EventArgs e)
        {
            Project project;
            using (var errortracker = new ErrortrackerContext())
            {
                project = errortracker.Projects.Where(p => p.ProjectId == Project_id).First();
            
                // Add changelog
                if (project.Description != project_description_textbox.Text)
                {
                    Account account = errortracker.Accounts.First(a => a.AccountId == Form1.Account_Id);
                    Change change = new Change()
                    {
                        ProjectId = Project_id,
                        Change1 = $"{account.Username} : {account.Name} changed the description",
                    };
                    errortracker.Changes.Add(change);
                }
                project.Description = project_description_textbox.Text;


                errortracker.SaveChanges();
            }
            project_description_textbox.Text = project.Description;
            description_changed_panel.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            collaborator_list_box.ClearSelected();
            removeCollaborator.Enabled = false;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox1.Text.Count() > 0)
                {
                    addCollaborator_Click(sender, e);
                }
            }
        }

        private void addCollaborator_Click(object sender, EventArgs e)
        {
            using (var errortracker = new ErrortrackerContext())
            {
                var account = errortracker.Accounts.FirstOrDefault(a => a.Username == textBox1.Text);
                if (account != null)
                {
                    var project = errortracker.Projects.Include(p => p.Accounts).First(p => p.ProjectId == Project_id);
                    if (!project.Accounts.Contains(account))
                    {
                        var currAccount = errortracker.Accounts.First(a => a.AccountId == Form1.Account_Id);
                        project.Accounts.Add(account);
                        Change change = new Change()
                        {
                            ProjectId = Project_id,
                            Change1 = $"{currAccount.Username} : {currAccount.Name} added {account.Username} : {account.Name}"
                        };
                        errortracker.Changes.Add(change);

                        errortracker.SaveChanges();
                        textBox1.Clear();
                        SetCollaborator();
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Count() > 0)
            {
                addCollaborator.Enabled = true;
            }
            else
            {
                addCollaborator.Enabled = false;
            }
        }

        private void collaborator_list_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (collaborator_list_box.SelectedIndex != -1)
            {
                removeCollaborator.Enabled = true;
            }
        }

        private void removeCollaborator_Click(object sender, EventArgs e)
        {
            using (var errortracker = new ErrortrackerContext())
            {
                var account = errortracker.Accounts.FirstOrDefault(a => a.AccountId == (collaborator_list_box.SelectedItem as Account).AccountId);
                if (account != null)
                {
                    var project = errortracker.Projects.Include(p => p.Accounts).First(p => p.ProjectId == Project_id);
                    if (project.Accounts.Contains(account))
                    {
                        var currAccount = errortracker.Accounts.First(a => a.AccountId == Form1.Account_Id);
                        project.Accounts.Remove(account);

                        Change change = new Change()
                        {
                            ProjectId = Project_id,
                            Change1 = $"{currAccount.Username} : {currAccount.Name} removed {account.Username} : {account.Name}"
                        };
                        errortracker.Changes.Add(change);

                        errortracker.SaveChanges();
                        SetCollaborator();
                    }
                }
            }
        }

        private void help_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("After all inputs are put in correctly, the Add Error button will be enabled.\nAll fields are required.\n" +
                "Priority and Severity must be integers between 1 and 10, where 1 is low and 10 is high.", "Add Error Help");
        }

        private void e_name_textbox_TextChanged(object sender, EventArgs e)
        {
            if (e_name_textbox.Text.Count() == 0)
            {
                name_filled = false;
            }
            else
            {
                name_filled = true;
            }
            change_add_error();
        }

        private void e_description_textbox_TextChanged(object sender, EventArgs e)
        {
            if (e_description_textbox.Text.Count() == 0)
            {
                description_filled = false;
            }
            else
            {
                description_filled = true;
            }
            change_add_error();
        }

        private void e_type_textbox_TextChanged(object sender, EventArgs e)
        {
            if (e_type_textbox.Text.Count() == 0)
            {
                type_filled = false;
            }
            else
            {
                type_filled = true;
            }
            change_add_error();
        }

        private void e_status_textbox_TextChanged(object sender, EventArgs e)
        {
            if (e_status_textbox.Text.Count() == 0)
            {
                status_filled = false;
            }
            else
            {
                status_filled = true;
            }
            change_add_error();
        }

        private void e_priority_textbox_TextChanged(object sender, EventArgs e)
        {

            int number;
            bool success = int.TryParse(e_priority_textbox.Text, out number);
            if (success)
            {
                if (0 <= number && number <= 10)
                {
                    priority_filled = true;
                }
                else
                {
                    priority_filled = false;
                }
            }
            else
            {
                priority_filled = false;
            }
            change_add_error();
        }

        private void e_severity_textbox_TextChanged(object sender, EventArgs e)
        {
            int number;
            bool success = int.TryParse(e_severity_textbox.Text, out number);
            if (success)
            {
                if (0 <= number && number <= 10)
                {
                    severity_filled = true;
                }
                else
                {
                    severity_filled = false;
                }
            }
            else
            {
                severity_filled = false;
            }
            change_add_error();
        }


        public void change_add_error()
        {
            if (name_filled && description_filled && type_filled && status_filled && priority_filled && severity_filled)
            {
                add_error.Enabled = true;
                add_error.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            }
            else
            {
                add_error.Enabled = false;
                add_error.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            }
        }

        private void add_error_Click(object sender, EventArgs e)
        {
            Error error = new Error()
            {
                ProjectId = Project_id,
                Name = e_name_textbox.Text,
                Description = e_description_textbox.Text,
                Type = e_type_textbox.Text,
                Status = e_status_textbox.Text,
                Priority = int.Parse(e_priority_textbox.Text),
                Severity = int.Parse(e_severity_textbox.Text),
            };

            using (var errortracker = new ErrortrackerContext())
            {
                errortracker.Errors.Add(error);
                errortracker.SaveChanges();

                Account account = errortracker.Accounts.First(a => a.AccountId == Form1.Account_Id);
                Change change = new Change()
                {
                    ProjectId = Project_id,
                    Change1 = $"{account.Username} : {account.Name} created error #{error.ErrorId} : {error.Name}"
                };
                errortracker.Changes.Add(change);
                errortracker.SaveChanges();
            }

            e_name_textbox.Clear();
            e_description_textbox.Clear();
            e_type_textbox.Clear();
            e_status_textbox.Clear();
            e_priority_textbox.Clear();
            e_severity_textbox.Clear();

            SetError();
        }

        private void refresh_error_Click(object sender, EventArgs e)
        {
            SetError();
        }

        private void filter_TextChanged(object sender, EventArgs e)
        {
            Filter = filter.Text;
            SetError();
        }
    }
}
