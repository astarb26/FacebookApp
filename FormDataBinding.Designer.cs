namespace BasicFacebookFeatures
{
    public partial class FormDataBinding
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label imageNormalLabel;
            System.Windows.Forms.Label likesCountLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label countryLabel;
            this.buttonProfileFacebook = new System.Windows.Forms.Button();
            this.panelPages = new System.Windows.Forms.Panel();
            this.cityLabel1 = new System.Windows.Forms.Label();
            this.pageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.countryLabel1 = new System.Windows.Forms.Label();
            this.descriptionLabel1 = new System.Windows.Forms.Label();
            this.imageNormalPictureBox = new System.Windows.Forms.PictureBox();
            this.likesCountLabel1 = new System.Windows.Forms.Label();
            this.nameLabel1 = new System.Windows.Forms.Label();
            this.listBoxPages = new System.Windows.Forms.ListBox();
            this.buttonPages = new System.Windows.Forms.Button();
            this.pictureBoxPage = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            descriptionLabel = new System.Windows.Forms.Label();
            imageNormalLabel = new System.Windows.Forms.Label();
            likesCountLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            countryLabel = new System.Windows.Forms.Label();
            this.panelPages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            descriptionLabel.Location = new System.Drawing.Point(67, 49);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(111, 24);
            descriptionLabel.TabIndex = 0;
            descriptionLabel.Text = "Description:";
            // 
            // imageNormalLabel
            // 
            imageNormalLabel.AutoSize = true;
            imageNormalLabel.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            imageNormalLabel.Location = new System.Drawing.Point(333, 75);
            imageNormalLabel.Name = "imageNormalLabel";
            imageNormalLabel.Size = new System.Drawing.Size(138, 24);
            imageNormalLabel.TabIndex = 2;
            imageNormalLabel.Text = "Image Normal:";
            // 
            // likesCountLabel
            // 
            likesCountLabel.AutoSize = true;
            likesCountLabel.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            likesCountLabel.Location = new System.Drawing.Point(67, 98);
            likesCountLabel.Name = "likesCountLabel";
            likesCountLabel.Size = new System.Drawing.Size(111, 24);
            likesCountLabel.TabIndex = 4;
            likesCountLabel.Text = "Likes Count:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            nameLabel.Location = new System.Drawing.Point(85, 144);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(66, 24);
            nameLabel.TabIndex = 6;
            nameLabel.Text = "Name:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            cityLabel.Location = new System.Drawing.Point(85, 186);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(49, 24);
            cityLabel.TabIndex = 8;
            cityLabel.Text = "City:";
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            countryLabel.Location = new System.Drawing.Point(73, 229);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new System.Drawing.Size(84, 24);
            countryLabel.TabIndex = 10;
            countryLabel.Text = "Country:";
            // 
            // buttonProfileFacebook
            // 
            this.buttonProfileFacebook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonProfileFacebook.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonProfileFacebook.Image = global::BasicFacebookFeatures.Properties.Resources.image002_png;
            this.buttonProfileFacebook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProfileFacebook.Location = new System.Drawing.Point(12, 34);
            this.buttonProfileFacebook.Name = "buttonProfileFacebook";
            this.buttonProfileFacebook.Size = new System.Drawing.Size(234, 45);
            this.buttonProfileFacebook.TabIndex = 0;
            this.buttonProfileFacebook.Text = "Facebook Profile";
            this.buttonProfileFacebook.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonProfileFacebook.UseVisualStyleBackColor = false;
            this.buttonProfileFacebook.Click += new System.EventHandler(this.buttonProfileFacebook_Click);
            // 
            // panelPages
            // 
            this.panelPages.BackColor = System.Drawing.Color.White;
            this.panelPages.Controls.Add(cityLabel);
            this.panelPages.Controls.Add(this.cityLabel1);
            this.panelPages.Controls.Add(countryLabel);
            this.panelPages.Controls.Add(this.countryLabel1);
            this.panelPages.Controls.Add(descriptionLabel);
            this.panelPages.Controls.Add(this.descriptionLabel1);
            this.panelPages.Controls.Add(imageNormalLabel);
            this.panelPages.Controls.Add(this.imageNormalPictureBox);
            this.panelPages.Controls.Add(likesCountLabel);
            this.panelPages.Controls.Add(this.likesCountLabel1);
            this.panelPages.Controls.Add(nameLabel);
            this.panelPages.Controls.Add(this.nameLabel1);
            this.panelPages.Location = new System.Drawing.Point(403, 212);
            this.panelPages.Name = "panelPages";
            this.panelPages.Size = new System.Drawing.Size(514, 340);
            this.panelPages.TabIndex = 1;
            // 
            // cityLabel1
            // 
            this.cityLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pageBindingSource, "Location.City", true));
            this.cityLabel1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cityLabel1.Location = new System.Drawing.Point(195, 179);
            this.cityLabel1.Name = "cityLabel1";
            this.cityLabel1.Size = new System.Drawing.Size(100, 24);
            this.cityLabel1.TabIndex = 9;
            this.cityLabel1.Text = "label1";
            // 
            // pageBindingSource
            // 
            this.pageBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Page);
            // 
            // countryLabel1
            // 
            this.countryLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pageBindingSource, "Location.Country", true));
            this.countryLabel1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.countryLabel1.Location = new System.Drawing.Point(195, 222);
            this.countryLabel1.Name = "countryLabel1";
            this.countryLabel1.Size = new System.Drawing.Size(100, 24);
            this.countryLabel1.TabIndex = 11;
            this.countryLabel1.Text = "label1";
            // 
            // descriptionLabel1
            // 
            this.descriptionLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pageBindingSource, "Description", true));
            this.descriptionLabel1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.descriptionLabel1.Location = new System.Drawing.Point(195, 49);
            this.descriptionLabel1.Name = "descriptionLabel1";
            this.descriptionLabel1.Size = new System.Drawing.Size(100, 24);
            this.descriptionLabel1.TabIndex = 1;
            this.descriptionLabel1.Text = "label1";
            // 
            // imageNormalPictureBox
            // 
            this.imageNormalPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.pageBindingSource, "ImageNormal", true));
            this.imageNormalPictureBox.Location = new System.Drawing.Point(311, 124);
            this.imageNormalPictureBox.Name = "imageNormalPictureBox";
            this.imageNormalPictureBox.Size = new System.Drawing.Size(160, 129);
            this.imageNormalPictureBox.TabIndex = 3;
            this.imageNormalPictureBox.TabStop = false;
            // 
            // likesCountLabel1
            // 
            this.likesCountLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pageBindingSource, "LikesCount", true));
            this.likesCountLabel1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.likesCountLabel1.Location = new System.Drawing.Point(195, 98);
            this.likesCountLabel1.Name = "likesCountLabel1";
            this.likesCountLabel1.Size = new System.Drawing.Size(100, 24);
            this.likesCountLabel1.TabIndex = 5;
            this.likesCountLabel1.Text = "label1";
            // 
            // nameLabel1
            // 
            this.nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pageBindingSource, "Name", true));
            this.nameLabel1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.nameLabel1.Location = new System.Drawing.Point(195, 137);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Size = new System.Drawing.Size(100, 24);
            this.nameLabel1.TabIndex = 7;
            this.nameLabel1.Text = "label1";
            // 
            // listBoxPages
            // 
            this.listBoxPages.BackColor = System.Drawing.Color.White;
            this.listBoxPages.DataSource = this.pageBindingSource;
            this.listBoxPages.FormattingEnabled = true;
            this.listBoxPages.ItemHeight = 16;
            this.listBoxPages.Location = new System.Drawing.Point(12, 212);
            this.listBoxPages.Name = "listBoxPages";
            this.listBoxPages.Size = new System.Drawing.Size(345, 340);
            this.listBoxPages.TabIndex = 2;
            this.listBoxPages.SelectedIndexChanged += new System.EventHandler(this.listBoxPages_SelectedIndexChanged);
            // 
            // buttonPages
            // 
            this.buttonPages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonPages.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonPages.Location = new System.Drawing.Point(12, 155);
            this.buttonPages.Name = "buttonPages";
            this.buttonPages.Size = new System.Drawing.Size(146, 40);
            this.buttonPages.TabIndex = 3;
            this.buttonPages.Text = "Fetch Pages";
            this.buttonPages.UseVisualStyleBackColor = false;
            this.buttonPages.Click += new System.EventHandler(this.buttonPages_Click);
            // 
            // pictureBoxPage
            // 
            this.pictureBoxPage.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBoxPage.Location = new System.Drawing.Point(193, 414);
            this.pictureBoxPage.Name = "pictureBoxPage";
            this.pictureBoxPage.Size = new System.Drawing.Size(164, 138);
            this.pictureBoxPage.TabIndex = 4;
            this.pictureBoxPage.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BasicFacebookFeatures.Properties.Resources.הורדה__1_;
            this.pictureBox1.Location = new System.Drawing.Point(525, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(349, 176);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FormDataBinding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::BasicFacebookFeatures.Properties.Resources.Cornwall_Creative_1900_x_950_Main_Images_Background_Facebook;
            this.ClientSize = new System.Drawing.Size(930, 577);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBoxPage);
            this.Controls.Add(this.buttonPages);
            this.Controls.Add(this.listBoxPages);
            this.Controls.Add(this.panelPages);
            this.Controls.Add(this.buttonProfileFacebook);
            this.Name = "FormDataBinding";
            this.Text = "FormDataBinding";
            this.panelPages.ResumeLayout(false);
            this.panelPages.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonProfileFacebook;
        private System.Windows.Forms.Panel panelPages;
        private System.Windows.Forms.ListBox listBoxPages;
        private System.Windows.Forms.Button buttonPages;
        private System.Windows.Forms.PictureBox pictureBoxPage;
        private System.Windows.Forms.BindingSource pageBindingSource;
        private System.Windows.Forms.Label cityLabel1;
        private System.Windows.Forms.Label countryLabel1;
        private System.Windows.Forms.Label descriptionLabel1;
        private System.Windows.Forms.PictureBox imageNormalPictureBox;
        private System.Windows.Forms.Label likesCountLabel1;
        private System.Windows.Forms.Label nameLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}