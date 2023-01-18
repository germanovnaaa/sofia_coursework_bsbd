﻿namespace sofia
{
    partial class categories
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionsTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new sofia.Database1DataSet();
            this.categoriesTableAdapter = new sofia.Database1DataSetTableAdapters.categoriesTableAdapter();
            this.select_button = new System.Windows.Forms.Button();
            this.update_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.insert_button = new System.Windows.Forms.Button();
            this.category_txt_cat = new System.Windows.Forms.ComboBox();
            this.id_txt_cat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.categoriesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categorynameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet1 = new sofia.Database1DataSet();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            this.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(508, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
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
            this.transactionsTypesToolStripMenuItem,
            this.transactionToolStripMenuItem});
            this.tablesToolStripMenuItem.Name = "tablesToolStripMenuItem";
            this.tablesToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.tablesToolStripMenuItem.Text = "Tables";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.usersToolStripMenuItem.Text = "users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // transactionsTypesToolStripMenuItem
            // 
            this.transactionsTypesToolStripMenuItem.Name = "transactionsTypesToolStripMenuItem";
            this.transactionsTypesToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.transactionsTypesToolStripMenuItem.Text = "transactions types";
            this.transactionsTypesToolStripMenuItem.Click += new System.EventHandler(this.transactionsTypesToolStripMenuItem_Click);
            // 
            // transactionToolStripMenuItem
            // 
            this.transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            this.transactionToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.transactionToolStripMenuItem.Text = "transaction";
            this.transactionToolStripMenuItem.Click += new System.EventHandler(this.transactionToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "categories";
            this.categoriesBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // select_button
            // 
            this.select_button.BackColor = System.Drawing.Color.White;
            this.select_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.select_button.Location = new System.Drawing.Point(340, 352);
            this.select_button.Margin = new System.Windows.Forms.Padding(4);
            this.select_button.Name = "select_button";
            this.select_button.Size = new System.Drawing.Size(100, 28);
            this.select_button.TabIndex = 9;
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
            this.update_button.Location = new System.Drawing.Point(232, 352);
            this.update_button.Margin = new System.Windows.Forms.Padding(4);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(100, 28);
            this.update_button.TabIndex = 8;
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
            this.delete_button.Location = new System.Drawing.Point(124, 352);
            this.delete_button.Margin = new System.Windows.Forms.Padding(4);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(100, 28);
            this.delete_button.TabIndex = 7;
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
            this.insert_button.Location = new System.Drawing.Point(16, 352);
            this.insert_button.Margin = new System.Windows.Forms.Padding(4);
            this.insert_button.Name = "insert_button";
            this.insert_button.Size = new System.Drawing.Size(100, 28);
            this.insert_button.TabIndex = 6;
            this.insert_button.Text = "insert";
            this.insert_button.UseVisualStyleBackColor = false;
            this.insert_button.Click += new System.EventHandler(this.insert_button_Click);
            this.insert_button.MouseEnter += new System.EventHandler(this.insert_button_MouseEnter);
            this.insert_button.MouseLeave += new System.EventHandler(this.insert_button_MouseLeave);
            // 
            // category_txt_cat
            // 
            this.category_txt_cat.FormattingEnabled = true;
            this.category_txt_cat.Items.AddRange(new object[] {
            "grocery",
            "transfer",
            "clothes",
            "entertainment",
            "education",
            "transport",
            "other"});
            this.category_txt_cat.Location = new System.Drawing.Point(111, 293);
            this.category_txt_cat.Margin = new System.Windows.Forms.Padding(4);
            this.category_txt_cat.Name = "category_txt_cat";
            this.category_txt_cat.Size = new System.Drawing.Size(229, 24);
            this.category_txt_cat.TabIndex = 23;
            // 
            // id_txt_cat
            // 
            this.id_txt_cat.Location = new System.Drawing.Point(115, 249);
            this.id_txt_cat.Margin = new System.Windows.Forms.Padding(4);
            this.id_txt_cat.Name = "id_txt_cat";
            this.id_txt_cat.Size = new System.Drawing.Size(225, 22);
            this.id_txt_cat.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 303);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "category";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 252);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "id";
            // 
            // categoriesBindingSource1
            // 
            this.categoriesBindingSource1.DataMember = "categories";
            this.categoriesBindingSource1.DataSource = this.database1DataSet;
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
            this.categorynameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.categoriesBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(17, 34);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(478, 185);
            this.dataGridView1.TabIndex = 24;
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
            // categorynameDataGridViewTextBoxColumn
            // 
            this.categorynameDataGridViewTextBoxColumn.DataPropertyName = "category_name";
            this.categorynameDataGridViewTextBoxColumn.HeaderText = "category_name";
            this.categorynameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.categorynameDataGridViewTextBoxColumn.Name = "categorynameDataGridViewTextBoxColumn";
            this.categorynameDataGridViewTextBoxColumn.ReadOnly = true;
            this.categorynameDataGridViewTextBoxColumn.Width = 125;
            // 
            // categoriesBindingSource2
            // 
            this.categoriesBindingSource2.DataMember = "categories";
            this.categoriesBindingSource2.DataSource = this.database1DataSet1;
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Database1DataSet";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(508, 416);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.category_txt_cat);
            this.Controls.Add(this.id_txt_cat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.select_button);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.insert_button);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "categories";
            this.Text = "categories";
            this.Load += new System.EventHandler(this.categories_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionsTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private Database1DataSetTableAdapters.categoriesTableAdapter categoriesTableAdapter;
        private System.Windows.Forms.Button select_button;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button insert_button;
        private System.Windows.Forms.ComboBox category_txt_cat;
        private System.Windows.Forms.TextBox id_txt_cat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource categoriesBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Database1DataSet database1DataSet1;
        private System.Windows.Forms.BindingSource categoriesBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categorynameDataGridViewTextBoxColumn;
    }
}