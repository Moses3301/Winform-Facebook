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
            this.components = new System.ComponentModel.Container();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.albumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameLabel1 = new System.Windows.Forms.Label();
            this.descriptionLabel1 = new System.Windows.Forms.Label();
            this.imageAlbumPictureBox = new System.Windows.Forms.PictureBox();
            this.createdTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageAlbumPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Location = new System.Drawing.Point(208, 187);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(18, 17);
            this.checkBox.TabIndex = 3;
            this.checkBox.UseVisualStyleBackColor = true;
            // 
            // albumBindingSource
            // 
            this.albumBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Album);
            // 
            // nameLabel1
            // 
            this.nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumBindingSource, "Name", true));
            this.nameLabel1.Location = new System.Drawing.Point(3, 10);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Size = new System.Drawing.Size(198, 23);
            this.nameLabel1.TabIndex = 5;
            this.nameLabel1.Text = "[NAME]";
            // 
            // descriptionLabel1
            // 
            this.descriptionLabel1.AutoSize = true;
            this.descriptionLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumBindingSource, "Description", true));
            this.descriptionLabel1.Location = new System.Drawing.Point(3, 61);
            this.descriptionLabel1.Name = "descriptionLabel1";
            this.descriptionLabel1.Size = new System.Drawing.Size(108, 17);
            this.descriptionLabel1.TabIndex = 6;
            this.descriptionLabel1.Text = "[DESCRIPTION]";
            // 
            // imageAlbumPictureBox
            // 
            this.imageAlbumPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.albumBindingSource, "ImageAlbum", true));
            this.imageAlbumPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageAlbumPictureBox.Location = new System.Drawing.Point(0, 0);
            this.imageAlbumPictureBox.Name = "imageAlbumPictureBox";
            this.imageAlbumPictureBox.Size = new System.Drawing.Size(229, 212);
            this.imageAlbumPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageAlbumPictureBox.TabIndex = 7;
            this.imageAlbumPictureBox.TabStop = false;
            // 
            // createdTimeDateTimePicker
            // 
            this.createdTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.albumBindingSource, "CreatedTime", true));
            this.createdTimeDateTimePicker.Enabled = false;
            this.createdTimeDateTimePicker.Location = new System.Drawing.Point(6, 36);
            this.createdTimeDateTimePicker.Name = "createdTimeDateTimePicker";
            this.createdTimeDateTimePicker.Size = new System.Drawing.Size(220, 22);
            this.createdTimeDateTimePicker.TabIndex = 8;
            // 
            // AlbumUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.createdTimeDateTimePicker);
            this.Controls.Add(this.descriptionLabel1);
            this.Controls.Add(this.nameLabel1);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.imageAlbumPictureBox);
            this.Name = "AlbumUI";
            this.Size = new System.Drawing.Size(229, 212);
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageAlbumPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.BindingSource albumBindingSource;
        private System.Windows.Forms.Label nameLabel1;
        private System.Windows.Forms.Label descriptionLabel1;
        private System.Windows.Forms.PictureBox imageAlbumPictureBox;
        private System.Windows.Forms.DateTimePicker createdTimeDateTimePicker;
    }
}
