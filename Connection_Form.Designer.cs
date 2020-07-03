namespace DinoRemont
{
    partial class Connection_Form
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
            this.lblServers = new System.Windows.Forms.Label();
            this.cbServers = new System.Windows.Forms.ComboBox();
            this.lblData = new System.Windows.Forms.Label();
            this.cbDatabases = new System.Windows.Forms.ComboBox();
            this.btCheked = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.btConnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblServers
            // 
            this.lblServers.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblServers.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblServers.Location = new System.Drawing.Point(0, 0);
            this.lblServers.Name = "lblServers";
            this.lblServers.Size = new System.Drawing.Size(522, 34);
            this.lblServers.TabIndex = 0;
            this.lblServers.Text = "Название сервера";
            this.lblServers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbServers
            // 
            this.cbServers.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbServers.Enabled = false;
            this.cbServers.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbServers.FormattingEnabled = true;
            this.cbServers.Location = new System.Drawing.Point(0, 34);
            this.cbServers.Name = "cbServers";
            this.cbServers.Size = new System.Drawing.Size(522, 33);
            this.cbServers.TabIndex = 1;
            this.cbServers.SelectedIndexChanged += new System.EventHandler(this.CbServers_SelectedIndexChanged);
            // 
            // lblData
            // 
            this.lblData.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblData.Location = new System.Drawing.Point(0, 67);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(522, 26);
            this.lblData.TabIndex = 2;
            this.lblData.Text = "Название базы данных";
            this.lblData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbDatabases
            // 
            this.cbDatabases.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbDatabases.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDatabases.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbDatabases.FormattingEnabled = true;
            this.cbDatabases.Location = new System.Drawing.Point(0, 93);
            this.cbDatabases.Name = "cbDatabases";
            this.cbDatabases.Size = new System.Drawing.Size(522, 33);
            this.cbDatabases.TabIndex = 3;
            // 
            // btCheked
            // 
            this.btCheked.Dock = System.Windows.Forms.DockStyle.Left;
            this.btCheked.Enabled = false;
            this.btCheked.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btCheked.Location = new System.Drawing.Point(0, 126);
            this.btCheked.Name = "btCheked";
            this.btCheked.Size = new System.Drawing.Size(158, 83);
            this.btCheked.TabIndex = 4;
            this.btCheked.Text = "Проверка подключения";
            this.btCheked.UseVisualStyleBackColor = true;
            this.btCheked.Click += new System.EventHandler(this.BtCheked_Click);
            // 
            // btCancel
            // 
            this.btCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btCancel.Location = new System.Drawing.Point(372, 126);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(150, 83);
            this.btCancel.TabIndex = 5;
            this.btCancel.Text = "Отмена";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.BtCancel_Click);
            // 
            // btConnect
            // 
            this.btConnect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btConnect.Enabled = false;
            this.btConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btConnect.Location = new System.Drawing.Point(158, 126);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(214, 83);
            this.btConnect.TabIndex = 6;
            this.btConnect.Text = "Подключиться";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.BtConnect_Click);
            // 
            // Connection_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 209);
            this.Controls.Add(this.btConnect);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btCheked);
            this.Controls.Add(this.cbDatabases);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.cbServers);
            this.Controls.Add(this.lblServers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Connection_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройка подеключения к источнику данных";
            this.Load += new System.EventHandler(this.Connection_Form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblServers;
        private System.Windows.Forms.ComboBox cbServers;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.ComboBox cbDatabases;
        private System.Windows.Forms.Button btCheked;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btConnect;
    }
}