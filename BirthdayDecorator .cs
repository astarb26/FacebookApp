using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public class BirthdayDecorator : IUserProfile
    {
        private IUserProfile m_DecoratedProfile;
        private string m_SelectedOption;

        public BirthdayDecorator(IUserProfile decoratedProfile, string selectedOption)
        {
            m_DecoratedProfile = decoratedProfile;
            m_SelectedOption = selectedOption;
        }

        public string GetProfileInfo(string selectedOption)
        {
            string decoratedInfo = m_DecoratedProfile.GetProfileInfo(selectedOption);
            string decoratedProfileInfo = string.Empty;

            switch (selectedOption)
            {
                case "Name":
                    decoratedProfileInfo = "Name: " + decoratedInfo;
                    break;
                case "Id":
                    decoratedProfileInfo = "Id: " + decoratedInfo;
                    break;
                case "Birthday":
                    decoratedProfileInfo = "Birthday: " + decoratedInfo;
                    break;
                case "Email":
                    decoratedProfileInfo = "Email: " + decoratedInfo;
                    break;
                default:
                    break;
            }

            return decoratedProfileInfo;
        }
    }
}
