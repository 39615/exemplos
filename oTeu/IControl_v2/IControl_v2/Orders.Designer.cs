namespace IControl_v2
{
    partial class Orders
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Orders));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.orders_list = new System.Windows.Forms.TabPage();
            this.bunifuCustomLabel14 = new ns1.BunifuCustomLabel();
            this.dgv_orders_list = new ns1.BunifuCustomDataGrid();
            this.txtbox_search_order = new System.Windows.Forms.TextBox();
            this.btn_new_order = new ns1.BunifuFlatButton();
            this.btn_edit_order = new ns1.BunifuFlatButton();
            this.new_edit_order = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bunifuCustomLabel8 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel9 = new ns1.BunifuCustomLabel();
            this.cbbox_purchasestatus = new System.Windows.Forms.ComboBox();
            this.cbbox_deliverystaus = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bunifuCustomLabel7 = new ns1.BunifuCustomLabel();
            this.cbbox_payment = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel4 = new ns1.BunifuCustomLabel();
            this.cbbox_paymentstatus = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtbox_start_order = new System.Windows.Forms.TextBox();
            this.txtbox_orderid = new System.Windows.Forms.TextBox();
            this.txtbox_clientid = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel2 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new ns1.BunifuCustomLabel();
            this.btn_browse_client = new ns1.BunifuImageButton();
            this.txtbox_userid = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel1 = new ns1.BunifuCustomLabel();
            this.txtbox_last_modification = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel6 = new ns1.BunifuCustomLabel();
            this.btn_delete_products = new ns1.BunifuImageButton();
            this.btn_add_product = new ns1.BunifuImageButton();
            this.bunifuCustomLabel10 = new ns1.BunifuCustomLabel();
            this.txtbox_totalprice = new System.Windows.Forms.TextBox();
            this.dgv_products = new ns1.BunifuCustomDataGrid();
            this.btn_save_order = new ns1.BunifuFlatButton();
            this.btn_cancel_order = new ns1.BunifuFlatButton();
            this.select_client = new System.Windows.Forms.TabPage();
            this.btn_select_client = new ns1.BunifuFlatButton();
            this.btn_cancel_client = new ns1.BunifuFlatButton();
            this.dgv_clients_list = new ns1.BunifuCustomDataGrid();
            this.bunifuCustomLabel11 = new ns1.BunifuCustomLabel();
            this.txtbox_search_client = new System.Windows.Forms.TextBox();
            this.select_product = new System.Windows.Forms.TabPage();
            this.btn_select_product = new ns1.BunifuFlatButton();
            this.btn_cancel_product = new ns1.BunifuFlatButton();
            this.dgv_products_list = new ns1.BunifuCustomDataGrid();
            this.bunifuCustomLabel12 = new ns1.BunifuCustomLabel();
            this.txtbox_search_products = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1.SuspendLayout();
            this.orders_list.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_orders_list)).BeginInit();
            this.new_edit_order.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_browse_client)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_delete_products)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_add_product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_products)).BeginInit();
            this.select_client.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clients_list)).BeginInit();
            this.select_product.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_products_list)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.orders_list);
            this.tabControl1.Controls.Add(this.new_edit_order);
            this.tabControl1.Controls.Add(this.select_client);
            this.tabControl1.Controls.Add(this.select_product);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(668, 445);
            this.tabControl1.TabIndex = 0;
            // 
            // orders_list
            // 
            this.orders_list.Controls.Add(this.bunifuCustomLabel14);
            this.orders_list.Controls.Add(this.dgv_orders_list);
            this.orders_list.Controls.Add(this.txtbox_search_order);
            this.orders_list.Controls.Add(this.btn_new_order);
            this.orders_list.Controls.Add(this.btn_edit_order);
            this.orders_list.Location = new System.Drawing.Point(4, 22);
            this.orders_list.Name = "orders_list";
            this.orders_list.Padding = new System.Windows.Forms.Padding(3);
            this.orders_list.Size = new System.Drawing.Size(660, 419);
            this.orders_list.TabIndex = 0;
            this.orders_list.Text = "Orders List";
            this.orders_list.UseVisualStyleBackColor = true;
            // 
            // bunifuCustomLabel14
            // 
            this.bunifuCustomLabel14.AutoSize = true;
            this.bunifuCustomLabel14.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel14.Location = new System.Drawing.Point(16, 16);
            this.bunifuCustomLabel14.Name = "bunifuCustomLabel14";
            this.bunifuCustomLabel14.Size = new System.Drawing.Size(46, 16);
            this.bunifuCustomLabel14.TabIndex = 29;
            this.bunifuCustomLabel14.Text = "Search";
            // 
            // dgv_orders_list
            // 
            this.dgv_orders_list.AllowUserToAddRows = false;
            this.dgv_orders_list.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_orders_list.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_orders_list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_orders_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_orders_list.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv_orders_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_orders_list.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_orders_list.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_orders_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            //this.dgv_orders_list.DoubleBuffered = true;
            this.dgv_orders_list.EnableHeadersVisualStyles = false;
            this.dgv_orders_list.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgv_orders_list.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(31)))));
            this.dgv_orders_list.HeaderForeColor = System.Drawing.Color.White;
            this.dgv_orders_list.Location = new System.Drawing.Point(16, 48);
            this.dgv_orders_list.MultiSelect = false;
            this.dgv_orders_list.Name = "dgv_orders_list";
            this.dgv_orders_list.ReadOnly = true;
            this.dgv_orders_list.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_orders_list.Size = new System.Drawing.Size(624, 320);
            this.dgv_orders_list.TabIndex = 25;
            this.dgv_orders_list.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_orders_list_CellClick);
            // 
            // txtbox_search_order
            // 
            this.txtbox_search_order.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbox_search_order.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_search_order.Location = new System.Drawing.Point(64, 16);
            this.txtbox_search_order.Name = "txtbox_search_order";
            this.txtbox_search_order.Size = new System.Drawing.Size(576, 21);
            this.txtbox_search_order.TabIndex = 28;
            // 
            // btn_new_order
            // 
            this.btn_new_order.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.btn_new_order.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_new_order.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.btn_new_order.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_new_order.BorderRadius = 0;
            this.btn_new_order.ButtonText = "&New";
            this.btn_new_order.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_new_order.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.btn_new_order.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_new_order.Iconimage = null;
            this.btn_new_order.Iconimage_right = null;
            this.btn_new_order.Iconimage_right_Selected = null;
            this.btn_new_order.Iconimage_Selected = null;
            this.btn_new_order.IconMarginLeft = 0;
            this.btn_new_order.IconMarginRight = 0;
            this.btn_new_order.IconRightVisible = false;
            this.btn_new_order.IconRightZoom = 0D;
            this.btn_new_order.IconVisible = false;
            this.btn_new_order.IconZoom = 90D;
            this.btn_new_order.IsTab = false;
            this.btn_new_order.Location = new System.Drawing.Point(504, 376);
            this.btn_new_order.Name = "btn_new_order";
            this.btn_new_order.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.btn_new_order.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(31)))));
            this.btn_new_order.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_new_order.selected = false;
            this.btn_new_order.Size = new System.Drawing.Size(64, 32);
            this.btn_new_order.TabIndex = 26;
            this.btn_new_order.Text = "&New";
            this.btn_new_order.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_new_order.Textcolor = System.Drawing.Color.White;
            this.btn_new_order.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new_order.Click += new System.EventHandler(this.btn_new_order_Click);
            // 
            // btn_edit_order
            // 
            this.btn_edit_order.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.btn_edit_order.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_edit_order.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.btn_edit_order.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_edit_order.BorderRadius = 0;
            this.btn_edit_order.ButtonText = "&Edit";
            this.btn_edit_order.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_edit_order.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.btn_edit_order.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_edit_order.Iconimage = null;
            this.btn_edit_order.Iconimage_right = null;
            this.btn_edit_order.Iconimage_right_Selected = null;
            this.btn_edit_order.Iconimage_Selected = null;
            this.btn_edit_order.IconMarginLeft = 0;
            this.btn_edit_order.IconMarginRight = 0;
            this.btn_edit_order.IconRightVisible = false;
            this.btn_edit_order.IconRightZoom = 0D;
            this.btn_edit_order.IconVisible = false;
            this.btn_edit_order.IconZoom = 90D;
            this.btn_edit_order.IsTab = false;
            this.btn_edit_order.Location = new System.Drawing.Point(576, 376);
            this.btn_edit_order.Name = "btn_edit_order";
            this.btn_edit_order.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.btn_edit_order.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(31)))));
            this.btn_edit_order.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_edit_order.selected = false;
            this.btn_edit_order.Size = new System.Drawing.Size(64, 32);
            this.btn_edit_order.TabIndex = 27;
            this.btn_edit_order.Text = "&Edit";
            this.btn_edit_order.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_edit_order.Textcolor = System.Drawing.Color.White;
            this.btn_edit_order.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit_order.Click += new System.EventHandler(this.btn_edit_order_Click);
            // 
            // new_edit_order
            // 
            this.new_edit_order.Controls.Add(this.groupBox3);
            this.new_edit_order.Controls.Add(this.groupBox2);
            this.new_edit_order.Controls.Add(this.groupBox1);
            this.new_edit_order.Controls.Add(this.btn_delete_products);
            this.new_edit_order.Controls.Add(this.btn_add_product);
            this.new_edit_order.Controls.Add(this.bunifuCustomLabel10);
            this.new_edit_order.Controls.Add(this.txtbox_totalprice);
            this.new_edit_order.Controls.Add(this.dgv_products);
            this.new_edit_order.Controls.Add(this.btn_save_order);
            this.new_edit_order.Controls.Add(this.btn_cancel_order);
            this.new_edit_order.Location = new System.Drawing.Point(4, 22);
            this.new_edit_order.Name = "new_edit_order";
            this.new_edit_order.Padding = new System.Windows.Forms.Padding(3);
            this.new_edit_order.Size = new System.Drawing.Size(660, 419);
            this.new_edit_order.TabIndex = 1;
            this.new_edit_order.Text = "New/Edit Order";
            this.new_edit_order.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bunifuCustomLabel8);
            this.groupBox3.Controls.Add(this.bunifuCustomLabel9);
            this.groupBox3.Controls.Add(this.cbbox_purchasestatus);
            this.groupBox3.Controls.Add(this.cbbox_deliverystaus);
            this.groupBox3.Location = new System.Drawing.Point(16, 272);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(296, 80);
            this.groupBox3.TabIndex = 39;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Order Status";
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(24, 24);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(87, 16);
            this.bunifuCustomLabel8.TabIndex = 26;
            this.bunifuCustomLabel8.Text = "Delivery Status";
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(16, 48);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(94, 16);
            this.bunifuCustomLabel9.TabIndex = 28;
            this.bunifuCustomLabel9.Text = "Purchase Status";
            // 
            // cbbox_purchasestatus
            // 
            this.cbbox_purchasestatus.FormattingEnabled = true;
            this.cbbox_purchasestatus.Location = new System.Drawing.Point(112, 48);
            this.cbbox_purchasestatus.Name = "cbbox_purchasestatus";
            this.cbbox_purchasestatus.Size = new System.Drawing.Size(152, 21);
            this.cbbox_purchasestatus.TabIndex = 27;
            // 
            // cbbox_deliverystaus
            // 
            this.cbbox_deliverystaus.FormattingEnabled = true;
            this.cbbox_deliverystaus.Location = new System.Drawing.Point(112, 24);
            this.cbbox_deliverystaus.Name = "cbbox_deliverystaus";
            this.cbbox_deliverystaus.Size = new System.Drawing.Size(152, 21);
            this.cbbox_deliverystaus.TabIndex = 25;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bunifuCustomLabel7);
            this.groupBox2.Controls.Add(this.cbbox_payment);
            this.groupBox2.Controls.Add(this.bunifuCustomLabel4);
            this.groupBox2.Controls.Add(this.cbbox_paymentstatus);
            this.groupBox2.Location = new System.Drawing.Point(16, 184);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(296, 80);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Payment";
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(16, 48);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(93, 16);
            this.bunifuCustomLabel7.TabIndex = 24;
            this.bunifuCustomLabel7.Text = "Payment Status";
            // 
            // cbbox_payment
            // 
            this.cbbox_payment.FormattingEnabled = true;
            this.cbbox_payment.Location = new System.Drawing.Point(112, 24);
            this.cbbox_payment.Name = "cbbox_payment";
            this.cbbox_payment.Size = new System.Drawing.Size(152, 21);
            this.cbbox_payment.TabIndex = 15;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(8, 24);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(104, 16);
            this.bunifuCustomLabel4.TabIndex = 20;
            this.bunifuCustomLabel4.Text = "Payment Method";
            // 
            // cbbox_paymentstatus
            // 
            this.cbbox_paymentstatus.FormattingEnabled = true;
            this.cbbox_paymentstatus.Location = new System.Drawing.Point(112, 48);
            this.cbbox_paymentstatus.Name = "cbbox_paymentstatus";
            this.cbbox_paymentstatus.Size = new System.Drawing.Size(152, 21);
            this.cbbox_paymentstatus.TabIndex = 23;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtbox_start_order);
            this.groupBox1.Controls.Add(this.txtbox_orderid);
            this.groupBox1.Controls.Add(this.txtbox_clientid);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel2);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel3);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel5);
            this.groupBox1.Controls.Add(this.btn_browse_client);
            this.groupBox1.Controls.Add(this.txtbox_userid);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel1);
            this.groupBox1.Controls.Add(this.txtbox_last_modification);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel6);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 152);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Informations";
            // 
            // txtbox_start_order
            // 
            this.txtbox_start_order.Enabled = false;
            this.txtbox_start_order.Location = new System.Drawing.Point(112, 96);
            this.txtbox_start_order.Name = "txtbox_start_order";
            this.txtbox_start_order.Size = new System.Drawing.Size(152, 21);
            this.txtbox_start_order.TabIndex = 19;
            // 
            // txtbox_orderid
            // 
            this.txtbox_orderid.Enabled = false;
            this.txtbox_orderid.Location = new System.Drawing.Point(112, 24);
            this.txtbox_orderid.Name = "txtbox_orderid";
            this.txtbox_orderid.Size = new System.Drawing.Size(152, 21);
            this.txtbox_orderid.TabIndex = 11;
            // 
            // txtbox_clientid
            // 
            this.txtbox_clientid.Location = new System.Drawing.Point(112, 48);
            this.txtbox_clientid.Name = "txtbox_clientid";
            this.txtbox_clientid.Size = new System.Drawing.Size(152, 21);
            this.txtbox_clientid.TabIndex = 12;
            this.txtbox_clientid.DoubleClick += new System.EventHandler(this.txtbox_clientid_DoubleClick);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(56, 24);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(50, 16);
            this.bunifuCustomLabel2.TabIndex = 13;
            this.bunifuCustomLabel2.Text = "OrderID";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(56, 48);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(50, 16);
            this.bunifuCustomLabel3.TabIndex = 14;
            this.bunifuCustomLabel3.Text = "ClientID";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(8, 120);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(100, 16);
            this.bunifuCustomLabel5.TabIndex = 16;
            this.bunifuCustomLabel5.Text = "Last Modification";
            // 
            // btn_browse_client
            // 
            this.btn_browse_client.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_browse_client.BackColor = System.Drawing.Color.Transparent;
            this.btn_browse_client.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_browse_client.Image = ((System.Drawing.Image)(resources.GetObject("btn_browse_client.Image")));
            this.btn_browse_client.ImageActive = null;
            this.btn_browse_client.Location = new System.Drawing.Point(264, 48);
            this.btn_browse_client.Name = "btn_browse_client";
            this.btn_browse_client.Size = new System.Drawing.Size(24, 24);
            this.btn_browse_client.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_browse_client.TabIndex = 31;
            this.btn_browse_client.TabStop = false;
            this.btn_browse_client.Zoom = 10;
            this.btn_browse_client.Click += new System.EventHandler(this.btn_browse_client_Click);
            // 
            // txtbox_userid
            // 
            this.txtbox_userid.Enabled = false;
            this.txtbox_userid.Location = new System.Drawing.Point(112, 72);
            this.txtbox_userid.Name = "txtbox_userid";
            this.txtbox_userid.Size = new System.Drawing.Size(152, 21);
            this.txtbox_userid.TabIndex = 17;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(64, 72);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(41, 16);
            this.bunifuCustomLabel1.TabIndex = 18;
            this.bunifuCustomLabel1.Text = "UserID";
            // 
            // txtbox_last_modification
            // 
            this.txtbox_last_modification.Enabled = false;
            this.txtbox_last_modification.Location = new System.Drawing.Point(112, 120);
            this.txtbox_last_modification.Name = "txtbox_last_modification";
            this.txtbox_last_modification.Size = new System.Drawing.Size(152, 21);
            this.txtbox_last_modification.TabIndex = 21;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(24, 96);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(80, 16);
            this.bunifuCustomLabel6.TabIndex = 22;
            this.bunifuCustomLabel6.Text = "Order Create";
            // 
            // btn_delete_products
            // 
            this.btn_delete_products.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_delete_products.BackColor = System.Drawing.Color.Transparent;
            this.btn_delete_products.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete_products.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete_products.Image")));
            this.btn_delete_products.ImageActive = null;
            this.btn_delete_products.Location = new System.Drawing.Point(352, 336);
            this.btn_delete_products.Name = "btn_delete_products";
            this.btn_delete_products.Size = new System.Drawing.Size(24, 24);
            this.btn_delete_products.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_delete_products.TabIndex = 36;
            this.btn_delete_products.TabStop = false;
            this.toolTip1.SetToolTip(this.btn_delete_products, "Remove product");
            this.btn_delete_products.Zoom = 10;
            this.btn_delete_products.Click += new System.EventHandler(this.btn_delete_products_Click);
            // 
            // btn_add_product
            // 
            this.btn_add_product.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_add_product.BackColor = System.Drawing.Color.Transparent;
            this.btn_add_product.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_product.Image = ((System.Drawing.Image)(resources.GetObject("btn_add_product.Image")));
            this.btn_add_product.ImageActive = null;
            this.btn_add_product.Location = new System.Drawing.Point(320, 336);
            this.btn_add_product.Name = "btn_add_product";
            this.btn_add_product.Size = new System.Drawing.Size(24, 24);
            this.btn_add_product.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_add_product.TabIndex = 35;
            this.btn_add_product.TabStop = false;
            this.toolTip1.SetToolTip(this.btn_add_product, "Add products");
            this.btn_add_product.Zoom = 10;
            this.btn_add_product.Click += new System.EventHandler(this.btn_add_product_Click);
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel10.AutoSize = true;
            this.bunifuCustomLabel10.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(496, 336);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(37, 16);
            this.bunifuCustomLabel10.TabIndex = 34;
            this.bunifuCustomLabel10.Text = "Total:";
            // 
            // txtbox_totalprice
            // 
            this.txtbox_totalprice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbox_totalprice.Enabled = false;
            this.txtbox_totalprice.Location = new System.Drawing.Point(536, 336);
            this.txtbox_totalprice.Name = "txtbox_totalprice";
            this.txtbox_totalprice.Size = new System.Drawing.Size(104, 20);
            this.txtbox_totalprice.TabIndex = 33;
            this.toolTip1.SetToolTip(this.txtbox_totalprice, "Total Order");
            // 
            // dgv_products
            // 
            this.dgv_products.AllowUserToAddRows = false;
            this.dgv_products.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_products.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_products.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_products.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_products.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv_products.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_products.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_products.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            //this.dgv_products.DoubleBuffered = true;
            this.dgv_products.EnableHeadersVisualStyles = false;
            this.dgv_products.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgv_products.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(31)))));
            this.dgv_products.HeaderForeColor = System.Drawing.Color.White;
            this.dgv_products.Location = new System.Drawing.Point(320, 16);
            this.dgv_products.MultiSelect = false;
            this.dgv_products.Name = "dgv_products";
            this.dgv_products.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_products.Size = new System.Drawing.Size(320, 312);
            this.dgv_products.TabIndex = 32;
            this.dgv_products.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_products_CellClick);
            this.dgv_products.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_products_CellEndEdit);
            this.dgv_products.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgv_products_RowsAdded);
            // 
            // btn_save_order
            // 
            this.btn_save_order.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.btn_save_order.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save_order.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.btn_save_order.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_save_order.BorderRadius = 0;
            this.btn_save_order.ButtonText = "&Save";
            this.btn_save_order.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save_order.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.btn_save_order.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_save_order.Iconimage = null;
            this.btn_save_order.Iconimage_right = null;
            this.btn_save_order.Iconimage_right_Selected = null;
            this.btn_save_order.Iconimage_Selected = null;
            this.btn_save_order.IconMarginLeft = 0;
            this.btn_save_order.IconMarginRight = 0;
            this.btn_save_order.IconRightVisible = false;
            this.btn_save_order.IconRightZoom = 0D;
            this.btn_save_order.IconVisible = false;
            this.btn_save_order.IconZoom = 90D;
            this.btn_save_order.IsTab = false;
            this.btn_save_order.Location = new System.Drawing.Point(512, 376);
            this.btn_save_order.Name = "btn_save_order";
            this.btn_save_order.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.btn_save_order.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(31)))));
            this.btn_save_order.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_save_order.selected = false;
            this.btn_save_order.Size = new System.Drawing.Size(64, 32);
            this.btn_save_order.TabIndex = 29;
            this.btn_save_order.Text = "&Save";
            this.btn_save_order.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_save_order.Textcolor = System.Drawing.Color.White;
            this.btn_save_order.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save_order.Click += new System.EventHandler(this.btn_save_order_Click);
            // 
            // btn_cancel_order
            // 
            this.btn_cancel_order.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.btn_cancel_order.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel_order.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.btn_cancel_order.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cancel_order.BorderRadius = 0;
            this.btn_cancel_order.ButtonText = "&Cancel";
            this.btn_cancel_order.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel_order.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.btn_cancel_order.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_cancel_order.Iconimage = null;
            this.btn_cancel_order.Iconimage_right = null;
            this.btn_cancel_order.Iconimage_right_Selected = null;
            this.btn_cancel_order.Iconimage_Selected = null;
            this.btn_cancel_order.IconMarginLeft = 0;
            this.btn_cancel_order.IconMarginRight = 0;
            this.btn_cancel_order.IconRightVisible = false;
            this.btn_cancel_order.IconRightZoom = 0D;
            this.btn_cancel_order.IconVisible = false;
            this.btn_cancel_order.IconZoom = 90D;
            this.btn_cancel_order.IsTab = false;
            this.btn_cancel_order.Location = new System.Drawing.Point(584, 376);
            this.btn_cancel_order.Name = "btn_cancel_order";
            this.btn_cancel_order.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.btn_cancel_order.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(31)))));
            this.btn_cancel_order.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_cancel_order.selected = false;
            this.btn_cancel_order.Size = new System.Drawing.Size(64, 32);
            this.btn_cancel_order.TabIndex = 30;
            this.btn_cancel_order.Text = "&Cancel";
            this.btn_cancel_order.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_cancel_order.Textcolor = System.Drawing.Color.White;
            this.btn_cancel_order.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel_order.Click += new System.EventHandler(this.btn_cancel_order_Click);
            // 
            // select_client
            // 
            this.select_client.Controls.Add(this.btn_select_client);
            this.select_client.Controls.Add(this.btn_cancel_client);
            this.select_client.Controls.Add(this.dgv_clients_list);
            this.select_client.Controls.Add(this.bunifuCustomLabel11);
            this.select_client.Controls.Add(this.txtbox_search_client);
            this.select_client.Location = new System.Drawing.Point(4, 22);
            this.select_client.Name = "select_client";
            this.select_client.Padding = new System.Windows.Forms.Padding(3);
            this.select_client.Size = new System.Drawing.Size(660, 419);
            this.select_client.TabIndex = 2;
            this.select_client.Text = "Select Client";
            this.select_client.UseVisualStyleBackColor = true;
            // 
            // btn_select_client
            // 
            this.btn_select_client.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.btn_select_client.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_select_client.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.btn_select_client.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_select_client.BorderRadius = 0;
            this.btn_select_client.ButtonText = "&Select";
            this.btn_select_client.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_select_client.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.btn_select_client.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_select_client.Iconimage = null;
            this.btn_select_client.Iconimage_right = null;
            this.btn_select_client.Iconimage_right_Selected = null;
            this.btn_select_client.Iconimage_Selected = null;
            this.btn_select_client.IconMarginLeft = 0;
            this.btn_select_client.IconMarginRight = 0;
            this.btn_select_client.IconRightVisible = false;
            this.btn_select_client.IconRightZoom = 0D;
            this.btn_select_client.IconVisible = false;
            this.btn_select_client.IconZoom = 90D;
            this.btn_select_client.IsTab = false;
            this.btn_select_client.Location = new System.Drawing.Point(512, 376);
            this.btn_select_client.Name = "btn_select_client";
            this.btn_select_client.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.btn_select_client.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(31)))));
            this.btn_select_client.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_select_client.selected = false;
            this.btn_select_client.Size = new System.Drawing.Size(64, 32);
            this.btn_select_client.TabIndex = 34;
            this.btn_select_client.Text = "&Select";
            this.btn_select_client.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_select_client.Textcolor = System.Drawing.Color.White;
            this.btn_select_client.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_select_client.Click += new System.EventHandler(this.btn_select_client_Click);
            // 
            // btn_cancel_client
            // 
            this.btn_cancel_client.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.btn_cancel_client.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel_client.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.btn_cancel_client.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cancel_client.BorderRadius = 0;
            this.btn_cancel_client.ButtonText = "&Cancel";
            this.btn_cancel_client.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel_client.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.btn_cancel_client.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_cancel_client.Iconimage = null;
            this.btn_cancel_client.Iconimage_right = null;
            this.btn_cancel_client.Iconimage_right_Selected = null;
            this.btn_cancel_client.Iconimage_Selected = null;
            this.btn_cancel_client.IconMarginLeft = 0;
            this.btn_cancel_client.IconMarginRight = 0;
            this.btn_cancel_client.IconRightVisible = false;
            this.btn_cancel_client.IconRightZoom = 0D;
            this.btn_cancel_client.IconVisible = false;
            this.btn_cancel_client.IconZoom = 90D;
            this.btn_cancel_client.IsTab = false;
            this.btn_cancel_client.Location = new System.Drawing.Point(584, 376);
            this.btn_cancel_client.Name = "btn_cancel_client";
            this.btn_cancel_client.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.btn_cancel_client.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(31)))));
            this.btn_cancel_client.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_cancel_client.selected = false;
            this.btn_cancel_client.Size = new System.Drawing.Size(64, 32);
            this.btn_cancel_client.TabIndex = 35;
            this.btn_cancel_client.Text = "&Cancel";
            this.btn_cancel_client.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_cancel_client.Textcolor = System.Drawing.Color.White;
            this.btn_cancel_client.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel_client.Click += new System.EventHandler(this.btn_cancel_client_Click);
            // 
            // dgv_clients_list
            // 
            this.dgv_clients_list.AllowUserToAddRows = false;
            this.dgv_clients_list.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_clients_list.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_clients_list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_clients_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_clients_list.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv_clients_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_clients_list.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_clients_list.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_clients_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            //this.dgv_clients_list.DoubleBuffered = true;
            this.dgv_clients_list.EnableHeadersVisualStyles = false;
            this.dgv_clients_list.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgv_clients_list.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(31)))));
            this.dgv_clients_list.HeaderForeColor = System.Drawing.Color.White;
            this.dgv_clients_list.Location = new System.Drawing.Point(16, 48);
            this.dgv_clients_list.MultiSelect = false;
            this.dgv_clients_list.Name = "dgv_clients_list";
            this.dgv_clients_list.ReadOnly = true;
            this.dgv_clients_list.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_clients_list.Size = new System.Drawing.Size(632, 320);
            this.dgv_clients_list.TabIndex = 33;
            this.dgv_clients_list.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_clients_list_CellClick);
            // 
            // bunifuCustomLabel11
            // 
            this.bunifuCustomLabel11.AutoSize = true;
            this.bunifuCustomLabel11.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel11.Location = new System.Drawing.Point(16, 16);
            this.bunifuCustomLabel11.Name = "bunifuCustomLabel11";
            this.bunifuCustomLabel11.Size = new System.Drawing.Size(46, 16);
            this.bunifuCustomLabel11.TabIndex = 31;
            this.bunifuCustomLabel11.Text = "Search";
            // 
            // txtbox_search_client
            // 
            this.txtbox_search_client.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbox_search_client.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_search_client.Location = new System.Drawing.Point(64, 16);
            this.txtbox_search_client.Name = "txtbox_search_client";
            this.txtbox_search_client.Size = new System.Drawing.Size(584, 21);
            this.txtbox_search_client.TabIndex = 30;
            this.txtbox_search_client.TextChanged += new System.EventHandler(this.txtbox_search_client_TextChanged);
            // 
            // select_product
            // 
            this.select_product.Controls.Add(this.btn_select_product);
            this.select_product.Controls.Add(this.btn_cancel_product);
            this.select_product.Controls.Add(this.dgv_products_list);
            this.select_product.Controls.Add(this.bunifuCustomLabel12);
            this.select_product.Controls.Add(this.txtbox_search_products);
            this.select_product.Location = new System.Drawing.Point(4, 22);
            this.select_product.Name = "select_product";
            this.select_product.Padding = new System.Windows.Forms.Padding(3);
            this.select_product.Size = new System.Drawing.Size(660, 419);
            this.select_product.TabIndex = 3;
            this.select_product.Text = "Select Product";
            this.select_product.UseVisualStyleBackColor = true;
            // 
            // btn_select_product
            // 
            this.btn_select_product.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.btn_select_product.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_select_product.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.btn_select_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_select_product.BorderRadius = 0;
            this.btn_select_product.ButtonText = "&Select";
            this.btn_select_product.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_select_product.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.btn_select_product.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_select_product.Iconimage = null;
            this.btn_select_product.Iconimage_right = null;
            this.btn_select_product.Iconimage_right_Selected = null;
            this.btn_select_product.Iconimage_Selected = null;
            this.btn_select_product.IconMarginLeft = 0;
            this.btn_select_product.IconMarginRight = 0;
            this.btn_select_product.IconRightVisible = false;
            this.btn_select_product.IconRightZoom = 0D;
            this.btn_select_product.IconVisible = false;
            this.btn_select_product.IconZoom = 90D;
            this.btn_select_product.IsTab = false;
            this.btn_select_product.Location = new System.Drawing.Point(510, 373);
            this.btn_select_product.Name = "btn_select_product";
            this.btn_select_product.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.btn_select_product.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(31)))));
            this.btn_select_product.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_select_product.selected = false;
            this.btn_select_product.Size = new System.Drawing.Size(64, 32);
            this.btn_select_product.TabIndex = 39;
            this.btn_select_product.Text = "&Select";
            this.btn_select_product.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_select_product.Textcolor = System.Drawing.Color.White;
            this.btn_select_product.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_select_product.Click += new System.EventHandler(this.btn_select_product_Click);
            // 
            // btn_cancel_product
            // 
            this.btn_cancel_product.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.btn_cancel_product.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel_product.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.btn_cancel_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cancel_product.BorderRadius = 0;
            this.btn_cancel_product.ButtonText = "&Cancel";
            this.btn_cancel_product.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel_product.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.btn_cancel_product.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_cancel_product.Iconimage = null;
            this.btn_cancel_product.Iconimage_right = null;
            this.btn_cancel_product.Iconimage_right_Selected = null;
            this.btn_cancel_product.Iconimage_Selected = null;
            this.btn_cancel_product.IconMarginLeft = 0;
            this.btn_cancel_product.IconMarginRight = 0;
            this.btn_cancel_product.IconRightVisible = false;
            this.btn_cancel_product.IconRightZoom = 0D;
            this.btn_cancel_product.IconVisible = false;
            this.btn_cancel_product.IconZoom = 90D;
            this.btn_cancel_product.IsTab = false;
            this.btn_cancel_product.Location = new System.Drawing.Point(582, 373);
            this.btn_cancel_product.Name = "btn_cancel_product";
            this.btn_cancel_product.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.btn_cancel_product.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(31)))));
            this.btn_cancel_product.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_cancel_product.selected = false;
            this.btn_cancel_product.Size = new System.Drawing.Size(64, 32);
            this.btn_cancel_product.TabIndex = 40;
            this.btn_cancel_product.Text = "&Cancel";
            this.btn_cancel_product.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_cancel_product.Textcolor = System.Drawing.Color.White;
            this.btn_cancel_product.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel_product.Click += new System.EventHandler(this.btn_cancel_product_Click);
            // 
            // dgv_products_list
            // 
            this.dgv_products_list.AllowUserToAddRows = false;
            this.dgv_products_list.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_products_list.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_products_list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_products_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_products_list.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv_products_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_products_list.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_products_list.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_products_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            //this.dgv_products_list.DoubleBuffered = true;
            this.dgv_products_list.EnableHeadersVisualStyles = false;
            this.dgv_products_list.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgv_products_list.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(31)))));
            this.dgv_products_list.HeaderForeColor = System.Drawing.Color.White;
            this.dgv_products_list.Location = new System.Drawing.Point(14, 45);
            this.dgv_products_list.MultiSelect = false;
            this.dgv_products_list.Name = "dgv_products_list";
            this.dgv_products_list.ReadOnly = true;
            this.dgv_products_list.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_products_list.Size = new System.Drawing.Size(632, 320);
            this.dgv_products_list.TabIndex = 38;
            this.dgv_products_list.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_products_list_CellClick);
            // 
            // bunifuCustomLabel12
            // 
            this.bunifuCustomLabel12.AutoSize = true;
            this.bunifuCustomLabel12.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel12.Location = new System.Drawing.Point(14, 13);
            this.bunifuCustomLabel12.Name = "bunifuCustomLabel12";
            this.bunifuCustomLabel12.Size = new System.Drawing.Size(46, 16);
            this.bunifuCustomLabel12.TabIndex = 37;
            this.bunifuCustomLabel12.Text = "Search";
            // 
            // txtbox_search_products
            // 
            this.txtbox_search_products.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbox_search_products.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_search_products.Location = new System.Drawing.Point(62, 13);
            this.txtbox_search_products.Name = "txtbox_search_products";
            this.txtbox_search_products.Size = new System.Drawing.Size(584, 21);
            this.txtbox_search_products.TabIndex = 36;
            this.txtbox_search_products.TextChanged += new System.EventHandler(this.txtbox_search_products_TextChanged);
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "Orders";
            this.Size = new System.Drawing.Size(668, 445);
            this.Load += new System.EventHandler(this.Orders_Load);
            this.tabControl1.ResumeLayout(false);
            this.orders_list.ResumeLayout(false);
            this.orders_list.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_orders_list)).EndInit();
            this.new_edit_order.ResumeLayout(false);
            this.new_edit_order.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_browse_client)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_delete_products)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_add_product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_products)).EndInit();
            this.select_client.ResumeLayout(false);
            this.select_client.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clients_list)).EndInit();
            this.select_product.ResumeLayout(false);
            this.select_product.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_products_list)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage orders_list;
        private System.Windows.Forms.TabPage new_edit_order;
        private System.Windows.Forms.TabPage select_client;
        private System.Windows.Forms.TabPage select_product;
        private ns1.BunifuCustomLabel bunifuCustomLabel14;
        private ns1.BunifuCustomDataGrid dgv_orders_list;
        private System.Windows.Forms.TextBox txtbox_search_order;
        private ns1.BunifuFlatButton btn_new_order;
        private ns1.BunifuFlatButton btn_edit_order;
        private ns1.BunifuCustomLabel bunifuCustomLabel3;
        private ns1.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.TextBox txtbox_clientid;
        private System.Windows.Forms.TextBox txtbox_orderid;
        private ns1.BunifuCustomLabel bunifuCustomLabel9;
        private System.Windows.Forms.ComboBox cbbox_purchasestatus;
        private ns1.BunifuCustomLabel bunifuCustomLabel8;
        private System.Windows.Forms.ComboBox cbbox_deliverystaus;
        private ns1.BunifuCustomLabel bunifuCustomLabel7;
        private System.Windows.Forms.ComboBox cbbox_paymentstatus;
        private ns1.BunifuCustomLabel bunifuCustomLabel6;
        private System.Windows.Forms.TextBox txtbox_last_modification;
        private ns1.BunifuCustomLabel bunifuCustomLabel4;
        private System.Windows.Forms.TextBox txtbox_start_order;
        private ns1.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.TextBox txtbox_userid;
        private ns1.BunifuCustomLabel bunifuCustomLabel5;
        private System.Windows.Forms.ComboBox cbbox_payment;
        private ns1.BunifuFlatButton btn_save_order;
        private ns1.BunifuFlatButton btn_cancel_order;
        private ns1.BunifuImageButton btn_browse_client;
        private ns1.BunifuCustomDataGrid dgv_products;
        private ns1.BunifuCustomLabel bunifuCustomLabel10;
        private System.Windows.Forms.TextBox txtbox_totalprice;
        private ns1.BunifuImageButton btn_delete_products;
        private System.Windows.Forms.ToolTip toolTip1;
        private ns1.BunifuImageButton btn_add_product;
        private ns1.BunifuFlatButton btn_select_client;
        private ns1.BunifuFlatButton btn_cancel_client;
        private ns1.BunifuCustomDataGrid dgv_clients_list;
        private ns1.BunifuCustomLabel bunifuCustomLabel11;
        private System.Windows.Forms.TextBox txtbox_search_client;
        private ns1.BunifuFlatButton btn_select_product;
        private ns1.BunifuFlatButton btn_cancel_product;
        private ns1.BunifuCustomDataGrid dgv_products_list;
        private ns1.BunifuCustomLabel bunifuCustomLabel12;
        private System.Windows.Forms.TextBox txtbox_search_products;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
