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
            Log_in_timer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // Log_in_timer
            // 
            Log_in_timer.Tick += this.Log_in_timer_Tick;
            // 
            // AppBody
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Name = "AppBody";
            Text = "Form2";
            Load += AppBody_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer Log_in_timer;
    }
}