using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public partial class FormPost : Form
    {
        private User m_LoggedInUser;
        private List<NewPost> createdPosts = new List<NewPost>();

        public FormPost(User i_LoggedInUser)
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

        private void buttonEvents_Click(object sender, EventArgs e)
        {
            new Thread(fetchPosts).Start();
        }

        private void fetchPosts()
        {
            listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Clear()));
            var fbClient = new FacebookClient(m_LoggedInUser);
            var posts = fbClient.GetPosts();

            foreach (Postf post in posts)
            {
                listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Add(post.ToString())));
            }

            foreach (var post in createdPosts)
            {
                listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Add(post.ToString())));
            }

            if (listBoxPosts.Items.Count == 0)
            {
                MessageBox.Show("No Posts to retrieve :(");
            }
        }

        private void listBoxEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            displaySelectedPost();
        }

        private void buttonNewPost_Click(object sender, EventArgs e)
        {
            string content = textBoxNewPost.Text;
            string photo = pictureBoxPhoto.ImageLocation;

            var post = new NewPost.Builder()
         .WithContent(content)
         .WithPictureURL(photo)
         .Build();

            createdPosts.Add(post);

            listBoxPosts.Items.Add(post.ToString());
            textBoxNewPost.Text = string.Empty;
            pictureBoxPhoto.Image = null;
        }

        private void buttonPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png, *.gif) | *.jpg; *.jpeg; *.png; *.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxPhoto.ImageLocation = openFileDialog.FileName;
            }
        }

        private void displaySelectedPost()
        {
            if (listBoxPosts.SelectedItems.Count == 1)
            {
                var selectedPost = listBoxPosts.SelectedItem as Postf;
                var selectedNewPost = listBoxPosts.SelectedItem as NewPost;
                string content = textBoxNewPost.Text;
                string photo = pictureBoxPhoto.ImageLocation;

                var post = new NewPost.Builder()
     .WithContent(content)
     .WithPictureURL(photo)
     .Build();

                if (listBoxPosts.SelectedItems.Count == 1)
                {
                    if (selectedPost != null)
                    {
                        content = selectedPost.Content;
                        photo = selectedPost.PictureURL;
                    }
                    else if (selectedNewPost != null)
                    {
                        content = selectedNewPost.Content;
                        photo = selectedNewPost.PictureURL;
                    }

                    if (!string.IsNullOrEmpty(photo))
                    {
                        pictureBoxPost.LoadAsync(photo);
                    }
                    else
                    {
                        pictureBoxPost.Image = pictureBoxPhoto.ErrorImage;
                    }
                }
            }
        }
    }
}
