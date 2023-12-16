namespace Error_Tracker
{
    partial class ProjectDashboard
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
            panel1 = new Panel();
            username_label = new Label();
            logout_button = new Button();
            label1 = new Label();
            submit_button = new Button();
            main = new Panel();
            project_panel = new Panel();
            panel2 = new Panel();
            label7 = new Label();
            filter = new TextBox();
            label6 = new Label();
            refresh_button = new Button();
            label5 = new Label();
            project_submit_message = new Label();
            label4 = new Label();
            project_description = new TextBox();
            label3 = new Label();
            project_name = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            main.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.FromArgb(255, 192, 192);
            panel1.Controls.Add(username_label);
            panel1.Controls.Add(logout_button);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(982, 102);
            panel1.TabIndex = 0;
            // 
            // username_label
            // 
            username_label.Anchor = AnchorStyles.Right;
            username_label.BackColor = Color.FromArgb(192, 255, 255);
            username_label.BorderStyle = BorderStyle.FixedSingle;
            username_label.Font = new Font("Eras Medium ITC", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point);
            username_label.Location = new Point(700, 21);
            username_label.Name = "username_label";
            username_label.RightToLeft = RightToLeft.No;
            username_label.Size = new Size(251, 32);
            username_label.TabIndex = 2;
            username_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // logout_button
            // 
            logout_button.Anchor = AnchorStyles.Right;
            logout_button.Cursor = Cursors.Hand;
            logout_button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            logout_button.Location = new Point(759, 55);
            logout_button.Name = "logout_button";
            logout_button.Size = new Size(128, 43);
            logout_button.TabIndex = 1;
            logout_button.Text = "Logout";
            logout_button.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(-1, 32);
            label1.Name = "label1";
            label1.Size = new Size(278, 41);
            label1.TabIndex = 0;
            label1.Text = "Project Dashboard";
            // 
            // submit_button
            // 
            submit_button.Anchor = AnchorStyles.Right;
            submit_button.Cursor = Cursors.Hand;
            submit_button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            submit_button.Location = new Point(714, 37);
            submit_button.Name = "submit_button";
            submit_button.Size = new Size(96, 69);
            submit_button.TabIndex = 3;
            submit_button.Text = "Submit";
            submit_button.UseVisualStyleBackColor = true;
            submit_button.Click += submit_button_Click;
            // 
            // main
            // 
            main.AutoScroll = true;
            main.Controls.Add(project_panel);
            main.Controls.Add(panel2);
            main.Controls.Add(panel1);
            main.Dock = DockStyle.Fill;
            main.Location = new Point(0, 0);
            main.Name = "main";
            main.Size = new Size(982, 403);
            main.TabIndex = 1;
            // 
            // project_panel
            // 
            project_panel.AutoSize = true;
            project_panel.Dock = DockStyle.Top;
            project_panel.Location = new Point(0, 272);
            project_panel.Name = "project_panel";
            project_panel.Size = new Size(982, 0);
            project_panel.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label7);
            panel2.Controls.Add(filter);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(refresh_button);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(project_submit_message);
            panel2.Controls.Add(submit_button);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(project_description);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(project_name);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 102);
            panel2.Name = "panel2";
            panel2.Size = new Size(982, 170);
            panel2.TabIndex = 1;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(512, 140);
            label7.Name = "label7";
            label7.Size = new Size(455, 23);
            label7.TabIndex = 10;
            label7.Text = "WARNING: LEAVING A PROJECT CANNOT BE REVERSED";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // filter
            // 
            filter.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            filter.Location = new Point(338, 136);
            filter.MaxLength = 20;
            filter.Name = "filter";
            filter.PlaceholderText = "Name Filter";
            filter.Size = new Size(176, 30);
            filter.TabIndex = 9;
            filter.TextChanged += filter_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(185, 139);
            label6.Name = "label6";
            label6.Size = new Size(160, 23);
            label6.TabIndex = 8;
            label6.Text = "Filter Project Name: ";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // refresh_button
            // 
            refresh_button.Cursor = Cursors.Hand;
            refresh_button.Location = new Point(103, 134);
            refresh_button.Name = "refresh_button";
            refresh_button.Size = new Size(75, 29);
            refresh_button.TabIndex = 7;
            refresh_button.Text = "Refresh";
            refresh_button.UseVisualStyleBackColor = true;
            refresh_button.Click += refresh_button_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Rockwell", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(2, 134);
            label5.Name = "label5";
            label5.Size = new Size(104, 29);
            label5.TabIndex = 6;
            label5.Text = "Projects";
            // 
            // project_submit_message
            // 
            project_submit_message.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            project_submit_message.AutoSize = true;
            project_submit_message.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            project_submit_message.Location = new Point(818, 12);
            project_submit_message.MaximumSize = new Size(155, 0);
            project_submit_message.Name = "project_submit_message";
            project_submit_message.Size = new Size(0, 23);
            project_submit_message.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(50, 6);
            label4.Name = "label4";
            label4.Size = new Size(285, 115);
            label4.TabIndex = 4;
            label4.Text = "Create A Project\r\nEnter Name (Required)\r\nEnter Description (Optional)\r\nClick Submit\r\nNote: Name cannot start with space\r\n";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // project_description
            // 
            project_description.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            project_description.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            project_description.Location = new Point(468, 44);
            project_description.MaxLength = 100;
            project_description.Multiline = true;
            project_description.Name = "project_description";
            project_description.PlaceholderText = "Max 100 characters";
            project_description.ScrollBars = ScrollBars.Vertical;
            project_description.Size = new Size(240, 86);
            project_description.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(372, 48);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 2;
            label3.Text = "Description:";
            // 
            // project_name
            // 
            project_name.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            project_name.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            project_name.Location = new Point(468, 5);
            project_name.MaxLength = 20;
            project_name.Name = "project_name";
            project_name.PlaceholderText = "Max 20 characters";
            project_name.Size = new Size(240, 30);
            project_name.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(411, 7);
            label2.Name = "label2";
            label2.Size = new Size(60, 23);
            label2.TabIndex = 0;
            label2.Text = "Name:";
            // 
            // ProjectDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(main);
            Name = "ProjectDashboard";
            Size = new Size(982, 403);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            main.ResumeLayout(false);
            main.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        public Panel main;
        public Button logout_button;
        public Label username_label;
        private Panel panel2;
        private Label label2;
        private TextBox project_name;
        private TextBox project_description;
        private Label label3;
        private Label label4;
        public Button submit_button;
        private Label project_submit_message;
        private Panel project_panel;
        private Button refresh_button;
        private Label label5;
        private Label label6;
        private TextBox filter;
        private Label label7;
    }
}
