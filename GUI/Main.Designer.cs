namespace GUI
{
    partial class Main
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
            this.panelLeftMenu = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblNameApp = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.panelSelectedButton = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnExchange = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.btnSubmitStock = new System.Windows.Forms.Button();
            this.btnCash = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.panelLeftMenu.SuspendLayout();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeftMenu
            // 
            this.panelLeftMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelLeftMenu.Controls.Add(this.btnExchange);
            this.panelLeftMenu.Controls.Add(this.btnStock);
            this.panelLeftMenu.Controls.Add(this.btnSubmitStock);
            this.panelLeftMenu.Controls.Add(this.btnCash);
            this.panelLeftMenu.Controls.Add(this.btnCustomer);
            this.panelLeftMenu.Controls.Add(this.labelVersion);
            this.panelLeftMenu.Controls.Add(this.lblNameApp);
            this.panelLeftMenu.Controls.Add(this.pictureBoxIcon);
            this.panelLeftMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftMenu.Location = new System.Drawing.Point(0, 0);
            this.panelLeftMenu.Name = "panelLeftMenu";
            this.panelLeftMenu.Size = new System.Drawing.Size(165, 512);
            this.panelLeftMenu.TabIndex = 0;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.DimGray;
            this.panelTop.Controls.Add(this.btnMinimize);
            this.panelTop.Controls.Add(this.btnClose);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(165, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(733, 72);
            this.panelTop.TabIndex = 1;
            // 
            // lblNameApp
            // 
            this.lblNameApp.AutoSize = true;
            this.lblNameApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameApp.ForeColor = System.Drawing.Color.White;
            this.lblNameApp.Location = new System.Drawing.Point(42, 4);
            this.lblNameApp.Name = "lblNameApp";
            this.lblNameApp.Size = new System.Drawing.Size(119, 17);
            this.lblNameApp.TabIndex = 2;
            this.lblNameApp.Text = "Credit Manager";
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.ForeColor = System.Drawing.Color.White;
            this.labelVersion.Location = new System.Drawing.Point(59, 28);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(63, 13);
            this.labelVersion.TabIndex = 2;
            this.labelVersion.Text = "v1.0 (64 bit)";
            // 
            // panelSelectedButton
            // 
            this.panelSelectedButton.BackColor = System.Drawing.Color.LightGreen;
            this.panelSelectedButton.Location = new System.Drawing.Point(165, 72);
            this.panelSelectedButton.Name = "panelSelectedButton";
            this.panelSelectedButton.Size = new System.Drawing.Size(5, 45);
            this.panelSelectedButton.TabIndex = 2;
            // 
            // btnMinimize
            // 
            this.btnMinimize.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = global::GUI.Properties.Resources.Minimize_Window_24px;
            this.btnMinimize.Location = new System.Drawing.Point(675, -5);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(30, 38);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::GUI.Properties.Resources.Close_Window_24px;
            this.btnClose.Location = new System.Drawing.Point(702, -5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 38);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnExchange
            // 
            this.btnExchange.FlatAppearance.BorderSize = 0;
            this.btnExchange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExchange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExchange.ForeColor = System.Drawing.Color.White;
            this.btnExchange.Image = global::GUI.Properties.Resources.Exchange_48px;
            this.btnExchange.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExchange.Location = new System.Drawing.Point(0, 337);
            this.btnExchange.Name = "btnExchange";
            this.btnExchange.Size = new System.Drawing.Size(165, 60);
            this.btnExchange.TabIndex = 2;
            this.btnExchange.Text = "     Exchange";
            this.btnExchange.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExchange.UseVisualStyleBackColor = true;
            this.btnExchange.Click += new System.EventHandler(this.btnExchange_Click);
            // 
            // btnStock
            // 
            this.btnStock.FlatAppearance.BorderSize = 0;
            this.btnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStock.ForeColor = System.Drawing.Color.White;
            this.btnStock.Image = global::GUI.Properties.Resources.Profit_48px;
            this.btnStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStock.Location = new System.Drawing.Point(0, 271);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(165, 60);
            this.btnStock.TabIndex = 2;
            this.btnStock.Text = "     Stock";
            this.btnStock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStock.UseVisualStyleBackColor = true;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // btnSubmitStock
            // 
            this.btnSubmitStock.FlatAppearance.BorderSize = 0;
            this.btnSubmitStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitStock.ForeColor = System.Drawing.Color.White;
            this.btnSubmitStock.Image = global::GUI.Properties.Resources.Receive_Cash_48px;
            this.btnSubmitStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubmitStock.Location = new System.Drawing.Point(0, 205);
            this.btnSubmitStock.Name = "btnSubmitStock";
            this.btnSubmitStock.Size = new System.Drawing.Size(165, 60);
            this.btnSubmitStock.TabIndex = 2;
            this.btnSubmitStock.Text = "    Submit Stock";
            this.btnSubmitStock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSubmitStock.UseVisualStyleBackColor = true;
            this.btnSubmitStock.Click += new System.EventHandler(this.btnSubmitStock_Click);
            // 
            // btnCash
            // 
            this.btnCash.FlatAppearance.BorderSize = 0;
            this.btnCash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCash.ForeColor = System.Drawing.Color.White;
            this.btnCash.Image = global::GUI.Properties.Resources.Money_Bag_48px;
            this.btnCash.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCash.Location = new System.Drawing.Point(0, 139);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(165, 60);
            this.btnCash.TabIndex = 2;
            this.btnCash.Text = "     Cash";
            this.btnCash.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCash.UseVisualStyleBackColor = true;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.FlatAppearance.BorderSize = 0;
            this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.ForeColor = System.Drawing.Color.White;
            this.btnCustomer.Image = global::GUI.Properties.Resources.Customer_48px;
            this.btnCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomer.Location = new System.Drawing.Point(0, 73);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(165, 60);
            this.btnCustomer.TabIndex = 2;
            this.btnCustomer.Text = "     Customer";
            this.btnCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.Image = global::GUI.Properties.Resources.Rent_96px;
            this.pictureBoxIcon.Location = new System.Drawing.Point(1, 1);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(56, 70);
            this.pictureBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxIcon.TabIndex = 2;
            this.pictureBoxIcon.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 512);
            this.Controls.Add(this.panelSelectedButton);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelLeftMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.panelLeftMenu.ResumeLayout(false);
            this.panelLeftMenu.PerformLayout();
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeftMenu;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.PictureBox pictureBoxIcon;
        private System.Windows.Forms.Label lblNameApp;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.Panel panelSelectedButton;
        private System.Windows.Forms.Button btnSubmitStock;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Button btnExchange;
    }
}

