using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper;
using Facebook;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public class FacebookClient
    {
        private readonly User m_LoggedInUser;

        public FacebookClient(User loggedInUser)
        {
            m_LoggedInUser = loggedInUser;
        }

        public List<Postf> GetPosts()
        {
            var posts = new List<Postf>();

            foreach (Post post in m_LoggedInUser.Posts)
            {
                posts.Add(new Postf(post.Message, post.Caption, post.Description, post.PictureURL));
            }

            return posts;
        }
    }
}
