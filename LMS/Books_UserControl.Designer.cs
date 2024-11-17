namespace LMS
{
    partial class Books_UserControl
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
            Books = new Label();
            SuspendLayout();
            // 
            // Books
            // 
            Books.AutoSize = true;
            Books.Location = new Point(350, 160);
            Books.Name = "Books";
            Books.Size = new Size(49, 20);
            Books.TabIndex = 0;
            Books.Text = "Books";
            // 
            // Books_UserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Books);
            Name = "Books_UserControl";
            Size = new Size(890, 701);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Books;
    }
}
