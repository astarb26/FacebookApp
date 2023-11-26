using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public class AllUserFriendsfilter : friendsBirthdays
    {        
        public AllUserFriendsfilter(User i_LoggedInUser) : base(i_LoggedInUser)
        {
            m_stringBuilder = new StringBuilder();

            for (int i = 0; i < m_friendsBirthdayArray.Length; i++)
            {
                string friendDisplay = string.Format("{0} {1}  ", m_friendsBirthdayArray[i].Name, m_friendsBirthdayArray[i].BirthdayDate);
                m_stringBuilder.AppendLine(friendDisplay);
            }
        }
    }
}
