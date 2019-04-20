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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PageUI));
            this.profileOvalPictureBox = new OvalPictureBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.NumberOfPeopleLabel = new System.Windows.Forms.Label();
            this.peopleLikedThisText = new System.Windows.Forms.Label();
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
            this.profileOvalPictureBox.TabIndex = 2;
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
            this.nameLabel.Size = new System.Drawing.Size(97, 33);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Pagename";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // NumberOfPeopleLabel
            // 
            this.NumberOfPeopleLabel.AutoSize = true;
            this.NumberOfPeopleLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.NumberOfPeopleLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NumberOfPeopleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberOfPeopleLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.NumberOfPeopleLabel.Location = new System.Drawing.Point(144, 56);
            this.NumberOfPeopleLabel.Name = "NumberOfPeopleLabel";
            this.NumberOfPeopleLabel.Padding = new System.Windows.Forms.Padding(10, 15, 0, 0);
            this.NumberOfPeopleLabel.Size = new System.Drawing.Size(152, 33);
            this.NumberOfPeopleLabel.TabIndex = 4;
            this.NumberOfPeopleLabel.Text = "Number of people";
            this.NumberOfPeopleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // peopleLikedThisText
            // 
            this.peopleLikedThisText.AutoSize = true;
            this.peopleLikedThisText.Cursor = System.Windows.Forms.Cursors.Default;
            this.peopleLikedThisText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.peopleLikedThisText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.peopleLikedThisText.ForeColor = System.Drawing.Color.MidnightBlue;
            this.peopleLikedThisText.Location = new System.Drawing.Point(302, 56);
            this.peopleLikedThisText.Name = "peopleLikedThisText";
            this.peopleLikedThisText.Padding = new System.Windows.Forms.Padding(10, 15, 0, 0);
            this.peopleLikedThisText.Size = new System.Drawing.Size(181, 33);
            this.peopleLikedThisText.TabIndex = 5;
            this.peopleLikedThisText.Text = "people liked this page";
            this.peopleLikedThisText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PageUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.peopleLikedThisText);
            this.Controls.Add(this.NumberOfPeopleLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.profileOvalPictureBox);
            this.Name = "PageUI";
            this.Size = new System.Drawing.Size(903, 150);
            ((System.ComponentModel.ISupportInitialize)(this.profileOvalPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OvalPictureBox profileOvalPictureBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label NumberOfPeopleLabel;
        private System.Windows.Forms.Label peopleLikedThisText;
    }
}
