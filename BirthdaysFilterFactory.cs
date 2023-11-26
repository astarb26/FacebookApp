using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public static class BirthdaysFilterFactory
    {
        public static friendsBirthdays CreateFilter(User i_LoggedInUser, string filterType, int? month = null, int year = 0, DateTime? date = null)
        {
            switch (filterType)
            {
                case "all":
                     return new AllUserFriendsfilter(i_LoggedInUser);
                case "month":
                     return new MonthFilterBirthdayList(i_LoggedInUser, month.Value);
                case "year":
                     return new YearFilterBirthdayList(i_LoggedInUser, year);
                case "date":
                     return new DateFilterBirthdayList(i_LoggedInUser, date.Value);
                case "sortDatesByProximityToToday":
                     return new SortedByProximity(i_LoggedInUser);
                default:
                     throw new ArgumentException("Invalid filter type");
            }
        }
    }
}
