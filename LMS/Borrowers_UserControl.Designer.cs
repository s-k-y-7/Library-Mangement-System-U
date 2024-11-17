namespace LMS
{
    partial class Borrowers_UserControl
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
            Borrowers = new Label();
            SuspendLayout();
            // 
            // Borrowers
            // 
            Borrowers.AutoSize = true;
            Borrowers.Location = new Point(375, 224);
            Borrowers.Name = "Borrowers";
            Borrowers.Size = new Size(76, 20);
            Borrowers.TabIndex = 0;
            Borrowers.Text = "Borrowers";
            // 
            // Borrowers_UserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Borrowers);
            Name = "Borrowers_UserControl";
            Size = new Size(890, 701);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Borrowers;
    }
}
