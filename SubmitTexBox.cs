using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B19_Ex01_Matan_311116313_Moshe_305097453
{
    public partial class SubmitTexBox : UserControl
    {
        public delegate object SubmitTexBoxEventHandler(string str);
        public event SubmitTexBoxEventHandler SubmitClicked;
        public SubmitTexBox()
        {
            InitializeComponent();
        }
        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text)) { submitButton.Enabled = false; }
            else { submitButton.Enabled = true; }
        }
        protected virtual void onSubmitClick()
        {
            if (SubmitClicked!= null)
            {
                SubmitClicked(textBox.Text);
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            onSubmitClick();
        }
    }
}
