namespace DinoRemont
{
    partial class Authorization
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
            this.components = new System.ComponentModel.Container();
            this.Button_Auth = new System.Windows.Forms.Button();
            this.TextBox_Password = new System.Windows.Forms.TextBox();
            this.Label_Password = new System.Windows.Forms.Label();
            this.TextBox_Login = new System.Windows.Forms.TextBox();
            this.Label_Login = new System.Windows.Forms.Label();
            this.Label_DinoRemont = new System.Windows.Forms.Label();
            this.checkBox_KnowMe = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Button_Auth
            // 
            this.Button_Auth.BackColor = System.Drawing.Color.Yellow;
            this.Button_Auth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Auth.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Auth.Location = new System.Drawing.Point(142, 144);
            this.Button_Auth.Name = "Button_Auth";
            this.Button_Auth.Size = new System.Drawing.Size(150, 30);
            this.Button_Auth.TabIndex = 3;
            this.Button_Auth.Text = "Авторизоваться";
            this.Button_Auth.UseVisualStyleBackColor = true;
            this.Button_Auth.Click += new System.EventHandler(this.BtEnter_Click);
            // 
            // TextBox_Password
            // 
            this.TextBox_Password.Location = new System.Drawing.Point(142, 118);
            this.TextBox_Password.Name = "TextBox_Password";
            this.TextBox_Password.Size = new System.Drawing.Size(150, 20);
            this.TextBox_Password.TabIndex = 2;
            this.TextBox_Password.UseSystemPasswordChar = true;
            // 
            // Label_Password
            // 
            this.Label_Password.AutoSize = true;
            this.Label_Password.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Password.Location = new System.Drawing.Point(92, 121);
            this.Label_Password.Name = "Label_Password";
            this.Label_Password.Size = new System.Drawing.Size(44, 14);
            this.Label_Password.TabIndex = 3;
            this.Label_Password.Text = "Пароль";
            // 
            // TextBox_Login
            // 
            this.TextBox_Login.Location = new System.Drawing.Point(142, 92);
            this.TextBox_Login.Name = "TextBox_Login";
            this.TextBox_Login.Size = new System.Drawing.Size(150, 20);
            this.TextBox_Login.TabIndex = 1;
            // 
            // Label_Login
            // 
            this.Label_Login.AutoSize = true;
            this.Label_Login.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Login.Location = new System.Drawing.Point(100, 95);
            this.Label_Login.Name = "Label_Login";
            this.Label_Login.Size = new System.Drawing.Size(36, 14);
            this.Label_Login.TabIndex = 5;
            this.Label_Login.Text = "Логин";
            // 
            // Label_DinoRemont
            // 
            this.Label_DinoRemont.AutoSize = true;
            this.Label_DinoRemont.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_DinoRemont.Location = new System.Drawing.Point(136, 35);
            this.Label_DinoRemont.Name = "Label_DinoRemont";
            this.Label_DinoRemont.Size = new System.Drawing.Size(179, 33);
            this.Label_DinoRemont.TabIndex = 6;
            this.Label_DinoRemont.Text = "DinoRemont";
            // 
            // checkBox_KnowMe
            // 
            this.checkBox_KnowMe.AutoSize = true;
            this.checkBox_KnowMe.Location = new System.Drawing.Point(159, 189);
            this.checkBox_KnowMe.Name = "checkBox_KnowMe";
            this.checkBox_KnowMe.Size = new System.Drawing.Size(111, 17);
            this.checkBox_KnowMe.TabIndex = 7;
            this.checkBox_KnowMe.Text = "Запомнить меня";
            this.checkBox_KnowMe.UseVisualStyleBackColor = true;
            this.checkBox_KnowMe.CheckedChanged += new System.EventHandler(this.checkBox_KnowMe_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(434, 261);
            this.Controls.Add(this.checkBox_KnowMe);
            this.Controls.Add(this.Label_DinoRemont);
            this.Controls.Add(this.Label_Login);
            this.Controls.Add(this.TextBox_Login);
            this.Controls.Add(this.Label_Password);
            this.Controls.Add(this.TextBox_Password);
            this.Controls.Add(this.Button_Auth);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Authorization";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DinoRemont";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Authorization_FormClosing);
            this.Load += new System.EventHandler(this.Authorization_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Button_Auth;
        private System.Windows.Forms.TextBox TextBox_Password;
        private System.Windows.Forms.Label Label_Password;
        private System.Windows.Forms.TextBox TextBox_Login;
        private System.Windows.Forms.Label Label_Login;
        private System.Windows.Forms.Label Label_DinoRemont;
        private System.Windows.Forms.CheckBox checkBox_KnowMe;
        private System.Windows.Forms.Timer timer1;
    }
}

