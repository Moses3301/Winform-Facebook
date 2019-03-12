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

namespace B19_Ex01_Matan_311116313_Moshe_305097453
{
    public partial class PostUI : UserControl
    {
        public PostUI(Post i_Post)
        {
            InitializeComponent();
            m_Post = i_Post;
            fetchPostInfo();
        }
        public PostUI()
        {
            InitializeComponent();
        }
        private Post m_Post;
        private void fetchPostInfo()
        {
            User aouther = m_Post.From;
            profileOvalPictureBox.LoadAsync(aouther.PictureNormalURL);
            nameLabel.Text = aouther.Name;
            dateLabel.Text = m_Post.CreatedTime.ToString();
            if (!string.IsNullOrEmpty(m_Post.PictureURL))
            {
                PictureBox pic = new PictureBox();
                pic.LoadAsync(m_Post.PictureURL);
                pic.SizeMode = PictureBoxSizeMode.Zoom;
                bodyFlowLayoutPanel.Controls.Add(pic);
            }
            if (!string.IsNullOrEmpty(m_Post.Message))
            {
                Label msg = new Label();
                msg.Text = m_Post.Message;
                msg.AutoSize = true;
                bodyFlowLayoutPanel.Controls.Add(msg);
            }
            LikesLabel.Text = m_Post.LikedBy.Count.ToString();
            commentsLabel.Text = m_Post.Comments.Count.ToString();
        }
    }
}
