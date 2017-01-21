namespace IControl_v2
{
    partial class Users
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Users));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.users_list = new System.Windows.Forms.TabPage();
            this.bunifuCustomLabel14 = new ns1.BunifuCustomLabel();
            this.btn_delete = new ns1.BunifuFlatButton();
            this.txtbox_search = new System.Windows.Forms.TextBox();
            this.btn_edit = new ns1.BunifuFlatButton();
            this.btn_new = new ns1.BunifuFlatButton();
            this.dgv_users_list = new ns1.BunifuCustomDataGrid();
            this.new_edit_user = new System.Windows.Forms.TabPage();
            this.btn_deleteaddress = new ns1.BunifuImageButton();
            this.btn_newaddress = new ns1.BunifuImageButton();
            this.gb_address = new System.Windows.Forms.GroupBox();
            this.bunifuCustomLabel13 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel12 = new ns1.BunifuCustomLabel();
            this.txtbox_zip_code = new System.Windows.Forms.MaskedTextBox();
            this.txtbox_country = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel11 = new ns1.BunifuCustomLabel();
            this.txtbox_city = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel10 = new ns1.BunifuCustomLabel();
            this.txtbox_address = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel9 = new ns1.BunifuCustomLabel();
            this.txtbox_addressid = new System.Windows.Forms.TextBox();
            this.btn_cancel = new ns1.BunifuFlatButton();
            this.btn_save = new ns1.BunifuFlatButton();
            this.dgv_address = new ns1.BunifuCustomDataGrid();
            this.gb_client_info = new System.Windows.Forms.GroupBox();
            this.cbbox_permission = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel8 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel7 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new ns1.BunifuCustomLabel();
            this.txtbox_firstname = new System.Windows.Forms.TextBox();
            this.txtbox_email = new System.Windows.Forms.TextBox();
            this.txtbox_userid = new System.Windows.Forms.TextBox();
            this.txtbox_cellphone = new System.Windows.Forms.TextBox();
            this.cbbox_gender = new System.Windows.Forms.ComboBox();
            this.txtbox_password = new System.Windows.Forms.TextBox();
            this.txtbox_lastname = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.users_list.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_users_list)).BeginInit();
            this.new_edit_user.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_deleteaddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_newaddress)).BeginInit();
            this.gb_address.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_address)).BeginInit();
            this.gb_client_info.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.users_list);
            this.tabControl1.Controls.Add(this.new_edit_user);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(668, 445);
            this.tabControl1.TabIndex = 1;
            // 
            // users_list
            // 
            this.users_list.Controls.Add(this.bunifuCustomLabel14);
            this.users_list.Controls.Add(this.btn_delete);
            this.users_list.Controls.Add(this.txtbox_search);
            this.users_list.Controls.Add(this.btn_edit);
            this.users_list.Controls.Add(this.btn_new);
            this.users_list.Controls.Add(this.dgv_users_list);
            this.users_list.Location = new System.Drawing.Point(4, 22);
            this.users_list.Name = "users_list";
            this.users_list.Padding = new System.Windows.Forms.Padding(3);
            this.users_list.Size = new System.Drawing.Size(660, 419);
            this.users_list.TabIndex = 0;
            this.users_list.Text = "Users List";
            this.users_list.UseVisualStyleBackColor = true;
            // 
            // bunifuCustomLabel14
            // 
            this.bunifuCustomLabel14.AutoSize = true;
            this.bunifuCustomLabel14.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel14.Location = new System.Drawing.Point(16, 16);
            this.bunifuCustomLabel14.Name = "bunifuCustomLabel14";
            this.bunifuCustomLabel14.Size = new System.Drawing.Size(46, 16);
            this.bunifuCustomLabel14.TabIndex = 24;
            this.bunifuCustomLabel14.Text = "Search";
            // 
            // btn_delete
            // 
            this.btn_delete.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.btn_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.btn_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_delete.BorderRadius = 0;
            this.btn_delete.ButtonText = "&Delete";
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.btn_delete.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_delete.Iconimage = null;
            this.btn_delete.Iconimage_right = null;
            this.btn_delete.Iconimage_right_Selected = null;
            this.btn_delete.Iconimage_Selected = null;
            this.btn_delete.IconMarginLeft = 0;
            this.btn_delete.IconMarginRight = 0;
            this.btn_delete.IconRightVisible = false;
            this.btn_delete.IconRightZoom = 0D;
            this.btn_delete.IconVisible = false;
            this.btn_delete.IconZoom = 90D;
            this.btn_delete.IsTab = false;
            this.btn_delete.Location = new System.Drawing.Point(576, 386);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.btn_delete.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(31)))));
            this.btn_delete.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_delete.selected = false;
            this.btn_delete.Size = new System.Drawing.Size(64, 32);
            this.btn_delete.TabIndex = 7;
            this.btn_delete.Text = "&Delete";
            this.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_delete.Textcolor = System.Drawing.Color.White;
            this.btn_delete.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // txtbox_search
            // 
            this.txtbox_search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbox_search.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_search.Location = new System.Drawing.Point(64, 16);
            this.txtbox_search.Name = "txtbox_search";
            this.txtbox_search.Size = new System.Drawing.Size(576, 21);
            this.txtbox_search.TabIndex = 23;
            this.txtbox_search.TextChanged += new System.EventHandler(this.txtbox_search_TextChanged);
            // 
            // btn_edit
            // 
            this.btn_edit.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.btn_edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.btn_edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_edit.BorderRadius = 0;
            this.btn_edit.ButtonText = "&Edit";
            this.btn_edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_edit.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.btn_edit.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_edit.Iconimage = null;
            this.btn_edit.Iconimage_right = null;
            this.btn_edit.Iconimage_right_Selected = null;
            this.btn_edit.Iconimage_Selected = null;
            this.btn_edit.IconMarginLeft = 0;
            this.btn_edit.IconMarginRight = 0;
            this.btn_edit.IconRightVisible = false;
            this.btn_edit.IconRightZoom = 0D;
            this.btn_edit.IconVisible = false;
            this.btn_edit.IconZoom = 90D;
            this.btn_edit.IsTab = false;
            this.btn_edit.Location = new System.Drawing.Point(504, 386);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.btn_edit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(31)))));
            this.btn_edit.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_edit.selected = false;
            this.btn_edit.Size = new System.Drawing.Size(64, 32);
            this.btn_edit.TabIndex = 6;
            this.btn_edit.Text = "&Edit";
            this.btn_edit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_edit.Textcolor = System.Drawing.Color.White;
            this.btn_edit.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_new
            // 
            this.btn_new.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.btn_new.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_new.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.btn_new.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_new.BorderRadius = 0;
            this.btn_new.ButtonText = "&New";
            this.btn_new.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_new.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.btn_new.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_new.Iconimage = null;
            this.btn_new.Iconimage_right = null;
            this.btn_new.Iconimage_right_Selected = null;
            this.btn_new.Iconimage_Selected = null;
            this.btn_new.IconMarginLeft = 0;
            this.btn_new.IconMarginRight = 0;
            this.btn_new.IconRightVisible = false;
            this.btn_new.IconRightZoom = 0D;
            this.btn_new.IconVisible = false;
            this.btn_new.IconZoom = 90D;
            this.btn_new.IsTab = false;
            this.btn_new.Location = new System.Drawing.Point(432, 386);
            this.btn_new.Name = "btn_new";
            this.btn_new.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.btn_new.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(31)))));
            this.btn_new.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_new.selected = false;
            this.btn_new.Size = new System.Drawing.Size(64, 32);
            this.btn_new.TabIndex = 5;
            this.btn_new.Text = "&New";
            this.btn_new.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_new.Textcolor = System.Drawing.Color.White;
            this.btn_new.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // dgv_users_list
            // 
            this.dgv_users_list.AllowUserToAddRows = false;
            this.dgv_users_list.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_users_list.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_users_list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_users_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_users_list.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv_users_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_users_list.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_users_list.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_users_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            //this.dgv_users_list.DoubleBuffered = true;
            this.dgv_users_list.EnableHeadersVisualStyles = false;
            this.dgv_users_list.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgv_users_list.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(31)))));
            this.dgv_users_list.HeaderForeColor = System.Drawing.Color.White;
            this.dgv_users_list.Location = new System.Drawing.Point(16, 48);
            this.dgv_users_list.MultiSelect = false;
            this.dgv_users_list.Name = "dgv_users_list";
            this.dgv_users_list.ReadOnly = true;
            this.dgv_users_list.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_users_list.Size = new System.Drawing.Size(624, 322);
            this.dgv_users_list.TabIndex = 0;
            this.dgv_users_list.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_users_list_CellClick);
            // 
            // new_edit_user
            // 
            this.new_edit_user.BackColor = System.Drawing.Color.White;
            this.new_edit_user.Controls.Add(this.btn_deleteaddress);
            this.new_edit_user.Controls.Add(this.btn_newaddress);
            this.new_edit_user.Controls.Add(this.gb_address);
            this.new_edit_user.Controls.Add(this.btn_cancel);
            this.new_edit_user.Controls.Add(this.btn_save);
            this.new_edit_user.Controls.Add(this.dgv_address);
            this.new_edit_user.Controls.Add(this.gb_client_info);
            this.new_edit_user.Location = new System.Drawing.Point(4, 22);
            this.new_edit_user.Name = "new_edit_user";
            this.new_edit_user.Padding = new System.Windows.Forms.Padding(3);
            this.new_edit_user.Size = new System.Drawing.Size(660, 419);
            this.new_edit_user.TabIndex = 1;
            this.new_edit_user.Text = "New/Edit User";
            // 
            // btn_deleteaddress
            // 
            this.btn_deleteaddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_deleteaddress.BackColor = System.Drawing.Color.Transparent;
            this.btn_deleteaddress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_deleteaddress.Image = ((System.Drawing.Image)(resources.GetObject("btn_deleteaddress.Image")));
            this.btn_deleteaddress.ImageActive = null;
            this.btn_deleteaddress.Location = new System.Drawing.Point(624, 296);
            this.btn_deleteaddress.Name = "btn_deleteaddress";
            this.btn_deleteaddress.Size = new System.Drawing.Size(24, 24);
            this.btn_deleteaddress.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_deleteaddress.TabIndex = 25;
            this.btn_deleteaddress.TabStop = false;
            this.btn_deleteaddress.Zoom = 10;
            this.btn_deleteaddress.Click += new System.EventHandler(this.btn_deleteaddress_Click);
            // 
            // btn_newaddress
            // 
            this.btn_newaddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_newaddress.BackColor = System.Drawing.Color.Transparent;
            this.btn_newaddress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_newaddress.Image = ((System.Drawing.Image)(resources.GetObject("btn_newaddress.Image")));
            this.btn_newaddress.ImageActive = null;
            this.btn_newaddress.Location = new System.Drawing.Point(624, 264);
            this.btn_newaddress.Name = "btn_newaddress";
            this.btn_newaddress.Size = new System.Drawing.Size(24, 24);
            this.btn_newaddress.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_newaddress.TabIndex = 24;
            this.btn_newaddress.TabStop = false;
            this.btn_newaddress.Zoom = 10;
            this.btn_newaddress.Click += new System.EventHandler(this.btn_newaddress_Click);
            // 
            // gb_address
            // 
            this.gb_address.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_address.Controls.Add(this.bunifuCustomLabel13);
            this.gb_address.Controls.Add(this.bunifuCustomLabel12);
            this.gb_address.Controls.Add(this.txtbox_zip_code);
            this.gb_address.Controls.Add(this.txtbox_country);
            this.gb_address.Controls.Add(this.bunifuCustomLabel11);
            this.gb_address.Controls.Add(this.txtbox_city);
            this.gb_address.Controls.Add(this.bunifuCustomLabel10);
            this.gb_address.Controls.Add(this.txtbox_address);
            this.gb_address.Controls.Add(this.bunifuCustomLabel9);
            this.gb_address.Controls.Add(this.txtbox_addressid);
            this.gb_address.Enabled = false;
            this.gb_address.Location = new System.Drawing.Point(16, 136);
            this.gb_address.Name = "gb_address";
            this.gb_address.Size = new System.Drawing.Size(632, 120);
            this.gb_address.TabIndex = 12;
            this.gb_address.TabStop = false;
            this.gb_address.Text = "User Address";
            // 
            // bunifuCustomLabel13
            // 
            this.bunifuCustomLabel13.AutoSize = true;
            this.bunifuCustomLabel13.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel13.Location = new System.Drawing.Point(456, 88);
            this.bunifuCustomLabel13.Name = "bunifuCustomLabel13";
            this.bunifuCustomLabel13.Size = new System.Drawing.Size(59, 16);
            this.bunifuCustomLabel13.TabIndex = 17;
            this.bunifuCustomLabel13.Text = "Zip-Code";
            // 
            // bunifuCustomLabel12
            // 
            this.bunifuCustomLabel12.AutoSize = true;
            this.bunifuCustomLabel12.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel12.Location = new System.Drawing.Point(16, 88);
            this.bunifuCustomLabel12.Name = "bunifuCustomLabel12";
            this.bunifuCustomLabel12.Size = new System.Drawing.Size(51, 16);
            this.bunifuCustomLabel12.TabIndex = 23;
            this.bunifuCustomLabel12.Text = "Country";
            // 
            // txtbox_zip_code
            // 
            this.txtbox_zip_code.Location = new System.Drawing.Point(520, 88);
            this.txtbox_zip_code.Mask = "0000-999";
            this.txtbox_zip_code.Name = "txtbox_zip_code";
            this.txtbox_zip_code.Size = new System.Drawing.Size(88, 20);
            this.txtbox_zip_code.TabIndex = 4;
            this.txtbox_zip_code.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtbox_country
            // 
            this.txtbox_country.Location = new System.Drawing.Point(80, 88);
            this.txtbox_country.Name = "txtbox_country";
            this.txtbox_country.Size = new System.Drawing.Size(144, 20);
            this.txtbox_country.TabIndex = 2;
            // 
            // bunifuCustomLabel11
            // 
            this.bunifuCustomLabel11.AutoSize = true;
            this.bunifuCustomLabel11.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel11.Location = new System.Drawing.Point(232, 88);
            this.bunifuCustomLabel11.Name = "bunifuCustomLabel11";
            this.bunifuCustomLabel11.Size = new System.Drawing.Size(29, 16);
            this.bunifuCustomLabel11.TabIndex = 21;
            this.bunifuCustomLabel11.Text = "City";
            // 
            // txtbox_city
            // 
            this.txtbox_city.Location = new System.Drawing.Point(264, 88);
            this.txtbox_city.Name = "txtbox_city";
            this.txtbox_city.Size = new System.Drawing.Size(176, 20);
            this.txtbox_city.TabIndex = 3;
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.AutoSize = true;
            this.bunifuCustomLabel10.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(16, 48);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(49, 16);
            this.bunifuCustomLabel10.TabIndex = 19;
            this.bunifuCustomLabel10.Text = "Address";
            // 
            // txtbox_address
            // 
            this.txtbox_address.Location = new System.Drawing.Point(80, 48);
            this.txtbox_address.Multiline = true;
            this.txtbox_address.Name = "txtbox_address";
            this.txtbox_address.Size = new System.Drawing.Size(400, 32);
            this.txtbox_address.TabIndex = 1;
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(8, 24);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(60, 16);
            this.bunifuCustomLabel9.TabIndex = 17;
            this.bunifuCustomLabel9.Text = "AddressID";
            // 
            // txtbox_addressid
            // 
            this.txtbox_addressid.Enabled = false;
            this.txtbox_addressid.Location = new System.Drawing.Point(80, 24);
            this.txtbox_addressid.Name = "txtbox_addressid";
            this.txtbox_addressid.Size = new System.Drawing.Size(176, 20);
            this.txtbox_addressid.TabIndex = 0;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.btn_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cancel.BorderRadius = 0;
            this.btn_cancel.ButtonText = "&Cancel";
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.btn_cancel.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_cancel.Iconimage = null;
            this.btn_cancel.Iconimage_right = null;
            this.btn_cancel.Iconimage_right_Selected = null;
            this.btn_cancel.Iconimage_Selected = null;
            this.btn_cancel.IconMarginLeft = 0;
            this.btn_cancel.IconMarginRight = 0;
            this.btn_cancel.IconRightVisible = false;
            this.btn_cancel.IconRightZoom = 0D;
            this.btn_cancel.IconVisible = false;
            this.btn_cancel.IconZoom = 90D;
            this.btn_cancel.IsTab = false;
            this.btn_cancel.Location = new System.Drawing.Point(584, 378);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.btn_cancel.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(31)))));
            this.btn_cancel.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_cancel.selected = false;
            this.btn_cancel.Size = new System.Drawing.Size(64, 32);
            this.btn_cancel.TabIndex = 11;
            this.btn_cancel.Text = "&Cancel";
            this.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_cancel.Textcolor = System.Drawing.Color.White;
            this.btn_cancel.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
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
            this.btn_save.IconRightVisible = false;
            this.btn_save.IconRightZoom = 0D;
            this.btn_save.IconVisible = false;
            this.btn_save.IconZoom = 90D;
            this.btn_save.IsTab = false;
            this.btn_save.Location = new System.Drawing.Point(512, 378);
            this.btn_save.Name = "btn_save";
            this.btn_save.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.btn_save.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(31)))));
            this.btn_save.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_save.selected = false;
            this.btn_save.Size = new System.Drawing.Size(64, 32);
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "&Save";
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_save.Textcolor = System.Drawing.Color.White;
            this.btn_save.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // dgv_address
            // 
            this.dgv_address.AllowUserToAddRows = false;
            this.dgv_address.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_address.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_address.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_address.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_address.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv_address.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_address.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_address.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_address.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            //this.dgv_address.DoubleBuffered = true;
            this.dgv_address.EnableHeadersVisualStyles = false;
            this.dgv_address.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgv_address.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(31)))));
            this.dgv_address.HeaderForeColor = System.Drawing.Color.White;
            this.dgv_address.Location = new System.Drawing.Point(16, 264);
            this.dgv_address.MultiSelect = false;
            this.dgv_address.Name = "dgv_address";
            this.dgv_address.ReadOnly = true;
            this.dgv_address.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_address.Size = new System.Drawing.Size(600, 98);
            this.dgv_address.TabIndex = 9;
            this.dgv_address.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_address_CellClick);
            // 
            // gb_client_info
            // 
            this.gb_client_info.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_client_info.Controls.Add(this.cbbox_permission);
            this.gb_client_info.Controls.Add(this.bunifuCustomLabel8);
            this.gb_client_info.Controls.Add(this.bunifuCustomLabel7);
            this.gb_client_info.Controls.Add(this.bunifuCustomLabel6);
            this.gb_client_info.Controls.Add(this.bunifuCustomLabel5);
            this.gb_client_info.Controls.Add(this.bunifuCustomLabel4);
            this.gb_client_info.Controls.Add(this.bunifuCustomLabel3);
            this.gb_client_info.Controls.Add(this.bunifuCustomLabel1);
            this.gb_client_info.Controls.Add(this.bunifuCustomLabel2);
            this.gb_client_info.Controls.Add(this.txtbox_firstname);
            this.gb_client_info.Controls.Add(this.txtbox_email);
            this.gb_client_info.Controls.Add(this.txtbox_userid);
            this.gb_client_info.Controls.Add(this.txtbox_cellphone);
            this.gb_client_info.Controls.Add(this.cbbox_gender);
            this.gb_client_info.Controls.Add(this.txtbox_password);
            this.gb_client_info.Controls.Add(this.txtbox_lastname);
            this.gb_client_info.Location = new System.Drawing.Point(16, 8);
            this.gb_client_info.Name = "gb_client_info";
            this.gb_client_info.Size = new System.Drawing.Size(632, 128);
            this.gb_client_info.TabIndex = 0;
            this.gb_client_info.TabStop = false;
            this.gb_client_info.Text = "User Information";
            // 
            // cbbox_permission
            // 
            this.cbbox_permission.FormattingEnabled = true;
            this.cbbox_permission.Location = new System.Drawing.Point(360, 72);
            this.cbbox_permission.Name = "cbbox_permission";
            this.cbbox_permission.Size = new System.Drawing.Size(176, 21);
            this.cbbox_permission.TabIndex = 16;
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(312, 96);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(36, 16);
            this.bunifuCustomLabel8.TabIndex = 15;
            this.bunifuCustomLabel8.Text = "Email";
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(8, 96);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(64, 16);
            this.bunifuCustomLabel7.TabIndex = 14;
            this.bunifuCustomLabel7.Text = "Cellphone";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(288, 72);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(61, 16);
            this.bunifuCustomLabel6.TabIndex = 13;
            this.bunifuCustomLabel6.Text = "Permission";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(16, 72);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(50, 16);
            this.bunifuCustomLabel5.TabIndex = 12;
            this.bunifuCustomLabel5.Text = "Gender";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(288, 48);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(65, 16);
            this.bunifuCustomLabel4.TabIndex = 11;
            this.bunifuCustomLabel4.Text = "Last Name";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(8, 48);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(62, 16);
            this.bunifuCustomLabel3.TabIndex = 10;
            this.bunifuCustomLabel3.Text = "First Name";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(296, 24);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(59, 16);
            this.bunifuCustomLabel1.TabIndex = 9;
            this.bunifuCustomLabel1.Text = "Password";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(24, 24);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(41, 16);
            this.bunifuCustomLabel2.TabIndex = 8;
            this.bunifuCustomLabel2.Text = "UserID";
            // 
            // txtbox_firstname
            // 
            this.txtbox_firstname.Location = new System.Drawing.Point(80, 48);
            this.txtbox_firstname.Name = "txtbox_firstname";
            this.txtbox_firstname.Size = new System.Drawing.Size(200, 20);
            this.txtbox_firstname.TabIndex = 2;
            // 
            // txtbox_email
            // 
            this.txtbox_email.Location = new System.Drawing.Point(360, 96);
            this.txtbox_email.Name = "txtbox_email";
            this.txtbox_email.Size = new System.Drawing.Size(176, 20);
            this.txtbox_email.TabIndex = 7;
            // 
            // txtbox_userid
            // 
            this.txtbox_userid.Enabled = false;
            this.txtbox_userid.Location = new System.Drawing.Point(80, 24);
            this.txtbox_userid.Name = "txtbox_userid";
            this.txtbox_userid.Size = new System.Drawing.Size(200, 20);
            this.txtbox_userid.TabIndex = 0;
            // 
            // txtbox_cellphone
            // 
            this.txtbox_cellphone.Location = new System.Drawing.Point(80, 96);
            this.txtbox_cellphone.Name = "txtbox_cellphone";
            this.txtbox_cellphone.Size = new System.Drawing.Size(200, 20);
            this.txtbox_cellphone.TabIndex = 6;
            // 
            // cbbox_gender
            // 
            this.cbbox_gender.FormattingEnabled = true;
            this.cbbox_gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbbox_gender.Location = new System.Drawing.Point(80, 72);
            this.cbbox_gender.Name = "cbbox_gender";
            this.cbbox_gender.Size = new System.Drawing.Size(200, 21);
            this.cbbox_gender.TabIndex = 4;
            // 
            // txtbox_password
            // 
            this.txtbox_password.Location = new System.Drawing.Point(360, 24);
            this.txtbox_password.Name = "txtbox_password";
            this.txtbox_password.Size = new System.Drawing.Size(176, 20);
            this.txtbox_password.TabIndex = 1;
            // 
            // txtbox_lastname
            // 
            this.txtbox_lastname.Location = new System.Drawing.Point(360, 48);
            this.txtbox_lastname.Name = "txtbox_lastname";
            this.txtbox_lastname.Size = new System.Drawing.Size(176, 20);
            this.txtbox_lastname.TabIndex = 3;
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "Users";
            this.Size = new System.Drawing.Size(668, 445);
            this.Load += new System.EventHandler(this.Users_Load);
            this.tabControl1.ResumeLayout(false);
            this.users_list.ResumeLayout(false);
            this.users_list.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_users_list)).EndInit();
            this.new_edit_user.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_deleteaddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_newaddress)).EndInit();
            this.gb_address.ResumeLayout(false);
            this.gb_address.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_address)).EndInit();
            this.gb_client_info.ResumeLayout(false);
            this.gb_client_info.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage users_list;
        private ns1.BunifuCustomLabel bunifuCustomLabel14;
        private ns1.BunifuFlatButton btn_delete;
        private System.Windows.Forms.TextBox txtbox_search;
        private ns1.BunifuFlatButton btn_edit;
        private ns1.BunifuFlatButton btn_new;
        private ns1.BunifuCustomDataGrid dgv_users_list;
        private System.Windows.Forms.TabPage new_edit_user;
        private ns1.BunifuImageButton btn_deleteaddress;
        private ns1.BunifuImageButton btn_newaddress;
        private System.Windows.Forms.GroupBox gb_address;
        private ns1.BunifuCustomLabel bunifuCustomLabel13;
        private ns1.BunifuCustomLabel bunifuCustomLabel12;
        private System.Windows.Forms.MaskedTextBox txtbox_zip_code;
        private System.Windows.Forms.TextBox txtbox_country;
        private ns1.BunifuCustomLabel bunifuCustomLabel11;
        private System.Windows.Forms.TextBox txtbox_city;
        private ns1.BunifuCustomLabel bunifuCustomLabel10;
        private System.Windows.Forms.TextBox txtbox_address;
        private ns1.BunifuCustomLabel bunifuCustomLabel9;
        private System.Windows.Forms.TextBox txtbox_addressid;
        private ns1.BunifuFlatButton btn_cancel;
        private ns1.BunifuFlatButton btn_save;
        private ns1.BunifuCustomDataGrid dgv_address;
        private System.Windows.Forms.GroupBox gb_client_info;
        private ns1.BunifuCustomLabel bunifuCustomLabel8;
        private ns1.BunifuCustomLabel bunifuCustomLabel7;
        private ns1.BunifuCustomLabel bunifuCustomLabel6;
        private ns1.BunifuCustomLabel bunifuCustomLabel5;
        private ns1.BunifuCustomLabel bunifuCustomLabel4;
        private ns1.BunifuCustomLabel bunifuCustomLabel3;
        private ns1.BunifuCustomLabel bunifuCustomLabel1;
        private ns1.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.TextBox txtbox_firstname;
        private System.Windows.Forms.TextBox txtbox_email;
        private System.Windows.Forms.TextBox txtbox_userid;
        private System.Windows.Forms.TextBox txtbox_cellphone;
        private System.Windows.Forms.ComboBox cbbox_gender;
        private System.Windows.Forms.TextBox txtbox_password;
        private System.Windows.Forms.TextBox txtbox_lastname;
        private System.Windows.Forms.ComboBox cbbox_permission;
    }
}
