using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public class DateFilterBirthdayList : friendsBirthdays
    {
        private DateTime m_date;

        public DateFilterBirthdayList(User i_LoggedInUser, DateTime i_date) : base(i_LoggedInUser)
        {
            m_date = i_date;

            m_stringBuilder = new StringBuilder();

            for (int i = 0; i < m_friendsBirthdayArray.Length; i++)
            {
                if (m_friendsBirthdayArray[i].BirthdayDate == m_date)
                {
                    string friendDisplay = string.Format("{0} {1} \n", m_friendsBirthdayArray[i].Name, m_friendsBirthdayArray[i].BirthdayDate);
                    m_stringBuilder.AppendLine(friendDisplay);
                }
            }
        }
    }
}