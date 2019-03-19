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
    public partial class AlbumDetails : Form
    {
        public AlbumDetails(Album i_Album)
        {
            InitializeComponent();
            m_Album = i_Album;
            fetchAlbumDetails();
        }

        private void fetchAlbumDetails()
        {
            detailsLabel.Text = m_Album.ToString();
            thumPictureBox.LoadAsync(m_Album.PictureAlbumURL);
        }

        Album m_Album;
    }
}
