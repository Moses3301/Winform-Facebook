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
    public partial class UserUI : UserControl
    {
        private User m_User;

        public UserUI(User i_User)
        {
            InitializeComponent();
            m_User = i_User;
            fetchUserInfo();
        }

        private void fetchUserInfo()
        {
            userBindingSource.DataSource = m_User;
        }

        User User { get { return m_User; } }

        private void nameLabel1_Click(object sender, EventArgs e)
        {
            UserForm newWindow = new UserForm(m_User);
            newWindow.Show();
        }
    }
}
