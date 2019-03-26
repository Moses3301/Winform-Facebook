using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B19_Ex01_Matan_311116313_Moshe_305097453
{
    public partial class AlbumDownloader : Form
    {
        private ICollection<Album> m_Albums;
        private string imageUrl;

        public AlbumDownloader(ICollection<Album> i_Albums)
        {
            InitializeComponent();
            m_Albums = i_Albums;
            loadPhotos();
            submitTexBox.SubmitButton.Text = "save";
            submitTexBox.SubmitButton.Click += new EventHandler(saveButton_Click);
        }
        public System.Drawing.Image DownloadImageFromUrl(string imageUrl)
        {
            System.Drawing.Image image = null;

            try
            {
                System.Net.HttpWebRequest webRequest = (System.Net.HttpWebRequest)System.Net.HttpWebRequest.Create(imageUrl);
                webRequest.AllowWriteStreamBuffering = true;
                webRequest.Timeout = 30000;

                System.Net.WebResponse webResponse = webRequest.GetResponse();

                System.IO.Stream stream = webResponse.GetResponseStream();

                image = System.Drawing.Image.FromStream(stream);

                webResponse.Close();
            }
            catch (Exception ex)
            {
                return null;
            }

            return image;
        }
        private void loadPhotos()
        {
            foreach(Album album in m_Albums)
            {
                foreach (Photo photo in album.Photos)
                {
                    PhotoIconWithCheckBox newPhoto = new PhotoIconWithCheckBox(photo);
                    flowLayoutPanel.Controls.Add(newPhoto);
                }
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string rootPath = @submitTexBox.TextBox.Text.ToString();

            foreach (Control control in flowLayoutPanel.Controls)
            {
                PhotoIconWithCheckBox photo = control as PhotoIconWithCheckBox;
                if (photo != null)
                {
                    if (photo.CheckBox.Checked)
                    {
                        try
                        {
                            System.Drawing.Image image = DownloadImageFromUrl(photo.Photo.PictureNormalURL.Trim());
                            string photoName = photo.Photo.Name;
                            if (photoName == null)
                            {
                                photoName = photo.Photo.CreatedTime.ToString();
                            }

                            photoName = string.Concat(photoName.Where(char.IsLetterOrDigit));
                            string fileName = System.IO.Path.Combine(rootPath, photoName + ".jpg");
                            image.Save(fileName);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            break;
                        }
                    }
                }
            }
        }
    }
}
