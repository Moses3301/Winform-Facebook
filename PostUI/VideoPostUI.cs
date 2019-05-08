using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using System.Diagnostics;

namespace B19_Ex01_Matan_311116313_Moshe_305097453.PostUI
{
    public partial class VideoPostUI : PostUI
    {
        public VideoPostUI(Post i_Post) : base(i_Post)
        {
            InitializeComponent();
            m_post = i_Post;
            this.bodyFlowLayoutPanel.Controls.Add(videoPanel);
            videoImage.LoadAsync(m_post.PictureURL);
        }
        private Post m_post;
        private void videoPanel_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo(m_post.Link);
            Process.Start(sInfo);
        }
    }
}
