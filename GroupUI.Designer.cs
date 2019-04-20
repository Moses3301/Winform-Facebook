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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroupUI));
            this.profileOvalPictureBox = new OvalPictureBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.watchMembersButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.profileOvalPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // profileOvalPictureBox
            // 
            this.profileOvalPictureBox.BackColor = System.Drawing.Color.DarkGray;
            this.profileOvalPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("profileOvalPictureBox.Image")));
            this.profileOvalPictureBox.Location = new System.Drawing.Point(15, 23);
            this.profileOvalPictureBox.Margin = new System.Windows.Forms.Padding(5);
            this.profileOvalPictureBox.Name = "profileOvalPictureBox";
            this.profileOvalPictureBox.Size = new System.Drawing.Size(121, 104);
            this.profileOvalPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profileOvalPictureBox.TabIndex = 3;
            this.profileOvalPictureBox.TabStop = false;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.nameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.nameLabel.Location = new System.Drawing.Point(144, 23);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Padding = new System.Windows.Forms.Padding(10, 15, 0, 0);
            this.nameLabel.Size = new System.Drawing.Size(109, 33);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "GroupName";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // watchMembersButton
            // 
            this.watchMembersButton.Location = new System.Drawing.Point(158, 70);
            this.watchMembersButton.Name = "watchMembersButton";
            this.watchMembersButton.Size = new System.Drawing.Size(95, 23);
            this.watchMembersButton.TabIndex = 5;
            this.watchMembersButton.Text = "Watch Members";
            this.watchMembersButton.UseVisualStyleBackColor = true;
            this.watchMembersButton.Click += new System.EventHandler(this.watch_members_click);
            // 
            // GroupUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.watchMembersButton);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.profileOvalPictureBox);
            this.Name = "GroupUI";
            this.Size = new System.Drawing.Size(910, 150);
            ((System.ComponentModel.ISupportInitialize)(this.profileOvalPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OvalPictureBox profileOvalPictureBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button watchMembersButton;
    }
}
