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
    public partial class GroupUI : UserControl
    {
        private Group m_Group;

        public GroupUI()
        {
            InitializeComponent();
        }

        public GroupUI(Group i_Group)
        {
            InitializeComponent();
            m_Group = i_Group;
        }

        private void fetchGroupInfo()
        {
            profileOvalPictureBox.LoadAsync(m_Group.PictureLargeURL);
            nameLabel.Text = m_Group.Name;

        }

        private void watch_members_click(object sender, EventArgs e)
        {
            UserDetails userDetails = new UserDetails(m_Group.Members);
        }
    }
}
