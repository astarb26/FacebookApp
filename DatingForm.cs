using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public partial class DatingForm : Form
    {
        private User m_LoggedInUser;
        private IEnumerable<FacebookFriendData> filteredFriends;
        private FaceboookFriendsList friendsList;

        public DatingForm(User i_LoggedInUser)
        {
            InitializeComponent();
            m_LoggedInUser = i_LoggedInUser;
            friendsList = new FaceboookFriendsList(m_LoggedInUser);
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            listBoxDating.Items.Clear();
            string userGender = comboBox1.SelectedItem.ToString();
            string userInterestedIn = comboBox2.SelectedItem.ToString();
            filteredFriends = filterFriendsList(friendsList, userGender, userInterestedIn);

            foreach (FacebookFriendData friendData in filteredFriends)
            {
                listBoxDating.Items.Add(friendData.Name);
                listBoxDating.Items.Add($"Gender: {friendData.Gender}");
                listBoxDating.Items.Add($"Location: {friendData.Location}");
                listBoxDating.Items.Add($"Birthday: {friendData.Birthday}");
                listBoxDating.Items.Add($"Link: {friendData.Link}");

                listBoxDating.Items.Add(string.Empty); // Add a blank line
                                                       // Add other information as desired
                listBoxDating.Items.Add(string.Empty); // Add a blank line
            }
        }

        private IEnumerable<FacebookFriendData> filterFriendsList(FaceboookFriendsList friendsList, string userGender, string userInterestedIn)
        {
            if (userGender == "Female")
            {
                if (userInterestedIn == "Female")
                {
                    filteredFriends = friendsList.Where(friend =>
                    friend.Gender == User.eGender.female &&
                    (friend.InterestedIn == null || friend.InterestedIn.Contains(User.eGender.female)));
                }
                else if (userInterestedIn == "Male")
                {
                    filteredFriends = friendsList.Where(friend =>
                    friend.Gender == User.eGender.female &&
                    (friend.InterestedIn == null || friend.InterestedIn.Contains(User.eGender.male)));
                }
                else
                {
                    filteredFriends = friendsList.Where(friend =>
                    friend.Gender == User.eGender.female && friend.Gender == User.eGender.male &&
                    (friend.InterestedIn == null || friend.InterestedIn.Contains(User.eGender.female)));
                }
            }
            else if (userGender == "Male")
            {
                if (userInterestedIn == "Female")
                {
                    filteredFriends = friendsList.Where(friend =>
                    friend.Gender == User.eGender.male &&
                    (friend.InterestedIn == null || friend.InterestedIn.Contains(User.eGender.female)));
                }
                else if (userInterestedIn == "Male")
                {
                    filteredFriends = friendsList.Where(friend =>
                    friend.Gender == User.eGender.male &&
                    (friend.InterestedIn == null || friend.InterestedIn.Contains(User.eGender.male)));
                }
                else
                {
                    filteredFriends = friendsList.Where(friend =>
                    friend.Gender == User.eGender.female && friend.Gender == User.eGender.male &&
                    (friend.InterestedIn == null || friend.InterestedIn.Contains(User.eGender.male)));
                }
            }
            else
            {
                filteredFriends = friendsList.Where(friend =>
                friend.Gender == User.eGender.female && friend.Gender == User.eGender.male &&
                (friend.InterestedIn == null));
            }

            return filteredFriends; 
        }

        private void buttonFacebookProfile_Click(object sender, EventArgs e)
        {
            FormMain formMain = new FormMain();
            this.Hide();
            formMain.ShowDialog();
        }
    }
}
