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
            this.components = new System.ComponentModel.Container();
            this.btmFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.LikePictureBox = new System.Windows.Forms.PictureBox();
            this.LikesLabel = new System.Windows.Forms.Label();
            this.commentsPictureBox = new System.Windows.Forms.PictureBox();
            this.commentsLabel = new System.Windows.Forms.Label();
            this.topFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.nameLabel1 = new System.Windows.Forms.Label();
            this.postBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bodyFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.createdTimeLabel1 = new System.Windows.Forms.Label();
            this.imageSmallOvalPictureBox = new OvalPictureBox();
            this.messageLabel1 = new System.Windows.Forms.Label();
            this.btmFlowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LikePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentsPictureBox)).BeginInit();
            this.topFlowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).BeginInit();
            this.bodyFlowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageSmallOvalPictureBox)).BeginInit();
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
            this.LikesLabel.Size = new System.Drawing.Size(13, 16);
            this.LikesLabel.TabIndex = 1;
            this.LikesLabel.Text = "0";
            // 
            // commentsPictureBox
            // 
            this.commentsPictureBox.Image = global::B19_Ex01_Matan_311116313_Moshe_305097453.Properties.Resources.comment;
            this.commentsPictureBox.Location = new System.Drawing.Point(74, 3);
            this.commentsPictureBox.Name = "commentsPictureBox";
            this.commentsPictureBox.Size = new System.Drawing.Size(46, 20);
            this.commentsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.commentsPictureBox.TabIndex = 2;
            this.commentsPictureBox.TabStop = false;
            // 
            // commentsLabel
            // 
            this.commentsLabel.AutoSize = true;
            this.commentsLabel.Location = new System.Drawing.Point(126, 0);
            this.commentsLabel.Name = "commentsLabel";
            this.commentsLabel.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.commentsLabel.Size = new System.Drawing.Size(13, 16);
            this.commentsLabel.TabIndex = 3;
            this.commentsLabel.Text = "0";
            // 
            // topFlowLayoutPanel
            // 
            this.topFlowLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(227)))), ((int)(((byte)(238)))));
            this.topFlowLayoutPanel.Controls.Add(this.imageSmallOvalPictureBox);
            this.topFlowLayoutPanel.Controls.Add(this.nameLabel1);
            this.topFlowLayoutPanel.Controls.Add(this.createdTimeLabel1);
            this.topFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.topFlowLayoutPanel.Name = "topFlowLayoutPanel";
            this.topFlowLayoutPanel.Size = new System.Drawing.Size(1108, 53);
            this.topFlowLayoutPanel.TabIndex = 1;
            // 
            // nameLabel1
            // 
            this.nameLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.nameLabel1.Location = new System.Drawing.Point(55, 0);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Size = new System.Drawing.Size(434, 49);
            this.nameLabel1.TabIndex = 4;
            this.nameLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // postBindingSource
            // 
            this.postBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Post);
            // 
            // bodyFlowLayoutPanel
            // 
            this.bodyFlowLayoutPanel.AutoSize = true;
            this.bodyFlowLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.bodyFlowLayoutPanel.Controls.Add(this.messageLabel1);
            this.bodyFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bodyFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.bodyFlowLayoutPanel.Location = new System.Drawing.Point(0, 53);
            this.bodyFlowLayoutPanel.Name = "bodyFlowLayoutPanel";
            this.bodyFlowLayoutPanel.Size = new System.Drawing.Size(1108, 24);
            this.bodyFlowLayoutPanel.TabIndex = 2;
            this.bodyFlowLayoutPanel.WrapContents = false;
            this.bodyFlowLayoutPanel.Click += new System.EventHandler(this.bodyFlowLayoutPanel_Click);
            // 
            // createdTimeLabel1
            // 
            this.createdTimeLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postBindingSource, "CreatedTime", true));
            this.createdTimeLabel1.Location = new System.Drawing.Point(495, 0);
            this.createdTimeLabel1.Name = "createdTimeLabel1";
            this.createdTimeLabel1.Size = new System.Drawing.Size(428, 23);
            this.createdTimeLabel1.TabIndex = 5;
            this.createdTimeLabel1.Text = "[DATE]";
            // 
            // imageSmallOvalPictureBox
            // 
            this.imageSmallOvalPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.imageSmallOvalPictureBox.Location = new System.Drawing.Point(3, 3);
            this.imageSmallOvalPictureBox.Name = "imageSmallOvalPictureBox";
            this.imageSmallOvalPictureBox.Size = new System.Drawing.Size(46, 47);
            this.imageSmallOvalPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageSmallOvalPictureBox.TabIndex = 3;
            this.imageSmallOvalPictureBox.TabStop = false;
            // 
            // messageLabel1
            // 
            this.messageLabel1.AutoSize = true;
            this.messageLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postBindingSource, "Message", true));
            this.messageLabel1.Location = new System.Drawing.Point(3, 0);
            this.messageLabel1.Name = "messageLabel1";
            this.messageLabel1.Size = new System.Drawing.Size(0, 13);
            this.messageLabel1.TabIndex = 1;
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
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).EndInit();
            this.bodyFlowLayoutPanel.ResumeLayout(false);
            this.bodyFlowLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageSmallOvalPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel btmFlowLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel topFlowLayoutPanel;
        private System.Windows.Forms.PictureBox LikePictureBox;
        private System.Windows.Forms.Label LikesLabel;
        private System.Windows.Forms.PictureBox commentsPictureBox;
        private System.Windows.Forms.Label commentsLabel;
        private System.Windows.Forms.FlowLayoutPanel bodyFlowLayoutPanel;
        private OvalPictureBox imageSmallOvalPictureBox;
        private System.Windows.Forms.BindingSource postBindingSource;
        private System.Windows.Forms.Label nameLabel1;
        private System.Windows.Forms.Label createdTimeLabel1;
        private System.Windows.Forms.Label messageLabel1;
    }
}
