using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public class FacebookUserProfile : IUserProfile
    {
        private User m_User;

        public FacebookUserProfile(User user)
        {
            m_User = user;
        }

        public string GetProfileInfo(string selectedOption)
        {
            switch (selectedOption)
            {
                case "Name":
                    return m_User.Name;
                case "Birthday":
                    return m_User.Birthday;
                case "Email":
                    return m_User.Email;
                case "Id":
                    return m_User.Id;
                default:
                    return string.Empty;
            }
        }
    }
}
