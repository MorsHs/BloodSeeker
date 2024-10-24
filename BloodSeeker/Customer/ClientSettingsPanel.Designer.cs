namespace BloodSeeker.Client
{
    partial class ClientSettingsPanel
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
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_secu = new Guna.UI2.WinForms.Guna2Button();
            this.btn_acc = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.menuTransition = new System.Windows.Forms.Timer(this.components);
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Controls.Add(this.label1);
            this.guna2CustomGradientPanel1.Controls.Add(this.btn_secu);
            this.guna2CustomGradientPanel1.Controls.Add(this.btn_acc);
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2Panel1);
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(1555, 748);
            this.guna2CustomGradientPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.label1.Location = new System.Drawing.Point(39, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 54);
            this.label1.TabIndex = 10;
            this.label1.Text = "Settings";
            // 
            // btn_secu
            // 
            this.btn_secu.BorderRadius = 5;
            this.btn_secu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_secu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_secu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_secu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_secu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_secu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_secu.ForeColor = System.Drawing.Color.White;
            this.btn_secu.Location = new System.Drawing.Point(197, 121);
            this.btn_secu.Margin = new System.Windows.Forms.Padding(4);
            this.btn_secu.Name = "btn_secu";
            this.btn_secu.Size = new System.Drawing.Size(105, 36);
            this.btn_secu.TabIndex = 9;
            this.btn_secu.Text = "Security";
            this.btn_secu.Click += new System.EventHandler(this.btn_secu_Click_1);
            // 
            // btn_acc
            // 
            this.btn_acc.BorderRadius = 5;
            this.btn_acc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_acc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_acc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_acc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_acc.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_acc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_acc.ForeColor = System.Drawing.Color.White;
            this.btn_acc.Location = new System.Drawing.Point(49, 121);
            this.btn_acc.Margin = new System.Windows.Forms.Padding(4);
            this.btn_acc.Name = "btn_acc";
            this.btn_acc.Size = new System.Drawing.Size(105, 36);
            this.btn_acc.TabIndex = 8;
            this.btn_acc.Text = "Account";
            this.btn_acc.Click += new System.EventHandler(this.btn_acc_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Location = new System.Drawing.Point(4, 164);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1517, 535);
            this.guna2Panel1.TabIndex = 7;
            // 
            // ClientSettingsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1555, 750);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClientSettingsPanel";
            this.Text = "ClientSettingsPanel";
            this.Load += new System.EventHandler(this.ClientSettingsPanel_Load_1);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btn_acc;
        private Guna.UI2.WinForms.Guna2Button btn_secu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer menuTransition;
    }
}