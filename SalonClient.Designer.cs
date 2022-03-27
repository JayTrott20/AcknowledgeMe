namespace QueensBeyondV._3
{
    partial class SalonClient
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
            this.btnApptRequest = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panelRequest = new System.Windows.Forms.Panel();
            this.lblDateTimeRequest = new System.Windows.Forms.Label();
            this.lblServiceRequest = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.dateTimeRequest = new System.Windows.Forms.DateTimePicker();
            this.comboServiceRequest = new System.Windows.Forms.ComboBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblServiceId = new System.Windows.Forms.Label();
            this.txtServiceId = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureboxScrolling = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelRequest.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxScrolling)).BeginInit();
            this.SuspendLayout();
            // 
            // btnApptRequest
            // 
            this.btnApptRequest.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnApptRequest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Pink;
            this.btnApptRequest.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApptRequest.Location = new System.Drawing.Point(236, 23);
            this.btnApptRequest.Name = "btnApptRequest";
            this.btnApptRequest.Size = new System.Drawing.Size(252, 63);
            this.btnApptRequest.TabIndex = 0;
            this.btnApptRequest.Text = "Appointment Request";
            this.btnApptRequest.UseVisualStyleBackColor = false;
            this.btnApptRequest.Click += new System.EventHandler(this.btnApptRequest_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Pink;
            this.btnHome.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(236, 110);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(252, 63);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelRequest
            // 
            this.panelRequest.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelRequest.Controls.Add(this.lblDateTimeRequest);
            this.panelRequest.Controls.Add(this.lblServiceRequest);
            this.panelRequest.Controls.Add(this.lblFullName);
            this.panelRequest.Controls.Add(this.dateTimeRequest);
            this.panelRequest.Controls.Add(this.comboServiceRequest);
            this.panelRequest.Controls.Add(this.txtFullName);
            this.panelRequest.Controls.Add(this.pictureboxScrolling);
            this.panelRequest.Location = new System.Drawing.Point(112, 30);
            this.panelRequest.Name = "panelRequest";
            this.panelRequest.Size = new System.Drawing.Size(726, 365);
            this.panelRequest.TabIndex = 3;
            // 
            // lblDateTimeRequest
            // 
            this.lblDateTimeRequest.AutoSize = true;
            this.lblDateTimeRequest.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTimeRequest.Location = new System.Drawing.Point(491, 313);
            this.lblDateTimeRequest.Name = "lblDateTimeRequest";
            this.lblDateTimeRequest.Size = new System.Drawing.Size(216, 24);
            this.lblDateTimeRequest.TabIndex = 6;
            this.lblDateTimeRequest.Text = "Date and Time Requested";
            // 
            // lblServiceRequest
            // 
            this.lblServiceRequest.AutoSize = true;
            this.lblServiceRequest.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceRequest.Location = new System.Drawing.Point(249, 313);
            this.lblServiceRequest.Name = "lblServiceRequest";
            this.lblServiceRequest.Size = new System.Drawing.Size(186, 24);
            this.lblServiceRequest.TabIndex = 5;
            this.lblServiceRequest.Text = "Service Request Type";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.Location = new System.Drawing.Point(63, 313);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(102, 28);
            this.lblFullName.TabIndex = 4;
            this.lblFullName.Text = "Full Name";
            // 
            // dateTimeRequest
            // 
            this.dateTimeRequest.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeRequest.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeRequest.Location = new System.Drawing.Point(515, 252);
            this.dateTimeRequest.Name = "dateTimeRequest";
            this.dateTimeRequest.Size = new System.Drawing.Size(171, 31);
            this.dateTimeRequest.TabIndex = 3;
            // 
            // comboServiceRequest
            // 
            this.comboServiceRequest.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboServiceRequest.FormattingEnabled = true;
            this.comboServiceRequest.Location = new System.Drawing.Point(244, 252);
            this.comboServiceRequest.Name = "comboServiceRequest";
            this.comboServiceRequest.Size = new System.Drawing.Size(191, 32);
            this.comboServiceRequest.TabIndex = 2;
            this.comboServiceRequest.SelectedIndexChanged += new System.EventHandler(this.comboServiceRequest_SelectedIndexChanged);
            // 
            // txtFullName
            // 
            this.txtFullName.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.Location = new System.Drawing.Point(19, 254);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(180, 31);
            this.txtFullName.TabIndex = 1;
            // 
            // lblServiceId
            // 
            this.lblServiceId.AutoSize = true;
            this.lblServiceId.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceId.Location = new System.Drawing.Point(36, 74);
            this.lblServiceId.Name = "lblServiceId";
            this.lblServiceId.Size = new System.Drawing.Size(113, 28);
            this.lblServiceId.TabIndex = 8;
            this.lblServiceId.Text = "Service Id";
            // 
            // txtServiceId
            // 
            this.txtServiceId.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServiceId.Location = new System.Drawing.Point(21, 32);
            this.txtServiceId.Name = "txtServiceId";
            this.txtServiceId.Size = new System.Drawing.Size(154, 35);
            this.txtServiceId.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Pink;
            this.panel1.Controls.Add(this.lblServiceId);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.txtServiceId);
            this.panel1.Controls.Add(this.btnApptRequest);
            this.panel1.Location = new System.Drawing.Point(112, 401);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(726, 185);
            this.panel1.TabIndex = 4;
            // 
            // pictureboxScrolling
            // 
            this.pictureboxScrolling.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureboxScrolling.Image = global::QueensBeyondV._3.Properties.Resources.PortfolioPic5;
            this.pictureboxScrolling.Location = new System.Drawing.Point(0, -2);
            this.pictureboxScrolling.Name = "pictureboxScrolling";
            this.pictureboxScrolling.Size = new System.Drawing.Size(722, 363);
            this.pictureboxScrolling.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureboxScrolling.TabIndex = 0;
            this.pictureboxScrolling.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(924, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // SalonClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(956, 616);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelRequest);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SalonClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salon Client";
            this.Load += new System.EventHandler(this.SalonClient_Load);
            this.panelRequest.ResumeLayout(false);
            this.panelRequest.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxScrolling)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnApptRequest;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panelRequest;
        private System.Windows.Forms.PictureBox pictureboxScrolling;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDateTimeRequest;
        private System.Windows.Forms.Label lblServiceRequest;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.DateTimePicker dateTimeRequest;
        private System.Windows.Forms.ComboBox comboServiceRequest;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblServiceId;
        private System.Windows.Forms.TextBox txtServiceId;
        private System.Windows.Forms.Label label1;
    }
}