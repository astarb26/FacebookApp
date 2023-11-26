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
    public class Postf
    {
        public string Message { get; set; }

        public string Caption { get; set; }

        public string Content { get; set; }

        public string Type { get; set; }

        public string From { get; set; }

        public string PostId { get; set; }

        public string PictureURL { get; set; }

        public string Location { get; set; }

        public List<string> Tags { get; set; }

        public Postf()
        {
        }

        public Postf(string message, string caption, string type, string photo)
        {
            Message = message;
            Caption = caption;
            Type = type;
            PictureURL = photo;
        }

        public void CreatePost()
        {
            Console.WriteLine("Creating a new post on Facebook:");
            Console.WriteLine("Content: " + Message);
            Console.WriteLine("Post created successfully!");
        }

        public override string ToString()
        {
        if (Message != null)
        {
            return Message;
        }
        else if (Caption != null)
        {
            return Caption;
        }
        else
        {
            return string.Format("[{0}]", Type);
        }
    }
}
}
