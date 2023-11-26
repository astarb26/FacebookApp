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
    public partial class BirthdaysForm : Form
    {
        private User m_LoggedInUser;
        private string filterType;
        private friendsBirthdays birthdayList;

        public BirthdaysForm(User i_LoggedInUser)
        {
            InitializeComponent();
            m_LoggedInUser = i_LoggedInUser;
        }
      
        private void dateTimePickerYear_ValueChanged(object sender, EventArgs e)
        {
            listBoxFriends.Items.Clear();
            int selectedYear = dateTimePickerYear.Value.Year;
            filterType = "year";
            friendsBirthdays birthdayList = BirthdaysFilterFactory.CreateFilter(m_LoggedInUser, filterType, year: selectedYear);
            listBoxInserting(birthdayList);
        }

        private void buttonFetchFriends_Click(object sender, EventArgs e)
        {
            listBoxFriends.Items.Clear();
            filterType = "all";
            birthdayList = BirthdaysFilterFactory.CreateFilter(m_LoggedInUser, filterType);
            listBoxInserting(birthdayList);
        }

        private void comboBoxMonth_SelectedIndexChanged(object sender, EventArgs e)
        {   
            listBoxFriends.Items.Clear();
            int selectedMonth = int.Parse(comboBoxMonth.SelectedItem.ToString());
            filterType = "month";
            birthdayList = BirthdaysFilterFactory.CreateFilter(m_LoggedInUser, filterType, selectedMonth);
            listBoxInserting(birthdayList);
        }

        private void listBoxInserting(friendsBirthdays birthdayList)
        {
            string[] substrings = birthdayList.StringBuilder.ToString().Split(new string[] { "  " }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string substring in substrings)
            {
                listBoxFriends.Items.Add(substring);
            }
        }

        private void buttonSortDescending_Click(object sender, EventArgs e)
        {
            listBoxFriends.Items.Clear();
            
            filterType = "sortDatesByProximityToToday";
            birthdayList = BirthdaysFilterFactory.CreateFilter(m_LoggedInUser, filterType);
            listBoxInserting(birthdayList);
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            FormMain formMain = new FormMain();
            this.Hide();
            formMain.ShowDialog();
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            listBoxFriends.Items.Clear();
            DateTime selectedDate = dateTimePickerYear.Value.Date;
            filterType = "date"; 
            friendsBirthdays birthdayList = BirthdaysFilterFactory.CreateFilter(m_LoggedInUser, filterType, date: selectedDate);
            listBoxInserting(birthdayList);
        }
    }
}
