namespace B19_Ex01_Matan_311116313_Moshe_305097453.PostUI
{
    partial class VideoPostUI
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
            this.videoPanel = new System.Windows.Forms.Panel();
            this.videoImage = new System.Windows.Forms.PictureBox();
            this.descriptionLabel1 = new System.Windows.Forms.Label();
            this.nameLabel2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).BeginInit();
            this.videoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.videoImage)).BeginInit();
            this.SuspendLayout();
            // 
            // videoPanel
            // 
            this.videoPanel.BackColor = System.Drawing.Color.Silver;
            this.videoPanel.Controls.Add(this.videoImage);
            this.videoPanel.Controls.Add(this.descriptionLabel1);
            this.videoPanel.Controls.Add(this.nameLabel2);
            this.videoPanel.Location = new System.Drawing.Point(3, 16);
            this.videoPanel.Name = "videoPanel";
            this.videoPanel.Size = new System.Drawing.Size(1102, 126);
            this.videoPanel.TabIndex = 2;
            this.videoPanel.Click += new System.EventHandler(this.videoPanel_Click);
            // 
            // videoImage
            // 
            this.videoImage.BackColor = System.Drawing.Color.Black;
            this.videoImage.Location = new System.Drawing.Point(4, 4);
            this.videoImage.Name = "videoImage";
            this.videoImage.Size = new System.Drawing.Size(146, 101);
            this.videoImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.videoImage.TabIndex = 6;
            this.videoImage.TabStop = false;
            // 
            // descriptionLabel1
            // 
            this.descriptionLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postBindingSource, "Description", true));
            this.descriptionLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel1.Location = new System.Drawing.Point(156, 34);
            this.descriptionLabel1.Name = "descriptionLabel1";
            this.descriptionLabel1.Size = new System.Drawing.Size(457, 71);
            this.descriptionLabel1.TabIndex = 3;
            this.descriptionLabel1.Text = "label1";
            // 
            // nameLabel2
            // 
            this.nameLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postBindingSource, "Name", true));
            this.nameLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel2.Location = new System.Drawing.Point(156, 11);
            this.nameLabel2.Name = "nameLabel2";
            this.nameLabel2.Size = new System.Drawing.Size(100, 23);
            this.nameLabel2.TabIndex = 1;
            this.nameLabel2.Text = "[NAME]";
            // 
            // VideoPostUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "VideoPostUI";
            this.Size = new System.Drawing.Size(1108, 224);
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).EndInit();
            this.videoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.videoImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel videoPanel;
        private System.Windows.Forms.Label descriptionLabel1;
        private System.Windows.Forms.Label nameLabel2;
        private System.Windows.Forms.PictureBox videoImage;
    }
}
