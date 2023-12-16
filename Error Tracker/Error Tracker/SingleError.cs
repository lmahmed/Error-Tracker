using Microsoft.EntityFrameworkCore;
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

    public partial class SingleError : UserControl
    {
        public Error Error;

        public SingleError(Error error)
        {
            InitializeComponent();
            Dock = DockStyle.Top;
            Error = error;

            error_name.Text = Error.Name;
            setError();

            e_timestamp_textbox.ReadOnly = true;

            setReadOnly();
        }

        public void setError()
        {
            e_description_textbox.Text = Error.Description;
            e_type_textbox.Text = Error.Type;
            e_status_textbox.Text = Error.Status;
            e_priority_textbox.Text = Error.Priority.ToString();
            e_severity_textbox.Text = Error.Severity.ToString();
            e_timestamp_textbox.Text = Error.Timestamp.ToLocalTime().ToString();
        }

        public void setReadOnly()
        {
            e_description_textbox.ReadOnly = true;
            e_type_textbox.ReadOnly = true;
            e_status_textbox.ReadOnly = true;
            e_priority_textbox.ReadOnly = true;
            e_severity_textbox.ReadOnly = true;
        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            e_description_textbox.ReadOnly = false;
            e_type_textbox.ReadOnly = false;
            e_status_textbox.ReadOnly = false;
            e_priority_textbox.ReadOnly = false;
            e_severity_textbox.ReadOnly = false;

            edit_button.Visible = false;
            delete_button.Visible = false;

            cancel_edit.Visible = true;
            save_button.Visible = true;
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            edit_button.Visible = false;
            delete_button.Visible = false;

            delete_confirm.Visible = true;
            cancel_delete.Visible = true;
        }

        private void cancel_edit_Click(object sender, EventArgs e)
        {
            using (var errortracker = new ErrortrackerContext())
            {
                Error = errortracker.Errors.First(e => e.ErrorId == Error.ErrorId);
            }
            setError();
            setReadOnly();

            cancel_edit.Visible = false;
            save_button.Visible = false;

            edit_button.Visible = true;
            delete_button.Visible = true;
        }

        private void cancel_delete_Click(object sender, EventArgs e)
        {
            delete_confirm.Visible = false;
            cancel_delete.Visible = false;

            edit_button.Visible = true;
            delete_button.Visible = true;
        }

        private void delete_confirm_Click(object sender, EventArgs e)
        {
            try
            {
                using (var errortracker = new ErrortrackerContext())
                {
                    Error = errortracker.Errors.First(e => e.ErrorId == Error.ErrorId);
                    errortracker.Errors.Remove(Error);
                    errortracker.SaveChanges();
                }
            }
            catch
            {

            }
            (this.Parent as Panel).Controls.Remove(this);

        }

        private void save_button_Click(object sender, EventArgs e)
        {
            if (e_description_textbox.Text.Count() != 0 && e_type_textbox.Text.Count() != 0 && e_status_textbox.Text.Count() != 0 &&
                e_priority_textbox.Text.Count() != 0 && e_severity_textbox.Text.Count() != 0)
            {
                int priority;
                int severity;
                if (int.TryParse(e_priority_textbox.Text, out priority) && int.TryParse(e_severity_textbox.Text, out severity))
                {
                    if (0 <= priority && priority <= 10 && 0 <= severity && severity <= 10)
                    {
                        using (var errortracker = new ErrortrackerContext())
                        {
                            Error = errortracker.Errors.First(e => e.ErrorId == Error.ErrorId);
                            Error.Description = e_description_textbox.Text;
                            Error.Type = e_type_textbox.Text;
                            Error.Status = e_status_textbox.Text;
                            Error.Priority = priority;
                            Error.Severity = severity;

                            Account account = errortracker.Accounts.First(a => a.AccountId == Form1.Account_Id);
                            Change change = new Change()
                            {
                                ProjectId = Error.ProjectId,
                                Change1 = $"{account.Username} : {account.Name} edited error #{Error.ErrorId} : {Error.Name}",
                            };
                            errortracker.Changes.Add(change);
                            errortracker.SaveChanges();
                        }
                        save_button.Visible = false;
                        cancel_edit.Visible = false;

                        edit_button.Visible = true;
                        delete_button.Visible = true;

                        setReadOnly();
                    }
                    else
                    {
                        MessageBox.Show("Priority and Severity must be between 1 and 10", "Edit Error");
                    }
                }
                else
                {
                    MessageBox.Show("Priority and Severity must be integer", "Edit Error");
                }
            }
            else
            {
                MessageBox.Show("All fields are required", "Edit Error");
            }

        }

        private void help_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("All fields are required.\n" +
                "Priority and Severity must be integers between 1 and 10, where 1 is low and 10 is high." +
                "\nPress edit to start editing, cancel or save changes with the respective buttons." +
                "\nPress delete and another delete button will appear as confirmation to delete this error.", "Edit Error Help");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comment_textbox.Text.Count() != 0)
            {
                using (var errortracker = new ErrortrackerContext())
                {
                    Errorcomment errorcomment = new Errorcomment()
                    {
                        AccountId = Form1.Account_Id,
                        ErrorId = Error.ErrorId,
                        Comment = comment_textbox.Text,
                    };
                    errortracker.Errorcomments.Add(errorcomment);
                    errortracker.SaveChanges();
                }
                comment_textbox.Clear();
                if (refresh_comment.Visible == true)
                {
                    SetComments();
                }
            }
            else
            {
                MessageBox.Show("Comment must contain text", "Post Comment Error");
            }
        }

        private void show_comment_button_Click(object sender, EventArgs e)
        {
            show_comment_button.Visible = false;

            SetComments();

            hide_comment_button.Visible = true;
            refresh_comment.Visible = true;
        }

        private void refresh_comment_Click(object sender, EventArgs e)
        {
            SetComments();
        }

        private void hide_comment_button_Click(object sender, EventArgs e)
        {
            hide_comment_button.Visible = false;
            refresh_comment.Visible = false;

            comment_panel.Controls.Clear();

            show_comment_button.Visible = true;
        }

        public void SetComments()
        {
            comment_panel.Controls.Clear();

            List<Errorcomment> errorcomments;
            using (var errortracker = new ErrortrackerContext()) 
            {
                errorcomments = errortracker.Errorcomments.Include(p => p.Account).Where(p => p.ErrorId == Error.ErrorId).OrderByDescending(p => p.Timestamp).ToList();
            }

            foreach (var errorcomment in errorcomments) 
            {
                Label comment_label = new Label()
                {
                    Text = $"{errorcomment.Timestamp.ToLocalTime()} by {errorcomment.Account.Username}: {errorcomment.Comment}",
                    AutoSize = true,
                };
                Panel panel = new Panel()
                {
                    AutoSize = true,
                    Dock = DockStyle.Top,
                };
                panel.SizeChanged += (sender, e) => SetCommentLabelMaxWidth(sender, e, comment_label);
                panel.Controls.Add(comment_label);

                comment_panel.Controls.Add(panel);
                comment_panel.Controls.SetChildIndex(panel, 0);
            }
        }

        public void SetCommentLabelMaxWidth(object? sender, EventArgs e, Label label)
        {
            label.MaximumSize = new Size((sender as Panel).Width, 0);
        }
    }
}
