using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B19_Ex01_Matan_311116313_Moshe_305097453
{
    public partial class PostDetails : Form
    {
        public PostDetails(PostedItem i_Post)
        {
            InitializeComponent();
            m_Post = i_Post;
            submitTexBox.SubmitClicked += m_Post.Comment;
            fetchComments();
        }
        PostedItem m_Post;
        private void fetchComments()
        {
            PostUI post = new PostUI(m_Post);
            topPanel.Controls.Add(post);
            post.Dock = DockStyle.Fill;
            foreach (Comment comment in m_Post.Comments)
            {
                PostUI newComment = new PostUI(comment);
                mainFlowLayoutPanel.Controls.Add(newComment);
            }
        }

    }
}
