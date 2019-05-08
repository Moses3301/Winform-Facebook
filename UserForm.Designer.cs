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
            this.components = new System.ComponentModel.Container();
            this.leftFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.imageSmallOvalPictureBox = new OvalPictureBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.homeButton = new System.Windows.Forms.Button();
            this.albumButton = new System.Windows.Forms.Button();
            this.friendsButton = new System.Windows.Forms.Button();
            this.pagesButton = new System.Windows.Forms.Button();
            this.groupsButton = new System.Windows.Forms.Button();
            this.topFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.mainFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.nameLabel1 = new System.Windows.Forms.Label();
            this.leftFlowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageSmallOvalPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // leftFlowLayoutPanel
            // 
            this.leftFlowLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.leftFlowLayoutPanel.Controls.Add(this.imageSmallOvalPictureBox);
            this.leftFlowLayoutPanel.Controls.Add(this.nameLabel1);
            this.leftFlowLayoutPanel.Controls.Add(this.homeButton);
            this.leftFlowLayoutPanel.Controls.Add(this.albumButton);
            this.leftFlowLayoutPanel.Controls.Add(this.friendsButton);
            this.leftFlowLayoutPanel.Controls.Add(this.pagesButton);
            this.leftFlowLayoutPanel.Controls.Add(this.groupsButton);
            this.leftFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.leftFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.leftFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.leftFlowLayoutPanel.Name = "leftFlowLayoutPanel";
            this.leftFlowLayoutPanel.Size = new System.Drawing.Size(150, 410);
            this.leftFlowLayoutPanel.TabIndex = 10;
            this.leftFlowLayoutPanel.WrapContents = false;
            // 
            // imageSmallOvalPictureBox
            // 
            this.imageSmallOvalPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imageSmallOvalPictureBox.BackColor = System.Drawing.Color.DarkGray;
            this.imageSmallOvalPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.userBindingSource, "ImageSmall", true));
            this.imageSmallOvalPictureBox.Location = new System.Drawing.Point(42, 3);
            this.imageSmallOvalPictureBox.Name = "imageSmallOvalPictureBox";
            this.imageSmallOvalPictureBox.Size = new System.Drawing.Size(65, 60);
            this.imageSmallOvalPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageSmallOvalPictureBox.TabIndex = 1;
            this.imageSmallOvalPictureBox.TabStop = false;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.User);
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
            this.homeButton.Location = new System.Drawing.Point(0, 92);
            this.homeButton.Margin = new System.Windows.Forms.Padding(0);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(150, 56);
            this.homeButton.TabIndex = 12;
            this.homeButton.Tag = "HOME";
            this.homeButton.Text = "Home";
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
            this.albumButton.Location = new System.Drawing.Point(0, 148);
            this.albumButton.Margin = new System.Windows.Forms.Padding(0);
            this.albumButton.Name = "albumButton";
            this.albumButton.Size = new System.Drawing.Size(150, 56);
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
            this.friendsButton.Location = new System.Drawing.Point(0, 204);
            this.friendsButton.Margin = new System.Windows.Forms.Padding(0);
            this.friendsButton.Name = "friendsButton";
            this.friendsButton.Size = new System.Drawing.Size(150, 56);
            this.friendsButton.TabIndex = 14;
            this.friendsButton.Tag = "FRIENDS";
            this.friendsButton.Text = "Friends";
            this.friendsButton.UseVisualStyleBackColor = false;
            this.friendsButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // pagesButton
            // 
            this.pagesButton.AutoSize = true;
            this.pagesButton.BackColor = System.Drawing.Color.Transparent;
            this.pagesButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pagesButton.FlatAppearance.BorderSize = 0;
            this.pagesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pagesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pagesButton.ForeColor = System.Drawing.Color.Cornsilk;
            this.pagesButton.Location = new System.Drawing.Point(0, 260);
            this.pagesButton.Margin = new System.Windows.Forms.Padding(0);
            this.pagesButton.Name = "pagesButton";
            this.pagesButton.Size = new System.Drawing.Size(150, 56);
            this.pagesButton.TabIndex = 15;
            this.pagesButton.Tag = "PAGES";
            this.pagesButton.Text = "Pages";
            this.pagesButton.UseVisualStyleBackColor = false;
            this.pagesButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // groupsButton
            // 
            this.groupsButton.AutoSize = true;
            this.groupsButton.BackColor = System.Drawing.Color.Transparent;
            this.groupsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupsButton.FlatAppearance.BorderSize = 0;
            this.groupsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupsButton.ForeColor = System.Drawing.Color.Cornsilk;
            this.groupsButton.Location = new System.Drawing.Point(0, 316);
            this.groupsButton.Margin = new System.Windows.Forms.Padding(0);
            this.groupsButton.Name = "groupsButton";
            this.groupsButton.Size = new System.Drawing.Size(150, 56);
            this.groupsButton.TabIndex = 16;
            this.groupsButton.Tag = "GROUPS";
            this.groupsButton.Text = "Groups";
            this.groupsButton.UseVisualStyleBackColor = false;
            this.groupsButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // topFlowLayoutPanel
            // 
            this.topFlowLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.topFlowLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.topFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topFlowLayoutPanel.Location = new System.Drawing.Point(150, 0);
            this.topFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.topFlowLayoutPanel.Name = "topFlowLayoutPanel";
            this.topFlowLayoutPanel.Size = new System.Drawing.Size(653, 82);
            this.topFlowLayoutPanel.TabIndex = 1;
            // 
            // mainFlowLayoutPanel
            // 
            this.mainFlowLayoutPanel.AutoScroll = true;
            this.mainFlowLayoutPanel.BackColor = System.Drawing.Color.White;
            this.mainFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.mainFlowLayoutPanel.Location = new System.Drawing.Point(150, 82);
            this.mainFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.mainFlowLayoutPanel.Name = "mainFlowLayoutPanel";
            this.mainFlowLayoutPanel.Size = new System.Drawing.Size(653, 328);
            this.mainFlowLayoutPanel.TabIndex = 2;
            this.mainFlowLayoutPanel.WrapContents = false;
            // 
            // nameLabel1
            // 
            this.nameLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nameLabel1.AutoSize = true;
            this.nameLabel1.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Name", true));
            this.nameLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nameLabel1.Location = new System.Drawing.Point(47, 66);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.nameLabel1.Size = new System.Drawing.Size(55, 26);
            this.nameLabel1.TabIndex = 1;
            this.nameLabel1.Text = "[NAME]";
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 410);
            this.Controls.Add(this.mainFlowLayoutPanel);
            this.Controls.Add(this.topFlowLayoutPanel);
            this.Controls.Add(this.leftFlowLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserForm";
            this.leftFlowLayoutPanel.ResumeLayout(false);
            this.leftFlowLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageSmallOvalPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel leftFlowLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel topFlowLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel mainFlowLayoutPanel;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button albumButton;
        private System.Windows.Forms.Button friendsButton;
        private System.Windows.Forms.Button pagesButton;
        private System.Windows.Forms.Button groupsButton;
        private OvalPictureBox imageSmallOvalPictureBox;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.Label nameLabel1;
    }
}

