using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        private const string k_AppId = "752017769879192";
        private static readonly string[] sr_Permission =
     {
               "email",
                    "public_profile",
                    "user_age_range",
                    "user_birthday",
                    "user_events",
                    "user_friends",
                    "user_gender",
                    "user_hometown",
                    "user_likes",
                    "user_link",
                    "user_location",
                    "user_photos",
                    "user_posts",
                    "user_videos"
        };

        private User m_LoggedInUser;
        private LoginResult m_LoginResult;
        private AlbumSaverAdapter albumSaverAdapter;
        private Albums myAlbum;

        public FormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 200;
            myAlbum = new Albums("album_id", "My Album", "album_picture_url");
            albumSaverAdapter = new AlbumSaverAdapter(myAlbum);
        }

        private void loginAndInit()
        {
            m_LoginResult = FacebookService.Login(k_AppId, sr_Permission);

            if (!string.IsNullOrEmpty(m_LoginResult.AccessToken))
            {
                m_LoggedInUser = m_LoginResult.LoggedInUser;

                fetchUserInfo();
                initializeLabelUserName();
            }
            else
            {
                MessageBox.Show(m_LoginResult.ErrorMessage, "Login Failed");
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("design.patterns.22aa"); /// the current password for Desig Patter

            loginAndInit();
        }

        private void listBoxPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
 
        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FacebookService.LogoutWithUI();
            buttonLogin.Text = "Login";
        }

        private void fetchUserInfo()
        {
            pictureBoxProfile.LoadAsync(m_LoggedInUser.PictureNormalURL);
        }

        private void textBoxStatus_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        { 
        }

        private void listBoxPostComments_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void listBoxAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            displaySelectedAlbum();
        }

        private void displaySelectedAlbum()
        {
            if (listBoxAlbums.SelectedItems.Count == 1)
            {
                Albums selectedAlbum = listBoxAlbums.SelectedItem as Albums;
                if (selectedAlbum.PictureAlbumURL != null)
                {
                    pictureBoxAlbum.LoadAsync(selectedAlbum.PictureAlbumURL);
                }
                else
                {
                    pictureBoxProfile.Image = pictureBoxProfile.ErrorImage;
                }
            }
        }

        private void pictureBoxAlbum_Click(object sender, EventArgs e)
        {
        }

        private void fetchAlbums()
        {
            listBoxAlbums.Items.Clear();
            listBoxAlbums.DisplayMember = "Name";

            foreach (var albums in m_LoggedInUser.Albums)
            {
                Albums newAlbum = new Albums(albums.Id, albums.Name, albums.PictureAlbumURL);
                listBoxAlbums.Items.Add(newAlbum);
            }

            if (listBoxAlbums.Items.Count == 0)
            {
                MessageBox.Show("No Albums to retrieve :(");
            }
        }

        private void fetchSaveAlbums(Albums selectedAlbum = null)
        {
            listBoxAlbums.Items.Clear();
            listBoxAlbums.DisplayMember = "Name";
            albumSaverAdapter = new AlbumSaverAdapter(selectedAlbum);

            foreach (var albums in m_LoggedInUser.Albums)
            {
                if (selectedAlbum == null || albums.Id == selectedAlbum.Id)
                {
                    string albumName = albumSaverAdapter.GetAlbumName();
                    listBoxSaveAlbum.Items.Add(albumName);
                }
            }

            if (listBoxSaveAlbum.Items.Count == 0)
            {
                MessageBox.Show("No Albums to retrieve :(");
            }
        }

        private void pictureBoxCover_Click(object sender, EventArgs e)
        {
        }

        private void listBoxFriends_SelectedIndexChanged(object sender, EventArgs e)
        { 
        }

        private void textBoxSearchFriend_TextChanged(object sender, EventArgs e)
        { 
        }

        private void initializeLabelUserName()
        {
            labelUserName.Text = m_LoggedInUser.Name;
        }

        private void basicInformation()
        {
            string nameInfo = string.Format("Name: {0}", m_LoggedInUser.Name);
            string birthdayInfo = string.Format("Birthday: {0}", m_LoggedInUser.Birthday);

            listBoxInfo.Items.Add(nameInfo);
            listBoxInfo.Items.Add(string.Empty);
            listBoxInfo.Items.Add(birthdayInfo);
            listBoxInfo.Items.Add(string.Empty);
            listBoxInfo.Items.Add(string.Format("Gender: {0}", m_LoggedInUser.Gender));
        }

        private void buttoninformation_Click(object sender, EventArgs e)
        {
            basicInformation();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BirthdaysForm friendsBirthday = new BirthdaysForm(m_LoggedInUser);
            this.Hide();
            friendsBirthday.ShowDialog();
        }

        private void buttonAlbums_Click(object sender, EventArgs e)
        {
            fetchAlbums();
        }

        private void buttonEvents_Click(object sender, EventArgs e)
        {
            FormPost posts = new FormPost(m_LoggedInUser);
            this.Hide();
            posts.ShowDialog();
        }

        private void buttonSaveAlbum_Click(object sender, EventArgs e)
        {
            if (listBoxAlbums.SelectedItems.Count == 1)
            {
                Albums selectedAlbum = listBoxAlbums.SelectedItem as Albums;

                if (selectedAlbum != null)
                {
                    albumSaverAdapter.SaveAlbum(selectedAlbum);
                    fetchSaveAlbums(selectedAlbum);
                }
            }
        }

        private void listBoxSaveAlbum_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxSaveAlbum.SelectedItems.Count == 1)
            {
                string selectedAlbumName = listBoxSaveAlbum.SelectedItem as string;
                if (!string.IsNullOrEmpty(selectedAlbumName))
                {
                    string pictureURL = albumSaverAdapter.GetAlbumPictureURL();
                    string id = albumSaverAdapter.GetAlbumId();

                    if (!string.IsNullOrEmpty(pictureURL))
                    {
                        pictureBoxSavePhotoA.LoadAsync(pictureURL);
                        textBoxSaveDate.Text = id;
                    }
                    else
                    {
                        pictureBoxSavePhotoA.Image = pictureBoxSavePhotoA.ErrorImage;
                    }
                }
            }
        }

        private void buttonPages_Click(object sender, EventArgs e)
        {
            FormDataBinding pages = new FormDataBinding(m_LoggedInUser);
            this.Hide();
            pages.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserInformationForm info = new UserInformationForm(m_LoggedInUser);
            this.Hide();
            info.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PagesForm page = new PagesForm(m_LoggedInUser);
            this.Hide();
            page.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DatingForm dating = new DatingForm(m_LoggedInUser);
            this.Hide();
            dating.ShowDialog();
        }
    }
}
