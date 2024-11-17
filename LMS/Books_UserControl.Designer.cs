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
            label1 = new Label();
            bookId_textbox = new TextBox();
            searchbooks_button = new Button();
            addnew_button = new Button();
            update_button = new Button();
            delete_button = new Button();
            clear_button = new Button();
            label2 = new Label();
            accno_textBox = new TextBox();
            name_textbox = new TextBox();
            label3 = new Label();
            publisher_textbox = new TextBox();
            label4 = new Label();
            author_textbox = new TextBox();
            label5 = new Label();
            isbn_textbox = new TextBox();
            label6 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(90, 54);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 1;
            label1.Text = "Book ID:";
            // 
            // bookId_textbox
            // 
            bookId_textbox.Location = new Point(205, 51);
            bookId_textbox.Name = "bookId_textbox";
            bookId_textbox.Size = new Size(412, 21);
            bookId_textbox.TabIndex = 2;
            // 
            // searchbooks_button
            // 
            searchbooks_button.Location = new Point(281, 92);
            searchbooks_button.Name = "searchbooks_button";
            searchbooks_button.Size = new Size(191, 47);
            searchbooks_button.TabIndex = 3;
            searchbooks_button.Text = "Search Books";
            searchbooks_button.UseVisualStyleBackColor = true;
            searchbooks_button.Click += searchbooks_button_Click;
            // 
            // addnew_button
            // 
            addnew_button.Location = new Point(92, 331);
            addnew_button.Name = "addnew_button";
            addnew_button.Size = new Size(130, 55);
            addnew_button.TabIndex = 4;
            addnew_button.Text = "Add New";
            addnew_button.UseVisualStyleBackColor = true;
            addnew_button.Click += button2_Click;
            // 
            // update_button
            // 
            update_button.Location = new Point(254, 331);
            update_button.Name = "update_button";
            update_button.Size = new Size(130, 55);
            update_button.TabIndex = 5;
            update_button.Text = "Update";
            update_button.UseVisualStyleBackColor = true;
            // 
            // delete_button
            // 
            delete_button.Location = new Point(413, 331);
            delete_button.Name = "delete_button";
            delete_button.Size = new Size(130, 55);
            delete_button.TabIndex = 6;
            delete_button.Text = "Delete";
            delete_button.UseVisualStyleBackColor = true;
            // 
            // clear_button
            // 
            clear_button.Location = new Point(576, 331);
            clear_button.Name = "clear_button";
            clear_button.Size = new Size(130, 55);
            clear_button.TabIndex = 7;
            clear_button.Text = "Clear";
            clear_button.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(254, 414);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 8;
            label2.Text = "Acc No:";
            // 
            // accno_textBox
            // 
            accno_textBox.Location = new Point(336, 411);
            accno_textBox.Name = "accno_textBox";
            accno_textBox.Size = new Size(156, 21);
            accno_textBox.TabIndex = 9;
            // 
            // name_textbox
            // 
            name_textbox.Location = new Point(174, 455);
            name_textbox.Name = "name_textbox";
            name_textbox.Size = new Size(156, 21);
            name_textbox.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(92, 458);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 10;
            label3.Text = "Name:";
            // 
            // publisher_textbox
            // 
            publisher_textbox.Location = new Point(174, 506);
            publisher_textbox.Name = "publisher_textbox";
            publisher_textbox.Size = new Size(156, 21);
            publisher_textbox.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(92, 509);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 12;
            label4.Text = "Publisher:";
            // 
            // author_textbox
            // 
            author_textbox.Location = new Point(526, 503);
            author_textbox.Name = "author_textbox";
            author_textbox.Size = new Size(156, 21);
            author_textbox.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(444, 506);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 16;
            label5.Text = "Author:";
            // 
            // isbn_textbox
            // 
            isbn_textbox.Location = new Point(526, 452);
            isbn_textbox.Name = "isbn_textbox";
            isbn_textbox.Size = new Size(156, 21);
            isbn_textbox.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(444, 455);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 14;
            label6.Text = "ISBN:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(37, 159);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(840, 150);
            dataGridView1.TabIndex = 18;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Books_UserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(author_textbox);
            Controls.Add(label5);
            Controls.Add(isbn_textbox);
            Controls.Add(label6);
            Controls.Add(publisher_textbox);
            Controls.Add(label4);
            Controls.Add(name_textbox);
            Controls.Add(label3);
            Controls.Add(accno_textBox);
            Controls.Add(label2);
            Controls.Add(clear_button);
            Controls.Add(delete_button);
            Controls.Add(update_button);
            Controls.Add(addnew_button);
            Controls.Add(searchbooks_button);
            Controls.Add(bookId_textbox);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Books_UserControl";
            Size = new Size(904, 559);
            Load += Books_UserControl_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox bookId_textbox;
        private Button searchbooks_button;
        private Button addnew_button;
        private Button update_button;
        private Button delete_button;
        private Button clear_button;
        private Label label2;
        private TextBox accno_textBox;
        private TextBox name_textbox;
        private Label label3;
        private TextBox publisher_textbox;
        private Label label4;
        private TextBox author_textbox;
        private Label label5;
        private TextBox isbn_textbox;
        private Label label6;
        private DataGridView dataGridView1;
    }
}
