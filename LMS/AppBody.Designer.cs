﻿namespace LMS
{
    partial class AppBody
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppBody));
            Log_in_timer = new System.Windows.Forms.Timer(components);
            TitleBar1 = new Panel();
            LogOffButton = new Button();
            MinimizeButton = new Button();
            closeButton = new Button();
            SlidingPanel = new Panel();
            AboutTabButton = new Button();
            SettingsTabButton = new Button();
            TransactionTabButton = new Button();
            BorrowersTabButton = new Button();
            BooksTabButton = new Button();
            SlidingPanel_ToggleButton = new Button();
            SlidingPanel_Timer = new System.Windows.Forms.Timer(components);
            TitleBar1.SuspendLayout();
            SlidingPanel.SuspendLayout();
            SuspendLayout();
            // 
            // Log_in_timer
            // 
            Log_in_timer.Tick += Log_in_timer_Tick;
            // 
            // TitleBar1
            // 
            TitleBar1.BackColor = Color.DeepSkyBlue;
            TitleBar1.Controls.Add(LogOffButton);
            TitleBar1.Controls.Add(MinimizeButton);
            TitleBar1.Controls.Add(closeButton);
            TitleBar1.Dock = DockStyle.Top;
            TitleBar1.Location = new Point(0, 0);
            TitleBar1.Margin = new Padding(4, 5, 4, 5);
            TitleBar1.Name = "TitleBar1";
            TitleBar1.Size = new Size(1540, 58);
            TitleBar1.TabIndex = 0;
            TitleBar1.MouseDown += TitleBar1_MouseDown;
            // 
            // LogOffButton
            // 
            LogOffButton.BackgroundImage = (Image)resources.GetObject("LogOffButton.BackgroundImage");
            LogOffButton.BackgroundImageLayout = ImageLayout.Stretch;
            LogOffButton.FlatStyle = FlatStyle.Flat;
            LogOffButton.ForeColor = Color.DeepSkyBlue;
            LogOffButton.Location = new Point(1364, 0);
            LogOffButton.Margin = new Padding(4, 5, 4, 5);
            LogOffButton.Name = "LogOffButton";
            LogOffButton.Size = new Size(51, 58);
            LogOffButton.TabIndex = 3;
            LogOffButton.UseVisualStyleBackColor = true;
            LogOffButton.Click += LogOffButton_Click;
            // 
            // MinimizeButton
            // 
            MinimizeButton.BackgroundImage = (Image)resources.GetObject("MinimizeButton.BackgroundImage");
            MinimizeButton.BackgroundImageLayout = ImageLayout.Zoom;
            MinimizeButton.FlatStyle = FlatStyle.Flat;
            MinimizeButton.ForeColor = Color.DeepSkyBlue;
            MinimizeButton.Location = new Point(1424, 0);
            MinimizeButton.Margin = new Padding(4, 5, 4, 5);
            MinimizeButton.Name = "MinimizeButton";
            MinimizeButton.Size = new Size(51, 58);
            MinimizeButton.TabIndex = 2;
            MinimizeButton.UseVisualStyleBackColor = true;
            MinimizeButton.Click += MinimizeButton_Click;
            // 
            // closeButton
            // 
            closeButton.BackgroundImage = (Image)resources.GetObject("closeButton.BackgroundImage");
            closeButton.BackgroundImageLayout = ImageLayout.Zoom;
            closeButton.FlatStyle = FlatStyle.Flat;
            closeButton.ForeColor = Color.DeepSkyBlue;
            closeButton.Location = new Point(1484, 0);
            closeButton.Margin = new Padding(4, 5, 4, 5);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(51, 58);
            closeButton.TabIndex = 1;
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // SlidingPanel
            // 
            SlidingPanel.BackColor = Color.LightSkyBlue;
            SlidingPanel.BackgroundImage = (Image)resources.GetObject("SlidingPanel.BackgroundImage");
            SlidingPanel.BackgroundImageLayout = ImageLayout.Stretch;
            SlidingPanel.Controls.Add(AboutTabButton);
            SlidingPanel.Controls.Add(SettingsTabButton);
            SlidingPanel.Controls.Add(TransactionTabButton);
            SlidingPanel.Controls.Add(BorrowersTabButton);
            SlidingPanel.Controls.Add(BooksTabButton);
            SlidingPanel.Controls.Add(SlidingPanel_ToggleButton);
            SlidingPanel.Dock = DockStyle.Left;
            SlidingPanel.Location = new Point(0, 58);
            SlidingPanel.Margin = new Padding(4, 5, 4, 5);
            SlidingPanel.Name = "SlidingPanel";
            SlidingPanel.Size = new Size(429, 877);
            SlidingPanel.TabIndex = 1;
            // 
            // AboutTabButton
            // 
            AboutTabButton.BackColor = Color.Transparent;
            AboutTabButton.FlatStyle = FlatStyle.Flat;
            AboutTabButton.Font = new Font("Arial", 20.25F);
            AboutTabButton.Image = Properties.Resources.About;
            AboutTabButton.ImageAlign = ContentAlignment.MiddleLeft;
            AboutTabButton.Location = new Point(-1, 592);
            AboutTabButton.Margin = new Padding(4, 5, 4, 5);
            AboutTabButton.Name = "AboutTabButton";
            AboutTabButton.Size = new Size(429, 118);
            AboutTabButton.TabIndex = 7;
            AboutTabButton.Text = "ABOUT";
            AboutTabButton.UseVisualStyleBackColor = false;
            // 
            // SettingsTabButton
            // 
            SettingsTabButton.BackColor = Color.Transparent;
            SettingsTabButton.FlatStyle = FlatStyle.Flat;
            SettingsTabButton.Font = new Font("Arial", 20.25F);
            SettingsTabButton.Image = Properties.Resources.Settings;
            SettingsTabButton.ImageAlign = ContentAlignment.MiddleLeft;
            SettingsTabButton.Location = new Point(-1, 473);
            SettingsTabButton.Margin = new Padding(4, 5, 4, 5);
            SettingsTabButton.Name = "SettingsTabButton";
            SettingsTabButton.Size = new Size(429, 118);
            SettingsTabButton.TabIndex = 6;
            SettingsTabButton.Text = "SETTINGS";
            SettingsTabButton.UseVisualStyleBackColor = false;
            // 
            // TransactionTabButton
            // 
            TransactionTabButton.BackColor = Color.Transparent;
            TransactionTabButton.FlatStyle = FlatStyle.Flat;
            TransactionTabButton.Font = new Font("Arial", 20.25F);
            TransactionTabButton.Image = Properties.Resources.Transactions;
            TransactionTabButton.ImageAlign = ContentAlignment.MiddleLeft;
            TransactionTabButton.Location = new Point(-1, 355);
            TransactionTabButton.Margin = new Padding(4, 5, 4, 5);
            TransactionTabButton.Name = "TransactionTabButton";
            TransactionTabButton.Size = new Size(429, 118);
            TransactionTabButton.TabIndex = 5;
            TransactionTabButton.Text = "TRANSACTION";
            TransactionTabButton.UseVisualStyleBackColor = false;
            // 
            // BorrowersTabButton
            // 
            BorrowersTabButton.BackColor = Color.Transparent;
            BorrowersTabButton.FlatStyle = FlatStyle.Flat;
            BorrowersTabButton.Font = new Font("Arial", 20.25F);
            BorrowersTabButton.Image = Properties.Resources.Borrowers;
            BorrowersTabButton.ImageAlign = ContentAlignment.MiddleLeft;
            BorrowersTabButton.Location = new Point(-1, 237);
            BorrowersTabButton.Margin = new Padding(4, 5, 4, 5);
            BorrowersTabButton.Name = "BorrowersTabButton";
            BorrowersTabButton.Size = new Size(429, 118);
            BorrowersTabButton.TabIndex = 4;
            BorrowersTabButton.Text = "BORROWERS";
            BorrowersTabButton.UseVisualStyleBackColor = false;
            // 
            // BooksTabButton
            // 
            BooksTabButton.BackColor = Color.Transparent;
            BooksTabButton.FlatStyle = FlatStyle.Flat;
            BooksTabButton.Font = new Font("Arial", 20.25F);
            BooksTabButton.Image = Properties.Resources.Books;
            BooksTabButton.ImageAlign = ContentAlignment.MiddleLeft;
            BooksTabButton.Location = new Point(-1, 118);
            BooksTabButton.Margin = new Padding(4, 5, 4, 5);
            BooksTabButton.Name = "BooksTabButton";
            BooksTabButton.Size = new Size(429, 118);
            BooksTabButton.TabIndex = 3;
            BooksTabButton.Text = "BOOKS";
            BooksTabButton.UseVisualStyleBackColor = false;
            BooksTabButton.Click += BooksTabButton_Click;
            // 
            // SlidingPanel_ToggleButton
            // 
            SlidingPanel_ToggleButton.BackColor = Color.Transparent;
            SlidingPanel_ToggleButton.FlatStyle = FlatStyle.Flat;
            SlidingPanel_ToggleButton.Image = Properties.Resources.llarrow;
            SlidingPanel_ToggleButton.Location = new Point(-1, 0);
            SlidingPanel_ToggleButton.Margin = new Padding(4, 5, 4, 5);
            SlidingPanel_ToggleButton.Name = "SlidingPanel_ToggleButton";
            SlidingPanel_ToggleButton.Size = new Size(429, 118);
            SlidingPanel_ToggleButton.TabIndex = 2;
            SlidingPanel_ToggleButton.UseVisualStyleBackColor = false;
            SlidingPanel_ToggleButton.Click += SlidingPanel_ToggleButton_Click;
            // 
            // SlidingPanel_Timer
            // 
            SlidingPanel_Timer.Tick += Sliding_Panel_Timer_Tick;
            // 
            // AppBody
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1540, 935);
            Controls.Add(SlidingPanel);
            Controls.Add(TitleBar1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "AppBody";
            Text = "Form2";
            Load += AppBody_Load;
            TitleBar1.ResumeLayout(false);
            SlidingPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer Log_in_timer;
        private Panel TitleBar1;
        private Button LogOffButton;
        private Button MinimizeButton;
        private Button closeButton;
        private Panel SlidingPanel;
        private Button SlidingPanel_ToggleButton;
        private System.Windows.Forms.Timer SlidingPanel_Timer;
        private Button AboutTabButton;
        private Button SettingsTabButton;
        private Button TransactionTabButton;
        private Button BorrowersTabButton;
        private Button BooksTabButton;
    }
}