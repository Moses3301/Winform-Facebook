using FacebookWrapper;
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
    public partial class UserForm : Form
    {
        public UserForm(User i_User)
        {
            InitializeComponent();
            m_User = i_User;
            fetchUserInfo();
        }
        private User m_User;

        private void menuButton_Click(object sender, EventArgs e)
        {
            foreach (Control control in leftFlowLayoutPanel.Controls)
            {
                if (control is Button)
                {
                    control.BackColor = System.Drawing.Color.Transparent;
                }
            }
            Button btn = (Button)sender;
            btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(157)))), ((int)(((byte)(195)))));
            mainFlowLayoutPanel.Controls.Clear();
            string tag = btn.Tag.ToString();
            switch (tag)
            {
                case "HOME":
                    loadWallPosts(m_User);
                    break;
                case "ALBUMS":
                    loadAlbums(m_User);
                    break;
                case "FRIENDS":
                    loadFriends(m_User);
                    break;
                default:
                    break;
            }
        }

        private void loadWallPosts(User i_User)
        {
            foreach (Post post in i_User.NewsFeed)
            {
                PostUI newPostUI = new PostUI(post);
                mainFlowLayoutPanel.Controls.Add(newPostUI);
            }
        }
        private void loadAlbums(User i_User)
        {
            foreach (Album album in i_User.Albums)
            {
                AlbumUI newAlbumUI = new AlbumUI(album);
                mainFlowLayoutPanel.Controls.Add(newAlbumUI);
            }
        }
        private void fetchUserInfo()
        {
            profileOvalPictureBox.LoadAsync(m_User.PictureNormalURL);
            userNameLabel.Text = m_User.Name;
        }
    }
}
