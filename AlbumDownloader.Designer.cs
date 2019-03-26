namespace B19_Ex01_Matan_311116313_Moshe_305097453
{
    partial class AlbumDownloader
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
            this.pathLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.submitTexBox = new B19_Ex01_Matan_311116313_Moshe_305097453.SubmitTexBox();
            this.SuspendLayout();
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Location = new System.Drawing.Point(13, 13);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(37, 17);
            this.pathLabel.TabIndex = 0;
            this.pathLabel.Text = "Path";
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.Location = new System.Drawing.Point(3, 60);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(640, 453);
            this.flowLayoutPanel.TabIndex = 2;
            // 
            // submitTexBox
            // 
            this.submitTexBox.Location = new System.Drawing.Point(49, 12);
            this.submitTexBox.Name = "submitTexBox";
            this.submitTexBox.Size = new System.Drawing.Size(582, 42);
            this.submitTexBox.TabIndex = 3;
            // 
            // AlbumDownloader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 516);
            this.Controls.Add(this.submitTexBox);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.pathLabel);
            this.Name = "AlbumDownloader";
            this.Text = "AlbumDownloader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private SubmitTexBox submitTexBox;
    }
}