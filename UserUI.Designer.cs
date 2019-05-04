namespace B19_Ex01_Matan_311116313_Moshe_305097453
{
    partial class UserUI
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
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameLabel1 = new System.Windows.Forms.Label();
            this.statusesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imageSmallOvalPictureBox = new OvalPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSmallOvalPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.User);
            // 
            // nameLabel1
            // 
            this.nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Name", true));
            this.nameLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.nameLabel1.Location = new System.Drawing.Point(63, 14);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Size = new System.Drawing.Size(269, 37);
            this.nameLabel1.TabIndex = 3;
            this.nameLabel1.Text = "[NAME]";
            this.nameLabel1.Click += new System.EventHandler(this.nameLabel1_Click);
            // 
            // statusesBindingSource
            // 
            this.statusesBindingSource.DataMember = "Statuses";
            this.statusesBindingSource.DataSource = this.userBindingSource;
            // 
            // imageSmallOvalPictureBox
            // 
            this.imageSmallOvalPictureBox.BackColor = System.Drawing.Color.DarkGray;
            this.imageSmallOvalPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.userBindingSource, "ImageSmall", true));
            this.imageSmallOvalPictureBox.Location = new System.Drawing.Point(3, 3);
            this.imageSmallOvalPictureBox.Name = "imageSmallOvalPictureBox";
            this.imageSmallOvalPictureBox.Size = new System.Drawing.Size(54, 57);
            this.imageSmallOvalPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageSmallOvalPictureBox.TabIndex = 2;
            this.imageSmallOvalPictureBox.TabStop = false;
            // 
            // UserUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Controls.Add(this.nameLabel1);
            this.Controls.Add(this.imageSmallOvalPictureBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserUI";
            this.Size = new System.Drawing.Size(340, 64);
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSmallOvalPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource userBindingSource;
        private OvalPictureBox imageSmallOvalPictureBox;
        private System.Windows.Forms.Label nameLabel1;
        private System.Windows.Forms.BindingSource statusesBindingSource;
    }
}
