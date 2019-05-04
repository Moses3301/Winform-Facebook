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
    public partial class PageUI : UserControl
    {
        private Page m_Page;

        public PageUI()
        {
            InitializeComponent();
        }

        public PageUI(Page i_Page)
        {
            InitializeComponent();
            m_Page = i_Page;
            fetchPageInfo();
        }

        private void fetchPageInfo()
        {
            pageBindingSource.DataSource = m_Page;
        }
    }
}
