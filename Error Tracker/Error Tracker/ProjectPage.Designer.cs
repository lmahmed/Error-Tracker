namespace Error_Tracker
{
    partial class ProjectPage
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectPage));
            panel1 = new Panel();
            refresh_page_button = new Button();
            project_dashboard_button = new Button();
            username_label = new Label();
            logout_button = new Button();
            project_name_label = new Label();
            comment_panel = new Panel();
            actual_comment_panel = new Panel();
            panel4 = new Panel();
            refresh_comments = new Button();
            project_comment_button = new Button();
            project_comment = new TextBox();
            panel3 = new Panel();
            label1 = new Label();
            main = new Panel();
            change_panel = new Panel();
            panel22 = new Panel();
            label16 = new Label();
            error_panel = new Panel();
            panel21 = new Panel();
            filter = new TextBox();
            label14 = new Label();
            refresh_error = new Button();
            label13 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel13 = new Panel();
            e_priority_textbox = new TextBox();
            panel18 = new Panel();
            label10 = new Label();
            panel12 = new Panel();
            e_status_textbox = new TextBox();
            panel17 = new Panel();
            label9 = new Label();
            panel11 = new Panel();
            e_type_textbox = new TextBox();
            panel16 = new Panel();
            label8 = new Label();
            panel10 = new Panel();
            e_description_textbox = new TextBox();
            panel15 = new Panel();
            label7 = new Label();
            panel9 = new Panel();
            e_name_textbox = new TextBox();
            panel14 = new Panel();
            label6 = new Label();
            panel19 = new Panel();
            e_severity_textbox = new TextBox();
            panel20 = new Panel();
            label12 = new Label();
            label11 = new Label();
            panel2 = new Panel();
            add_error = new Button();
            help_button = new Button();
            label5 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel5 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel7 = new Panel();
            label3 = new Label();
            collaborator_list_box = new ListBox();
            panel8 = new Panel();
            pictureBox1 = new PictureBox();
            removeCollaborator = new Button();
            addCollaborator = new Button();
            label4 = new Label();
            textBox1 = new TextBox();
            panel6 = new Panel();
            project_description_textbox = new TextBox();
            label2 = new Label();
            description_changed_panel = new Panel();
            save_description_button = new Button();
            cancel_description_button = new Button();
            changeBindingSource = new BindingSource(components);
            panel1.SuspendLayout();
            comment_panel.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            main.SuspendLayout();
            panel22.SuspendLayout();
            panel21.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel13.SuspendLayout();
            panel18.SuspendLayout();
            panel12.SuspendLayout();
            panel17.SuspendLayout();
            panel11.SuspendLayout();
            panel16.SuspendLayout();
            panel10.SuspendLayout();
            panel15.SuspendLayout();
            panel9.SuspendLayout();
            panel14.SuspendLayout();
            panel19.SuspendLayout();
            panel20.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel5.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel6.SuspendLayout();
            description_changed_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)changeBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.FromArgb(255, 192, 192);
            panel1.Controls.Add(refresh_page_button);
            panel1.Controls.Add(project_dashboard_button);
            panel1.Controls.Add(username_label);
            panel1.Controls.Add(logout_button);
            panel1.Controls.Add(project_name_label);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(940, 102);
            panel1.TabIndex = 1;
            // 
            // refresh_page_button
            // 
            refresh_page_button.Cursor = Cursors.Hand;
            refresh_page_button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            refresh_page_button.Location = new Point(217, 64);
            refresh_page_button.Margin = new Padding(0);
            refresh_page_button.Name = "refresh_page_button";
            refresh_page_button.Size = new Size(138, 36);
            refresh_page_button.TabIndex = 6;
            refresh_page_button.Text = "Refresh Page";
            refresh_page_button.UseVisualStyleBackColor = true;
            refresh_page_button.Click += refresh_page_button_Click;
            // 
            // project_dashboard_button
            // 
            project_dashboard_button.Cursor = Cursors.Hand;
            project_dashboard_button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            project_dashboard_button.Location = new Point(9, 64);
            project_dashboard_button.Margin = new Padding(0);
            project_dashboard_button.Name = "project_dashboard_button";
            project_dashboard_button.Size = new Size(198, 36);
            project_dashboard_button.TabIndex = 5;
            project_dashboard_button.Text = "Project Dashboard";
            project_dashboard_button.UseVisualStyleBackColor = true;
            project_dashboard_button.Click += project_dashboard_button_Click;
            // 
            // username_label
            // 
            username_label.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            username_label.BackColor = Color.FromArgb(192, 255, 255);
            username_label.BorderStyle = BorderStyle.FixedSingle;
            username_label.Font = new Font("Eras Medium ITC", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point);
            username_label.Location = new Point(658, 21);
            username_label.Name = "username_label";
            username_label.RightToLeft = RightToLeft.No;
            username_label.Size = new Size(251, 32);
            username_label.TabIndex = 4;
            username_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // logout_button
            // 
            logout_button.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            logout_button.Cursor = Cursors.Hand;
            logout_button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            logout_button.Location = new Point(717, 55);
            logout_button.Name = "logout_button";
            logout_button.Size = new Size(128, 43);
            logout_button.TabIndex = 3;
            logout_button.Text = "Logout";
            logout_button.UseVisualStyleBackColor = true;
            // 
            // project_name_label
            // 
            project_name_label.AutoSize = true;
            project_name_label.BackColor = Color.Transparent;
            project_name_label.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            project_name_label.Location = new Point(6, 21);
            project_name_label.Name = "project_name_label";
            project_name_label.Size = new Size(0, 41);
            project_name_label.TabIndex = 0;
            // 
            // comment_panel
            // 
            comment_panel.AutoScroll = true;
            comment_panel.BackgroundImageLayout = ImageLayout.None;
            comment_panel.BorderStyle = BorderStyle.FixedSingle;
            comment_panel.Controls.Add(actual_comment_panel);
            comment_panel.Controls.Add(panel4);
            comment_panel.Controls.Add(panel3);
            comment_panel.Dock = DockStyle.Right;
            comment_panel.Location = new Point(717, 102);
            comment_panel.Name = "comment_panel";
            comment_panel.Size = new Size(223, 301);
            comment_panel.TabIndex = 2;
            // 
            // actual_comment_panel
            // 
            actual_comment_panel.AutoSize = true;
            actual_comment_panel.Dock = DockStyle.Top;
            actual_comment_panel.Location = new Point(0, 107);
            actual_comment_panel.Name = "actual_comment_panel";
            actual_comment_panel.Size = new Size(221, 0);
            actual_comment_panel.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(255, 192, 192);
            panel4.Controls.Add(refresh_comments);
            panel4.Controls.Add(project_comment_button);
            panel4.Controls.Add(project_comment);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 39);
            panel4.Name = "panel4";
            panel4.Size = new Size(221, 68);
            panel4.TabIndex = 1;
            // 
            // refresh_comments
            // 
            refresh_comments.Location = new Point(137, 36);
            refresh_comments.Name = "refresh_comments";
            refresh_comments.Size = new Size(71, 29);
            refresh_comments.TabIndex = 2;
            refresh_comments.Text = "Refresh";
            refresh_comments.UseVisualStyleBackColor = true;
            refresh_comments.Click += refresh_comments_Click;
            // 
            // project_comment_button
            // 
            project_comment_button.Location = new Point(3, 36);
            project_comment_button.Name = "project_comment_button";
            project_comment_button.Size = new Size(124, 29);
            project_comment_button.TabIndex = 1;
            project_comment_button.Text = "Post Comment";
            project_comment_button.UseVisualStyleBackColor = true;
            project_comment_button.Click += project_comment_button_Click;
            // 
            // project_comment
            // 
            project_comment.Location = new Point(3, 6);
            project_comment.MaxLength = 45;
            project_comment.Name = "project_comment";
            project_comment.PlaceholderText = "Max 45 characters";
            project_comment.ScrollBars = ScrollBars.Horizontal;
            project_comment.Size = new Size(216, 27);
            project_comment.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(221, 39);
            panel3.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 17F, FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(32, -3);
            label1.Name = "label1";
            label1.Size = new Size(155, 40);
            label1.TabIndex = 3;
            label1.Text = "Comments";
            // 
            // main
            // 
            main.AutoScroll = true;
            main.AutoSize = true;
            main.Controls.Add(change_panel);
            main.Controls.Add(panel22);
            main.Controls.Add(error_panel);
            main.Controls.Add(panel21);
            main.Controls.Add(tableLayoutPanel3);
            main.Controls.Add(panel2);
            main.Controls.Add(tableLayoutPanel1);
            main.Dock = DockStyle.Fill;
            main.Location = new Point(0, 102);
            main.Name = "main";
            main.Size = new Size(717, 301);
            main.TabIndex = 3;
            // 
            // change_panel
            // 
            change_panel.AutoSize = true;
            change_panel.Dock = DockStyle.Top;
            change_panel.Location = new Point(0, 350);
            change_panel.Name = "change_panel";
            change_panel.Size = new Size(696, 0);
            change_panel.TabIndex = 0;
            // 
            // panel22
            // 
            panel22.BackColor = Color.FromArgb(255, 192, 192);
            panel22.Controls.Add(label16);
            panel22.Dock = DockStyle.Top;
            panel22.Location = new Point(0, 299);
            panel22.Name = "panel22";
            panel22.Size = new Size(696, 51);
            panel22.TabIndex = 7;
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Top;
            label16.AutoSize = true;
            label16.BackColor = Color.Transparent;
            label16.Font = new Font("Segoe UI", 17F, FontStyle.Underline, GraphicsUnit.Point);
            label16.Location = new Point(287, 6);
            label16.Name = "label16";
            label16.Size = new Size(126, 40);
            label16.TabIndex = 5;
            label16.Text = "Changes";
            // 
            // error_panel
            // 
            error_panel.AutoSize = true;
            error_panel.Dock = DockStyle.Top;
            error_panel.Location = new Point(0, 299);
            error_panel.Name = "error_panel";
            error_panel.Size = new Size(696, 0);
            error_panel.TabIndex = 7;
            // 
            // panel21
            // 
            panel21.BackColor = Color.FromArgb(255, 192, 192);
            panel21.Controls.Add(filter);
            panel21.Controls.Add(label14);
            panel21.Controls.Add(refresh_error);
            panel21.Controls.Add(label13);
            panel21.Dock = DockStyle.Top;
            panel21.Location = new Point(0, 248);
            panel21.Name = "panel21";
            panel21.Size = new Size(696, 51);
            panel21.TabIndex = 6;
            // 
            // filter
            // 
            filter.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            filter.Location = new Point(313, 10);
            filter.MaxLength = 20;
            filter.Name = "filter";
            filter.PlaceholderText = "Name Filter";
            filter.Size = new Size(176, 30);
            filter.TabIndex = 11;
            filter.TextChanged += filter_TextChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10F, FontStyle.Italic, GraphicsUnit.Point);
            label14.Location = new Point(176, 13);
            label14.Name = "label14";
            label14.Size = new Size(145, 23);
            label14.TabIndex = 10;
            label14.Text = "Filter Error Name: ";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // refresh_error
            // 
            refresh_error.Location = new Point(102, 12);
            refresh_error.Name = "refresh_error";
            refresh_error.Size = new Size(71, 29);
            refresh_error.TabIndex = 6;
            refresh_error.Text = "Refresh";
            refresh_error.UseVisualStyleBackColor = true;
            refresh_error.Click += refresh_error_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Segoe UI", 17F, FontStyle.Underline, GraphicsUnit.Point);
            label13.Location = new Point(5, 3);
            label13.Name = "label13";
            label13.Size = new Size(91, 40);
            label13.TabIndex = 5;
            label13.Text = "Errors";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel3.ColumnCount = 6;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel3.Controls.Add(panel13, 4, 0);
            tableLayoutPanel3.Controls.Add(panel12, 3, 0);
            tableLayoutPanel3.Controls.Add(panel11, 2, 0);
            tableLayoutPanel3.Controls.Add(panel10, 1, 0);
            tableLayoutPanel3.Controls.Add(panel9, 0, 0);
            tableLayoutPanel3.Controls.Add(panel19, 5, 0);
            tableLayoutPanel3.Dock = DockStyle.Top;
            tableLayoutPanel3.Location = new Point(0, 165);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(696, 83);
            tableLayoutPanel3.TabIndex = 4;
            // 
            // panel13
            // 
            panel13.Controls.Add(e_priority_textbox);
            panel13.Controls.Add(panel18);
            panel13.Dock = DockStyle.Fill;
            panel13.Location = new Point(556, 4);
            panel13.Name = "panel13";
            panel13.Size = new Size(62, 75);
            panel13.TabIndex = 4;
            // 
            // e_priority_textbox
            // 
            e_priority_textbox.Dock = DockStyle.Fill;
            e_priority_textbox.Location = new Point(0, 23);
            e_priority_textbox.MaxLength = 2;
            e_priority_textbox.Multiline = true;
            e_priority_textbox.Name = "e_priority_textbox";
            e_priority_textbox.PlaceholderText = "1-10";
            e_priority_textbox.Size = new Size(62, 52);
            e_priority_textbox.TabIndex = 3;
            e_priority_textbox.TextChanged += e_priority_textbox_TextChanged;
            // 
            // panel18
            // 
            panel18.AutoSize = true;
            panel18.Controls.Add(label10);
            panel18.Dock = DockStyle.Top;
            panel18.Location = new Point(0, 0);
            panel18.Name = "panel18";
            panel18.Size = new Size(62, 23);
            panel18.TabIndex = 2;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(-1, 0);
            label10.Name = "label10";
            label10.Size = new Size(64, 23);
            label10.TabIndex = 1;
            label10.Text = "Priority";
            // 
            // panel12
            // 
            panel12.Controls.Add(e_status_textbox);
            panel12.Controls.Add(panel17);
            panel12.Dock = DockStyle.Fill;
            panel12.Location = new Point(418, 4);
            panel12.Name = "panel12";
            panel12.Size = new Size(131, 75);
            panel12.TabIndex = 3;
            // 
            // e_status_textbox
            // 
            e_status_textbox.Dock = DockStyle.Fill;
            e_status_textbox.Location = new Point(0, 23);
            e_status_textbox.MaxLength = 15;
            e_status_textbox.Multiline = true;
            e_status_textbox.Name = "e_status_textbox";
            e_status_textbox.PlaceholderText = "Max 15 characters";
            e_status_textbox.Size = new Size(131, 52);
            e_status_textbox.TabIndex = 3;
            e_status_textbox.TextChanged += e_status_textbox_TextChanged;
            // 
            // panel17
            // 
            panel17.AutoSize = true;
            panel17.Controls.Add(label9);
            panel17.Dock = DockStyle.Top;
            panel17.Location = new Point(0, 0);
            panel17.Name = "panel17";
            panel17.Size = new Size(131, 23);
            panel17.TabIndex = 2;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(36, 0);
            label9.Name = "label9";
            label9.Size = new Size(56, 23);
            label9.TabIndex = 1;
            label9.Text = "Status";
            // 
            // panel11
            // 
            panel11.Controls.Add(e_type_textbox);
            panel11.Controls.Add(panel16);
            panel11.Dock = DockStyle.Fill;
            panel11.Location = new Point(280, 4);
            panel11.Name = "panel11";
            panel11.Size = new Size(131, 75);
            panel11.TabIndex = 2;
            // 
            // e_type_textbox
            // 
            e_type_textbox.Dock = DockStyle.Fill;
            e_type_textbox.Location = new Point(0, 23);
            e_type_textbox.MaxLength = 10;
            e_type_textbox.Multiline = true;
            e_type_textbox.Name = "e_type_textbox";
            e_type_textbox.PlaceholderText = "Max 10 characters ";
            e_type_textbox.Size = new Size(131, 52);
            e_type_textbox.TabIndex = 3;
            e_type_textbox.TextChanged += e_type_textbox_TextChanged;
            // 
            // panel16
            // 
            panel16.AutoSize = true;
            panel16.Controls.Add(label8);
            panel16.Dock = DockStyle.Top;
            panel16.Location = new Point(0, 0);
            panel16.Name = "panel16";
            panel16.Size = new Size(131, 23);
            panel16.TabIndex = 2;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(41, 0);
            label8.Name = "label8";
            label8.Size = new Size(45, 23);
            label8.TabIndex = 1;
            label8.Text = "Type";
            // 
            // panel10
            // 
            panel10.Controls.Add(e_description_textbox);
            panel10.Controls.Add(panel15);
            panel10.Dock = DockStyle.Fill;
            panel10.Location = new Point(142, 4);
            panel10.Name = "panel10";
            panel10.Size = new Size(131, 75);
            panel10.TabIndex = 1;
            // 
            // e_description_textbox
            // 
            e_description_textbox.Dock = DockStyle.Fill;
            e_description_textbox.Location = new Point(0, 21);
            e_description_textbox.MaxLength = 45;
            e_description_textbox.Multiline = true;
            e_description_textbox.Name = "e_description_textbox";
            e_description_textbox.PlaceholderText = "Max 45 characters";
            e_description_textbox.Size = new Size(131, 54);
            e_description_textbox.TabIndex = 3;
            e_description_textbox.TextChanged += e_description_textbox_TextChanged;
            // 
            // panel15
            // 
            panel15.AutoSize = true;
            panel15.Controls.Add(label7);
            panel15.Dock = DockStyle.Top;
            panel15.Location = new Point(0, 0);
            panel15.Name = "panel15";
            panel15.Size = new Size(131, 21);
            panel15.TabIndex = 2;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(16, -2);
            label7.Name = "label7";
            label7.Size = new Size(96, 23);
            label7.TabIndex = 1;
            label7.Text = "Description";
            // 
            // panel9
            // 
            panel9.Controls.Add(e_name_textbox);
            panel9.Controls.Add(panel14);
            panel9.Dock = DockStyle.Fill;
            panel9.Location = new Point(4, 4);
            panel9.Name = "panel9";
            panel9.Size = new Size(131, 75);
            panel9.TabIndex = 0;
            // 
            // e_name_textbox
            // 
            e_name_textbox.Dock = DockStyle.Fill;
            e_name_textbox.Location = new Point(0, 23);
            e_name_textbox.MaxLength = 45;
            e_name_textbox.Multiline = true;
            e_name_textbox.Name = "e_name_textbox";
            e_name_textbox.PlaceholderText = "Max 45 characters";
            e_name_textbox.Size = new Size(131, 52);
            e_name_textbox.TabIndex = 2;
            e_name_textbox.TextChanged += e_name_textbox_TextChanged;
            // 
            // panel14
            // 
            panel14.AutoSize = true;
            panel14.Controls.Add(label6);
            panel14.Dock = DockStyle.Top;
            panel14.Location = new Point(0, 0);
            panel14.Name = "panel14";
            panel14.Size = new Size(131, 23);
            panel14.TabIndex = 1;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(36, 0);
            label6.Name = "label6";
            label6.Size = new Size(56, 23);
            label6.TabIndex = 0;
            label6.Text = "Name";
            // 
            // panel19
            // 
            panel19.Controls.Add(e_severity_textbox);
            panel19.Controls.Add(panel20);
            panel19.Dock = DockStyle.Fill;
            panel19.Location = new Point(625, 4);
            panel19.Name = "panel19";
            panel19.Size = new Size(67, 75);
            panel19.TabIndex = 5;
            // 
            // e_severity_textbox
            // 
            e_severity_textbox.Dock = DockStyle.Fill;
            e_severity_textbox.Location = new Point(0, 21);
            e_severity_textbox.MaxLength = 2;
            e_severity_textbox.Multiline = true;
            e_severity_textbox.Name = "e_severity_textbox";
            e_severity_textbox.PlaceholderText = "1-10";
            e_severity_textbox.Size = new Size(67, 54);
            e_severity_textbox.TabIndex = 4;
            e_severity_textbox.TextChanged += e_severity_textbox_TextChanged;
            // 
            // panel20
            // 
            panel20.Controls.Add(label12);
            panel20.Controls.Add(label11);
            panel20.Dock = DockStyle.Top;
            panel20.Location = new Point(0, 0);
            panel20.Name = "panel20";
            panel20.Size = new Size(67, 21);
            panel20.TabIndex = 3;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.None;
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(0, -1);
            label12.Name = "label12";
            label12.Size = new Size(69, 23);
            label12.TabIndex = 2;
            label12.Text = "Severity";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(-25, -40);
            label11.Name = "label11";
            label11.Size = new Size(56, 23);
            label11.TabIndex = 1;
            label11.Text = "Status";
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.BackColor = Color.FromArgb(255, 192, 192);
            panel2.Controls.Add(add_error);
            panel2.Controls.Add(help_button);
            panel2.Controls.Add(label5);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 125);
            panel2.Name = "panel2";
            panel2.Size = new Size(696, 40);
            panel2.TabIndex = 5;
            // 
            // add_error
            // 
            add_error.Anchor = AnchorStyles.None;
            add_error.BackColor = Color.White;
            add_error.Cursor = Cursors.Hand;
            add_error.Enabled = false;
            add_error.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            add_error.ForeColor = Color.Black;
            add_error.Location = new Point(430, 6);
            add_error.Name = "add_error";
            add_error.Size = new Size(141, 29);
            add_error.TabIndex = 11;
            add_error.Text = "Add Error";
            add_error.UseVisualStyleBackColor = false;
            add_error.Click += add_error_Click;
            // 
            // help_button
            // 
            help_button.Anchor = AnchorStyles.None;
            help_button.Location = new Point(178, 6);
            help_button.Name = "help_button";
            help_button.Size = new Size(94, 29);
            help_button.TabIndex = 10;
            help_button.Text = "Help";
            help_button.UseVisualStyleBackColor = true;
            help_button.Click += help_button_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI", 17F, FontStyle.Underline, GraphicsUnit.Point);
            label5.Location = new Point(278, 0);
            label5.Name = "label5";
            label5.Size = new Size(140, 40);
            label5.TabIndex = 9;
            label5.Text = "Add Error";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel5, 1, 0);
            tableLayoutPanel1.Controls.Add(panel6, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(696, 125);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // panel5
            // 
            panel5.Controls.Add(tableLayoutPanel2);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(351, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(341, 117);
            panel5.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(panel7, 0, 0);
            tableLayoutPanel2.Controls.Add(panel8, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(341, 117);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.Controls.Add(label3);
            panel7.Controls.Add(collaborator_list_box);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(3, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(164, 111);
            panel7.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 17F, FontStyle.Underline, GraphicsUnit.Point);
            label3.Location = new Point(-6, 0);
            label3.Name = "label3";
            label3.Size = new Size(189, 40);
            label3.TabIndex = 10;
            label3.Text = "Collaborators";
            label3.Click += label3_Click;
            // 
            // collaborator_list_box
            // 
            collaborator_list_box.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            collaborator_list_box.FormattingEnabled = true;
            collaborator_list_box.HorizontalScrollbar = true;
            collaborator_list_box.ItemHeight = 20;
            collaborator_list_box.Location = new Point(1, 41);
            collaborator_list_box.MaximumSize = new Size(400, 0);
            collaborator_list_box.MinimumSize = new Size(0, 64);
            collaborator_list_box.Name = "collaborator_list_box";
            collaborator_list_box.Size = new Size(152, 64);
            collaborator_list_box.TabIndex = 9;
            collaborator_list_box.SelectedIndexChanged += collaborator_list_box_SelectedIndexChanged;
            // 
            // panel8
            // 
            panel8.Controls.Add(pictureBox1);
            panel8.Controls.Add(removeCollaborator);
            panel8.Controls.Add(addCollaborator);
            panel8.Controls.Add(label4);
            panel8.Controls.Add(textBox1);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(173, 3);
            panel8.Name = "panel8";
            panel8.Size = new Size(165, 111);
            panel8.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(7, 57);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(34, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // removeCollaborator
            // 
            removeCollaborator.BackColor = Color.FromArgb(255, 192, 192);
            removeCollaborator.Cursor = Cursors.Hand;
            removeCollaborator.Enabled = false;
            removeCollaborator.Location = new Point(6, 80);
            removeCollaborator.Name = "removeCollaborator";
            removeCollaborator.Size = new Size(84, 31);
            removeCollaborator.TabIndex = 15;
            removeCollaborator.Text = "Remove";
            removeCollaborator.UseVisualStyleBackColor = false;
            removeCollaborator.Click += removeCollaborator_Click;
            // 
            // addCollaborator
            // 
            addCollaborator.BackColor = Color.FromArgb(255, 192, 192);
            addCollaborator.Cursor = Cursors.Hand;
            addCollaborator.Enabled = false;
            addCollaborator.Location = new Point(89, 53);
            addCollaborator.Name = "addCollaborator";
            addCollaborator.Size = new Size(82, 29);
            addCollaborator.TabIndex = 14;
            addCollaborator.Text = "Add";
            addCollaborator.UseVisualStyleBackColor = false;
            addCollaborator.Click += addCollaborator_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(3, -3);
            label4.Name = "label4";
            label4.Size = new Size(165, 28);
            label4.TabIndex = 13;
            label4.Text = "Add Collaborator";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(1, 25);
            textBox1.MaxLength = 10;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Collaborator's username";
            textBox1.Size = new Size(162, 27);
            textBox1.TabIndex = 11;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyDown += textBox1_KeyDown;
            // 
            // panel6
            // 
            panel6.Controls.Add(project_description_textbox);
            panel6.Controls.Add(label2);
            panel6.Controls.Add(description_changed_panel);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(4, 4);
            panel6.Name = "panel6";
            panel6.Size = new Size(340, 117);
            panel6.TabIndex = 5;
            // 
            // project_description_textbox
            // 
            project_description_textbox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            project_description_textbox.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            project_description_textbox.Location = new Point(9, 40);
            project_description_textbox.MaxLength = 100;
            project_description_textbox.Multiline = true;
            project_description_textbox.Name = "project_description_textbox";
            project_description_textbox.ScrollBars = ScrollBars.Vertical;
            project_description_textbox.Size = new Size(319, 73);
            project_description_textbox.TabIndex = 0;
            project_description_textbox.TextChanged += project_description_textbox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 17F, FontStyle.Underline, GraphicsUnit.Point);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(161, 40);
            label2.TabIndex = 4;
            label2.Text = "Description";
            // 
            // description_changed_panel
            // 
            description_changed_panel.Anchor = AnchorStyles.None;
            description_changed_panel.AutoSize = true;
            description_changed_panel.Controls.Add(save_description_button);
            description_changed_panel.Controls.Add(cancel_description_button);
            description_changed_panel.Location = new Point(166, 3);
            description_changed_panel.Name = "description_changed_panel";
            description_changed_panel.Size = new Size(180, 36);
            description_changed_panel.TabIndex = 8;
            description_changed_panel.Visible = false;
            // 
            // save_description_button
            // 
            save_description_button.Anchor = AnchorStyles.Left;
            save_description_button.Cursor = Cursors.Hand;
            save_description_button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            save_description_button.Location = new Point(100, 0);
            save_description_button.Margin = new Padding(0);
            save_description_button.Name = "save_description_button";
            save_description_button.Size = new Size(80, 36);
            save_description_button.TabIndex = 8;
            save_description_button.Text = "Save";
            save_description_button.UseVisualStyleBackColor = true;
            save_description_button.Click += save_description_button_Click;
            // 
            // cancel_description_button
            // 
            cancel_description_button.Anchor = AnchorStyles.Left;
            cancel_description_button.Cursor = Cursors.Hand;
            cancel_description_button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cancel_description_button.Location = new Point(0, 0);
            cancel_description_button.Margin = new Padding(0);
            cancel_description_button.Name = "cancel_description_button";
            cancel_description_button.Size = new Size(80, 36);
            cancel_description_button.TabIndex = 7;
            cancel_description_button.Text = "Cancel";
            cancel_description_button.UseVisualStyleBackColor = true;
            cancel_description_button.Click += cancel_description_button_Click;
            // 
            // changeBindingSource
            // 
            changeBindingSource.DataSource = typeof(Change);
            // 
            // ProjectPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(main);
            Controls.Add(comment_panel);
            Controls.Add(panel1);
            Name = "ProjectPage";
            Size = new Size(940, 403);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            comment_panel.ResumeLayout(false);
            comment_panel.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            main.ResumeLayout(false);
            main.PerformLayout();
            panel22.ResumeLayout(false);
            panel22.PerformLayout();
            panel21.ResumeLayout(false);
            panel21.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            panel13.ResumeLayout(false);
            panel13.PerformLayout();
            panel18.ResumeLayout(false);
            panel18.PerformLayout();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panel17.ResumeLayout(false);
            panel17.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel16.ResumeLayout(false);
            panel16.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel15.ResumeLayout(false);
            panel15.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel14.ResumeLayout(false);
            panel14.PerformLayout();
            panel19.ResumeLayout(false);
            panel19.PerformLayout();
            panel20.ResumeLayout(false);
            panel20.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            description_changed_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)changeBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label project_name_label;
        public Label username_label;
        public Button logout_button;
        private Panel comment_panel;
        public Button project_dashboard_button;
        private Panel panel3;
        private Label label1;
        private Panel panel4;
        private Button project_comment_button;
        private TextBox project_comment;
        private Panel actual_comment_panel;
        private Button refresh_comments;
        private Panel main;
        private Label label2;
        private TextBox project_description_textbox;
        public Button refresh_page_button;
        private Panel description_changed_panel;
        public Button save_description_button;
        public Button cancel_description_button;
        private ListBox collaborator_list_box;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel5;
        private Panel panel6;
        private TextBox textBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel7;
        private Panel panel8;
        private Label label4;
        private Button removeCollaborator;
        private Button addCollaborator;
        private TableLayoutPanel tableLayoutPanel3;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label5;
        private Panel panel13;
        private Panel panel12;
        private Panel panel11;
        private Panel panel10;
        private Panel panel9;
        private Panel panel14;
        private TextBox e_priority_textbox;
        private Panel panel18;
        private Label label10;
        private TextBox e_status_textbox;
        private Panel panel17;
        private Label label9;
        private TextBox e_type_textbox;
        private Panel panel16;
        private Label label8;
        private TextBox e_description_textbox;
        private Panel panel15;
        private Label label7;
        private TextBox e_name_textbox;
        private Label label6;
        private Panel panel19;
        private Panel panel20;
        private Label label12;
        private Label label11;
        private TextBox e_severity_textbox;
        private Button help_button;
        private Button add_error;
        private Panel panel21;
        private Label label13;
        private Button refresh_error;
        private Panel error_panel;
        private TextBox filter;
        private Label label14;
        private Panel change_panel;
        private Panel panel22;
        private Label label16;
        private BindingSource changeBindingSource;
    }
}
