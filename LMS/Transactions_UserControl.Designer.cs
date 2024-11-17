namespace LMS
{
    partial class Transactions_UserControl
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
            Transactions = new Label();
            SuspendLayout();
            // 
            // Transactions
            // 
            Transactions.AutoSize = true;
            Transactions.Location = new Point(499, 199);
            Transactions.Name = "Transactions";
            Transactions.Size = new Size(90, 20);
            Transactions.TabIndex = 0;
            Transactions.Text = "Transactions";
            // 
            // Transactions_UserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Transactions);
            Name = "Transactions_UserControl";
            Size = new Size(890, 701);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Transactions;
    }
}
