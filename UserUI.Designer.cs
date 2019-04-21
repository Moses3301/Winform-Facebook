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
            this.profileOvalPictureBox = new OvalPictureBox();
            this.nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.profileOvalPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // profileOvalPictureBox
            // 
            this.profileOvalPictureBox.BackColor = System.Drawing.Color.SlateGray;
            this.profileOvalPictureBox.InitialImage = null;
            this.profileOvalPictureBox.Location = new System.Drawing.Point(34, 2);
            this.profileOvalPictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.profileOvalPictureBox.Name = "profileOvalPictureBox";
            this.profileOvalPictureBox.Size = new System.Drawing.Size(68, 72);
            this.profileOvalPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profileOvalPictureBox.TabIndex = 0;
            this.profileOvalPictureBox.TabStop = false;
            //this.profileOvalPictureBox.Click += new System.EventHandler(this.profileOvalPictureBox_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.Navy;
            this.nameLabel.Location = new System.Drawing.Point(2, 84);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(145, 19);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "firstname lastname";
            // 
            // UserUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.profileOvalPictureBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UserUI";
            this.Size = new System.Drawing.Size(147, 107);
            this.Click += new System.EventHandler(this.UserUI_Click);
            ((System.ComponentModel.ISupportInitialize)(this.profileOvalPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OvalPictureBox profileOvalPictureBox;
        private System.Windows.Forms.Label nameLabel;
    }
}
