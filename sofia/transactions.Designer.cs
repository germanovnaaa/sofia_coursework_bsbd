namespace sofia
{
    partial class transactions
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
            this.id_txt_transaction = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.select_button = new System.Windows.Forms.Button();
            this.update_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.insert_button = new System.Windows.Forms.Button();
            this.transactionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new sofia.Database1DataSet();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactiontypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionsTableAdapter = new sofia.Database1DataSetTableAdapters.transactionsTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.userid_txt_transaction = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cost_txt_transaction = new System.Windows.Forms.TextBox();
            this.transactionsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.transactionsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet1 = new sofia.Database1DataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactiontypeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.useridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionsBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet2 = new sofia.Database1DataSet();
            this.label6 = new System.Windows.Forms.Label();
            this.transdate_trasactions = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.transdate_from = new System.Windows.Forms.DateTimePicker();
            this.transdate_to = new System.Windows.Forms.DateTimePicker();
            this.sum_income = new System.Windows.Forms.Button();
            this.sum_outcome = new System.Windows.Forms.Button();
            this.transactions_box = new System.Windows.Forms.ComboBox();
            this.category_box = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // id_txt_transaction
            // 
            this.id_txt_transaction.Location = new System.Drawing.Point(155, 244);
            this.id_txt_transaction.Margin = new System.Windows.Forms.Padding(4);
            this.id_txt_transaction.Name = "id_txt_transaction";
            this.id_txt_transaction.Size = new System.Drawing.Size(225, 22);
            this.id_txt_transaction.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 298);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 40;
            this.label5.Text = "category";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 247);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 16);
            this.label1.TabIndex = 39;
            this.label1.Text = "id";
            // 
            // select_button
            // 
            this.select_button.BackColor = System.Drawing.Color.White;
            this.select_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.select_button.Location = new System.Drawing.Point(360, 505);
            this.select_button.Margin = new System.Windows.Forms.Padding(4);
            this.select_button.Name = "select_button";
            this.select_button.Size = new System.Drawing.Size(100, 28);
            this.select_button.TabIndex = 38;
            this.select_button.Text = "select";
            this.select_button.UseVisualStyleBackColor = false;
            this.select_button.Click += new System.EventHandler(this.select_button_Click);
            this.select_button.MouseEnter += new System.EventHandler(this.select_button_MouseEnter);
            this.select_button.MouseLeave += new System.EventHandler(this.select_button_MouseLeave);
            // 
            // update_button
            // 
            this.update_button.BackColor = System.Drawing.Color.White;
            this.update_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.update_button.Location = new System.Drawing.Point(252, 505);
            this.update_button.Margin = new System.Windows.Forms.Padding(4);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(100, 28);
            this.update_button.TabIndex = 37;
            this.update_button.Text = "update";
            this.update_button.UseVisualStyleBackColor = false;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            this.update_button.MouseEnter += new System.EventHandler(this.update_button_MouseEnter);
            this.update_button.MouseLeave += new System.EventHandler(this.update_button_MouseLeave);
            // 
            // delete_button
            // 
            this.delete_button.BackColor = System.Drawing.Color.White;
            this.delete_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete_button.Location = new System.Drawing.Point(144, 505);
            this.delete_button.Margin = new System.Windows.Forms.Padding(4);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(100, 28);
            this.delete_button.TabIndex = 36;
            this.delete_button.Text = "delete";
            this.delete_button.UseVisualStyleBackColor = false;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            this.delete_button.MouseEnter += new System.EventHandler(this.delete_button_MouseEnter);
            this.delete_button.MouseLeave += new System.EventHandler(this.delete_button_MouseLeave);
            // 
            // insert_button
            // 
            this.insert_button.BackColor = System.Drawing.Color.White;
            this.insert_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.insert_button.Location = new System.Drawing.Point(36, 505);
            this.insert_button.Margin = new System.Windows.Forms.Padding(4);
            this.insert_button.Name = "insert_button";
            this.insert_button.Size = new System.Drawing.Size(100, 28);
            this.insert_button.TabIndex = 35;
            this.insert_button.Text = "insert";
            this.insert_button.UseVisualStyleBackColor = false;
            this.insert_button.Click += new System.EventHandler(this.insert_button_Click);
            this.insert_button.MouseEnter += new System.EventHandler(this.insert_button_MouseEnter);
            this.insert_button.MouseLeave += new System.EventHandler(this.insert_button_MouseLeave);
            // 
            // transactionsBindingSource
            // 
            this.transactionsBindingSource.DataMember = "transactions";
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.tablesToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(957, 30);
            this.menuStrip1.TabIndex = 33;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(76, 26);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
            this.aboutToolStripMenuItem.Text = "about";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // tablesToolStripMenuItem
            // 
            this.tablesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem,
            this.categoriesToolStripMenuItem,
            this.transactiontypesToolStripMenuItem});
            this.tablesToolStripMenuItem.Name = "tablesToolStripMenuItem";
            this.tablesToolStripMenuItem.Size = new System.Drawing.Size(64, 26);
            this.tablesToolStripMenuItem.Text = "Tables";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.usersToolStripMenuItem.Text = "users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // categoriesToolStripMenuItem
            // 
            this.categoriesToolStripMenuItem.Name = "categoriesToolStripMenuItem";
            this.categoriesToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.categoriesToolStripMenuItem.Text = "categories";
            this.categoriesToolStripMenuItem.Click += new System.EventHandler(this.categoriesToolStripMenuItem_Click);
            // 
            // transactiontypesToolStripMenuItem
            // 
            this.transactiontypesToolStripMenuItem.Name = "transactiontypesToolStripMenuItem";
            this.transactiontypesToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.transactiontypesToolStripMenuItem.Text = "transaction_types";
            this.transactiontypesToolStripMenuItem.Click += new System.EventHandler(this.transactiontypesToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(47, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // transactionsTableAdapter
            // 
            this.transactionsTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(405, 251);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 43;
            this.label2.Text = "transaction type";
            // 
            // userid_txt_transaction
            // 
            this.userid_txt_transaction.Location = new System.Drawing.Point(559, 294);
            this.userid_txt_transaction.Margin = new System.Windows.Forms.Padding(4);
            this.userid_txt_transaction.Name = "userid_txt_transaction";
            this.userid_txt_transaction.Size = new System.Drawing.Size(196, 22);
            this.userid_txt_transaction.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(405, 298);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 46;
            this.label3.Text = "user id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 341);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 16);
            this.label4.TabIndex = 47;
            this.label4.Text = "cost";
            // 
            // cost_txt_transaction
            // 
            this.cost_txt_transaction.Location = new System.Drawing.Point(155, 341);
            this.cost_txt_transaction.Margin = new System.Windows.Forms.Padding(4);
            this.cost_txt_transaction.Name = "cost_txt_transaction";
            this.cost_txt_transaction.Size = new System.Drawing.Size(225, 22);
            this.cost_txt_transaction.TabIndex = 48;
            // 
            // transactionsBindingSource1
            // 
            this.transactionsBindingSource1.DataMember = "transactions";
            this.transactionsBindingSource1.DataSource = this.database1DataSet;
            // 
            // transactionsBindingSource2
            // 
            this.transactionsBindingSource2.DataMember = "transactions";
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Database1DataSet";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.categoryidDataGridViewTextBoxColumn,
            this.transactiontypeidDataGridViewTextBoxColumn,
            this.useridDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.transactionsBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(16, 33);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(898, 185);
            this.dataGridView1.TabIndex = 49;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // categoryidDataGridViewTextBoxColumn
            // 
            this.categoryidDataGridViewTextBoxColumn.DataPropertyName = "category_id";
            this.categoryidDataGridViewTextBoxColumn.HeaderText = "category_id";
            this.categoryidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.categoryidDataGridViewTextBoxColumn.Name = "categoryidDataGridViewTextBoxColumn";
            this.categoryidDataGridViewTextBoxColumn.ReadOnly = true;
            this.categoryidDataGridViewTextBoxColumn.Width = 125;
            // 
            // transactiontypeidDataGridViewTextBoxColumn
            // 
            this.transactiontypeidDataGridViewTextBoxColumn.DataPropertyName = "transaction_type_id";
            this.transactiontypeidDataGridViewTextBoxColumn.HeaderText = "transaction_type_id";
            this.transactiontypeidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.transactiontypeidDataGridViewTextBoxColumn.Name = "transactiontypeidDataGridViewTextBoxColumn";
            this.transactiontypeidDataGridViewTextBoxColumn.ReadOnly = true;
            this.transactiontypeidDataGridViewTextBoxColumn.Width = 125;
            // 
            // useridDataGridViewTextBoxColumn
            // 
            this.useridDataGridViewTextBoxColumn.DataPropertyName = "user_id";
            this.useridDataGridViewTextBoxColumn.HeaderText = "user_id";
            this.useridDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.useridDataGridViewTextBoxColumn.Name = "useridDataGridViewTextBoxColumn";
            this.useridDataGridViewTextBoxColumn.ReadOnly = true;
            this.useridDataGridViewTextBoxColumn.Width = 125;
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "cost";
            this.costDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            this.costDataGridViewTextBoxColumn.ReadOnly = true;
            this.costDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // transactionsBindingSource3
            // 
            this.transactionsBindingSource3.DataMember = "transactions";
            this.transactionsBindingSource3.DataSource = this.database1DataSet2;
            // 
            // database1DataSet2
            // 
            this.database1DataSet2.DataSetName = "Database1DataSet";
            this.database1DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(409, 348);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 16);
            this.label6.TabIndex = 50;
            this.label6.Text = "transaction date";
            // 
            // transdate_trasactions
            // 
            this.transdate_trasactions.Location = new System.Drawing.Point(559, 341);
            this.transdate_trasactions.Margin = new System.Windows.Forms.Padding(4);
            this.transdate_trasactions.Name = "transdate_trasactions";
            this.transdate_trasactions.Size = new System.Drawing.Size(287, 22);
            this.transdate_trasactions.TabIndex = 51;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 401);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 16);
            this.label7.TabIndex = 52;
            this.label7.Text = "select transaction time range";
            // 
            // transdate_from
            // 
            this.transdate_from.Location = new System.Drawing.Point(36, 448);
            this.transdate_from.Margin = new System.Windows.Forms.Padding(4);
            this.transdate_from.Name = "transdate_from";
            this.transdate_from.Size = new System.Drawing.Size(287, 22);
            this.transdate_from.TabIndex = 53;
            // 
            // transdate_to
            // 
            this.transdate_to.Location = new System.Drawing.Point(413, 448);
            this.transdate_to.Margin = new System.Windows.Forms.Padding(4);
            this.transdate_to.Name = "transdate_to";
            this.transdate_to.Size = new System.Drawing.Size(287, 22);
            this.transdate_to.TabIndex = 54;
            // 
            // sum_income
            // 
            this.sum_income.BackColor = System.Drawing.Color.White;
            this.sum_income.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sum_income.Location = new System.Drawing.Point(483, 503);
            this.sum_income.Margin = new System.Windows.Forms.Padding(4);
            this.sum_income.Name = "sum_income";
            this.sum_income.Size = new System.Drawing.Size(219, 28);
            this.sum_income.TabIndex = 55;
            this.sum_income.Text = "sum income for period";
            this.sum_income.UseVisualStyleBackColor = false;
            this.sum_income.Click += new System.EventHandler(this.sum_income_Click);
            this.sum_income.MouseEnter += new System.EventHandler(this.sum_income_MouseEnter);
            this.sum_income.MouseLeave += new System.EventHandler(this.sum_income_MouseLeave);
            // 
            // sum_outcome
            // 
            this.sum_outcome.BackColor = System.Drawing.Color.White;
            this.sum_outcome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sum_outcome.Location = new System.Drawing.Point(709, 503);
            this.sum_outcome.Margin = new System.Windows.Forms.Padding(4);
            this.sum_outcome.Name = "sum_outcome";
            this.sum_outcome.Size = new System.Drawing.Size(219, 28);
            this.sum_outcome.TabIndex = 56;
            this.sum_outcome.Text = "sum outcome for period";
            this.sum_outcome.UseVisualStyleBackColor = false;
            this.sum_outcome.Click += new System.EventHandler(this.sum_outcome_Click);
            this.sum_outcome.MouseEnter += new System.EventHandler(this.sum_outcome_MouseEnter);
            this.sum_outcome.MouseLeave += new System.EventHandler(this.sum_outcome_MouseLeave);
            // 
            // transactions_box
            // 
            this.transactions_box.FormattingEnabled = true;
            this.transactions_box.Items.AddRange(new object[] {
            "income",
            "outcome"});
            this.transactions_box.Location = new System.Drawing.Point(559, 251);
            this.transactions_box.Name = "transactions_box";
            this.transactions_box.Size = new System.Drawing.Size(196, 24);
            this.transactions_box.TabIndex = 57;
            // 
            // category_box
            // 
            this.category_box.FormattingEnabled = true;
            this.category_box.Items.AddRange(new object[] {
            "grocery",
            "transfer",
            "clothes",
            "entertainment",
            "education",
            "other"});
            this.category_box.Location = new System.Drawing.Point(155, 298);
            this.category_box.Name = "category_box";
            this.category_box.Size = new System.Drawing.Size(225, 24);
            this.category_box.TabIndex = 58;
            // 
            // transactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(957, 548);
            this.Controls.Add(this.category_box);
            this.Controls.Add(this.transactions_box);
            this.Controls.Add(this.sum_outcome);
            this.Controls.Add(this.sum_income);
            this.Controls.Add(this.transdate_to);
            this.Controls.Add(this.transdate_from);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.transdate_trasactions);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cost_txt_transaction);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.userid_txt_transaction);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.id_txt_transaction);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.select_button);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.insert_button);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "transactions";
            this.Text = "transactions";
            this.Load += new System.EventHandler(this.transactions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox id_txt_transaction;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button select_button;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button insert_button;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactiontypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource transactionsBindingSource;
        private Database1DataSetTableAdapters.transactionsTableAdapter transactionsTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userid_txt_transaction;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cost_txt_transaction;
        private System.Windows.Forms.BindingSource transactionsBindingSource1;
        private Database1DataSet database1DataSet1;
        private System.Windows.Forms.BindingSource transactionsBindingSource2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Database1DataSet database1DataSet2;
        private System.Windows.Forms.BindingSource transactionsBindingSource3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactiontypeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn useridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker transdate_trasactions;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker transdate_from;
        private System.Windows.Forms.DateTimePicker transdate_to;
        private System.Windows.Forms.Button sum_income;
        private System.Windows.Forms.Button sum_outcome;
        private System.Windows.Forms.ComboBox transactions_box;
        private System.Windows.Forms.ComboBox category_box;
    }
}