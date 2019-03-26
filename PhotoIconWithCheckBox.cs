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
    public partial class PhotoIconWithCheckBox : UserControl
    {
        public PhotoIconWithCheckBox(Photo i_Photo)
        {
            InitializeComponent();
            m_Photo = i_Photo;
            fetchPhotoInfo();
        }

        Photo m_Photo;
        public CheckBox CheckBox { get { return checkBox; } }
        public Photo Photo { get { return m_Photo; } }
        private void fetchPhotoInfo()
        {
            pictureBox.LoadAsync(m_Photo.PictureNormalURL);
        }
    }
}
