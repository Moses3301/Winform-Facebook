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
    public partial class AlbumUI : UserControl
    {
        public AlbumUI(Album i_Album)
        {
            InitializeComponent();
            m_Album = i_Album;
            fetchAlbumInfo();
        }
        Album m_Album;
        public Album Album { get { return m_Album; } }
        public CheckBox CheckBox { get { return checkBox; } }
        private void fetchAlbumInfo()
        {
            albumBindingSource.DataSource = m_Album;
        }

        private void coverPictureBox_Click(object sender, EventArgs e)
        {
            AlbumDetails albumDetails = new AlbumDetails(m_Album);
            albumDetails.Show();
        }
    }
}
