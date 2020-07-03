namespace KinoZAP
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
            this.Button_Exit = new System.Windows.Forms.Button();
            this.Button_Auth = new System.Windows.Forms.Button();
            this.TextBox_Password = new System.Windows.Forms.TextBox();
            this.Label_Password = new System.Windows.Forms.Label();
            this.TextBox_Login = new System.Windows.Forms.TextBox();
            this.Label_Login = new System.Windows.Forms.Label();
            this.Label_KinoZAP = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Button_Exit
            // 
            this.Button_Exit.BackColor = System.Drawing.Color.Yellow;
            this.Button_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Exit.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Exit.Location = new System.Drawing.Point(372, 199);
            this.Button_Exit.Name = "Button_Exit";
            this.Button_Exit.Size = new System.Drawing.Size(50, 50);
            this.Button_Exit.TabIndex = 0;
            this.Button_Exit.Text = "Выход";
            this.Button_Exit.UseVisualStyleBackColor = true;
            // 
            // Button_Auth
            // 
            this.Button_Auth.BackColor = System.Drawing.Color.Yellow;
            this.Button_Auth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Auth.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Auth.Location = new System.Drawing.Point(142, 144);
            this.Button_Auth.Name = "Button_Auth";
            this.Button_Auth.Size = new System.Drawing.Size(150, 30);
            this.Button_Auth.TabIndex = 1;
            this.Button_Auth.Text = "Авторизоваться";
            this.Button_Auth.UseVisualStyleBackColor = true;
            // 
            // TextBox_Password
            // 
            this.TextBox_Password.Location = new System.Drawing.Point(142, 118);
            this.TextBox_Password.Name = "TextBox_Password";
            this.TextBox_Password.Size = new System.Drawing.Size(150, 20);
            this.TextBox_Password.TabIndex = 2;
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
            this.TextBox_Login.TabIndex = 4;
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
            // Label_KinoZAP
            // 
            this.Label_KinoZAP.AutoSize = true;
            this.Label_KinoZAP.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_KinoZAP.Location = new System.Drawing.Point(153, 31);
            this.Label_KinoZAP.Name = "Label_KinoZAP";
            this.Label_KinoZAP.Size = new System.Drawing.Size(130, 33);
            this.Label_KinoZAP.TabIndex = 6;
            this.Label_KinoZAP.Text = "КиноZAP";
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(434, 261);
            this.Controls.Add(this.Label_KinoZAP);
            this.Controls.Add(this.Label_Login);
            this.Controls.Add(this.TextBox_Login);
            this.Controls.Add(this.Label_Password);
            this.Controls.Add(this.TextBox_Password);
            this.Controls.Add(this.Button_Auth);
            this.Controls.Add(this.Button_Exit);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Authorization";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_Exit;
        private System.Windows.Forms.Button Button_Auth;
        private System.Windows.Forms.TextBox TextBox_Password;
        private System.Windows.Forms.Label Label_Password;
        private System.Windows.Forms.TextBox TextBox_Login;
        private System.Windows.Forms.Label Label_Login;
        private System.Windows.Forms.Label Label_KinoZAP;
    }
}

