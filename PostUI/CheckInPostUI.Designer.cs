namespace B19_Ex01_Matan_311116313_Moshe_305097453.PostUI
{
    partial class CheckInPostUI
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
            this.checkinPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LocationLinkLabel = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).BeginInit();
            this.checkinPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkinPanel
            // 
            this.checkinPanel.Controls.Add(this.LocationLinkLabel);
            this.checkinPanel.Controls.Add(this.label1);
            this.checkinPanel.Controls.Add(this.pictureBox1);
            this.checkinPanel.Location = new System.Drawing.Point(3, 16);
            this.checkinPanel.Name = "checkinPanel";
            this.checkinPanel.Size = new System.Drawing.Size(1010, 63);
            this.checkinPanel.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::B19_Ex01_Matan_311116313_Moshe_305097453.Properties.Resources.placeholder;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "in - ";
            // 
            // LocationLinkLabel
            // 
            this.LocationLinkLabel.AutoSize = true;
            this.LocationLinkLabel.Location = new System.Drawing.Point(81, 37);
            this.LocationLinkLabel.Name = "LocationLinkLabel";
            this.LocationLinkLabel.Size = new System.Drawing.Size(54, 13);
            this.LocationLinkLabel.TabIndex = 2;
            this.LocationLinkLabel.TabStop = true;
            this.LocationLinkLabel.Text = "[Location]";
            this.LocationLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LocationLinkLabel_LinkClicked);
            // 
            // CheckInPostUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "CheckInPostUI";
            this.Size = new System.Drawing.Size(1016, 158);
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).EndInit();
            this.checkinPanel.ResumeLayout(false);
            this.checkinPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        System.Windows.Forms.Panel checkinPanel;
        private System.Windows.Forms.LinkLabel LocationLinkLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
