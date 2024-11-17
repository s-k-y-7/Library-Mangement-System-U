namespace LMS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(161, 439);
            button1.Name = "button1";
            button1.Size = new Size(146, 22);
            button1.TabIndex = 0;
            button1.Text = "LOG IN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 131, 170);
            label1.Font = new Font("Times New Roman", 10F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(161, 323);
            label1.Name = "label1";
            label1.Size = new Size(63, 16);
            label1.TabIndex = 1;
            label1.Text = "Username";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(0, 131, 170);
            label2.Font = new Font("Times New Roman", 10F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(161, 372);
            label2.Name = "label2";
            label2.Size = new Size(63, 16);
            label2.TabIndex = 2;
            label2.Text = "Password";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Arial", 20F);
            label3.Location = new Point(35, 53);
            label3.Name = "label3";
            label3.Size = new Size(362, 32);
            label3.TabIndex = 5;
            label3.Text = "Library Management System";
            label3.Click += label3_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.LightBlue;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(161, 389);
            textBox1.Name = "textBox1";
            textBox1.PasswordChar = '*';
            textBox1.Size = new Size(149, 14);
            textBox1.TabIndex = 8;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.LightBlue;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(161, 340);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(149, 14);
            textBox2.TabIndex = 9;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Enabled = false;
            label4.Font = new Font("Arial", 16F);
            label4.Location = new Point(74, 485);
            label4.Name = "label4";
            label4.Size = new Size(288, 25);
            label4.TabIndex = 10;
            label4.Text = "Login Credentials Are Wrong";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(450, 535);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form1";
            Text = "Library Management System";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label4;
    }
}
