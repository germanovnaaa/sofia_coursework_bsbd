namespace sofia
{
    partial class auth_form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.auth_login_box = new System.Windows.Forms.TextBox();
            this.auth_pass_box = new System.Windows.Forms.TextBox();
            this.auth_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "password";
            // 
            // auth_login_box
            // 
            this.auth_login_box.Location = new System.Drawing.Point(121, 32);
            this.auth_login_box.Margin = new System.Windows.Forms.Padding(4);
            this.auth_login_box.Name = "auth_login_box";
            this.auth_login_box.Size = new System.Drawing.Size(240, 22);
            this.auth_login_box.TabIndex = 2;
            // 
            // auth_pass_box
            // 
            this.auth_pass_box.Location = new System.Drawing.Point(121, 70);
            this.auth_pass_box.Margin = new System.Windows.Forms.Padding(4);
            this.auth_pass_box.Name = "auth_pass_box";
            this.auth_pass_box.PasswordChar = '*';
            this.auth_pass_box.Size = new System.Drawing.Size(240, 22);
            this.auth_pass_box.TabIndex = 3;
            this.auth_pass_box.UseSystemPasswordChar = true;
            // 
            // auth_button
            // 
            this.auth_button.BackColor = System.Drawing.Color.White;
            this.auth_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.auth_button.Location = new System.Drawing.Point(261, 134);
            this.auth_button.Margin = new System.Windows.Forms.Padding(4);
            this.auth_button.Name = "auth_button";
            this.auth_button.Size = new System.Drawing.Size(100, 28);
            this.auth_button.TabIndex = 4;
            this.auth_button.Text = "sign in";
            this.auth_button.UseVisualStyleBackColor = false;
            this.auth_button.Click += new System.EventHandler(this.auth_button_Click);
            this.auth_button.MouseEnter += new System.EventHandler(this.auth_button_MouseEnter);
            this.auth_button.MouseLeave += new System.EventHandler(this.auth_button_MouseLeave);
            // 
            // auth_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(396, 175);
            this.Controls.Add(this.auth_button);
            this.Controls.Add(this.auth_pass_box);
            this.Controls.Add(this.auth_login_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "auth_form";
            this.Text = "auth";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox auth_login_box;
        private System.Windows.Forms.TextBox auth_pass_box;
        private System.Windows.Forms.Button auth_button;
    }
}

