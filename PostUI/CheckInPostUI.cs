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
using System.Diagnostics;

namespace B19_Ex01_Matan_311116313_Moshe_305097453.PostUI
{
    public partial class CheckInPostUI : PostUI
    {
        public CheckInPostUI(Post i_Post) : base(i_Post)
        {
            InitializeComponent();
            this.LocationLinkLabel.Text = i_Post.ToString();
            bodyFlowLayoutPanel.Controls.Add(checkinPanel); 
        }

        private void LocationLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://www.google.com/maps/search/"+ sender.ToString());
            Process.Start(sInfo);
        }
    }
}
