using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public class FacebookFriendData
    {
        public string Name { get; set; }

        public string FriendEmail { get; set; }

        public string Birthday { get; set; }

        public Education[] Educations { get; set; }

        public User.eGender Gender { get; set; }

        public Page[] Languages { get; set; }

        public User.eGender[] InterestedIn { get; set; }

        public User.eRelationshipStatus RelationshipStatus { get; set; }

        public City Location { get; set; }

        public string Link { get; set; }
    }
}
