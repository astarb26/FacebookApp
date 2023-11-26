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
    public partial class PagesForm : Form
    {
        private User m_LoggedInUser;
        private MyFacebookPage myFacebookPage;

        public PagesForm(User i_LoggedInUser)
        {
            InitializeComponent();
            m_LoggedInUser = i_LoggedInUser;
        }

            private void buttonProfile_Click(object sender, EventArgs e)
        {
            FormMain formMain = new FormMain();
            this.Hide();
            formMain.ShowDialog();
        }

        private void buttonFetchPages_Click(object sender, EventArgs e)
        {
            myFacebookPage = new MyFacebookPage(m_LoggedInUser, listBoxPages);
            List<FacebookPageInfo> pages = myFacebookPage.GetPages();
            DisplayOption displayOption = GetSelectedDisplayOption(); // Implement this method to get the selected display option from the user interface
            myFacebookPage.DisplayPages(pages, displayOption);
        }

        private DisplayOption GetSelectedDisplayOption()
        {
            string selectedOption = comboBox1.SelectedItem.ToString();

            if (selectedOption == "Name")
            {
                return DisplayOption.Name;
            }
            else if (selectedOption == "Likes")
            {
                return DisplayOption.Likes;
            }
            else if (selectedOption == "Id")
            {
                return DisplayOption.Id;
            }
            else if (selectedOption == "Category")
            {
                return DisplayOption.Category;
            }
            else if (selectedOption == "All")
            {
                return DisplayOption.All;
            }

            return DisplayOption.Name;
        }
    }
}
