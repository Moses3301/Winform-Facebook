
namespace B19_Ex01_Matan_311116313_Moshe_305097453.PostUI
{
    partial class PhotoPostUI
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
            this.photoPanel = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.nameLabel2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).BeginInit();
            this.photoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // photoPanel
            // 
            this.photoPanel.Controls.Add(this.nameLabel2);
            this.photoPanel.Controls.Add(this.pictureBox);
            this.photoPanel.Location = new System.Drawing.Point(3, 16);
            this.photoPanel.Name = "photoPanel";
            this.photoPanel.Size = new System.Drawing.Size(1010, 272);
            this.photoPanel.TabIndex = 2;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox.Location = new System.Drawing.Point(13, 30);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(278, 222);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // nameLabel2
            // 
            this.nameLabel2.AutoSize = true;
            this.nameLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postBindingSource, "Name", true));
            this.nameLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel2.Location = new System.Drawing.Point(10, 9);
            this.nameLabel2.Name = "nameLabel2";
            this.nameLabel2.Size = new System.Drawing.Size(65, 18);
            this.nameLabel2.TabIndex = 2;
            this.nameLabel2.Text = "[NAME]";
            // 
            // PhotoPostUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "PhotoPostUI";
            this.Size = new System.Drawing.Size(1016, 367);
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).EndInit();
            this.photoPanel.ResumeLayout(false);
            this.photoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        System.Windows.Forms.Panel photoPanel;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label nameLabel2;
    }
}
