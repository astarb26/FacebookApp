using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public class AlbumSaverAdapter : IAlbumSaver
    {
        private Albums m_album;

        public AlbumSaverAdapter(Albums album)
        {
            m_album = album;
        }

        public void SaveAlbum(Albums album)
        {
        }

        public string GetAlbumName()
        {
            return m_album.Name;
        }

        public string GetAlbumId()
        {
            return m_album.Id.ToString();
        }

        public string GetAlbumPictureURL()
        {
            return m_album.PictureAlbumURL;
        }
    }
}
