namespace LMS
{
    partial class About_UserControl
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
            About = new Label();
            SuspendLayout();
            // 
            // About
            // 
            About.AutoSize = true;
            About.Location = new Point(424, 196);
            About.Name = "About";
            About.Size = new Size(50, 20);
            About.TabIndex = 0;
            About.Text = "About";
            // 
            // About_UserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(About);
            Name = "About_UserControl";
            Size = new Size(890, 701);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label About;
    }
}
