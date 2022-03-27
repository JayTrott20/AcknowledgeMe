namespace QueensBeyondV._3
{
    partial class FormQueen3
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
            this.btnAdminLogin = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.paneladminView = new System.Windows.Forms.Panel();
            this.AdminGridView = new System.Windows.Forms.DataGridView();
            this.btnDeleteAppt = new System.Windows.Forms.Button();
            this.pictureBackground = new System.Windows.Forms.PictureBox();
            this.salonManagementSystemDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.lblSalonManagment = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.paneladminView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdminGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salonManagementSystemDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdminLogin
            // 
            this.btnAdminLogin.BackColor = System.Drawing.Color.Pink;
            this.btnAdminLogin.FlatAppearance.BorderSize = 2;
            this.btnAdminLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OliveDrab;
            this.btnAdminLogin.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminLogin.Location = new System.Drawing.Point(224, 654);
            this.btnAdminLogin.Name = "btnAdminLogin";
            this.btnAdminLogin.Size = new System.Drawing.Size(236, 57);
            this.btnAdminLogin.TabIndex = 0;
            this.btnAdminLogin.Text = "Administrative View";
            this.btnAdminLogin.UseVisualStyleBackColor = false;
            this.btnAdminLogin.Click += new System.EventHandler(this.btnAdminLogin_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Pink;
            this.btnLogout.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLogout.FlatAppearance.BorderSize = 2;
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OliveDrab;
            this.btnLogout.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(936, 654);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(229, 57);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // paneladminView
            // 
            this.paneladminView.BackColor = System.Drawing.Color.White;
            this.paneladminView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.paneladminView.Controls.Add(this.AdminGridView);
            this.paneladminView.Controls.Add(this.pictureBackground);
            this.paneladminView.Location = new System.Drawing.Point(201, 102);
            this.paneladminView.Name = "paneladminView";
            this.paneladminView.Size = new System.Drawing.Size(990, 546);
            this.paneladminView.TabIndex = 5;
            // 
            // AdminGridView
            // 
            this.AdminGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AdminGridView.Location = new System.Drawing.Point(154, 157);
            this.AdminGridView.Name = "AdminGridView";
            this.AdminGridView.RowHeadersWidth = 51;
            this.AdminGridView.RowTemplate.Height = 24;
            this.AdminGridView.Size = new System.Drawing.Size(715, 213);
            this.AdminGridView.TabIndex = 10;
            // 
            // btnDeleteAppt
            // 
            this.btnDeleteAppt.BackColor = System.Drawing.Color.Pink;
            this.btnDeleteAppt.FlatAppearance.BorderSize = 2;
            this.btnDeleteAppt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OliveDrab;
            this.btnDeleteAppt.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAppt.Location = new System.Drawing.Point(567, 654);
            this.btnDeleteAppt.Name = "btnDeleteAppt";
            this.btnDeleteAppt.Size = new System.Drawing.Size(236, 57);
            this.btnDeleteAppt.TabIndex = 6;
            this.btnDeleteAppt.Text = "Delete Appointment";
            this.btnDeleteAppt.UseVisualStyleBackColor = false;
            this.btnDeleteAppt.Click += new System.EventHandler(this.btnDeleteAppt_Click);
            // 
            // pictureBackground
            // 
            this.pictureBackground.Image = global::QueensBeyondV._3.Properties.Resources.HomeBackground;
            this.pictureBackground.Location = new System.Drawing.Point(3, 3);
            this.pictureBackground.Name = "pictureBackground";
            this.pictureBackground.Size = new System.Drawing.Size(990, 546);
            this.pictureBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBackground.TabIndex = 11;
            this.pictureBackground.TabStop = false;
            // 
            // pictureLogo
            // 
            this.pictureLogo.Image = global::QueensBeyondV._3.Properties.Resources.ShopLogo;
            this.pictureLogo.Location = new System.Drawing.Point(12, 12);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(125, 134);
            this.pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureLogo.TabIndex = 7;
            this.pictureLogo.TabStop = false;
            // 
            // lblSalonManagment
            // 
            this.lblSalonManagment.AutoSize = true;
            this.lblSalonManagment.Font = new System.Drawing.Font("Imprint MT Shadow", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalonManagment.ForeColor = System.Drawing.Color.Pink;
            this.lblSalonManagment.Location = new System.Drawing.Point(462, 25);
            this.lblSalonManagment.Name = "lblSalonManagment";
            this.lblSalonManagment.Size = new System.Drawing.Size(434, 40);
            this.lblSalonManagment.TabIndex = 8;
            this.lblSalonManagment.Text = "Salon Management System";
            this.lblSalonManagment.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1348, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormQueen3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.CancelButton = this.btnLogout;
            this.ClientSize = new System.Drawing.Size(1380, 727);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSalonManagment);
            this.Controls.Add(this.pictureLogo);
            this.Controls.Add(this.paneladminView);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnAdminLogin);
            this.Controls.Add(this.btnDeleteAppt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormQueen3";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormQueen3_Load);
            this.paneladminView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AdminGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salonManagementSystemDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdminLogin;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel paneladminView;
        private System.Windows.Forms.Button btnDeleteAppt;
        private System.Windows.Forms.BindingSource salonManagementSystemDataSetBindingSource;
        private System.Windows.Forms.DataGridView AdminGridView;
        private System.Windows.Forms.PictureBox pictureBackground;
        private System.Windows.Forms.PictureBox pictureLogo;
        private System.Windows.Forms.Label lblSalonManagment;
        private System.Windows.Forms.Label label1;
    }
}

