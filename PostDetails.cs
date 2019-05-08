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
            submitTexBox.SubmitButton.Click += new EventHandler(comment_onClick);
            fetchComments();
        }
        PostedItem m_Post;
        private void fetchComments()
        {
            PostUI.PostUI post = new PostUI.PostUI(m_Post);
            topPanel.Controls.Add(post);
            post.Dock = DockStyle.Fill;
            foreach (Comment comment in m_Post.Comments)
            {
                PostUI.PostUI newComment = new PostUI.PostUI(comment);
                mainFlowLayoutPanel.Controls.Add(newComment);
            }
        }
        private void comment_onClick(object sender, EventArgs args)
        {
            m_Post.Comment(submitTexBox.TextBox.Text);
        }
    }
}
