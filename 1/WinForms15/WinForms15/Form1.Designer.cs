using System;
using System.Drawing;

namespace WinForms15
{
    partial class Form1
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
            this.catchMe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // catchMe
            // 
            this.catchMe.AutoSize = true;
            this.catchMe.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.catchMe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.catchMe.ForeColor = System.Drawing.SystemColors.Highlight;
            this.catchMe.Location = new System.Drawing.Point(114, 109);
            this.catchMe.MaximumSize = new System.Drawing.Size(60, 40);
            this.catchMe.MinimumSize = new System.Drawing.Size(60, 40);
            this.catchMe.Name = "catchMe";
            this.catchMe.Padding = new System.Windows.Forms.Padding(5, 9, 0, 0);
            this.catchMe.Size = new System.Drawing.Size(60, 40);
            this.catchMe.TabIndex = 0;
            this.catchMe.Text = "Catch me";
            this.catchMe.MouseMove += new System.Windows.Forms.MouseEventHandler(this.catchMe_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.catchMe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        
        #endregion

        private System.Windows.Forms.Label catchMe;
    }
}

