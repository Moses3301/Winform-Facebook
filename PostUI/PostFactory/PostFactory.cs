using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace B19_Ex01_Matan_311116313_Moshe_305097453.PostUI.PostFactory
{
    class PostFactory
    {
        public PostUI createUI(Post i_Post)
        {
            Post.eType? type = i_Post.Type;
            switch (type)
            {
                case Post.eType.checkin:
                    return new CheckInPostUI(i_Post);
                case Post.eType.photo:
                    return new PhotoPostUI(i_Post);
                case Post.eType.video:
                    return new VideoPostUI(i_Post);
                default:
                    return new PostUI(i_Post);
            }
        }
    }
}
