namespace BloodSeeker.Admin
{
    partial class AcceptReject
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
            this.components = new System.ComponentModel.Container();
            this.btn_accept = new Guna.UI2.WinForms.Guna2Button();
            this.btn_rejct = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.SuspendLayout();
            // 
            // btn_accept
            // 
            this.btn_accept.BorderRadius = 6;
            this.btn_accept.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_accept.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_accept.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_accept.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_accept.FillColor = System.Drawing.Color.Maroon;
            this.btn_accept.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_accept.ForeColor = System.Drawing.Color.White;
            this.btn_accept.Location = new System.Drawing.Point(10, 10);
            this.btn_accept.Name = "btn_accept";
            this.btn_accept.Size = new System.Drawing.Size(66, 24);
            this.btn_accept.TabIndex = 0;
            this.btn_accept.Text = "Accept";
            this.btn_accept.Click += new System.EventHandler(this.btn_accept_Click);
            // 
            // btn_rejct
            // 
            this.btn_rejct.BorderRadius = 6;
            this.btn_rejct.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_rejct.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_rejct.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_rejct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_rejct.FillColor = System.Drawing.Color.Maroon;
            this.btn_rejct.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_rejct.ForeColor = System.Drawing.Color.White;
            this.btn_rejct.Location = new System.Drawing.Point(92, 10);
            this.btn_rejct.Name = "btn_rejct";
            this.btn_rejct.Size = new System.Drawing.Size(66, 24);
            this.btn_rejct.TabIndex = 1;
            this.btn_rejct.Text = "Reject";
            this.btn_rejct.Click += new System.EventHandler(this.btn_rejct_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // AcceptReject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(171, 46);
            this.Controls.Add(this.btn_rejct);
            this.Controls.Add(this.btn_accept);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AcceptReject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AcceptReject";
            this.Load += new System.EventHandler(this.AcceptReject_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btn_accept;
        private Guna.UI2.WinForms.Guna2Button btn_rejct;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}