using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public class MonthFilterBirthdayList : friendsBirthdays
    {
        private int m_month;

        public MonthFilterBirthdayList(User i_LoggedInUser, int i_month) : base(i_LoggedInUser)
        {
            m_month = i_month;
            m_stringBuilder = new StringBuilder();

            for (int i = 0; i < m_friendsBirthdayArray.Length; i++)
            {
                if (m_friendsBirthdayArray[i].BirthdayDate.Month == m_month)
                {
                    string friendDisplay = string.Format("{0} {1}  ", m_friendsBirthdayArray[i].Name, m_friendsBirthdayArray[i].BirthdayDate);
                    m_stringBuilder.AppendLine(friendDisplay);
                }
            }
        }
    }
}