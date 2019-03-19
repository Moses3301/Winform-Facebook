using B19_Ex01_Matan_311116313_Moshe_305097453.Properties;

namespace B19_Ex01_Matan_311116313_Moshe_305097453
{
    partial class PostUI
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
            this.btmFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.LikePictureBox = new System.Windows.Forms.PictureBox();
            this.LikesLabel = new System.Windows.Forms.Label();
            this.commentsPictureBox = new System.Windows.Forms.PictureBox();
            this.commentsLabel = new System.Windows.Forms.Label();
            this.topFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.nameLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.bodyFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.profileOvalPictureBox = new OvalPictureBox();
            this.btmFlowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LikePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentsPictureBox)).BeginInit();
            this.topFlowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profileOvalPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btmFlowLayoutPanel
            // 
            this.btmFlowLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(227)))), ((int)(((byte)(238)))));
            this.btmFlowLayoutPanel.Controls.Add(this.LikePictureBox);
            this.btmFlowLayoutPanel.Controls.Add(this.LikesLabel);
            this.btmFlowLayoutPanel.Controls.Add(this.commentsPictureBox);
            this.btmFlowLayoutPanel.Controls.Add(this.commentsLabel);
            this.btmFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btmFlowLayoutPanel.Location = new System.Drawing.Point(0, 77);
            this.btmFlowLayoutPanel.Name = "btmFlowLayoutPanel";
            this.btmFlowLayoutPanel.Size = new System.Drawing.Size(1108, 23);
            this.btmFlowLayoutPanel.TabIndex = 0;
            // 
            // LikePictureBox
            // 
            this.LikePictureBox.Image = global::B19_Ex01_Matan_311116313_Moshe_305097453.Properties.Resources.thumbs_up;
            this.LikePictureBox.Location = new System.Drawing.Point(3, 3);
            this.LikePictureBox.Name = "LikePictureBox";
            this.LikePictureBox.Size = new System.Drawing.Size(46, 17);
            this.LikePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LikePictureBox.TabIndex = 0;
            this.LikePictureBox.TabStop = false;
            this.LikePictureBox.Click += new System.EventHandler(this.LikePictureBox_Click);
            // 
            // LikesLabel
            // 
            this.LikesLabel.AutoSize = true;
            this.LikesLabel.Location = new System.Drawing.Point(55, 0);
            this.LikesLabel.Name = "LikesLabel";
            this.LikesLabel.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.LikesLabel.Size = new System.Drawing.Size(16, 20);
            this.LikesLabel.TabIndex = 1;
            this.LikesLabel.Text = "0";
            // 
            // commentsPictureBox
            // 
            this.commentsPictureBox.Image = global::B19_Ex01_Matan_311116313_Moshe_305097453.Properties.Resources.comment;
            this.commentsPictureBox.Location = new System.Drawing.Point(77, 3);
            this.commentsPictureBox.Name = "commentsPictureBox";
            this.commentsPictureBox.Size = new System.Drawing.Size(46, 20);
            this.commentsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.commentsPictureBox.TabIndex = 2;
            this.commentsPictureBox.TabStop = false;
            // 
            // commentsLabel
            // 
            this.commentsLabel.AutoSize = true;
            this.commentsLabel.Location = new System.Drawing.Point(129, 0);
            this.commentsLabel.Name = "commentsLabel";
            this.commentsLabel.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.commentsLabel.Size = new System.Drawing.Size(16, 20);
            this.commentsLabel.TabIndex = 3;
            this.commentsLabel.Text = "0";
            // 
            // topFlowLayoutPanel
            // 
            this.topFlowLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(227)))), ((int)(((byte)(238)))));
            this.topFlowLayoutPanel.Controls.Add(this.profileOvalPictureBox);
            this.topFlowLayoutPanel.Controls.Add(this.nameLabel);
            this.topFlowLayoutPanel.Controls.Add(this.dateLabel);
            this.topFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.topFlowLayoutPanel.Name = "topFlowLayoutPanel";
            this.topFlowLayoutPanel.Size = new System.Drawing.Size(1108, 43);
            this.topFlowLayoutPanel.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.nameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.nameLabel.Location = new System.Drawing.Point(57, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Padding = new System.Windows.Forms.Padding(10, 15, 0, 0);
            this.nameLabel.Size = new System.Drawing.Size(207, 39);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Firstname Lastname";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(270, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Padding = new System.Windows.Forms.Padding(3);
            this.dateLabel.Size = new System.Drawing.Size(130, 23);
            this.dateLabel.TabIndex = 2;
            this.dateLabel.Text = "00/00/00 time time";
            // 
            // bodyFlowLayoutPanel
            // 
            this.bodyFlowLayoutPanel.AutoSize = true;
            this.bodyFlowLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.bodyFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bodyFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.bodyFlowLayoutPanel.Location = new System.Drawing.Point(0, 43);
            this.bodyFlowLayoutPanel.Name = "bodyFlowLayoutPanel";
            this.bodyFlowLayoutPanel.Size = new System.Drawing.Size(1108, 34);
            this.bodyFlowLayoutPanel.TabIndex = 2;
            this.bodyFlowLayoutPanel.WrapContents = false;
            this.bodyFlowLayoutPanel.Click += new System.EventHandler(this.bodyFlowLayoutPanel_Click);
            // 
            // profileOvalPictureBox
            // 
            this.profileOvalPictureBox.BackColor = System.Drawing.Color.DarkGray;
            this.profileOvalPictureBox.Image = global::B19_Ex01_Matan_311116313_Moshe_305097453.Properties.Resources.facebook_profile_photo;
            this.profileOvalPictureBox.Location = new System.Drawing.Point(5, 5);
            this.profileOvalPictureBox.Margin = new System.Windows.Forms.Padding(5);
            this.profileOvalPictureBox.Name = "profileOvalPictureBox";
            this.profileOvalPictureBox.Size = new System.Drawing.Size(44, 38);
            this.profileOvalPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profileOvalPictureBox.TabIndex = 0;
            this.profileOvalPictureBox.TabStop = false;
            // 
            // PostUI
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.Controls.Add(this.bodyFlowLayoutPanel);
            this.Controls.Add(this.topFlowLayoutPanel);
            this.Controls.Add(this.btmFlowLayoutPanel);
            this.MinimumSize = new System.Drawing.Size(600, 100);
            this.Name = "PostUI";
            this.Size = new System.Drawing.Size(1108, 100);
            this.Click += new System.EventHandler(this.PostUI_Click);
            this.btmFlowLayoutPanel.ResumeLayout(false);
            this.btmFlowLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LikePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentsPictureBox)).EndInit();
            this.topFlowLayoutPanel.ResumeLayout(false);
            this.topFlowLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profileOvalPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel btmFlowLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel topFlowLayoutPanel;
        private OvalPictureBox profileOvalPictureBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.PictureBox LikePictureBox;
        private System.Windows.Forms.Label LikesLabel;
        private System.Windows.Forms.PictureBox commentsPictureBox;
        private System.Windows.Forms.Label commentsLabel;
        private System.Windows.Forms.FlowLayoutPanel bodyFlowLayoutPanel;
    }
}
