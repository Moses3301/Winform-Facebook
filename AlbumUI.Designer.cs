namespace B19_Ex01_Matan_311116313_Moshe_305097453
{
    partial class AlbumUI
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.topFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.albumNameLabel = new System.Windows.Forms.Label();
            this.coverPictureBox = new System.Windows.Forms.PictureBox();
            this.ItemsLabel = new System.Windows.Forms.Label();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.topFlowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coverPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // topFlowLayoutPanel
            // 
            this.topFlowLayoutPanel.AutoSize = true;
            this.topFlowLayoutPanel.Controls.Add(this.albumNameLabel);
            this.topFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.topFlowLayoutPanel.Name = "topFlowLayoutPanel";
            this.topFlowLayoutPanel.Size = new System.Drawing.Size(204, 20);
            this.topFlowLayoutPanel.TabIndex = 0;
            // 
            // albumNameLabel
            // 
            this.albumNameLabel.AutoSize = true;
            this.albumNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.albumNameLabel.Location = new System.Drawing.Point(3, 0);
            this.albumNameLabel.Name = "albumNameLabel";
            this.albumNameLabel.Size = new System.Drawing.Size(50, 20);
            this.albumNameLabel.TabIndex = 0;
            this.albumNameLabel.Text = "name";
            // 
            // coverPictureBox
            // 
            this.coverPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.coverPictureBox.Location = new System.Drawing.Point(0, 20);
            this.coverPictureBox.Name = "coverPictureBox";
            this.coverPictureBox.Size = new System.Drawing.Size(204, 187);
            this.coverPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.coverPictureBox.TabIndex = 1;
            this.coverPictureBox.TabStop = false;
            this.coverPictureBox.Click += new System.EventHandler(this.coverPictureBox_Click);
            // 
            // ItemsLabel
            // 
            this.ItemsLabel.AutoSize = true;
            this.ItemsLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ItemsLabel.Location = new System.Drawing.Point(0, 190);
            this.ItemsLabel.Name = "ItemsLabel";
            this.ItemsLabel.Size = new System.Drawing.Size(53, 17);
            this.ItemsLabel.TabIndex = 2;
            this.ItemsLabel.Text = "0 Items";
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Location = new System.Drawing.Point(183, 187);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(18, 17);
            this.checkBox.TabIndex = 3;
            this.checkBox.UseVisualStyleBackColor = true;
            // 
            // AlbumUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.ItemsLabel);
            this.Controls.Add(this.coverPictureBox);
            this.Controls.Add(this.topFlowLayoutPanel);
            this.Name = "AlbumUI";
            this.Size = new System.Drawing.Size(204, 207);
            this.topFlowLayoutPanel.ResumeLayout(false);
            this.topFlowLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coverPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel topFlowLayoutPanel;
        private System.Windows.Forms.Label albumNameLabel;
        private System.Windows.Forms.PictureBox coverPictureBox;
        private System.Windows.Forms.Label ItemsLabel;
        private System.Windows.Forms.CheckBox checkBox;
    }
}
