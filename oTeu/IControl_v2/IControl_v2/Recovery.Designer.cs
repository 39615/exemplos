namespace IControl_v2
{
    partial class Recovery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Recovery));
            this.bunifuCustomLabel14 = new ns1.BunifuCustomLabel();
            this.txtbox_email = new System.Windows.Forms.TextBox();
            this.btn_recovery = new ns1.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel14
            // 
            this.bunifuCustomLabel14.AutoSize = true;
            this.bunifuCustomLabel14.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel14.Location = new System.Drawing.Point(8, 24);
            this.bunifuCustomLabel14.Name = "bunifuCustomLabel14";
            this.bunifuCustomLabel14.Size = new System.Drawing.Size(63, 16);
            this.bunifuCustomLabel14.TabIndex = 26;
            this.bunifuCustomLabel14.Text = "Your Email";
            // 
            // txtbox_email
            // 
            this.txtbox_email.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_email.Location = new System.Drawing.Point(72, 24);
            this.txtbox_email.Name = "txtbox_email";
            this.txtbox_email.Size = new System.Drawing.Size(296, 21);
            this.txtbox_email.TabIndex = 25;
            // 
            // btn_recovery
            // 
            this.btn_recovery.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.btn_recovery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_recovery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.btn_recovery.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_recovery.BorderRadius = 0;
            this.btn_recovery.ButtonText = "&Recovery";
            this.btn_recovery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_recovery.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.btn_recovery.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_recovery.Iconimage = null;
            this.btn_recovery.Iconimage_right = null;
            this.btn_recovery.Iconimage_right_Selected = null;
            this.btn_recovery.Iconimage_Selected = null;
            this.btn_recovery.IconMarginLeft = 0;
            this.btn_recovery.IconMarginRight = 0;
            this.btn_recovery.IconRightVisible = false;
            this.btn_recovery.IconRightZoom = 0D;
            this.btn_recovery.IconVisible = false;
            this.btn_recovery.IconZoom = 90D;
            this.btn_recovery.IsTab = false;
            this.btn_recovery.Location = new System.Drawing.Point(290, 60);
            this.btn_recovery.Name = "btn_recovery";
            this.btn_recovery.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.btn_recovery.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(31)))));
            this.btn_recovery.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_recovery.selected = false;
            this.btn_recovery.Size = new System.Drawing.Size(80, 32);
            this.btn_recovery.TabIndex = 27;
            this.btn_recovery.Text = "&Recovery";
            this.btn_recovery.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_recovery.Textcolor = System.Drawing.Color.White;
            this.btn_recovery.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_recovery.Click += new System.EventHandler(this.btn_recovery_Click);
            // 
            // Recovery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 106);
            this.Controls.Add(this.btn_recovery);
            this.Controls.Add(this.bunifuCustomLabel14);
            this.Controls.Add(this.txtbox_email);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Recovery";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recovery Account";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ns1.BunifuCustomLabel bunifuCustomLabel14;
        private System.Windows.Forms.TextBox txtbox_email;
        private ns1.BunifuFlatButton btn_recovery;
    }
}