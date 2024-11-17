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
            label1 = new Label();
            label2 = new Label();
            BorrowersTextBox = new TextBox();
            AccNoTextBox = new TextBox();
            SearchBorrowersButton = new Button();
            SearchBookButton = new Button();
            ClearAllButton = new Button();
            IssueBookButton = new Button();
            ReturnBookButton = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            Book1_label = new Label();
            Book2_label = new Label();
            borrowedBy_label = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 102);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 0;
            label1.Text = "Borrower's ID: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(84, 237);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 1;
            label2.Text = "Acc No:";
            // 
            // BorrowersTextBox
            // 
            BorrowersTextBox.Location = new Point(193, 103);
            BorrowersTextBox.Name = "BorrowersTextBox";
            BorrowersTextBox.Size = new Size(353, 21);
            BorrowersTextBox.TabIndex = 2;
            // 
            // AccNoTextBox
            // 
            AccNoTextBox.Location = new Point(194, 234);
            AccNoTextBox.Name = "AccNoTextBox";
            AccNoTextBox.Size = new Size(352, 21);
            AccNoTextBox.TabIndex = 3;
            // 
            // SearchBorrowersButton
            // 
            SearchBorrowersButton.Location = new Point(299, 148);
            SearchBorrowersButton.Name = "SearchBorrowersButton";
            SearchBorrowersButton.Size = new Size(135, 44);
            SearchBorrowersButton.TabIndex = 4;
            SearchBorrowersButton.Text = "Search Borrowers";
            SearchBorrowersButton.UseVisualStyleBackColor = true;
            SearchBorrowersButton.Click += SearchBorrowersButton_Click;
            // 
            // SearchBookButton
            // 
            SearchBookButton.Location = new Point(299, 301);
            SearchBookButton.Name = "SearchBookButton";
            SearchBookButton.Size = new Size(135, 44);
            SearchBookButton.TabIndex = 5;
            SearchBookButton.Text = "Search Book";
            SearchBookButton.UseVisualStyleBackColor = true;
            SearchBookButton.Click += SearchBookButton_Click;
            // 
            // ClearAllButton
            // 
            ClearAllButton.Location = new Point(299, 370);
            ClearAllButton.Name = "ClearAllButton";
            ClearAllButton.Size = new Size(135, 44);
            ClearAllButton.TabIndex = 6;
            ClearAllButton.Text = "Clear All";
            ClearAllButton.UseVisualStyleBackColor = true;
            // 
            // IssueBookButton
            // 
            IssueBookButton.Location = new Point(161, 432);
            IssueBookButton.Name = "IssueBookButton";
            IssueBookButton.Size = new Size(135, 44);
            IssueBookButton.TabIndex = 7;
            IssueBookButton.Text = "Issue Book";
            IssueBookButton.UseVisualStyleBackColor = true;
            IssueBookButton.Click += IssueBookButton_Click;
            // 
            // ReturnBookButton
            // 
            ReturnBookButton.Location = new Point(436, 432);
            ReturnBookButton.Name = "ReturnBookButton";
            ReturnBookButton.Size = new Size(135, 44);
            ReturnBookButton.TabIndex = 8;
            ReturnBookButton.Text = "Return Book";
            ReturnBookButton.UseVisualStyleBackColor = true;
            ReturnBookButton.Click += ReturnBookButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(579, 106);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 9;
            label3.Text = "Book 1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(579, 163);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 10;
            label4.Text = "Book 2";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(579, 291);
            label5.Name = "label5";
            label5.Size = new Size(76, 15);
            label5.TabIndex = 11;
            label5.Text = "Borrowed By";
            // 
            // Book1_label
            // 
            Book1_label.AutoSize = true;
            Book1_label.Location = new Point(679, 106);
            Book1_label.Name = "Book1_label";
            Book1_label.Size = new Size(74, 15);
            Book1_label.TabIndex = 12;
            Book1_label.Text = "borrowed by";
            // 
            // Book2_label
            // 
            Book2_label.AutoSize = true;
            Book2_label.Location = new Point(679, 163);
            Book2_label.Name = "Book2_label";
            Book2_label.Size = new Size(74, 15);
            Book2_label.TabIndex = 13;
            Book2_label.Text = "borrowed by";
            // 
            // borrowedBy_label
            // 
            borrowedBy_label.AutoSize = true;
            borrowedBy_label.Location = new Point(679, 291);
            borrowedBy_label.Name = "borrowedBy_label";
            borrowedBy_label.Size = new Size(59, 15);
            borrowedBy_label.TabIndex = 14;
            borrowedBy_label.Text = "borrowed";
            // 
            // Transactions_UserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(borrowedBy_label);
            Controls.Add(Book2_label);
            Controls.Add(Book1_label);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(ReturnBookButton);
            Controls.Add(IssueBookButton);
            Controls.Add(ClearAllButton);
            Controls.Add(SearchBookButton);
            Controls.Add(SearchBorrowersButton);
            Controls.Add(AccNoTextBox);
            Controls.Add(BorrowersTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Transactions_UserControl";
            Size = new Size(779, 526);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox BorrowersTextBox;
        private TextBox AccNoTextBox;
        private Button SearchBorrowersButton;
        private Button SearchBookButton;
        private Button ClearAllButton;
        private Button IssueBookButton;
        private Button ReturnBookButton;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label Book1_label;
        private Label Book2_label;
        private Label borrowedBy_label;
    }
}
