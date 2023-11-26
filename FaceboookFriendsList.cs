using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public class FaceboookFriendsList : IEnumerable<FacebookFriendData>
    {
        private readonly List<FacebookFriendData> m_friendslist;
        private User m_LoggedInUser;

        public FaceboookFriendsList(User i_LoggedInUser)
        {
            m_LoggedInUser = i_LoggedInUser;
            m_friendslist = new List<FacebookFriendData>();

            foreach (User friend in m_LoggedInUser.Friends)
            {
                FacebookFriendData newFriend = new FacebookFriendData
                {
                    Name = friend.Name,
                    FriendEmail = friend.Email,
                    Educations = friend.Educations,
                    Birthday = friend.Birthday,
                    Gender = (User.eGender)friend.Gender,
                    Languages = friend.Languages,
                    InterestedIn = friend.InterestedIn,
                    RelationshipStatus = (User.eRelationshipStatus)friend.RelationshipStatus,
                    Location = friend.Location,
                    Link = friend.Link
                };

                m_friendslist.Add(newFriend);
            }
        }

        public IEnumerator<FacebookFriendData> GetEnumerator()
        {
            return m_friendslist.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}