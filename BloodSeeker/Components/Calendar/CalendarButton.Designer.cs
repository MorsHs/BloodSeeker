﻿namespace BloodSeeker.Components.Calendar
{
    partial class CalendarButton
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.checkboxclicked = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.checkboxclicked);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(45, 47);
            this.panel1.TabIndex = 1;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            this.panel1.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            this.panel1.MouseHover += new System.EventHandler(this.panel1_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "1";
            this.label1.Click += new System.EventHandler(this.panel1_Click);
            this.label1.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            this.label1.MouseHover += new System.EventHandler(this.panel1_MouseHover);
            // 
            // checkboxclicked
            // 
            this.checkboxclicked.AutoSize = true;
            this.checkboxclicked.Location = new System.Drawing.Point(4, 4);
            this.checkboxclicked.Name = "checkboxclicked";
            this.checkboxclicked.Size = new System.Drawing.Size(15, 14);
            this.checkboxclicked.TabIndex = 1;
            this.checkboxclicked.UseVisualStyleBackColor = true;
            this.checkboxclicked.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            this.checkboxclicked.MouseHover += new System.EventHandler(this.panel1_MouseHover);
            // 
            // CalendarButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "CalendarButton";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Size = new System.Drawing.Size(47, 49);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkboxclicked;
    }
}
