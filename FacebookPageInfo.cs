using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public class FacebookPageInfo
    {
        public string Id { get; }

        public string Name { get; }

        public string Category { get; }

        public long LikesCount { get; }

        public FacebookPageInfo(string id, string name, string category, long likesCount)
        {
            Id = id;
            Name = name;
            Category = category;
            LikesCount = likesCount;
        }
    }
}
