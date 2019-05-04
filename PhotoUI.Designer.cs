namespace B19_Ex01_Matan_311116313_Moshe_305097453
{
    partial class PhotoUI
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
            this.components = new System.ComponentModel.Container();
            this.photoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imageNormalPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.photoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // photoBindingSource
            // 
            this.photoBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Photo);
            // 
            // imageNormalPictureBox
            // 
            this.imageNormalPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.photoBindingSource, "ImageNormal", true));
            this.imageNormalPictureBox.Location = new System.Drawing.Point(0, 0);
            this.imageNormalPictureBox.Name = "imageNormalPictureBox";
            this.imageNormalPictureBox.Size = new System.Drawing.Size(126, 124);
            this.imageNormalPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imageNormalPictureBox.TabIndex = 2;
            this.imageNormalPictureBox.TabStop = false;
            this.imageNormalPictureBox.Click += new System.EventHandler(this.imageNormalPictureBox_Click);
            // 
            // PhotoUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.imageNormalPictureBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PhotoUI";
            this.Size = new System.Drawing.Size(129, 127);
            ((System.ComponentModel.ISupportInitialize)(this.photoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource photoBindingSource;
        private System.Windows.Forms.PictureBox imageNormalPictureBox;
    }
}
