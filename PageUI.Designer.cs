namespace B19_Ex01_Matan_311116313_Moshe_305097453
{
    partial class PageUI
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
            this.pageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imageSmallPictureBox = new System.Windows.Forms.PictureBox();
            this.nameLabel1 = new System.Windows.Forms.Label();
            this.descriptionLabel1 = new System.Windows.Forms.Label();
            this.likesCountLabel1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSmallPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pageBindingSource
            // 
            this.pageBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Page);
            // 
            // imageSmallPictureBox
            // 
            this.imageSmallPictureBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.imageSmallPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.pageBindingSource, "ImageSmall", true));
            this.imageSmallPictureBox.Location = new System.Drawing.Point(3, 3);
            this.imageSmallPictureBox.Name = "imageSmallPictureBox";
            this.imageSmallPictureBox.Size = new System.Drawing.Size(101, 104);
            this.imageSmallPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageSmallPictureBox.TabIndex = 2;
            this.imageSmallPictureBox.TabStop = false;
            // 
            // nameLabel1
            // 
            this.nameLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pageBindingSource, "Name", true));
            this.nameLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.nameLabel1.Location = new System.Drawing.Point(110, 3);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Size = new System.Drawing.Size(770, 26);
            this.nameLabel1.TabIndex = 3;
            this.nameLabel1.Text = "[NAME]";
            // 
            // descriptionLabel1
            // 
            this.descriptionLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pageBindingSource, "Description", true));
            this.descriptionLabel1.Location = new System.Drawing.Point(110, 29);
            this.descriptionLabel1.Name = "descriptionLabel1";
            this.descriptionLabel1.Size = new System.Drawing.Size(770, 23);
            this.descriptionLabel1.TabIndex = 4;
            this.descriptionLabel1.Text = "[DESCRIPTION]";
            // 
            // likesCountLabel1
            // 
            this.likesCountLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pageBindingSource, "LikesCount", true));
            this.likesCountLabel1.Location = new System.Drawing.Point(112, 81);
            this.likesCountLabel1.Name = "likesCountLabel1";
            this.likesCountLabel1.Size = new System.Drawing.Size(43, 23);
            this.likesCountLabel1.TabIndex = 5;
            this.likesCountLabel1.Text = "[00]";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::B19_Ex01_Matan_311116313_Moshe_305097453.Properties.Resources.thumbs_up;
            this.pictureBox1.Location = new System.Drawing.Point(142, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // PageUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.likesCountLabel1);
            this.Controls.Add(this.descriptionLabel1);
            this.Controls.Add(this.nameLabel1);
            this.Controls.Add(this.imageSmallPictureBox);
            this.Name = "PageUI";
            this.Size = new System.Drawing.Size(903, 111);
            ((System.ComponentModel.ISupportInitialize)(this.pageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSmallPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private OvalPictureBox profileOvalPictureBox;
        private System.Windows.Forms.BindingSource pageBindingSource;
        private System.Windows.Forms.PictureBox imageSmallPictureBox;
        private System.Windows.Forms.Label nameLabel1;
        private System.Windows.Forms.Label descriptionLabel1;
        private System.Windows.Forms.Label likesCountLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
