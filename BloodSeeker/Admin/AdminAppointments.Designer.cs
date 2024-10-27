namespace BloodSeeker.Admin
{
    partial class AdminAppointments
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_Appointments = new Guna.UI2.WinForms.Guna2DataGridView();
            this.appointmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bloodGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel_acceptReject = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Appointments)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.guna2CustomGradientPanel1.Controls.Add(this.panel_acceptReject);
            this.guna2CustomGradientPanel1.Controls.Add(this.dgv_Appointments);
            this.guna2CustomGradientPanel1.Controls.Add(this.label1);
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.SystemColors.InactiveBorder;
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.SystemColors.InactiveBorder;
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.SystemColors.InactiveBorder;
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.SystemColors.InactiveBorder;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(1040, 600);
            this.guna2CustomGradientPanel1.TabIndex = 0;
            this.guna2CustomGradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2CustomGradientPanel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.label1.Location = new System.Drawing.Point(29, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Appointments";
            // 
            // dgv_Appointments
            // 
            this.dgv_Appointments.AllowUserToAddRows = false;
            this.dgv_Appointments.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.dgv_Appointments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Appointments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgv_Appointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Appointments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.appointmentID,
            this.name,
            this.address,
            this.mobileNum,
            this.bloodGroup,
            this.date,
            this.status});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Appointments.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgv_Appointments.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Appointments.Location = new System.Drawing.Point(26, 103);
            this.dgv_Appointments.Name = "dgv_Appointments";
            this.dgv_Appointments.ReadOnly = true;
            this.dgv_Appointments.RowHeadersVisible = false;
            this.dgv_Appointments.Size = new System.Drawing.Size(1002, 281);
            this.dgv_Appointments.TabIndex = 1;
            this.dgv_Appointments.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Appointments.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_Appointments.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_Appointments.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_Appointments.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_Appointments.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Appointments.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Appointments.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_Appointments.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Appointments.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Appointments.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_Appointments.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Appointments.ThemeStyle.HeaderStyle.Height = 15;
            this.dgv_Appointments.ThemeStyle.ReadOnly = true;
            this.dgv_Appointments.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Appointments.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Appointments.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Appointments.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_Appointments.ThemeStyle.RowsStyle.Height = 22;
            this.dgv_Appointments.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Appointments.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_Appointments.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Appointments_CellClick);
            // 
            // appointmentID
            // 
            this.appointmentID.HeaderText = "AppointmnetID";
            this.appointmentID.Name = "appointmentID";
            this.appointmentID.ReadOnly = true;
            this.appointmentID.Visible = false;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // address
            // 
            this.address.HeaderText = "Address";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            // 
            // mobileNum
            // 
            this.mobileNum.HeaderText = "Contact No.";
            this.mobileNum.Name = "mobileNum";
            this.mobileNum.ReadOnly = true;
            // 
            // bloodGroup
            // 
            this.bloodGroup.HeaderText = "BloodGroup";
            this.bloodGroup.Name = "bloodGroup";
            this.bloodGroup.ReadOnly = true;
            // 
            // date
            // 
            this.date.HeaderText = "Appointment Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // panel_acceptReject
            // 
            this.panel_acceptReject.BackColor = System.Drawing.Color.Transparent;
            this.panel_acceptReject.BorderColor = System.Drawing.Color.Black;
            this.panel_acceptReject.BorderRadius = 2;
            this.panel_acceptReject.FillColor = System.Drawing.Color.Transparent;
            this.panel_acceptReject.Location = new System.Drawing.Point(424, 204);
            this.panel_acceptReject.Name = "panel_acceptReject";
            this.panel_acceptReject.Size = new System.Drawing.Size(212, 51);
            this.panel_acceptReject.TabIndex = 2;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this.guna2CustomGradientPanel1;
            // 
            // AdminAppointments
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 600);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminAppointments";
            this.ShowIcon = false;
            this.Text = "AdminAppointments";
            this.Load += new System.EventHandler(this.AdminAppointments_Load);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Appointments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_Appointments;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointmentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn bloodGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewButtonColumn status;
        private Guna.UI2.WinForms.Guna2Panel panel_acceptReject;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}