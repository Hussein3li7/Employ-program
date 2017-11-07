namespace PersonInformation
{
    partial class MyForm
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
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btAdd = new System.Windows.Forms.Button();
            this.btFind = new System.Windows.Forms.Button();
            this.btAll = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this._logo = new System.Windows.Forms.Label();
            this.cbContry = new System.Windows.Forms.ComboBox();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.hide_data_btn = new System.Windows.Forms.Button();
            this.btChoosePhoto = new System.Windows.Forms.Button();
            this.btAllPhoto = new System.Windows.Forms.Button();
            this._openPhoto = new System.Windows.Forms.OpenFileDialog();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this._personPhoto = new System.Windows.Forms.PictureBox();
            this.btn_del = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._personPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(548, 148);
            this.tbID.Margin = new System.Windows.Forms.Padding(0);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(245, 26);
            this.tbID.TabIndex = 0;
            this.ToolTip.SetToolTip(this.tbID, "Put the ID of person here");
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(548, 190);
            this.tbName.Margin = new System.Windows.Forms.Padding(0);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(245, 26);
            this.tbName.TabIndex = 2;
            this.ToolTip.SetToolTip(this.tbName, "Put the Name of person here");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(96)))), ((int)(((byte)(84)))));
            this.label1.Location = new System.Drawing.Point(476, 155);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(96)))), ((int)(((byte)(84)))));
            this.label2.Location = new System.Drawing.Point(476, 193);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(96)))), ((int)(((byte)(84)))));
            this.label3.Location = new System.Drawing.Point(475, 235);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Contry:";
            // 
            // btAdd
            // 
            this.btAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(214)))), ((int)(((byte)(104)))));
            this.btAdd.FlatAppearance.BorderSize = 2;
            this.btAdd.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(214)))), ((int)(((byte)(104)))));
            this.btAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(214)))), ((int)(((byte)(104)))));
            this.btAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdd.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(96)))), ((int)(((byte)(84)))));
            this.btAdd.Location = new System.Drawing.Point(261, 328);
            this.btAdd.Margin = new System.Windows.Forms.Padding(0, 3, 8, 3);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(100, 35);
            this.btAdd.TabIndex = 6;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btFind
            // 
            this.btFind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btFind.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(214)))), ((int)(((byte)(104)))));
            this.btFind.FlatAppearance.BorderSize = 2;
            this.btFind.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(214)))), ((int)(((byte)(104)))));
            this.btFind.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(214)))), ((int)(((byte)(104)))));
            this.btFind.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFind.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFind.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(96)))), ((int)(((byte)(84)))));
            this.btFind.Location = new System.Drawing.Point(495, 328);
            this.btFind.Margin = new System.Windows.Forms.Padding(8, 3, 8, 3);
            this.btFind.Name = "btFind";
            this.btFind.Size = new System.Drawing.Size(100, 35);
            this.btFind.TabIndex = 7;
            this.btFind.Text = "Find";
            this.btFind.UseVisualStyleBackColor = true;
            this.btFind.Click += new System.EventHandler(this.btFind_Click);
            // 
            // btAll
            // 
            this.btAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(214)))), ((int)(((byte)(104)))));
            this.btAll.FlatAppearance.BorderSize = 2;
            this.btAll.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(214)))), ((int)(((byte)(104)))));
            this.btAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(214)))), ((int)(((byte)(104)))));
            this.btAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAll.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(96)))), ((int)(((byte)(84)))));
            this.btAll.Location = new System.Drawing.Point(611, 328);
            this.btAll.Margin = new System.Windows.Forms.Padding(8, 3, 8, 3);
            this.btAll.Name = "btAll";
            this.btAll.Size = new System.Drawing.Size(100, 35);
            this.btAll.TabIndex = 8;
            this.btAll.Text = "All";
            this.btAll.UseVisualStyleBackColor = true;
            this.btAll.Click += new System.EventHandler(this.btAll_Click);
            // 
            // btExit
            // 
            this.btExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(214)))), ((int)(((byte)(104)))));
            this.btExit.FlatAppearance.BorderSize = 2;
            this.btExit.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(214)))), ((int)(((byte)(104)))));
            this.btExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(214)))), ((int)(((byte)(104)))));
            this.btExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(96)))), ((int)(((byte)(84)))));
            this.btExit.Location = new System.Drawing.Point(843, 328);
            this.btExit.Margin = new System.Windows.Forms.Padding(8, 3, 8, 3);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(100, 35);
            this.btExit.TabIndex = 9;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // _logo
            // 
            this._logo.AutoSize = true;
            this._logo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._logo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(214)))), ((int)(((byte)(104)))));
            this._logo.Location = new System.Drawing.Point(284, 41);
            this._logo.Name = "_logo";
            this._logo.Size = new System.Drawing.Size(270, 55);
            this._logo.TabIndex = 10;
            this._logo.Text = "Person Info";
            // 
            // cbContry
            // 
            this.cbContry.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbContry.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbContry.FormattingEnabled = true;
            this.cbContry.Items.AddRange(new object[] {
            "Iraq",
            "Egypt",
            "UAE",
            "My Heart"});
            this.cbContry.Location = new System.Drawing.Point(548, 232);
            this.cbContry.Name = "cbContry";
            this.cbContry.Size = new System.Drawing.Size(245, 26);
            this.cbContry.TabIndex = 11;
            this.ToolTip.SetToolTip(this.cbContry, "Choose a Contry");
            // 
            // ToolTip
            // 
            this.ToolTip.IsBalloon = true;
            this.ToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ToolTip.ToolTipTitle = "Note";
            // 
            // hide_data_btn
            // 
            this.hide_data_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hide_data_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(214)))), ((int)(((byte)(104)))));
            this.hide_data_btn.FlatAppearance.BorderSize = 2;
            this.hide_data_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(214)))), ((int)(((byte)(104)))));
            this.hide_data_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(214)))), ((int)(((byte)(104)))));
            this.hide_data_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.hide_data_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hide_data_btn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hide_data_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(96)))), ((int)(((byte)(84)))));
            this.hide_data_btn.Location = new System.Drawing.Point(17, 649);
            this.hide_data_btn.Margin = new System.Windows.Forms.Padding(8, 3, 8, 3);
            this.hide_data_btn.Name = "hide_data_btn";
            this.hide_data_btn.Size = new System.Drawing.Size(1074, 68);
            this.hide_data_btn.TabIndex = 18;
            this.hide_data_btn.Text = "Click Her To Hide The Data";
            this.ToolTip.SetToolTip(this.hide_data_btn, "Hide The Data");
            this.hide_data_btn.UseVisualStyleBackColor = true;
            this.hide_data_btn.Click += new System.EventHandler(this.hide_data_btn_Click);
            // 
            // btChoosePhoto
            // 
            this.btChoosePhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btChoosePhoto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(214)))), ((int)(((byte)(104)))));
            this.btChoosePhoto.FlatAppearance.BorderSize = 2;
            this.btChoosePhoto.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(214)))), ((int)(((byte)(104)))));
            this.btChoosePhoto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(214)))), ((int)(((byte)(104)))));
            this.btChoosePhoto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btChoosePhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btChoosePhoto.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btChoosePhoto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(96)))), ((int)(((byte)(84)))));
            this.btChoosePhoto.Location = new System.Drawing.Point(285, 268);
            this.btChoosePhoto.Margin = new System.Windows.Forms.Padding(8);
            this.btChoosePhoto.Name = "btChoosePhoto";
            this.btChoosePhoto.Size = new System.Drawing.Size(133, 35);
            this.btChoosePhoto.TabIndex = 14;
            this.btChoosePhoto.Text = "Chose Photo";
            this.btChoosePhoto.UseVisualStyleBackColor = true;
            this.btChoosePhoto.Click += new System.EventHandler(this.btChoosePhoto_Click);
            // 
            // btAllPhoto
            // 
            this.btAllPhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAllPhoto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(214)))), ((int)(((byte)(104)))));
            this.btAllPhoto.FlatAppearance.BorderSize = 2;
            this.btAllPhoto.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(214)))), ((int)(((byte)(104)))));
            this.btAllPhoto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(214)))), ((int)(((byte)(104)))));
            this.btAllPhoto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btAllPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAllPhoto.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAllPhoto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(96)))), ((int)(((byte)(84)))));
            this.btAllPhoto.Location = new System.Drawing.Point(727, 328);
            this.btAllPhoto.Margin = new System.Windows.Forms.Padding(8, 3, 8, 3);
            this.btAllPhoto.Name = "btAllPhoto";
            this.btAllPhoto.Size = new System.Drawing.Size(100, 35);
            this.btAllPhoto.TabIndex = 15;
            this.btAllPhoto.Text = "All Photo";
            this.btAllPhoto.UseVisualStyleBackColor = true;
            this.btAllPhoto.Click += new System.EventHandler(this.btAllPhoto_Click);
            // 
            // _openPhoto
            // 
            this._openPhoto.InitialDirectory = "Desktop";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(111, 48);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.aboutToolStripMenuItem.Text = "About ";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(214)))), ((int)(((byte)(104)))));
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(214)))), ((int)(((byte)(104)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(214)))), ((int)(((byte)(104)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(96)))), ((int)(((byte)(84)))));
            this.button1.Location = new System.Drawing.Point(725, 50);
            this.button1.Margin = new System.Windows.Forms.Padding(0, 3, 8, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 35);
            this.button1.TabIndex = 16;
            this.button1.Text = "Test database";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.Location = new System.Drawing.Point(0, 412);
            this.dataGridView1.MaximumSize = new System.Drawing.Size(1109, 231);
            this.dataGridView1.MinimumSize = new System.Drawing.Size(1109, 231);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1109, 231);
            this.dataGridView1.TabIndex = 17;
            // 
            // _personPhoto
            // 
            this._personPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._personPhoto.Location = new System.Drawing.Point(285, 130);
            this._personPhoto.Name = "_personPhoto";
            this._personPhoto.Size = new System.Drawing.Size(133, 127);
            this._personPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._personPhoto.TabIndex = 13;
            this._personPhoto.TabStop = false;
            this._personPhoto.Click += new System.EventHandler(this._personPhoto_Click);
            // 
            // btn_del
            // 
            this.btn_del.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_del.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(214)))), ((int)(((byte)(104)))));
            this.btn_del.FlatAppearance.BorderSize = 2;
            this.btn_del.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(214)))), ((int)(((byte)(104)))));
            this.btn_del.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(214)))), ((int)(((byte)(104)))));
            this.btn_del.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_del.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_del.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(96)))), ((int)(((byte)(84)))));
            this.btn_del.Location = new System.Drawing.Point(379, 328);
            this.btn_del.Margin = new System.Windows.Forms.Padding(8, 3, 8, 3);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(100, 35);
            this.btn_del.TabIndex = 19;
            this.btn_del.Text = "Delete";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1108, 406);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.hide_data_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btAllPhoto);
            this.Controls.Add(this.btChoosePhoto);
            this.Controls.Add(this._personPhoto);
            this.Controls.Add(this.cbContry);
            this.Controls.Add(this._logo);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btAll);
            this.Controls.Add(this.btFind);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbID);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Data";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MyForm_FormClosing);
            this.Load += new System.EventHandler(this.MyForm_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._personPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btFind;
        private System.Windows.Forms.Button btAll;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Label _logo;
        private System.Windows.Forms.ComboBox cbContry;
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.PictureBox _personPhoto;
        private System.Windows.Forms.Button btChoosePhoto;
        private System.Windows.Forms.Button btAllPhoto;
        private System.Windows.Forms.OpenFileDialog _openPhoto;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button hide_data_btn;
        private System.Windows.Forms.Button btn_del;
    }
}

