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
        public PostUI(PostedItem i_Post)
        {
            InitializeComponent();
            m_Post = i_Post;
            fetchPostInfo();
        }
        public PostUI()
        {
            InitializeComponent();
        }
        private PostedItem m_Post;
        public PostedItem Post
        {
            get { return m_Post; }
            set { m_Post = value; Post_Change(this, EventArgs.Empty); }
        }
        private void fetchPostInfo()
        {
            User aouther = m_Post.From;
            profileOvalPictureBox.LoadAsync(aouther.PictureNormalURL);
            nameLabel.Text = aouther.Name;
            dateLabel.Text = m_Post.CreatedTime.ToString();

            if (!string.IsNullOrEmpty(m_Post.Message))
            {
                Label msg = new Label();
                msg.Text = m_Post.Message;
                msg.AutoSize = true;
                bodyFlowLayoutPanel.Controls.Add(msg);
            }
            Post post = m_Post as Post;
            if (post != null)
            {
                if (!string.IsNullOrEmpty(post.PictureURL))
                {
                    PictureBox pic = new PictureBox();
                    pic.LoadAsync(post.PictureURL);
                    pic.SizeMode = PictureBoxSizeMode.AutoSize;
                    bodyFlowLayoutPanel.Controls.Add(pic);
                }
                
            }
            LikesLabel.Text = m_Post.LikedBy.Count.ToString();
            commentsLabel.Text = m_Post.Comments.Count.ToString();
            m_Post.PropertyChanged += Post_Change;
        }
        private void Post_Change(object sender, EventArgs e)
        {
            m_Post.ReFetch();
            bodyFlowLayoutPanel.Controls.Clear();
            fetchPostInfo();
        }
        private void LikePictureBox_Click(object sender, EventArgs e)
        {
            m_Post.Like();
        }

        private void PostUI_Click(object sender, EventArgs e)
        {
            PostDetails postDetails = new PostDetails(m_Post);
            postDetails.Show();
        }

        private void bodyFlowLayoutPanel_Click(object sender, EventArgs e)
        {
            PostDetails postDetails = new PostDetails(m_Post);
            postDetails.Show();
        }
    }
}
