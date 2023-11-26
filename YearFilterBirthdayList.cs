using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public class YearFilterBirthdayList : friendsBirthdays
    {
        private int m_year;

        public YearFilterBirthdayList(User i_LoggedInUser, int i_year) : base(i_LoggedInUser)
        {
            m_year = i_year;
            m_stringBuilder = new StringBuilder();

            for (int i = 0; i < m_friendsBirthdayArray.Length; i++)
            {
                if (m_friendsBirthdayArray[i].BirthdayDate.Year == m_year)
                {
                    string friendDisplay = string.Format("{0} {1}  ", m_friendsBirthdayArray[i].Name, m_friendsBirthdayArray[i].BirthdayDate);
                    m_stringBuilder.AppendLine(friendDisplay);
                }
            }
        }
    }
}
