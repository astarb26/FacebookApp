using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public class SortedByProximity : friendsBirthdays
    {
        public SortedByProximity(User i_LoggedInUser) : base(i_LoggedInUser)
        {
            DateTime today = DateTime.Today;
            friendsBirthdays[] futureBirthdays = m_friendsBirthdayArray.Where(birthday =>
            {
                DateTime bdayThisYear = new DateTime(today.Year, birthday.BirthdayDate.Month, birthday.BirthdayDate.Day);
                return bdayThisYear > today;
            }).ToArray();

            Array.Sort(
                futureBirthdays,
                (birthday1, birthday2) =>
                {
                    DateTime bday1 = birthday1.BirthdayDate.Date;
                    DateTime bday2 = birthday2.BirthdayDate.Date;
                    DateTime bday1ThisYear = new DateTime(today.Year, bday1.Month, bday1.Day);
                    DateTime bday2ThisYear = new DateTime(today.Year, bday2.Month, bday2.Day);
                    if (bday1ThisYear <= today)
                    {
                        bday1ThisYear = new DateTime(today.Year + 1, bday1.Month, bday1.Day);
                    }

                    if (bday2ThisYear <= today)
                    {
                        bday2ThisYear = new DateTime(today.Year + 1, bday2.Month, bday2.Day);
                    }

                    TimeSpan span1 = bday1ThisYear - today;
                    TimeSpan span2 = bday2ThisYear - today;
                    return span1.CompareTo(span2);
                });

            m_stringBuilder = new StringBuilder();

            for (int i = 0; i < futureBirthdays.Length; i++)
            {
                string friendDisplay = string.Format("{0} {1}  ", futureBirthdays[i].Name, futureBirthdays[i].BirthdayDate);
                m_stringBuilder.AppendLine(friendDisplay);
            }
        }
    }
}