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

namespace B19_Ex01_Matan_311116313_Moshe_305097453.PostUI
{
    public partial class PhotoPostUI : PostUI
    {
        public PhotoPostUI(Post i_Post) : base(i_Post)
        {
            InitializeComponent();
            this.pictureBox.LoadAsync(i_Post.PictureURL);
            this.bodyFlowLayoutPanel.Controls.Add(photoPanel);
        }
    }
}
