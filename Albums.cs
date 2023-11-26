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
    public class Albums
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string PictureAlbumURL { get; set; }
        
        public List<Photo> Photos { get; set; }
      
        public Albums(string id, string name, string pictureAlbumURL)
        {
            Id = id;
            Name = name;
            PictureAlbumURL = pictureAlbumURL;
            Photos = new List<Photo>();
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
