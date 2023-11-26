using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public class NewPost
    {
        public string Content { get; set; }

        public string PictureURL { get; set; }

        public string Video { get; set; }

        private NewPost()
        {
        }

        public class Builder
        {
            private NewPost post;

            public Builder()
            {
                post = new NewPost();
            }

            public Builder WithContent(string content)
            {
                post.Content = content;
                return this;
            }

            public Builder WithPictureURL(string pictureURL)
            {
                post.PictureURL = pictureURL;
                return this;
            }

            public Builder WithVideo(string video)
            {
                post.Video = video;
                return this;
            }

            public NewPost Build()
            {
                return post;
            }
        }

        public override string ToString()
        {
            return Content;
        }
    }
}