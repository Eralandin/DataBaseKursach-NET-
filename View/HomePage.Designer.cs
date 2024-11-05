namespace DataBaseKursach__NET_.View
{
    partial class HomePage
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
            this.MainFormPB = new System.Windows.Forms.PictureBox();
            this.MainFormL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MainFormPB)).BeginInit();
            this.SuspendLayout();
            // 
            // MainFormPB
            // 
            this.MainFormPB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MainFormPB.Image = global::DataBaseKursach__NET_.Properties.Resources.Логотип_НГТУ_НЭТИ;
            this.MainFormPB.Location = new System.Drawing.Point(377, 125);
            this.MainFormPB.Name = "MainFormPB";
            this.MainFormPB.Size = new System.Drawing.Size(400, 180);
            this.MainFormPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MainFormPB.TabIndex = 0;
            this.MainFormPB.TabStop = false;
            // 
            // MainFormL
            // 
            this.MainFormL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MainFormL.AutoSize = true;
            this.MainFormL.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainFormL.Location = new System.Drawing.Point(578, 269);
            this.MainFormL.Name = "MainFormL";
            this.MainFormL.Size = new System.Drawing.Size(120, 33);
            this.MainFormL.TabIndex = 1;
            this.MainFormL.Text = "It works.";
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 461);
            this.Controls.Add(this.MainFormL);
            this.Controls.Add(this.MainFormPB);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomePage";
            ((System.ComponentModel.ISupportInitialize)(this.MainFormPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox MainFormPB;
        private System.Windows.Forms.Label MainFormL;
    }
}