using FacebookWrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B19_Ex01_Matan_311116313_Moshe_305097453
{   // this is the program
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoginResult result = FacebookService.Login("2069724039730421", /// (desig patter's "Design Patterns Course App 2.4" app)

            "public_profile",
            "email",
            "publish_to_groups",
            "user_birthday",
            "user_age_range",
            "user_gender",
            "user_link",
            "user_tagged_places",
            "user_videos",
            "publish_to_groups",
            "groups_access_member_info",
            "user_friends",
            "user_events",
            "user_likes",
            "user_location",
            "user_photos",
            "user_posts",
            "user_hometown"
          );

            if (!string.IsNullOrEmpty(result.AccessToken))
            {
                Application.Run(new UserForm(result.LoggedInUser));
            }
            else
            {
                MessageBox.Show(result.ErrorMessage);
            }         
        }
    }
}
