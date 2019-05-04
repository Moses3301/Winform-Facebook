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
            topFlowLayoutPanel.Controls.Clear();
            string tag = btn.Tag.ToString();
            switch (tag)
            {
                case "HOME":
                    loadWallPosts(m_User);
                    break;
                case "ALBUMS":
                    loadAlbumsScreen();
                    break;
                case "FRIENDS":
                    loadFriends(m_User);
                    break;
                case "PAGES":
                    loadLikedPages(m_User);
                    break;
                case "GROUPS":
                    loadGroups(m_User);
                    break;
                default:
                    break;
            }
        }

        private void loadAlbumsScreen()
        {
            loadAlbums(m_User);
            Button downladBtn = newButton("Download Albums");
            downladBtn.Click += new EventHandler(saveAlbums_Click);
            topFlowLayoutPanel.Controls.Add(downladBtn);
        }
        private Button newButton(string i_text)
        {
            Button button = new Button();
            button.Text = i_text;
            button.AutoSize = true;
            button.BackColor = System.Drawing.Color.Blue;
            button.FlatAppearance.BorderSize = 0;
            button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button.ForeColor = System.Drawing.Color.Cornsilk;
            button.Text = "Download Albums";
            return button;
        }
        private void saveAlbums_Click(object sender, EventArgs e)
        {
            List<Album> albums = new List<Album>();
            foreach (Control control in mainFlowLayoutPanel.Controls)
            {
                AlbumUI album = control as AlbumUI;
                if (album != null)
                {
                    if (album.CheckBox.Checked)
                    {
                        albums.Add(album.Album);
                    }
                }
            }
            AlbumDownloader albumDownloader = new AlbumDownloader(albums);
            albumDownloader.Show();
        }
        
        private void loadFriends(User i_User)
        {
            foreach (User friend in i_User.Friends)
            {
                UserUI newUserUI = new UserUI(friend);
                mainFlowLayoutPanel.Controls.Add(newUserUI);
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

        private void loadLikedPages(User i_User)
        {
            foreach (Page page in i_User.LikedPages)
            {
                PageUI newPageUI = new PageUI(page);
                mainFlowLayoutPanel.Controls.Add(newPageUI);
            }
        }

        private void loadGroups(User i_User)
        {
            foreach (Group group in i_User.Groups)
            {
                GroupUI newGroupUI = new GroupUI(group);
                mainFlowLayoutPanel.Controls.Add(newGroupUI);
            }
        }

        private void fetchUserInfo()
        {
            userBindingSource.DataSource = m_User;
        }
    }
}
