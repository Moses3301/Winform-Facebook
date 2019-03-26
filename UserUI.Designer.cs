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
            this.onlineOvalPictureBox = new OvalPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.profileOvalPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onlineOvalPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // profileOvalPictureBox
            // 
            this.profileOvalPictureBox.BackColor = System.Drawing.Color.DarkGray;
            this.profileOvalPictureBox.Location = new System.Drawing.Point(46, 3);
            this.profileOvalPictureBox.Name = "profileOvalPictureBox";
            this.profileOvalPictureBox.Size = new System.Drawing.Size(90, 88);
            this.profileOvalPictureBox.TabIndex = 0;
            this.profileOvalPictureBox.TabStop = false;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.Navy;
            this.nameLabel.Location = new System.Drawing.Point(3, 103);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(170, 20);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "firstname lastname";
            // 
            // onlineOvalPictureBox
            // 
            this.onlineOvalPictureBox.BackColor = System.Drawing.Color.DarkRed;
            this.onlineOvalPictureBox.Location = new System.Drawing.Point(130, 71);
            this.onlineOvalPictureBox.Name = "onlineOvalPictureBox";
            this.onlineOvalPictureBox.Size = new System.Drawing.Size(20, 20);
            this.onlineOvalPictureBox.TabIndex = 4;
            this.onlineOvalPictureBox.TabStop = false;
            // 
            // UserUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.onlineOvalPictureBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.profileOvalPictureBox);
            this.Name = "UserUI";
            this.Size = new System.Drawing.Size(182, 132);
            ((System.ComponentModel.ISupportInitialize)(this.profileOvalPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onlineOvalPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OvalPictureBox profileOvalPictureBox;
        private System.Windows.Forms.Label nameLabel;
        private OvalPictureBox onlineOvalPictureBox;
    }
}
