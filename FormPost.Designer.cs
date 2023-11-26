namespace BasicFacebookFeatures
{
    public partial class FormPost
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonProfile = new System.Windows.Forms.Button();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.buttonPost = new System.Windows.Forms.Button();
            this.buttonNewPost = new System.Windows.Forms.Button();
            this.buttonPhoto = new System.Windows.Forms.Button();
            this.textBoxNewPost = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxPhoto = new System.Windows.Forms.PictureBox();
            this.pictureBoxPost = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPost)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonProfile
            // 
            this.buttonProfile.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonProfile.BackgroundImage = global::BasicFacebookFeatures.Properties.Resources.images;
            this.buttonProfile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonProfile.Image = global::BasicFacebookFeatures.Properties.Resources.image002_png;
            this.buttonProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProfile.Location = new System.Drawing.Point(582, 206);
            this.buttonProfile.Name = "buttonProfile";
            this.buttonProfile.Size = new System.Drawing.Size(243, 51);
            this.buttonProfile.TabIndex = 0;
            this.buttonProfile.Text = "Facebook Profile";
            this.buttonProfile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonProfile.UseVisualStyleBackColor = false;
            this.buttonProfile.Click += new System.EventHandler(this.buttonProfile_Click);
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.ItemHeight = 16;
            this.listBoxPosts.Location = new System.Drawing.Point(54, 361);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(479, 276);
            this.listBoxPosts.TabIndex = 1;
            this.listBoxPosts.SelectedIndexChanged += new System.EventHandler(this.listBoxEvents_SelectedIndexChanged);
            // 
            // buttonPost
            // 
            this.buttonPost.BackgroundImage = global::BasicFacebookFeatures.Properties.Resources.images;
            this.buttonPost.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonPost.Image = global::BasicFacebookFeatures.Properties.Resources.image002_png;
            this.buttonPost.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPost.Location = new System.Drawing.Point(54, 285);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(184, 54);
            this.buttonPost.TabIndex = 3;
            this.buttonPost.Text = "Fetch Posts";
            this.buttonPost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonPost.UseVisualStyleBackColor = true;
            this.buttonPost.Click += new System.EventHandler(this.buttonEvents_Click);
            // 
            // buttonNewPost
            // 
            this.buttonNewPost.Image = global::BasicFacebookFeatures.Properties.Resources.images;
            this.buttonNewPost.Location = new System.Drawing.Point(586, 361);
            this.buttonNewPost.Name = "buttonNewPost";
            this.buttonNewPost.Size = new System.Drawing.Size(111, 55);
            this.buttonNewPost.TabIndex = 4;
            this.buttonNewPost.Text = "New Post";
            this.buttonNewPost.UseVisualStyleBackColor = true;
            this.buttonNewPost.Click += new System.EventHandler(this.buttonNewPost_Click);
            // 
            // buttonPhoto
            // 
            this.buttonPhoto.Image = global::BasicFacebookFeatures.Properties.Resources.images;
            this.buttonPhoto.Location = new System.Drawing.Point(716, 361);
            this.buttonPhoto.Name = "buttonPhoto";
            this.buttonPhoto.Size = new System.Drawing.Size(110, 55);
            this.buttonPhoto.TabIndex = 5;
            this.buttonPhoto.Text = "Photo";
            this.buttonPhoto.UseVisualStyleBackColor = true;
            this.buttonPhoto.Click += new System.EventHandler(this.buttonPhoto_Click);
            // 
            // textBoxNewPost
            // 
            this.textBoxNewPost.Location = new System.Drawing.Point(586, 441);
            this.textBoxNewPost.Name = "textBoxNewPost";
            this.textBoxNewPost.Size = new System.Drawing.Size(239, 22);
            this.textBoxNewPost.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::BasicFacebookFeatures.Properties.Resources.images__1_;
            this.pictureBox1.Location = new System.Drawing.Point(54, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(875, 162);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxPhoto
            // 
            this.pictureBoxPhoto.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBoxPhoto.Location = new System.Drawing.Point(619, 482);
            this.pictureBoxPhoto.Name = "pictureBoxPhoto";
            this.pictureBoxPhoto.Size = new System.Drawing.Size(170, 145);
            this.pictureBoxPhoto.TabIndex = 7;
            this.pictureBoxPhoto.TabStop = false;
            // 
            // pictureBoxPost
            // 
            this.pictureBoxPost.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBoxPost.Location = new System.Drawing.Point(353, 482);
            this.pictureBoxPost.Name = "pictureBoxPost";
            this.pictureBoxPost.Size = new System.Drawing.Size(180, 155);
            this.pictureBoxPost.TabIndex = 2;
            this.pictureBoxPost.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(596, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 32);
            this.label1.TabIndex = 20;
            this.label1.Text = "Create a New Post:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Yellow;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label2.Location = new System.Drawing.Point(58, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 28);
            this.label2.TabIndex = 21;
            this.label2.Text = "Your Posts:";
            // 
            // FormPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::BasicFacebookFeatures.Properties.Resources.images;
            this.ClientSize = new System.Drawing.Size(975, 655);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBoxPhoto);
            this.Controls.Add(this.textBoxNewPost);
            this.Controls.Add(this.buttonPhoto);
            this.Controls.Add(this.buttonNewPost);
            this.Controls.Add(this.buttonPost);
            this.Controls.Add(this.pictureBoxPost);
            this.Controls.Add(this.listBoxPosts);
            this.Controls.Add(this.buttonProfile);
            this.Name = "FormPost";
            this.Text = "Facebook Posts";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonProfile;
        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.PictureBox pictureBoxPost;
        private System.Windows.Forms.Button buttonPost;
        private System.Windows.Forms.Button buttonNewPost;
        private System.Windows.Forms.Button buttonPhoto;
        private System.Windows.Forms.TextBox textBoxNewPost;
        private System.Windows.Forms.PictureBox pictureBoxPhoto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}