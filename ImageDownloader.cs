using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B19_Ex01_Matan_311116313_Moshe_305097453
{
    class ImageDownloader
    {
        private System.Drawing.Image DownloadImageFromUrl(string imageUrl)
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
        public static void DownloadToFile(String i_Root, String i_url, String i_name)
        {
            System.Drawing.Image image = DownloadImageFromUrl(i_url);

            string rootPath = i_Root;
            string fileName = System.IO.Path.Combine(rootPath, i_name);
            image.Save(fileName);
        }
    }
}
