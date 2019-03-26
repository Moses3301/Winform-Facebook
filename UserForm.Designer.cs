using B19_Ex01_Matan_311116313_Moshe_305097453.Properties;

namespace B19_Ex01_Matan_311116313_Moshe_305097453
{
    partial class UserForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.leftFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.profileOvalPictureBox = new OvalPictureBox();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.homeButton = new System.Windows.Forms.Button();
            this.albumButton = new System.Windows.Forms.Button();
            this.friendsButton = new System.Windows.Forms.Button();
            this.topFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.postSubmitTexBox = new B19_Ex01_Matan_311116313_Moshe_305097453.SubmitTexBox();
            this.mainFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.leftFlowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profileOvalPictureBox)).BeginInit();
            this.topFlowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftFlowLayoutPanel
            // 
            this.leftFlowLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.leftFlowLayoutPanel.Controls.Add(this.profileOvalPictureBox);
            this.leftFlowLayoutPanel.Controls.Add(this.userNameLabel);
            this.leftFlowLayoutPanel.Controls.Add(this.homeButton);
            this.leftFlowLayoutPanel.Controls.Add(this.albumButton);
            this.leftFlowLayoutPanel.Controls.Add(this.friendsButton);
            this.leftFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.leftFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.leftFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.leftFlowLayoutPanel.Name = "leftFlowLayoutPanel";
            this.leftFlowLayoutPanel.Size = new System.Drawing.Size(200, 505);
            this.leftFlowLayoutPanel.TabIndex = 10;
            this.leftFlowLayoutPanel.WrapContents = false;
            // 
            // profileOvalPictureBox
            // 
            this.profileOvalPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.profileOvalPictureBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.profileOvalPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("profileOvalPictureBox.Image")));
            this.profileOvalPictureBox.Location = new System.Drawing.Point(50, 10);
            this.profileOvalPictureBox.Margin = new System.Windows.Forms.Padding(11, 10, 11, 0);
            this.profileOvalPictureBox.Name = "profileOvalPictureBox";
            this.profileOvalPictureBox.Size = new System.Drawing.Size(100, 100);
            this.profileOvalPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profileOvalPictureBox.TabIndex = 10;
            this.profileOvalPictureBox.TabStop = false;
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userNameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userNameLabel.Location = new System.Drawing.Point(0, 110);
            this.userNameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.userNameLabel.Size = new System.Drawing.Size(200, 37);
            this.userNameLabel.TabIndex = 11;
            this.userNameLabel.Text = "Firstname Lastname";
            this.userNameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // homeButton
            // 
            this.homeButton.AutoSize = true;
            this.homeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(157)))), ((int)(((byte)(195)))));
            this.homeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homeButton.FlatAppearance.BorderSize = 0;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.ForeColor = System.Drawing.Color.Cornsilk;
            this.homeButton.Location = new System.Drawing.Point(0, 147);
            this.homeButton.Margin = new System.Windows.Forms.Padding(0);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(200, 48);
            this.homeButton.TabIndex = 12;
            this.homeButton.Tag = "HOME";
            this.homeButton.Text = global::B19_Ex01_Matan_311116313_Moshe_305097453.Properties.Resources.home;
            this.homeButton.UseVisualStyleBackColor = false;
            this.homeButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // albumButton
            // 
            this.albumButton.AutoSize = true;
            this.albumButton.BackColor = System.Drawing.Color.Transparent;
            this.albumButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.albumButton.FlatAppearance.BorderSize = 0;
            this.albumButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.albumButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.albumButton.ForeColor = System.Drawing.Color.Cornsilk;
            this.albumButton.Location = new System.Drawing.Point(0, 195);
            this.albumButton.Margin = new System.Windows.Forms.Padding(0);
            this.albumButton.Name = "albumButton";
            this.albumButton.Size = new System.Drawing.Size(200, 48);
            this.albumButton.TabIndex = 13;
            this.albumButton.Tag = "ALBUMS";
            this.albumButton.Text = "Albums";
            this.albumButton.UseVisualStyleBackColor = false;
            this.albumButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // friendsButton
            // 
            this.friendsButton.AutoSize = true;
            this.friendsButton.BackColor = System.Drawing.Color.Transparent;
            this.friendsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.friendsButton.FlatAppearance.BorderSize = 0;
            this.friendsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.friendsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.friendsButton.ForeColor = System.Drawing.Color.Cornsilk;
            this.friendsButton.Location = new System.Drawing.Point(0, 243);
            this.friendsButton.Margin = new System.Windows.Forms.Padding(0);
            this.friendsButton.Name = "friendsButton";
            this.friendsButton.Size = new System.Drawing.Size(200, 48);
            this.friendsButton.TabIndex = 14;
            this.friendsButton.Tag = "FRIENDS";
            this.friendsButton.Text = "Friends";
            this.friendsButton.UseVisualStyleBackColor = false;
            this.friendsButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // topFlowLayoutPanel
            // 
            this.topFlowLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.topFlowLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.topFlowLayoutPanel.Controls.Add(this.postSubmitTexBox);
            this.topFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topFlowLayoutPanel.Location = new System.Drawing.Point(200, 0);
            this.topFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.topFlowLayoutPanel.Name = "topFlowLayoutPanel";
            this.topFlowLayoutPanel.Size = new System.Drawing.Size(871, 97);
            this.topFlowLayoutPanel.TabIndex = 1;
            // 
            // postSubmitTexBox
            // 
            this.postSubmitTexBox.Location = new System.Drawing.Point(3, 3);
            this.postSubmitTexBox.Name = "postSubmitTexBox";
            this.postSubmitTexBox.Size = new System.Drawing.Size(582, 42);
            this.postSubmitTexBox.TabIndex = 0;
            // 
            // mainFlowLayoutPanel
            // 
            this.mainFlowLayoutPanel.AutoScroll = true;
            this.mainFlowLayoutPanel.BackColor = System.Drawing.Color.White;
            this.mainFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.mainFlowLayoutPanel.Location = new System.Drawing.Point(200, 97);
            this.mainFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainFlowLayoutPanel.Name = "mainFlowLayoutPanel";
            this.mainFlowLayoutPanel.Size = new System.Drawing.Size(871, 408);
            this.mainFlowLayoutPanel.TabIndex = 2;
            this.mainFlowLayoutPanel.WrapContents = false;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 505);
            this.Controls.Add(this.mainFlowLayoutPanel);
            this.Controls.Add(this.topFlowLayoutPanel);
            this.Controls.Add(this.leftFlowLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserForm";
            this.leftFlowLayoutPanel.ResumeLayout(false);
            this.leftFlowLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profileOvalPictureBox)).EndInit();
            this.topFlowLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel leftFlowLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel topFlowLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel mainFlowLayoutPanel;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Button homeButton;
        private OvalPictureBox profileOvalPictureBox;
        private SubmitTexBox postSubmitTexBox;
        private System.Windows.Forms.Button albumButton;
        private System.Windows.Forms.Button friendsButton;
    }
}

