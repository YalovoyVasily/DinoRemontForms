namespace DinoRemont
{
    partial class Account
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
            this.CheckBox_Filter = new System.Windows.Forms.CheckBox();
            this.TextBox_Search = new System.Windows.Forms.TextBox();
            this.Button_Search = new System.Windows.Forms.Button();
            this.ListBox_Employee = new System.Windows.Forms.ListBox();
            this.Button_Exit = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbLast_Name = new System.Windows.Forms.TextBox();
            this.Button_Add = new System.Windows.Forms.Button();
            this.Button_Delete = new System.Windows.Forms.Button();
            this.Button_Correct = new System.Windows.Forms.Button();
            this.Label_Employee = new System.Windows.Forms.Label();
            this.DataGridView_Employee = new System.Windows.Forms.DataGridView();
            this.Button_Print = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Employee)).BeginInit();
            this.SuspendLayout();
            // 
            // CheckBox_Filter
            // 
            this.CheckBox_Filter.AutoSize = true;
            this.CheckBox_Filter.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckBox_Filter.Location = new System.Drawing.Point(12, 466);
            this.CheckBox_Filter.Name = "CheckBox_Filter";
            this.CheckBox_Filter.Size = new System.Drawing.Size(110, 20);
            this.CheckBox_Filter.TabIndex = 22;
            this.CheckBox_Filter.Text = "Отфильтровать";
            this.CheckBox_Filter.UseVisualStyleBackColor = true;
            this.CheckBox_Filter.CheckedChanged += new System.EventHandler(this.CheckBox_Filter_CheckedChanged);
            // 
            // TextBox_Search
            // 
            this.TextBox_Search.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBox_Search.Location = new System.Drawing.Point(12, 372);
            this.TextBox_Search.Name = "TextBox_Search";
            this.TextBox_Search.Size = new System.Drawing.Size(214, 29);
            this.TextBox_Search.TabIndex = 21;
            this.TextBox_Search.TextChanged += new System.EventHandler(this.TextBox_Search_TextChanged);
            // 
            // Button_Search
            // 
            this.Button_Search.Font = new System.Drawing.Font("Microsoft YaHei", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Search.Location = new System.Drawing.Point(12, 313);
            this.Button_Search.Name = "Button_Search";
            this.Button_Search.Size = new System.Drawing.Size(214, 53);
            this.Button_Search.TabIndex = 20;
            this.Button_Search.Text = "Поиск";
            this.Button_Search.UseVisualStyleBackColor = true;
            this.Button_Search.Click += new System.EventHandler(this.Button_Search_Click);
            // 
            // ListBox_Employee
            // 
            this.ListBox_Employee.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListBox_Employee.FormattingEnabled = true;
            this.ListBox_Employee.ItemHeight = 20;
            this.ListBox_Employee.Items.AddRange(new object[] {
            "Таблица должностей",
            "Таблица сотрудников",
            "Таблица заказов",
            "Таблица банков",
            "Таблица поставщиков",
            "Таблица аккаунтов"});
            this.ListBox_Employee.Location = new System.Drawing.Point(12, 63);
            this.ListBox_Employee.Name = "ListBox_Employee";
            this.ListBox_Employee.Size = new System.Drawing.Size(214, 244);
            this.ListBox_Employee.TabIndex = 19;
            this.ListBox_Employee.SelectedIndexChanged += new System.EventHandler(this.ListBox_Employee_SelectedIndexChanged);
            // 
            // Button_Exit
            // 
            this.Button_Exit.Font = new System.Drawing.Font("Microsoft YaHei", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Exit.Location = new System.Drawing.Point(12, 499);
            this.Button_Exit.Name = "Button_Exit";
            this.Button_Exit.Size = new System.Drawing.Size(100, 50);
            this.Button_Exit.TabIndex = 18;
            this.Button_Exit.Text = "Выход";
            this.Button_Exit.UseVisualStyleBackColor = true;
            this.Button_Exit.Click += new System.EventHandler(this.Button_Exit_Click);
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbName.Location = new System.Drawing.Point(644, 447);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(228, 29);
            this.tbName.TabIndex = 17;
            // 
            // tbLast_Name
            // 
            this.tbLast_Name.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLast_Name.Location = new System.Drawing.Point(407, 447);
            this.tbLast_Name.Name = "tbLast_Name";
            this.tbLast_Name.Size = new System.Drawing.Size(228, 29);
            this.tbLast_Name.TabIndex = 16;
            // 
            // Button_Add
            // 
            this.Button_Add.Font = new System.Drawing.Font("Microsoft YaHei", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Add.Location = new System.Drawing.Point(407, 367);
            this.Button_Add.Name = "Button_Add";
            this.Button_Add.Size = new System.Drawing.Size(150, 74);
            this.Button_Add.TabIndex = 12;
            this.Button_Add.Text = "Добавить";
            this.Button_Add.UseVisualStyleBackColor = true;
            this.Button_Add.Click += new System.EventHandler(this.Button_Add_Click);
            // 
            // Button_Delete
            // 
            this.Button_Delete.Font = new System.Drawing.Font("Microsoft YaHei", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Delete.Location = new System.Drawing.Point(722, 367);
            this.Button_Delete.Name = "Button_Delete";
            this.Button_Delete.Size = new System.Drawing.Size(150, 74);
            this.Button_Delete.TabIndex = 15;
            this.Button_Delete.Text = "Удалить";
            this.Button_Delete.UseVisualStyleBackColor = true;
            this.Button_Delete.Click += new System.EventHandler(this.Button_Delete_Click);
            // 
            // Button_Correct
            // 
            this.Button_Correct.Font = new System.Drawing.Font("Microsoft YaHei", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Correct.Location = new System.Drawing.Point(563, 367);
            this.Button_Correct.Name = "Button_Correct";
            this.Button_Correct.Size = new System.Drawing.Size(153, 74);
            this.Button_Correct.TabIndex = 14;
            this.Button_Correct.Text = "Изменить";
            this.Button_Correct.UseVisualStyleBackColor = true;
            this.Button_Correct.Click += new System.EventHandler(this.Button_Correct_Click);
            // 
            // Label_Employee
            // 
            this.Label_Employee.AutoSize = true;
            this.Label_Employee.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Employee.Location = new System.Drawing.Point(224, 10);
            this.Label_Employee.Name = "Label_Employee";
            this.Label_Employee.Size = new System.Drawing.Size(402, 49);
            this.Label_Employee.TabIndex = 13;
            this.Label_Employee.Text = "Таблица аккаунтов";
            // 
            // DataGridView_Employee
            // 
            this.DataGridView_Employee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DataGridView_Employee.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGridView_Employee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_Employee.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DataGridView_Employee.Location = new System.Drawing.Point(407, 63);
            this.DataGridView_Employee.Name = "DataGridView_Employee";
            this.DataGridView_Employee.ReadOnly = true;
            this.DataGridView_Employee.Size = new System.Drawing.Size(465, 298);
            this.DataGridView_Employee.TabIndex = 11;
            this.DataGridView_Employee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_Employee_CellClick);
            this.DataGridView_Employee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_Employee_CellContentClick);
            // 
            // Button_Print
            // 
            this.Button_Print.Font = new System.Drawing.Font("Microsoft YaHei", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Print.Location = new System.Drawing.Point(12, 407);
            this.Button_Print.Name = "Button_Print";
            this.Button_Print.Size = new System.Drawing.Size(214, 53);
            this.Button_Print.TabIndex = 27;
            this.Button_Print.Text = "Doc документ";
            this.Button_Print.UseVisualStyleBackColor = true;
            this.Button_Print.Click += new System.EventHandler(this.Button_Print_Click);
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.Button_Print);
            this.Controls.Add(this.CheckBox_Filter);
            this.Controls.Add(this.TextBox_Search);
            this.Controls.Add(this.Button_Search);
            this.Controls.Add(this.ListBox_Employee);
            this.Controls.Add(this.Button_Exit);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbLast_Name);
            this.Controls.Add(this.Button_Add);
            this.Controls.Add(this.Button_Delete);
            this.Controls.Add(this.Button_Correct);
            this.Controls.Add(this.Label_Employee);
            this.Controls.Add(this.DataGridView_Employee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Account";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DinoRemont";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Employee_FormClosing);
            this.Load += new System.EventHandler(this.Employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Employee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CheckBox_Filter;
        private System.Windows.Forms.TextBox TextBox_Search;
        private System.Windows.Forms.Button Button_Search;
        private System.Windows.Forms.ListBox ListBox_Employee;
        private System.Windows.Forms.Button Button_Exit;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbLast_Name;
        private System.Windows.Forms.Button Button_Add;
        private System.Windows.Forms.Button Button_Delete;
        private System.Windows.Forms.Button Button_Correct;
        private System.Windows.Forms.Label Label_Employee;
        private System.Windows.Forms.DataGridView DataGridView_Employee;
        private System.Windows.Forms.Button Button_Print;
    }
}