namespace Papirus
{
    partial class FormLogin
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
            this.gbLogin = new System.Windows.Forms.GroupBox();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.gbPassword = new System.Windows.Forms.GroupBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.bEnter = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.gbLogin.SuspendLayout();
            this.gbPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.CausesValidation = false;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "Папирус";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbLogin
            // 
            this.gbLogin.Controls.Add(this.tbLogin);
            this.gbLogin.Location = new System.Drawing.Point(12, 86);
            this.gbLogin.Name = "gbLogin";
            this.gbLogin.Size = new System.Drawing.Size(260, 67);
            this.gbLogin.TabIndex = 1;
            this.gbLogin.TabStop = false;
            this.gbLogin.Text = "Логин";
            // 
            // tbLogin
            // 
            this.tbLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLogin.Location = new System.Drawing.Point(17, 29);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(228, 23);
            this.tbLogin.TabIndex = 0;
            // 
            // gbPassword
            // 
            this.gbPassword.Controls.Add(this.tbPassword);
            this.gbPassword.Location = new System.Drawing.Point(12, 179);
            this.gbPassword.Name = "gbPassword";
            this.gbPassword.Size = new System.Drawing.Size(260, 67);
            this.gbPassword.TabIndex = 2;
            this.gbPassword.TabStop = false;
            this.gbPassword.Text = "Пароль";
            // 
            // tbPassword
            // 
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPassword.Location = new System.Drawing.Point(17, 29);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '●';
            this.tbPassword.Size = new System.Drawing.Size(228, 23);
            this.tbPassword.TabIndex = 0;
            // 
            // bEnter
            // 
            this.bEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.bEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEnter.ForeColor = System.Drawing.Color.White;
            this.bEnter.Location = new System.Drawing.Point(12, 289);
            this.bEnter.Name = "bEnter";
            this.bEnter.Size = new System.Drawing.Size(260, 45);
            this.bEnter.TabIndex = 3;
            this.bEnter.Text = "Войти";
            this.bEnter.UseVisualStyleBackColor = false;
            this.bEnter.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Куратор",
            "Модератор",
            "Администратор"});
            this.comboBox1.Location = new System.Drawing.Point(12, 252);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(260, 27);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.Text = "Выберите пользователя";
            // 
            // FormLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(284, 347);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.bEnter);
            this.Controls.Add(this.gbPassword);
            this.Controls.Add(this.gbLogin);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogin";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLogin_FormClosing);
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.gbLogin.ResumeLayout(false);
            this.gbLogin.PerformLayout();
            this.gbPassword.ResumeLayout(false);
            this.gbPassword.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbLogin;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.GroupBox gbPassword;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button bEnter;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

