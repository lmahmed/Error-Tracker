namespace Error_Tracker
{
    partial class CreateAccount
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAccount));
            login_button = new Button();
            panel2 = new Panel();
            label1 = new Label();
            main = new Panel();
            label5 = new Label();
            panel = new Panel();
            name_textbox = new TextBox();
            label4 = new Label();
            cancel_button = new Button();
            create_account_error_label = new Label();
            submit_button = new Button();
            password_textbox = new TextBox();
            label3 = new Label();
            username_textbox = new TextBox();
            label2 = new Label();
            panel2.SuspendLayout();
            main.SuspendLayout();
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // login_button
            // 
            login_button.Anchor = AnchorStyles.Top;
            login_button.BackColor = Color.Gainsboro;
            login_button.Cursor = Cursors.Hand;
            login_button.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            login_button.Location = new Point(757, 39);
            login_button.Name = "login_button";
            login_button.Size = new Size(177, 78);
            login_button.TabIndex = 6;
            login_button.Text = "Login";
            login_button.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top;
            panel2.BackColor = Color.FromArgb(255, 192, 192);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(333, 39);
            panel2.Name = "panel2";
            panel2.Size = new Size(311, 35);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(83, 2);
            label1.Name = "label1";
            label1.Size = new Size(145, 28);
            label1.TabIndex = 0;
            label1.Text = "Create Account";
            // 
            // main
            // 
            main.AutoSize = true;
            main.Controls.Add(label5);
            main.Controls.Add(login_button);
            main.Controls.Add(panel2);
            main.Controls.Add(panel);
            main.Dock = DockStyle.Fill;
            main.Location = new Point(0, 0);
            main.Name = "main";
            main.Size = new Size(982, 403);
            main.TabIndex = 1;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(255, 192, 192);
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(99, 8);
            label5.MaximumSize = new Size(200, 0);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.No;
            label5.Size = new Size(196, 364);
            label5.TabIndex = 10;
            label5.Text = resources.GetString("label5.Text");
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel
            // 
            panel.Anchor = AnchorStyles.Top;
            panel.BackColor = Color.FromArgb(255, 192, 192);
            panel.Controls.Add(name_textbox);
            panel.Controls.Add(label4);
            panel.Controls.Add(cancel_button);
            panel.Controls.Add(create_account_error_label);
            panel.Controls.Add(submit_button);
            panel.Controls.Add(password_textbox);
            panel.Controls.Add(label3);
            panel.Controls.Add(username_textbox);
            panel.Controls.Add(label2);
            panel.Location = new Point(333, 80);
            panel.Name = "panel";
            panel.Size = new Size(311, 265);
            panel.TabIndex = 0;
            // 
            // name_textbox
            // 
            name_textbox.Cursor = Cursors.IBeam;
            name_textbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            name_textbox.Location = new Point(118, 8);
            name_textbox.MaxLength = 45;
            name_textbox.Name = "name_textbox";
            name_textbox.PlaceholderText = "Max 45 characters";
            name_textbox.Size = new Size(183, 34);
            name_textbox.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(43, 8);
            label4.Name = "label4";
            label4.Size = new Size(68, 28);
            label4.TabIndex = 8;
            label4.Text = "Name:";
            // 
            // cancel_button
            // 
            cancel_button.BackColor = Color.Gainsboro;
            cancel_button.Cursor = Cursors.Hand;
            cancel_button.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            cancel_button.ForeColor = Color.Black;
            cancel_button.Location = new Point(8, 204);
            cancel_button.Name = "cancel_button";
            cancel_button.Size = new Size(106, 46);
            cancel_button.TabIndex = 7;
            cancel_button.Text = "Cancel";
            cancel_button.UseVisualStyleBackColor = false;
            // 
            // create_account_error_label
            // 
            create_account_error_label.AutoSize = true;
            create_account_error_label.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            create_account_error_label.ForeColor = Color.DarkGreen;
            create_account_error_label.Location = new Point(8, 134);
            create_account_error_label.MaximumSize = new Size(300, 0);
            create_account_error_label.Name = "create_account_error_label";
            create_account_error_label.RightToLeft = RightToLeft.No;
            create_account_error_label.Size = new Size(0, 23);
            create_account_error_label.TabIndex = 6;
            create_account_error_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // submit_button
            // 
            submit_button.BackColor = Color.Gainsboro;
            submit_button.Cursor = Cursors.Hand;
            submit_button.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            submit_button.ForeColor = Color.Black;
            submit_button.Location = new Point(127, 204);
            submit_button.Name = "submit_button";
            submit_button.Size = new Size(177, 46);
            submit_button.TabIndex = 3;
            submit_button.Text = "Submit";
            submit_button.UseVisualStyleBackColor = false;
            // 
            // password_textbox
            // 
            password_textbox.Cursor = Cursors.IBeam;
            password_textbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            password_textbox.Location = new Point(118, 93);
            password_textbox.MaxLength = 25;
            password_textbox.Name = "password_textbox";
            password_textbox.PlaceholderText = "Max 25 characters";
            password_textbox.Size = new Size(183, 34);
            password_textbox.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(17, 91);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(97, 28);
            label3.TabIndex = 3;
            label3.Text = "Password:";
            // 
            // username_textbox
            // 
            username_textbox.Cursor = Cursors.IBeam;
            username_textbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            username_textbox.Location = new Point(118, 50);
            username_textbox.MaxLength = 10;
            username_textbox.Name = "username_textbox";
            username_textbox.PlaceholderText = "Max 10 characters";
            username_textbox.Size = new Size(183, 34);
            username_textbox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(10, 48);
            label2.Name = "label2";
            label2.Size = new Size(103, 28);
            label2.TabIndex = 1;
            label2.Text = "Username:";
            // 
            // CreateAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(main);
            Name = "CreateAccount";
            Size = new Size(982, 403);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            main.ResumeLayout(false);
            main.PerformLayout();
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Button login_button;
        private Panel panel2;
        private Label label1;
        private Panel main;
        private Panel panel;
        public Label create_account_error_label;
        public Button submit_button;
        public TextBox password_textbox;
        private Label label3;
        public TextBox username_textbox;
        private Label label2;
        public Button cancel_button;
        public TextBox name_textbox;
        public Label label4;
        private Label label5;
    }
}
