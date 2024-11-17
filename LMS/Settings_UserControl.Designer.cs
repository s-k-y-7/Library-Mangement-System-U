namespace LMS
{
    partial class Settings_UserControl
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
            Settings = new Label();
            SuspendLayout();
            // 
            // Settings
            // 
            Settings.AutoSize = true;
            Settings.Location = new Point(382, 172);
            Settings.Name = "Settings";
            Settings.Size = new Size(62, 20);
            Settings.TabIndex = 0;
            Settings.Text = "Settings";
            // 
            // Settings_UserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Settings);
            Name = "Settings_UserControl";
            Size = new Size(890, 701);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Settings;
    }
}
