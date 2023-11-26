using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public class friendsBirthdays
    {
        private string m_name;
        private DateTime m_birthdayDate;
        private User m_LoggedInUser;
        protected friendsBirthdays[] m_friendsBirthdayArray;
        protected StringBuilder m_stringBuilder = new StringBuilder();

        public string Name 
        { 
            get { return m_name; } 
        }

        public DateTime BirthdayDate 
        { 
            get { return m_birthdayDate; } 
        }

        public User LoggedInUser 
        { 
            get { return m_LoggedInUser; } 
        }

        public friendsBirthdays[] FriendsBirthdayArray 
        { 
            get { return m_friendsBirthdayArray; } 
        }

        public StringBuilder StringBuilder 
        {
            get { return m_stringBuilder; } 
        }

        public friendsBirthdays()
        {
        }

        public friendsBirthdays(User i_LoggedInUser)
        {
            m_LoggedInUser = i_LoggedInUser;
            int i = 0;
            int arraySize = m_LoggedInUser.Friends.Count;

            m_friendsBirthdayArray = new friendsBirthdays[arraySize];
            foreach (User friend in m_LoggedInUser.Friends)
            {
                m_friendsBirthdayArray[i] = new friendsBirthdays();
                m_friendsBirthdayArray[i].m_birthdayDate = DateTime.ParseExact(friend.Birthday, "MM/dd/yyyy", CultureInfo.InvariantCulture);
                m_friendsBirthdayArray[i].m_name = friend.Name;
                i++;
            }
        }
    }
}