namespace WinForms52
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
        protected override void Dispose ( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose ();
            }
            base.Dispose ( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
        {
            this.listView = new System.Windows.Forms.ListView();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonSmallIcon = new System.Windows.Forms.Button();
            this.buttonList = new System.Windows.Forms.Button();
            this.buttonTile = new System.Windows.Forms.Button();
            this.buttonLargeIcon = new System.Windows.Forms.Button();
            this.buttonDetails = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.Location = new System.Drawing.Point(101, 66);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(876, 442);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView_MouseDoubleClick);
            // 
            // buttonUp
            // 
            this.buttonUp.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUp.Location = new System.Drawing.Point(168, 12);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(50, 35);
            this.buttonUp.TabIndex = 1;
            this.buttonUp.Text = "Up";
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // buttonSmallIcon
            // 
            this.buttonSmallIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSmallIcon.Location = new System.Drawing.Point(12, 109);
            this.buttonSmallIcon.Name = "buttonSmallIcon";
            this.buttonSmallIcon.Size = new System.Drawing.Size(74, 60);
            this.buttonSmallIcon.TabIndex = 2;
            this.buttonSmallIcon.Text = "SmallIcon";
            this.buttonSmallIcon.UseVisualStyleBackColor = true;
            this.buttonSmallIcon.Click += new System.EventHandler(this.buttonSmallIcon_Click);
            // 
            // buttonList
            // 
            this.buttonList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonList.Location = new System.Drawing.Point(12, 191);
            this.buttonList.Name = "buttonList";
            this.buttonList.Size = new System.Drawing.Size(74, 60);
            this.buttonList.TabIndex = 3;
            this.buttonList.Text = "List";
            this.buttonList.UseVisualStyleBackColor = true;
            this.buttonList.Click += new System.EventHandler(this.buttonList_Click);
            // 
            // buttonTile
            // 
            this.buttonTile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTile.Location = new System.Drawing.Point(12, 272);
            this.buttonTile.Name = "buttonTile";
            this.buttonTile.Size = new System.Drawing.Size(74, 60);
            this.buttonTile.TabIndex = 4;
            this.buttonTile.Text = "Tile";
            this.buttonTile.UseVisualStyleBackColor = true;
            this.buttonTile.Click += new System.EventHandler(this.buttonTile_Click);
            // 
            // buttonLargeIcon
            // 
            this.buttonLargeIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLargeIcon.Location = new System.Drawing.Point(12, 358);
            this.buttonLargeIcon.Name = "buttonLargeIcon";
            this.buttonLargeIcon.Size = new System.Drawing.Size(74, 60);
            this.buttonLargeIcon.TabIndex = 5;
            this.buttonLargeIcon.Text = "LargeIcon";
            this.buttonLargeIcon.UseVisualStyleBackColor = true;
            this.buttonLargeIcon.Click += new System.EventHandler(this.buttonLargeIcon_Click);
            // 
            // buttonDetails
            // 
            this.buttonDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDetails.Location = new System.Drawing.Point(12, 448);
            this.buttonDetails.Name = "buttonDetails";
            this.buttonDetails.Size = new System.Drawing.Size(74, 60);
            this.buttonDetails.TabIndex = 6;
            this.buttonDetails.Text = "Details";
            this.buttonDetails.UseVisualStyleBackColor = true;
            this.buttonDetails.Click += new System.EventHandler(this.buttonDetails_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 520);
            this.Controls.Add(this.buttonDetails);
            this.Controls.Add(this.buttonLargeIcon);
            this.Controls.Add(this.buttonTile);
            this.Controls.Add(this.buttonList);
            this.Controls.Add(this.buttonSmallIcon);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.listView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonSmallIcon;
        private System.Windows.Forms.Button buttonList;
        private System.Windows.Forms.Button buttonTile;
        private System.Windows.Forms.Button buttonLargeIcon;
        private System.Windows.Forms.Button buttonDetails;
    }
}

