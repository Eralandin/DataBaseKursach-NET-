namespace DataBaseKursach__NET_.View
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TopPanel = new System.Windows.Forms.Panel();
            this.BottomLabel = new System.Windows.Forms.Label();
            this.TopLabel = new System.Windows.Forms.Label();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.ManufacturersLabel = new System.Windows.Forms.Label();
            this.ManufacturersBtn = new DataBaseKursach__NET_.View.CustomElements.ImageButton();
            this.GroupsLabel = new System.Windows.Forms.Label();
            this.GroupsBtn = new DataBaseKursach__NET_.View.CustomElements.ImageButton();
            this.HomeBtnLabel = new System.Windows.Forms.Label();
            this.HomeBtn = new DataBaseKursach__NET_.View.CustomElements.ImageButton();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.AccountingUnitsBtn = new DataBaseKursach__NET_.View.CustomElements.ImageButton();
            this.AccountingUnitsLabel = new System.Windows.Forms.Label();
            this.TopPanel.SuspendLayout();
            this.BottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ManufacturersBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupsBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountingUnitsBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.ForestGreen;
            this.TopPanel.Controls.Add(this.BottomLabel);
            this.TopPanel.Controls.Add(this.TopLabel);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1184, 75);
            this.TopPanel.TabIndex = 0;
            // 
            // BottomLabel
            // 
            this.BottomLabel.AutoSize = true;
            this.BottomLabel.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BottomLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BottomLabel.Location = new System.Drawing.Point(13, 38);
            this.BottomLabel.Name = "BottomLabel";
            this.BottomLabel.Size = new System.Drawing.Size(167, 23);
            this.BottomLabel.TabIndex = 2;
            this.BottomLabel.Text = "Главная страница";
            // 
            // TopLabel
            // 
            this.TopLabel.AutoSize = true;
            this.TopLabel.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TopLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TopLabel.Location = new System.Drawing.Point(12, 9);
            this.TopLabel.Name = "TopLabel";
            this.TopLabel.Size = new System.Drawing.Size(372, 29);
            this.TopLabel.TabIndex = 1;
            this.TopLabel.Text = "Торгово-посредническая фирма";
            // 
            // BottomPanel
            // 
            this.BottomPanel.BackColor = System.Drawing.Color.ForestGreen;
            this.BottomPanel.Controls.Add(this.AccountingUnitsLabel);
            this.BottomPanel.Controls.Add(this.AccountingUnitsBtn);
            this.BottomPanel.Controls.Add(this.ManufacturersLabel);
            this.BottomPanel.Controls.Add(this.ManufacturersBtn);
            this.BottomPanel.Controls.Add(this.GroupsLabel);
            this.BottomPanel.Controls.Add(this.GroupsBtn);
            this.BottomPanel.Controls.Add(this.HomeBtnLabel);
            this.BottomPanel.Controls.Add(this.HomeBtn);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(0, 536);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(1184, 75);
            this.BottomPanel.TabIndex = 1;
            // 
            // ManufacturersLabel
            // 
            this.ManufacturersLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ManufacturersLabel.AutoSize = true;
            this.ManufacturersLabel.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ManufacturersLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ManufacturersLabel.Location = new System.Drawing.Point(264, 46);
            this.ManufacturersLabel.Name = "ManufacturersLabel";
            this.ManufacturersLabel.Size = new System.Drawing.Size(146, 23);
            this.ManufacturersLabel.TabIndex = 5;
            this.ManufacturersLabel.Text = "Производители";
            // 
            // ManufacturersBtn
            // 
            this.ManufacturersBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ManufacturersBtn.Image = global::DataBaseKursach__NET_.Properties.Resources.ManufacturersNormal;
            this.ManufacturersBtn.ImageHover = global::DataBaseKursach__NET_.Properties.Resources.ManufacturersHover;
            this.ManufacturersBtn.ImageNormal = global::DataBaseKursach__NET_.Properties.Resources.ManufacturersNormal;
            this.ManufacturersBtn.InitialImage = global::DataBaseKursach__NET_.Properties.Resources.ManufacturersNormal;
            this.ManufacturersBtn.Location = new System.Drawing.Point(315, 6);
            this.ManufacturersBtn.Name = "ManufacturersBtn";
            this.ManufacturersBtn.Size = new System.Drawing.Size(40, 40);
            this.ManufacturersBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ManufacturersBtn.TabIndex = 4;
            this.ManufacturersBtn.TabStop = false;
            this.ManufacturersBtn.Click += new System.EventHandler(this.ManufacturersBtn_Click);
            // 
            // GroupsLabel
            // 
            this.GroupsLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.GroupsLabel.AutoSize = true;
            this.GroupsLabel.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupsLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.GroupsLabel.Location = new System.Drawing.Point(112, 46);
            this.GroupsLabel.Name = "GroupsLabel";
            this.GroupsLabel.Size = new System.Drawing.Size(146, 23);
            this.GroupsLabel.TabIndex = 3;
            this.GroupsLabel.Text = "Группы товаров";
            // 
            // GroupsBtn
            // 
            this.GroupsBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.GroupsBtn.Image = global::DataBaseKursach__NET_.Properties.Resources.ProductGroupsNormal;
            this.GroupsBtn.ImageHover = global::DataBaseKursach__NET_.Properties.Resources.ProductGroupsHover;
            this.GroupsBtn.ImageNormal = global::DataBaseKursach__NET_.Properties.Resources.ProductGroupsNormal;
            this.GroupsBtn.InitialImage = global::DataBaseKursach__NET_.Properties.Resources.ProductGroupsNormal;
            this.GroupsBtn.Location = new System.Drawing.Point(162, 6);
            this.GroupsBtn.Name = "GroupsBtn";
            this.GroupsBtn.Size = new System.Drawing.Size(40, 40);
            this.GroupsBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GroupsBtn.TabIndex = 2;
            this.GroupsBtn.TabStop = false;
            this.GroupsBtn.Click += new System.EventHandler(this.GroupsBtn_Click);
            // 
            // HomeBtnLabel
            // 
            this.HomeBtnLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.HomeBtnLabel.AutoSize = true;
            this.HomeBtnLabel.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HomeBtnLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.HomeBtnLabel.Location = new System.Drawing.Point(12, 46);
            this.HomeBtnLabel.Name = "HomeBtnLabel";
            this.HomeBtnLabel.Size = new System.Drawing.Size(80, 23);
            this.HomeBtnLabel.TabIndex = 1;
            this.HomeBtnLabel.Text = "Главная";
            // 
            // HomeBtn
            // 
            this.HomeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.HomeBtn.Image = global::DataBaseKursach__NET_.Properties.Resources.HomePicture;
            this.HomeBtn.ImageHover = global::DataBaseKursach__NET_.Properties.Resources.HomePictureHover;
            this.HomeBtn.ImageNormal = global::DataBaseKursach__NET_.Properties.Resources.HomePicture;
            this.HomeBtn.InitialImage = global::DataBaseKursach__NET_.Properties.Resources.HomePicture;
            this.HomeBtn.Location = new System.Drawing.Point(30, 6);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(40, 40);
            this.HomeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HomeBtn.TabIndex = 0;
            this.HomeBtn.TabStop = false;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 75);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1184, 461);
            this.MainPanel.TabIndex = 2;
            // 
            // AccountingUnitsBtn
            // 
            this.AccountingUnitsBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.AccountingUnitsBtn.Image = global::DataBaseKursach__NET_.Properties.Resources.AccountingUnitsNormal;
            this.AccountingUnitsBtn.ImageHover = global::DataBaseKursach__NET_.Properties.Resources.AccountingUnitsHover;
            this.AccountingUnitsBtn.ImageNormal = global::DataBaseKursach__NET_.Properties.Resources.AccountingUnitsNormal;
            this.AccountingUnitsBtn.InitialImage = global::DataBaseKursach__NET_.Properties.Resources.AccountingUnitsNormal;
            this.AccountingUnitsBtn.Location = new System.Drawing.Point(465, 6);
            this.AccountingUnitsBtn.Name = "AccountingUnitsBtn";
            this.AccountingUnitsBtn.Size = new System.Drawing.Size(40, 40);
            this.AccountingUnitsBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AccountingUnitsBtn.TabIndex = 6;
            this.AccountingUnitsBtn.TabStop = false;
            this.AccountingUnitsBtn.Click += new System.EventHandler(this.AccountingUnitsBtn_Click);
            // 
            // AccountingUnitsLabel
            // 
            this.AccountingUnitsLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.AccountingUnitsLabel.AutoSize = true;
            this.AccountingUnitsLabel.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AccountingUnitsLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AccountingUnitsLabel.Location = new System.Drawing.Point(416, 46);
            this.AccountingUnitsLabel.Name = "AccountingUnitsLabel";
            this.AccountingUnitsLabel.Size = new System.Drawing.Size(141, 23);
            this.AccountingUnitsLabel.TabIndex = 7;
            this.AccountingUnitsLabel.Text = "Учёт. единицы";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 611);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.BottomPanel);
            this.Controls.Add(this.TopPanel);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1200, 300);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Торгово-посредническая фирма";
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.BottomPanel.ResumeLayout(false);
            this.BottomPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ManufacturersBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupsBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountingUnitsBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label BottomLabel;
        private System.Windows.Forms.Label TopLabel;
        private System.Windows.Forms.Panel BottomPanel;
        private CustomElements.ImageButton HomeBtn;
        private System.Windows.Forms.Label HomeBtnLabel;
        public System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label GroupsLabel;
        private CustomElements.ImageButton GroupsBtn;
        private System.Windows.Forms.Label ManufacturersLabel;
        private CustomElements.ImageButton ManufacturersBtn;
        private System.Windows.Forms.Label AccountingUnitsLabel;
        private CustomElements.ImageButton AccountingUnitsBtn;
    }
}