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
            postUI.Post = m_Post;
            submitTexBox.SubmitClicked += m_Post.Comment;
            fetchComments();
        }
        PostedItem m_Post;
        private void fetchComments()
        {
            foreach (Comment comment in m_Post.Comments)
            {
                PostUI newComment = new PostUI(comment);
                mainFlowLayoutPanel.Controls.Add(newComment);
            }
        }

    }
}
