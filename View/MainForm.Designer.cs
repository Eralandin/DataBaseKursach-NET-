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
            this.TopPanel = new System.Windows.Forms.Panel();
            this.BottomLabel = new System.Windows.Forms.Label();
            this.TopLabel = new System.Windows.Forms.Label();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.imageButton1 = new DataBaseKursach__NET_.View.CustomElements.ImageButton();
            this.MainDGV = new System.Windows.Forms.DataGridView();
            this.TopPanel.SuspendLayout();
            this.BottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainDGV)).BeginInit();
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
            this.TopPanel.Size = new System.Drawing.Size(1200, 75);
            this.TopPanel.TabIndex = 0;
            // 
            // BottomLabel
            // 
            this.BottomLabel.AutoSize = true;
            this.BottomLabel.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BottomLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BottomLabel.Location = new System.Drawing.Point(13, 38);
            this.BottomLabel.Name = "BottomLabel";
            this.BottomLabel.Size = new System.Drawing.Size(126, 23);
            this.BottomLabel.TabIndex = 2;
            this.BottomLabel.Text = "Главное окно";
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
            this.BottomPanel.Controls.Add(this.imageButton1);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(0, 540);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(1200, 60);
            this.BottomPanel.TabIndex = 1;
            // 
            // imageButton1
            // 
            this.imageButton1.Image = global::DataBaseKursach__NET_.Properties.Resources.HomePicture;
            this.imageButton1.ImageHover = global::DataBaseKursach__NET_.Properties.Resources.HomePictureHover;
            this.imageButton1.ImageNormal = global::DataBaseKursach__NET_.Properties.Resources.HomePicture;
            this.imageButton1.InitialImage = global::DataBaseKursach__NET_.Properties.Resources.HomePicture;
            this.imageButton1.Location = new System.Drawing.Point(17, 8);
            this.imageButton1.Name = "imageButton1";
            this.imageButton1.Size = new System.Drawing.Size(40, 40);
            this.imageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageButton1.TabIndex = 0;
            this.imageButton1.TabStop = false;
            // 
            // MainDGV
            // 
            this.MainDGV.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.MainDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainDGV.Location = new System.Drawing.Point(0, 75);
            this.MainDGV.Name = "MainDGV";
            this.MainDGV.Size = new System.Drawing.Size(1200, 465);
            this.MainDGV.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.MainDGV);
            this.Controls.Add(this.BottomPanel);
            this.Controls.Add(this.TopPanel);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.BottomPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label BottomLabel;
        private System.Windows.Forms.Label TopLabel;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.DataGridView MainDGV;
        private CustomElements.ImageButton imageButton1;
    }
}