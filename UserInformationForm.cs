using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public partial class UserInformationForm : Form
    {
        private User m_LoggedInUser;
        private IUserProfile m_UserProfile;

        public UserInformationForm(User i_LoggedInUser)
        {
            InitializeComponent();
            m_LoggedInUser = i_LoggedInUser;
            m_UserProfile = new FacebookUserProfile(m_LoggedInUser);
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            List<string> selectedOptions = checkedListBox1.CheckedItems.Cast<string>().ToList();

            if (selectedOptions.Any())
            {
                StringBuilder profileInfoBuilder = new StringBuilder();

                foreach (string selectedOption in selectedOptions)
                {
                    IUserProfile decorator = GetDecoratorByOption(selectedOption);
                    string profileInfo = decorator.GetProfileInfo(selectedOption);
                    profileInfoBuilder.AppendLine(profileInfo);
                }

                string profileInfoText = profileInfoBuilder.ToString().TrimEnd();
                listBoxInfo.Items.Clear();
                listBoxInfo.Items.AddRange(profileInfoText.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries));
            }
        }

        private IUserProfile GetDecoratorByOption(string option)
        {
            switch (option)
            {
                case "Name":
                    return new NameDecorator(m_UserProfile, option);
                case "Id":
                    return new IdDecorator(m_UserProfile, option);
                case "Birthday":
                    return new BirthdayDecorator(m_UserProfile, option);
                case "Email":
                    return new EmailDecorator(m_UserProfile, option);
                default:
                    return m_UserProfile;
            }
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            FormMain formMain = new FormMain();
            this.Hide();
            formMain.ShowDialog();
        }
    }
}
