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
    public partial class PhotoUI : UserControl
    {
        public PhotoUI(Photo i_Photo)
        {
            InitializeComponent();
            m_Photo = i_Photo;
            fetchPhotoDetails();
        }

        private void fetchPhotoDetails()
        {
            pictureBox.LoadAsync(m_Photo.PictureNormalURL);
        }

        Photo m_Photo;
        private void pictureBox_Click(object sender, EventArgs e)
        {
            PostDetails postDetails = new PostDetails(m_Photo);
            postDetails.Show();
        }
    }
}
