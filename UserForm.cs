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
using B19_Ex01_Matan_311116313_Moshe_305097453.PostUI;

namespace B19_Ex01_Matan_311116313_Moshe_305097453
{
    public partial class UserForm : Form
    {
        public UserForm(User i_User)
        {
            InitializeComponent();
            m_User = i_User;
            m_PostFactory = new PostUI.PostFactory.PostFactory();
            fetchUserInfo();
        }

        private User m_User;
        private PostUI.PostFactory.PostFactory m_PostFactory;

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
            sortFreindsInit();
            foreach (User friend in i_User.Friends)
            {
                UserUI newUserUI = new UserUI(friend);
                mainFlowLayoutPanel.Controls.Add(newUserUI);
            }
        }

        private void sortFreindsInit()
        {
            Label sortByLabel = new Label();
            sortByLabel.Text = "SortBy";
            topFlowLayoutPanel.Controls.Add(sortByLabel);
            ComboBox sortComboBox = new ComboBox();
            sortComboBox.Items.AddRange(new object[] {
            "Age",
            "Name",
            "Friends",
            "Genger"});
            SortStrategy<UserUI> sortStrategy = new SortStrategy<UserUI>();
            {
                List<UserUI> users = new List<UserUI>();
                foreach (UserUI user in mainFlowLayoutPanel.Controls)
                {
                    users.Add(user);
                    mainFlowLayoutPanel.Controls.Remove(user);
                }

                switch (sortComboBox.SelectedText)
                {
                    case "Name":
                        sortStrategy.SetComperElements((user_x,user_y) => {
                            if (user_x.User.Name.ToString().CompareTo(user_y.User.Name.ToString()) == -1)
                                return true;
                            else
                                return false;
                        });
                        break;
                    case "Age":
                        sortStrategy.SetComperElements((user_x, user_y) => {
                            if (user_x.User.Birthday.ToString().TrimEnd('-').CompareTo(user_y.User.Birthday.ToString().TrimEnd('-')) == -1)
                                return true;
                            else
                                return false;
                        });
                        break;
                    case "Gender":
                        sortStrategy.SetComperElements((user_x, user_y) => {
                            if (user_x.User.Gender.Value.Equals("male") && user_x.User.Gender.Value.Equals("female"))
                                return true;
                            else
                                return false;
                        });
                        break;
                    case "Friends":
                        sortStrategy.SetComperElements((user_x, user_y) => {
                            return (user_x.User.FriendLists.Count < user_y.User.FriendLists.Count);
                        });
                        break;
                    case "Statuses Number":
                        sortStrategy.SetComperElements((user_x, user_y) => {
                            return (user_x.User.Statuses.Count < user_y.User.Statuses.Count);
                        });
                        break;
                    default:
                        break;
                }
                mainFlowLayoutPanel.Controls.AddRange(sortStrategy.Sort(users).ToArray());
            };

        }

        private void loadWallPosts(User i_User)
        {
            foreach (Post post in i_User.NewsFeed)
            {
                PostUI.PostUI postui = m_PostFactory.createUI(post);
                mainFlowLayoutPanel.Controls.Add(postui);
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
