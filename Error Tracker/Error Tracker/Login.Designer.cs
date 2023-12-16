namespace Error_Tracker
{
    partial class Login
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
            main = new Panel();
            create_account_button = new Button();
            panel2 = new Panel();
            label1 = new Label();
            panel1 = new Panel();
            login_error_label = new Label();
            login_button = new Button();
            password_textbox = new TextBox();
            label3 = new Label();
            username_textbox = new TextBox();
            label2 = new Label();
            main.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // main
            // 
            main.AutoSize = true;
            main.Controls.Add(create_account_button);
            main.Controls.Add(panel2);
            main.Controls.Add(panel1);
            main.Dock = DockStyle.Fill;
            main.Location = new Point(0, 0);
            main.Name = "main";
            main.Size = new Size(982, 403);
            main.TabIndex = 0;
            // 
            // create_account_button
            // 
            create_account_button.Anchor = AnchorStyles.Top;
            create_account_button.BackColor = Color.Gainsboro;
            create_account_button.Cursor = Cursors.Hand;
            create_account_button.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            create_account_button.Location = new Point(763, 39);
            create_account_button.Name = "create_account_button";
            create_account_button.Size = new Size(177, 78);
            create_account_button.TabIndex = 6;
            create_account_button.Text = "Create Account";
            create_account_button.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top;
            panel2.BackColor = Color.FromArgb(255, 192, 192);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(339, 39);
            panel2.Name = "panel2";
            panel2.Size = new Size(311, 35);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(123, 2);
            label1.Name = "label1";
            label1.Size = new Size(61, 28);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.BackColor = Color.FromArgb(255, 192, 192);
            panel1.Controls.Add(login_error_label);
            panel1.Controls.Add(login_button);
            panel1.Controls.Add(password_textbox);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(username_textbox);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(339, 80);
            panel1.Name = "panel1";
            panel1.Size = new Size(311, 265);
            panel1.TabIndex = 0;
            // 
            // login_error_label
            // 
            login_error_label.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            login_error_label.ForeColor = Color.DarkGreen;
            login_error_label.Location = new Point(8, 154);
            login_error_label.Name = "login_error_label";
            login_error_label.RightToLeft = RightToLeft.No;
            login_error_label.Size = new Size(300, 23);
            login_error_label.TabIndex = 6;
            login_error_label.Text = "Invalid username/password. Try again.";
            login_error_label.Visible = false;
            // 
            // login_button
            // 
            login_button.BackColor = Color.Gainsboro;
            login_button.Cursor = Cursors.Hand;
            login_button.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            login_button.ForeColor = Color.Black;
            login_button.Location = new Point(63, 204);
            login_button.Name = "login_button";
            login_button.Size = new Size(177, 46);
            login_button.TabIndex = 5;
            login_button.Text = "Login";
            login_button.UseVisualStyleBackColor = false;
            // 
            // password_textbox
            // 
            password_textbox.Cursor = Cursors.IBeam;
            password_textbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            password_textbox.Location = new Point(118, 85);
            password_textbox.MaxLength = 25;
            password_textbox.Name = "password_textbox";
            password_textbox.Size = new Size(183, 34);
            password_textbox.TabIndex = 4;
            password_textbox.KeyDown += password_textbox_KeyDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(17, 84);
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
            username_textbox.Location = new Point(118, 40);
            username_textbox.MaxLength = 10;
            username_textbox.Name = "username_textbox";
            username_textbox.Size = new Size(183, 34);
            username_textbox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(10, 37);
            label2.Name = "label2";
            label2.Size = new Size(103, 28);
            label2.TabIndex = 1;
            label2.Text = "Username:";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(main);
            Name = "Login";
            Size = new Size(982, 403);
            main.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel main;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        public TextBox username_textbox;
        private Label label2;
        public TextBox password_textbox;
        private Label label3;
        public Button login_button;
        public Button create_account_button;
        public Label login_error_label;
    }
}
