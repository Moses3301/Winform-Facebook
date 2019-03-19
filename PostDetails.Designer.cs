namespace B19_Ex01_Matan_311116313_Moshe_305097453
{
    partial class PostDetails
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
            this.topPanel = new System.Windows.Forms.Panel();
            this.mainFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.submitTexBox = new B19_Ex01_Matan_311116313_Moshe_305097453.SubmitTexBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topPanel.Location = new System.Drawing.Point(2, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(561, 206);
            this.topPanel.TabIndex = 0;
            // 
            // mainFlowLayoutPanel
            // 
            this.mainFlowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainFlowLayoutPanel.AutoScroll = true;
            this.mainFlowLayoutPanel.Location = new System.Drawing.Point(2, 252);
            this.mainFlowLayoutPanel.Name = "mainFlowLayoutPanel";
            this.mainFlowLayoutPanel.Size = new System.Drawing.Size(561, 365);
            this.mainFlowLayoutPanel.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.submitTexBox);
            this.panel2.Location = new System.Drawing.Point(5, 204);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(548, 42);
            this.panel2.TabIndex = 2;
            // 
            // submitTexBox
            // 
            this.submitTexBox.Location = new System.Drawing.Point(0, 0);
            this.submitTexBox.Name = "submitTexBox";
            this.submitTexBox.Size = new System.Drawing.Size(548, 42);
            this.submitTexBox.TabIndex = 0;
            // 
            // PostDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 618);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.mainFlowLayoutPanel);
            this.Controls.Add(this.topPanel);
            this.Name = "PostDetails";
            this.Text = "PostDetails";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.FlowLayoutPanel mainFlowLayoutPanel;
        private System.Windows.Forms.Panel panel2;
        private SubmitTexBox submitTexBox;
    }
}