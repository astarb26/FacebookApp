namespace BasicFacebookFeatures
{
    public partial class BirthdaysForm
    {
        private System.ComponentModel.IContainer components = null;

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
            this.buttonFetchFriends = new System.Windows.Forms.Button();
            this.buttonSortDescending = new System.Windows.Forms.Button();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.comboBoxMonth = new System.Windows.Forms.ComboBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerYear = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonProfile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelyear = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonFetchFriends
            // 
            this.buttonFetchFriends.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonFetchFriends.Location = new System.Drawing.Point(233, 322);
            this.buttonFetchFriends.Name = "buttonFetchFriends";
            this.buttonFetchFriends.Size = new System.Drawing.Size(130, 59);
            this.buttonFetchFriends.TabIndex = 0;
            this.buttonFetchFriends.Text = "Fetch All Friends";
            this.buttonFetchFriends.UseVisualStyleBackColor = true;
            this.buttonFetchFriends.Click += new System.EventHandler(this.buttonFetchFriends_Click);
            // 
            // buttonSortDescending
            // 
            this.buttonSortDescending.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonSortDescending.Location = new System.Drawing.Point(369, 322);
            this.buttonSortDescending.Name = "buttonSortDescending";
            this.buttonSortDescending.Size = new System.Drawing.Size(251, 59);
            this.buttonSortDescending.TabIndex = 1;
            this.buttonSortDescending.Text = "Sort Birthdays By Proximity To Today ";
            this.buttonSortDescending.UseVisualStyleBackColor = true;
            this.buttonSortDescending.Click += new System.EventHandler(this.buttonSortDescending_Click);
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.ItemHeight = 16;
            this.listBoxFriends.Location = new System.Drawing.Point(306, 397);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(248, 228);
            this.listBoxFriends.TabIndex = 2;
            // 
            // comboBoxMonth
            // 
            this.comboBoxMonth.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.comboBoxMonth.FormattingEnabled = true;
            this.comboBoxMonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboBoxMonth.Location = new System.Drawing.Point(594, 425);
            this.comboBoxMonth.Name = "comboBoxMonth";
            this.comboBoxMonth.Size = new System.Drawing.Size(200, 31);
            this.comboBoxMonth.TabIndex = 3;
            this.comboBoxMonth.Text = "Months";
            this.comboBoxMonth.SelectedIndexChanged += new System.EventHandler(this.comboBoxMonth_SelectedIndexChanged);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(594, 575);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 31);
            this.dateTimePicker.TabIndex = 4;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // dateTimePickerYear
            // 
            this.dateTimePickerYear.CustomFormat = "yyyy";
            this.dateTimePickerYear.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dateTimePickerYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerYear.Location = new System.Drawing.Point(594, 502);
            this.dateTimePickerYear.Name = "dateTimePickerYear";
            this.dateTimePickerYear.Size = new System.Drawing.Size(200, 31);
            this.dateTimePickerYear.TabIndex = 5;
            this.dateTimePickerYear.ValueChanged += new System.EventHandler(this.dateTimePickerYear_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(180, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(458, 45);
            this.label1.TabIndex = 6;
            this.label1.Text = "Find your friends\' birthdays:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.BackgroundImage = global::BasicFacebookFeatures.Properties.Resources._55ded8d98ec37a795722a6097e3290be;
            this.pictureBox1.Location = new System.Drawing.Point(92, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(650, 226);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // buttonProfile
            // 
            this.buttonProfile.BackgroundImage = global::BasicFacebookFeatures.Properties.Resources.Cornwall_Creative_1900_x_950_Main_Images_Background_Facebook;
            this.buttonProfile.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonProfile.Image = global::BasicFacebookFeatures.Properties.Resources._636292522180130000;
            this.buttonProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProfile.Location = new System.Drawing.Point(31, 510);
            this.buttonProfile.Name = "buttonProfile";
            this.buttonProfile.Size = new System.Drawing.Size(244, 71);
            this.buttonProfile.TabIndex = 8;
            this.buttonProfile.Text = "Facebook Profile";
            this.buttonProfile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonProfile.UseVisualStyleBackColor = true;
            this.buttonProfile.Click += new System.EventHandler(this.buttonProfile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Image = global::BasicFacebookFeatures.Properties.Resources.Cornwall_Creative_1900_x_950_Main_Images_Background_Facebook;
            this.label2.Location = new System.Drawing.Point(589, 397);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Select By Month:";
            // 
            // labelyear
            // 
            this.labelyear.AutoSize = true;
            this.labelyear.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelyear.Image = global::BasicFacebookFeatures.Properties.Resources.Cornwall_Creative_1900_x_950_Main_Images_Background_Facebook;
            this.labelyear.Location = new System.Drawing.Point(589, 474);
            this.labelyear.Name = "labelyear";
            this.labelyear.Size = new System.Drawing.Size(140, 25);
            this.labelyear.TabIndex = 10;
            this.labelyear.Text = "Select By Year:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Image = global::BasicFacebookFeatures.Properties.Resources.Cornwall_Creative_1900_x_950_Main_Images_Background_Facebook;
            this.label3.Location = new System.Drawing.Point(589, 547);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Select By Date:";
            // 
            // BirthdaysForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::BasicFacebookFeatures.Properties.Resources.Cornwall_Creative_1900_x_950_Main_Images_Background_Facebook;
            this.ClientSize = new System.Drawing.Size(898, 665);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelyear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonProfile);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerYear);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.comboBoxMonth);
            this.Controls.Add(this.listBoxFriends);
            this.Controls.Add(this.buttonSortDescending);
            this.Controls.Add(this.buttonFetchFriends);
            this.Name = "BirthdaysForm";
            this.Text = "BirthdaysForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFetchFriends;
        private System.Windows.Forms.Button buttonSortDescending;
        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.ComboBox comboBoxMonth;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.DateTimePicker dateTimePickerYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonProfile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelyear;
        private System.Windows.Forms.Label label3;
    }
}