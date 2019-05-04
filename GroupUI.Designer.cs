namespace B19_Ex01_Matan_311116313_Moshe_305097453
{
    partial class GroupUI
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
            this.watchMembersButton = new System.Windows.Forms.Button();
            this.groupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.imageSmallOvalPictureBox = new OvalPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSmallOvalPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // watchMembersButton
            // 
            this.watchMembersButton.Location = new System.Drawing.Point(84, 58);
            this.watchMembersButton.Name = "watchMembersButton";
            this.watchMembersButton.Size = new System.Drawing.Size(95, 23);
            this.watchMembersButton.TabIndex = 5;
            this.watchMembersButton.Text = "Watch Members";
            this.watchMembersButton.UseVisualStyleBackColor = true;
            this.watchMembersButton.Click += new System.EventHandler(this.watch_members_click);
            // 
            // groupBindingSource
            // 
            this.groupBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Group);
            // 
            // nameLabel
            // 
            this.nameLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.groupBindingSource, "Name", true));
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.nameLabel.Location = new System.Drawing.Point(80, 3);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(100, 23);
            this.nameLabel.TabIndex = 7;
            this.nameLabel.Text = "[NAME]";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.groupBindingSource, "Description", true));
            this.descriptionLabel.Location = new System.Drawing.Point(81, 26);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(718, 29);
            this.descriptionLabel.TabIndex = 8;
            this.descriptionLabel.Text = "[description]";
            // 
            // imageSmallOvalPictureBox
            // 
            this.imageSmallOvalPictureBox.BackColor = System.Drawing.Color.DarkGray;
            this.imageSmallOvalPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.groupBindingSource, "ImageSmall", true));
            this.imageSmallOvalPictureBox.Location = new System.Drawing.Point(7, 3);
            this.imageSmallOvalPictureBox.Name = "imageSmallOvalPictureBox";
            this.imageSmallOvalPictureBox.Size = new System.Drawing.Size(71, 65);
            this.imageSmallOvalPictureBox.TabIndex = 9;
            this.imageSmallOvalPictureBox.TabStop = false;
            // 
            // GroupUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.imageSmallOvalPictureBox);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.watchMembersButton);
            this.Name = "GroupUI";
            this.Size = new System.Drawing.Size(910, 88);
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSmallOvalPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button watchMembersButton;
        private System.Windows.Forms.BindingSource groupBindingSource;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private OvalPictureBox imageSmallOvalPictureBox;
    }
}
