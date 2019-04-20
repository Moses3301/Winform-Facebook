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
    public partial class UserDetails : Form
    {
        private FacebookObjectCollection<User> m_Members;

        public UserDetails()
        {
            InitializeComponent();
        }

        public UserDetails(FacebookObjectCollection<User> i_Members)
        {
            InitializeComponent();
            m_Members = i_Members;
            fetchMembersDetails();
        }

        private void fetchMembersDetails()
        {
            foreach(User member in m_Members)
            {
                mainFlowLayoutPanel.Controls.Add(new UserUI(member));
            }
        }
    }
}
