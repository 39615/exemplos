namespace IControl_v2
{
    partial class Permission
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Permission));
            this.cbbox_permission_name = new System.Windows.Forms.ComboBox();
            this.txtbox_description = new System.Windows.Forms.TextBox();
            this.groupBox_permissions = new System.Windows.Forms.GroupBox();
            this.bunifuCustomLabel10 = new ns1.BunifuCustomLabel();
            this.chk_admin_settings = new ns1.BunifuCheckbox();
            this.bunifuCustomLabel9 = new ns1.BunifuCustomLabel();
            this.chk_permissions_menu = new ns1.BunifuCheckbox();
            this.bunifuCustomLabel8 = new ns1.BunifuCustomLabel();
            this.chk_users_menu = new ns1.BunifuCheckbox();
            this.bunifuCustomLabel7 = new ns1.BunifuCustomLabel();
            this.chk_suppliers_menu = new ns1.BunifuCheckbox();
            this.bunifuCustomLabel6 = new ns1.BunifuCustomLabel();
            this.chk_products_menu = new ns1.BunifuCheckbox();
            this.bunifuCustomLabel5 = new ns1.BunifuCustomLabel();
            this.chk_orders_menu = new ns1.BunifuCheckbox();
            this.bunifuCustomLabel4 = new ns1.BunifuCustomLabel();
            this.chk_clients_password = new ns1.BunifuCheckbox();
            this.bunifuCustomLabel3 = new ns1.BunifuCustomLabel();
            this.chk_clients_menu = new ns1.BunifuCheckbox();
            this.bunifuCustomLabel1 = new ns1.BunifuCustomLabel();
            this.btn_save = new ns1.BunifuFlatButton();
            this.bunifuFlatButton1 = new ns1.BunifuFlatButton();
            this.bunifuCustomLabel2 = new ns1.BunifuCustomLabel();
            this.toolTip_text = new System.Windows.Forms.ToolTip(this.components);
            this.btn_delete = new ns1.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox_permissions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbox_permission_name
            // 
            this.cbbox_permission_name.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbox_permission_name.FormattingEnabled = true;
            this.cbbox_permission_name.Location = new System.Drawing.Point(136, 32);
            this.cbbox_permission_name.Name = "cbbox_permission_name";
            this.cbbox_permission_name.Size = new System.Drawing.Size(240, 24);
            this.cbbox_permission_name.TabIndex = 0;
            this.cbbox_permission_name.TextChanged += new System.EventHandler(this.cbbox_permission_name_TextChanged);
            // 
            // txtbox_description
            // 
            this.txtbox_description.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_description.Location = new System.Drawing.Point(136, 64);
            this.txtbox_description.Multiline = true;
            this.txtbox_description.Name = "txtbox_description";
            this.txtbox_description.Size = new System.Drawing.Size(344, 64);
            this.txtbox_description.TabIndex = 1;
            // 
            // groupBox_permissions
            // 
            this.groupBox_permissions.Controls.Add(this.bunifuCustomLabel10);
            this.groupBox_permissions.Controls.Add(this.chk_admin_settings);
            this.groupBox_permissions.Controls.Add(this.bunifuCustomLabel9);
            this.groupBox_permissions.Controls.Add(this.chk_permissions_menu);
            this.groupBox_permissions.Controls.Add(this.bunifuCustomLabel8);
            this.groupBox_permissions.Controls.Add(this.chk_users_menu);
            this.groupBox_permissions.Controls.Add(this.bunifuCustomLabel7);
            this.groupBox_permissions.Controls.Add(this.chk_suppliers_menu);
            this.groupBox_permissions.Controls.Add(this.bunifuCustomLabel6);
            this.groupBox_permissions.Controls.Add(this.chk_products_menu);
            this.groupBox_permissions.Controls.Add(this.bunifuCustomLabel5);
            this.groupBox_permissions.Controls.Add(this.chk_orders_menu);
            this.groupBox_permissions.Controls.Add(this.bunifuCustomLabel4);
            this.groupBox_permissions.Controls.Add(this.chk_clients_password);
            this.groupBox_permissions.Controls.Add(this.bunifuCustomLabel3);
            this.groupBox_permissions.Controls.Add(this.chk_clients_menu);
            this.groupBox_permissions.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_permissions.Location = new System.Drawing.Point(16, 144);
            this.groupBox_permissions.Name = "groupBox_permissions";
            this.groupBox_permissions.Size = new System.Drawing.Size(552, 152);
            this.groupBox_permissions.TabIndex = 2;
            this.groupBox_permissions.TabStop = false;
            this.groupBox_permissions.Text = "Permissions";
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.AutoSize = true;
            this.bunifuCustomLabel10.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(240, 112);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(238, 16);
            this.bunifuCustomLabel10.TabIndex = 21;
            this.bunifuCustomLabel10.Text = "Admin Settings (Recomended only Admins)";
            // 
            // chk_admin_settings
            // 
            this.chk_admin_settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chk_admin_settings.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chk_admin_settings.Checked = false;
            this.chk_admin_settings.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.chk_admin_settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chk_admin_settings.ForeColor = System.Drawing.Color.White;
            this.chk_admin_settings.Location = new System.Drawing.Point(208, 112);
            this.chk_admin_settings.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.chk_admin_settings.Name = "chk_admin_settings";
            this.chk_admin_settings.Size = new System.Drawing.Size(20, 20);
            this.chk_admin_settings.TabIndex = 20;
            this.chk_admin_settings.OnChange += new System.EventHandler(this.bunifuCheckbox1_OnChange);
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(240, 88);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(252, 16);
            this.bunifuCustomLabel9.TabIndex = 19;
            this.bunifuCustomLabel9.Text = "Permissions Menu (Recomended only Admins)";
            // 
            // chk_permissions_menu
            // 
            this.chk_permissions_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chk_permissions_menu.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chk_permissions_menu.Checked = false;
            this.chk_permissions_menu.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.chk_permissions_menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chk_permissions_menu.ForeColor = System.Drawing.Color.White;
            this.chk_permissions_menu.Location = new System.Drawing.Point(208, 88);
            this.chk_permissions_menu.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.chk_permissions_menu.Name = "chk_permissions_menu";
            this.chk_permissions_menu.Size = new System.Drawing.Size(20, 20);
            this.chk_permissions_menu.TabIndex = 18;
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(240, 64);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(221, 16);
            this.bunifuCustomLabel8.TabIndex = 17;
            this.bunifuCustomLabel8.Text = "Users Menu (Recomended only Admins)";
            // 
            // chk_users_menu
            // 
            this.chk_users_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chk_users_menu.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chk_users_menu.Checked = false;
            this.chk_users_menu.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.chk_users_menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chk_users_menu.ForeColor = System.Drawing.Color.White;
            this.chk_users_menu.Location = new System.Drawing.Point(208, 64);
            this.chk_users_menu.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.chk_users_menu.Name = "chk_users_menu";
            this.chk_users_menu.Size = new System.Drawing.Size(20, 20);
            this.chk_users_menu.TabIndex = 16;
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(240, 40);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(90, 16);
            this.bunifuCustomLabel7.TabIndex = 15;
            this.bunifuCustomLabel7.Text = "Suppliers Menu";
            // 
            // chk_suppliers_menu
            // 
            this.chk_suppliers_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chk_suppliers_menu.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chk_suppliers_menu.Checked = false;
            this.chk_suppliers_menu.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.chk_suppliers_menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chk_suppliers_menu.ForeColor = System.Drawing.Color.White;
            this.chk_suppliers_menu.Location = new System.Drawing.Point(208, 40);
            this.chk_suppliers_menu.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.chk_suppliers_menu.Name = "chk_suppliers_menu";
            this.chk_suppliers_menu.Size = new System.Drawing.Size(20, 20);
            this.chk_suppliers_menu.TabIndex = 14;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(48, 112);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(90, 16);
            this.bunifuCustomLabel6.TabIndex = 13;
            this.bunifuCustomLabel6.Text = "Products Menu";
            // 
            // chk_products_menu
            // 
            this.chk_products_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chk_products_menu.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chk_products_menu.Checked = false;
            this.chk_products_menu.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.chk_products_menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chk_products_menu.ForeColor = System.Drawing.Color.White;
            this.chk_products_menu.Location = new System.Drawing.Point(16, 112);
            this.chk_products_menu.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.chk_products_menu.Name = "chk_products_menu";
            this.chk_products_menu.Size = new System.Drawing.Size(20, 20);
            this.chk_products_menu.TabIndex = 12;
            this.toolTip_text.SetToolTip(this.chk_products_menu, "Allow user to acess products menu.");
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(48, 88);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(78, 16);
            this.bunifuCustomLabel5.TabIndex = 11;
            this.bunifuCustomLabel5.Text = "Orders Menu";
            // 
            // chk_orders_menu
            // 
            this.chk_orders_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chk_orders_menu.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chk_orders_menu.Checked = false;
            this.chk_orders_menu.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.chk_orders_menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chk_orders_menu.ForeColor = System.Drawing.Color.White;
            this.chk_orders_menu.Location = new System.Drawing.Point(16, 88);
            this.chk_orders_menu.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.chk_orders_menu.Name = "chk_orders_menu";
            this.chk_orders_menu.Size = new System.Drawing.Size(20, 20);
            this.chk_orders_menu.TabIndex = 10;
            this.toolTip_text.SetToolTip(this.chk_orders_menu, "Allow user to acess orders menu, create orders and modificate them.");
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(48, 64);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(97, 16);
            this.bunifuCustomLabel4.TabIndex = 9;
            this.bunifuCustomLabel4.Text = "Clients Password";
            // 
            // chk_clients_password
            // 
            this.chk_clients_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chk_clients_password.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chk_clients_password.Checked = false;
            this.chk_clients_password.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.chk_clients_password.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chk_clients_password.Enabled = false;
            this.chk_clients_password.ForeColor = System.Drawing.Color.White;
            this.chk_clients_password.Location = new System.Drawing.Point(16, 64);
            this.chk_clients_password.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.chk_clients_password.Name = "chk_clients_password";
            this.chk_clients_password.Size = new System.Drawing.Size(20, 20);
            this.chk_clients_password.TabIndex = 8;
            this.toolTip_text.SetToolTip(this.chk_clients_password, "Allow to user see and edit clients passwords.");
            this.chk_clients_password.OnChange += new System.EventHandler(this.chk_clients_password_OnChange);
            this.chk_clients_password.Click += new System.EventHandler(this.chk_clients_password_Click);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(48, 40);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(78, 16);
            this.bunifuCustomLabel3.TabIndex = 7;
            this.bunifuCustomLabel3.Text = "Clients Menu";
            // 
            // chk_clients_menu
            // 
            this.chk_clients_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chk_clients_menu.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chk_clients_menu.Checked = false;
            this.chk_clients_menu.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.chk_clients_menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chk_clients_menu.ForeColor = System.Drawing.Color.White;
            this.chk_clients_menu.Location = new System.Drawing.Point(16, 40);
            this.chk_clients_menu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chk_clients_menu.Name = "chk_clients_menu";
            this.chk_clients_menu.Size = new System.Drawing.Size(20, 20);
            this.chk_clients_menu.TabIndex = 0;
            this.toolTip_text.SetToolTip(this.chk_clients_menu, "Acess to the clients menu, allow to create, edit, delete clients informations.");
            this.chk_clients_menu.OnChange += new System.EventHandler(this.chk_clients_menu_OnChange);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(24, 40);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(100, 16);
            this.bunifuCustomLabel1.TabIndex = 3;
            this.bunifuCustomLabel1.Text = "Permission Name:";
            // 
            // btn_save
            // 
            this.btn_save.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.btn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_save.BorderRadius = 0;
            this.btn_save.ButtonText = "&Save";
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.btn_save.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_save.Iconimage = null;
            this.btn_save.Iconimage_right = null;
            this.btn_save.Iconimage_right_Selected = null;
            this.btn_save.Iconimage_Selected = null;
            this.btn_save.IconMarginLeft = 0;
            this.btn_save.IconMarginRight = 0;
            this.btn_save.IconRightVisible = true;
            this.btn_save.IconRightZoom = 0D;
            this.btn_save.IconVisible = true;
            this.btn_save.IconZoom = 90D;
            this.btn_save.IsTab = false;
            this.btn_save.Location = new System.Drawing.Point(520, 384);
            this.btn_save.Name = "btn_save";
            this.btn_save.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.btn_save.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(31)))));
            this.btn_save.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_save.selected = false;
            this.btn_save.Size = new System.Drawing.Size(64, 32);
            this.btn_save.TabIndex = 4;
            this.btn_save.Text = "&Save";
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_save.Textcolor = System.Drawing.Color.White;
            this.btn_save.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.bunifuFlatButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "&Cancel";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = null;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(592, 384);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(31)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(64, 32);
            this.bunifuFlatButton1.TabIndex = 5;
            this.bunifuFlatButton1.Text = "&Cancel";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(56, 72);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(70, 16);
            this.bunifuCustomLabel2.TabIndex = 6;
            this.bunifuCustomLabel2.Text = "Description:";
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Transparent;
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.Image")));
            this.btn_delete.ImageActive = null;
            this.btn_delete.Location = new System.Drawing.Point(384, 32);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(24, 24);
            this.btn_delete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_delete.TabIndex = 8;
            this.btn_delete.TabStop = false;
            this.btn_delete.Zoom = 20;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_cLICK);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(528, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // Permission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.groupBox_permissions);
            this.Controls.Add(this.txtbox_description);
            this.Controls.Add(this.cbbox_permission_name);
            this.Name = "Permission";
            this.Size = new System.Drawing.Size(668, 427);
            this.Load += new System.EventHandler(this.Permission_Load);
            this.groupBox_permissions.ResumeLayout(false);
            this.groupBox_permissions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbox_permission_name;
        private System.Windows.Forms.TextBox txtbox_description;
        private System.Windows.Forms.GroupBox groupBox_permissions;
        private ns1.BunifuCheckbox chk_clients_menu;
        private ns1.BunifuCustomLabel bunifuCustomLabel1;
        private ns1.BunifuCustomLabel bunifuCustomLabel9;
        private ns1.BunifuCheckbox chk_permissions_menu;
        private ns1.BunifuCustomLabel bunifuCustomLabel8;
        private ns1.BunifuCheckbox chk_users_menu;
        private ns1.BunifuCustomLabel bunifuCustomLabel7;
        private ns1.BunifuCheckbox chk_suppliers_menu;
        private ns1.BunifuCustomLabel bunifuCustomLabel6;
        private ns1.BunifuCheckbox chk_products_menu;
        private ns1.BunifuCustomLabel bunifuCustomLabel5;
        private ns1.BunifuCheckbox chk_orders_menu;
        private ns1.BunifuCustomLabel bunifuCustomLabel4;
        private ns1.BunifuCheckbox chk_clients_password;
        private ns1.BunifuCustomLabel bunifuCustomLabel3;
        private ns1.BunifuFlatButton btn_save;
        private ns1.BunifuFlatButton bunifuFlatButton1;
        private ns1.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.ToolTip toolTip_text;
        private ns1.BunifuImageButton btn_delete;
        private ns1.BunifuCustomLabel bunifuCustomLabel10;
        private ns1.BunifuCheckbox chk_admin_settings;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
