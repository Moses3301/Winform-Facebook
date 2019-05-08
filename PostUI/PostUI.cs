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

namespace B19_Ex01_Matan_311116313_Moshe_305097453.PostUI
{
    public partial class PostUI : UserControl
    {
        public PostUI(PostedItem i_Post)
        {
            InitializeComponent();
            m_Post = i_Post;
            fetchPostInfo();
        }
        private PostUI()
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
            postBindingSource.DataSource = m_Post;
            if (m_Post.From != null)
            {
                this.imageSmallOvalPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.postBindingSource, "From.ImageSmall", true));
                this.nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postBindingSource, "From.Name", true));
            }
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

        private void nameLabel_Click(object sender, EventArgs e)
        {
            UserForm newWindow = new UserForm(m_Post.From);
            newWindow.Show();
        }
    }

}

