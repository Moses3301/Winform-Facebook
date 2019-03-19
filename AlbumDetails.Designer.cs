namespace B19_Ex01_Matan_311116313_Moshe_305097453
{
    partial class AlbumDetails
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
            this.thumPictureBox = new System.Windows.Forms.PictureBox();
            this.detailsLabel = new System.Windows.Forms.Label();
            this.mainFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.thumPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // thumPictureBox
            // 
            this.thumPictureBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.thumPictureBox.Location = new System.Drawing.Point(0, 0);
            this.thumPictureBox.Name = "thumPictureBox";
            this.thumPictureBox.Size = new System.Drawing.Size(703, 88);
            this.thumPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.thumPictureBox.TabIndex = 0;
            this.thumPictureBox.TabStop = false;
            // 
            // detailsLabel
            // 
            this.detailsLabel.AutoSize = true;
            this.detailsLabel.Location = new System.Drawing.Point(7, 9);
            this.detailsLabel.Name = "detailsLabel";
            this.detailsLabel.Size = new System.Drawing.Size(49, 17);
            this.detailsLabel.TabIndex = 1;
            this.detailsLabel.Text = "details";
            // 
            // mainFlowLayoutPanel
            // 
            this.mainFlowLayoutPanel.AutoScroll = true;
            this.mainFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainFlowLayoutPanel.Location = new System.Drawing.Point(0, 88);
            this.mainFlowLayoutPanel.Name = "mainFlowLayoutPanel";
            this.mainFlowLayoutPanel.Size = new System.Drawing.Size(703, 399);
            this.mainFlowLayoutPanel.TabIndex = 2;
            // 
            // AlbumDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 487);
            this.Controls.Add(this.mainFlowLayoutPanel);
            this.Controls.Add(this.detailsLabel);
            this.Controls.Add(this.thumPictureBox);
            this.Name = "AlbumDetails";
            this.Text = "AlbumDetails";
            ((System.ComponentModel.ISupportInitialize)(this.thumPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox thumPictureBox;
        private System.Windows.Forms.Label detailsLabel;
        private System.Windows.Forms.FlowLayoutPanel mainFlowLayoutPanel;
    }
}