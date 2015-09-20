namespace WinForms17
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
            this.choose = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.month = new System.Windows.Forms.RadioButton();
            this.year = new System.Windows.Forms.RadioButton();
            this.day = new System.Windows.Forms.RadioButton();
            this.hour = new System.Windows.Forms.RadioButton();
            this.min = new System.Windows.Forms.RadioButton();
            this.measure = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.sec = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // choose
            // 
            this.choose.AutoSize = true;
            this.choose.Location = new System.Drawing.Point(24, 39);
            this.choose.Name = "choose";
            this.choose.Size = new System.Drawing.Size(90, 13);
            this.choose.TabIndex = 0;
            this.choose.Text = "Choose your date";
            // 
            // date
            // 
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date.Location = new System.Drawing.Point(120, 39);
            this.date.Name = "date";
            this.date.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.date.ShowUpDown = true;
            this.date.Size = new System.Drawing.Size(293, 20);
            this.date.TabIndex = 1;
            // 
            // month
            // 
            this.month.AutoSize = true;
            this.month.Location = new System.Drawing.Point(263, 112);
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(54, 17);
            this.month.TabIndex = 2;
            this.month.Text = "month";
            this.month.UseVisualStyleBackColor = true;
            // 
            // year
            // 
            this.year.AutoSize = true;
            this.year.Location = new System.Drawing.Point(192, 112);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(45, 17);
            this.year.TabIndex = 3;
            this.year.Text = "year";
            this.year.UseVisualStyleBackColor = true;
            // 
            // day
            // 
            this.day.AutoSize = true;
            this.day.Checked = true;
            this.day.Location = new System.Drawing.Point(345, 112);
            this.day.Name = "day";
            this.day.Size = new System.Drawing.Size(42, 17);
            this.day.TabIndex = 4;
            this.day.TabStop = true;
            this.day.Text = "day";
            this.day.UseVisualStyleBackColor = true;
            // 
            // hour
            // 
            this.hour.AutoSize = true;
            this.hour.Location = new System.Drawing.Point(192, 143);
            this.hour.Name = "hour";
            this.hour.Size = new System.Drawing.Size(46, 17);
            this.hour.TabIndex = 5;
            this.hour.Text = "hour";
            this.hour.UseVisualStyleBackColor = true;
            // 
            // min
            // 
            this.min.AutoSize = true;
            this.min.Location = new System.Drawing.Point(263, 143);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(41, 17);
            this.min.TabIndex = 6;
            this.min.Text = "min";
            this.min.UseVisualStyleBackColor = true;
            // 
            // measure
            // 
            this.measure.AutoSize = true;
            this.measure.Location = new System.Drawing.Point(24, 116);
            this.measure.Name = "measure";
            this.measure.Size = new System.Drawing.Size(134, 13);
            this.measure.TabIndex = 7;
            this.measure.Text = "Choose result measure unit";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(87, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(255, 36);
            this.button1.TabIndex = 8;
            this.button1.Text = "Show result";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.result.Location = new System.Drawing.Point(159, 296);
            this.result.MinimumSize = new System.Drawing.Size(120, 20);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(120, 20);
            this.result.TabIndex = 9;
            this.result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sec
            // 
            this.sec.AutoSize = true;
            this.sec.Location = new System.Drawing.Point(345, 143);
            this.sec.Name = "sec";
            this.sec.Size = new System.Drawing.Size(42, 17);
            this.sec.TabIndex = 10;
            this.sec.Text = "sec";
            this.sec.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 364);
            this.Controls.Add(this.sec);
            this.Controls.Add(this.result);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.measure);
            this.Controls.Add(this.min);
            this.Controls.Add(this.hour);
            this.Controls.Add(this.day);
            this.Controls.Add(this.year);
            this.Controls.Add(this.month);
            this.Controls.Add(this.date);
            this.Controls.Add(this.choose);
            this.Name = "Form1";
            this.Text = "Time interval that remains untill your choice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label choose;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.RadioButton month;
        private System.Windows.Forms.RadioButton year;
        private System.Windows.Forms.RadioButton day;
        private System.Windows.Forms.RadioButton hour;
        private System.Windows.Forms.RadioButton min;
        private System.Windows.Forms.Label measure;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.RadioButton sec;
    }
}

