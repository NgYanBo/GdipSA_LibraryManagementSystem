namespace SA47Team10a_GalaxyLibrary
{
    partial class frm1Welcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm1Welcome));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLibraryUsers = new System.Windows.Forms.Button();
            this.btnStaffLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1623, 1177);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(488, 666);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(693, 66);
            this.label1.TabIndex = 3;
            this.label1.Text = "Welcome to Galaxy Library";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(345, 733);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(976, 66);
            this.label2.TabIndex = 3;
            this.label2.Text = "A Vast Collection Of Knowledge Awaits";
            // 
            // btnLibraryUsers
            // 
            this.btnLibraryUsers.BackColor = System.Drawing.Color.Indigo;
            this.btnLibraryUsers.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLibraryUsers.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLibraryUsers.Location = new System.Drawing.Point(483, 841);
            this.btnLibraryUsers.Name = "btnLibraryUsers";
            this.btnLibraryUsers.Size = new System.Drawing.Size(330, 94);
            this.btnLibraryUsers.TabIndex = 0;
            this.btnLibraryUsers.Text = "Library Users";
            this.btnLibraryUsers.UseVisualStyleBackColor = false;
            this.btnLibraryUsers.Click += new System.EventHandler(this.btnLibraryUsers_Click);
            // 
            // btnStaffLogin
            // 
            this.btnStaffLogin.BackColor = System.Drawing.Color.Indigo;
            this.btnStaffLogin.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStaffLogin.FlatAppearance.BorderSize = 10;
            this.btnStaffLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnStaffLogin.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaffLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnStaffLogin.Location = new System.Drawing.Point(840, 841);
            this.btnStaffLogin.Name = "btnStaffLogin";
            this.btnStaffLogin.Size = new System.Drawing.Size(330, 94);
            this.btnStaffLogin.TabIndex = 0;
            this.btnStaffLogin.Text = "Staff Login";
            this.btnStaffLogin.UseVisualStyleBackColor = false;
            this.btnStaffLogin.Click += new System.EventHandler(this.btnStaffLogin_Click);
            // 
            // frm1Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1623, 1177);
            this.Controls.Add(this.btnStaffLogin);
            this.Controls.Add(this.btnLibraryUsers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frm1Welcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Galaxy Libray | Welcome";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLibraryUsers;
        private System.Windows.Forms.Button btnStaffLogin;
    }
}