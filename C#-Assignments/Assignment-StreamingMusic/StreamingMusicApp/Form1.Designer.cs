
namespace StreamingMusicApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.rtbViewAllSongs = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.tbArtist = new System.Windows.Forms.TextBox();
            this.tbDuration = new System.Windows.Forms.TextBox();
            this.cbGenre = new System.Windows.Forms.ComboBox();
            this.btnAddNewSong = new System.Windows.Forms.Button();
            this.btnClearNewSong = new System.Windows.Forms.Button();
            this.rtbViewAllUsers = new System.Windows.Forms.RichTextBox();
            this.btnClearNewUser = new System.Windows.Forms.Button();
            this.btnAddNewUser = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lvUsers = new System.Windows.Forms.ListView();
            this.label9 = new System.Windows.Forms.Label();
            this.rtbFavoriteSongsUser = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lvAllAvailableSongs = new System.Windows.Forms.ListView();
            this.btnAssignSongToFavourites = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1024, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.rtbViewAllSongs);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1016, 393);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "View All Songs";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnClearNewSong);
            this.tabPage2.Controls.Add(this.btnAddNewSong);
            this.tabPage2.Controls.Add(this.cbGenre);
            this.tabPage2.Controls.Add(this.tbDuration);
            this.tabPage2.Controls.Add(this.tbArtist);
            this.tabPage2.Controls.Add(this.tbTitle);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1016, 393);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add New Song";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.rtbViewAllUsers);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1016, 393);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "View All Users";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnClearNewUser);
            this.tabPage4.Controls.Add(this.btnAddNewUser);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.tbAddress);
            this.tabPage4.Controls.Add(this.tbEmail);
            this.tabPage4.Controls.Add(this.tbUserName);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1016, 393);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Add New User";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.btnAssignSongToFavourites);
            this.tabPage5.Controls.Add(this.lvAllAvailableSongs);
            this.tabPage5.Controls.Add(this.label10);
            this.tabPage5.Controls.Add(this.rtbFavoriteSongsUser);
            this.tabPage5.Controls.Add(this.label9);
            this.tabPage5.Controls.Add(this.lvUsers);
            this.tabPage5.Controls.Add(this.label8);
            this.tabPage5.Location = new System.Drawing.Point(4, 29);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1016, 393);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "User Favorite Song";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // rtbViewAllSongs
            // 
            this.rtbViewAllSongs.Location = new System.Drawing.Point(6, 16);
            this.rtbViewAllSongs.Name = "rtbViewAllSongs";
            this.rtbViewAllSongs.Size = new System.Drawing.Size(566, 371);
            this.rtbViewAllSongs.TabIndex = 0;
            this.rtbViewAllSongs.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Artist:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Duration(seconds):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Genre:";
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(229, 38);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(202, 27);
            this.tbTitle.TabIndex = 9;
            // 
            // tbArtist
            // 
            this.tbArtist.Location = new System.Drawing.Point(229, 86);
            this.tbArtist.Name = "tbArtist";
            this.tbArtist.Size = new System.Drawing.Size(202, 27);
            this.tbArtist.TabIndex = 10;
            // 
            // tbDuration
            // 
            this.tbDuration.Location = new System.Drawing.Point(229, 131);
            this.tbDuration.Name = "tbDuration";
            this.tbDuration.Size = new System.Drawing.Size(202, 27);
            this.tbDuration.TabIndex = 11;
            // 
            // cbGenre
            // 
            this.cbGenre.FormattingEnabled = true;
            this.cbGenre.Location = new System.Drawing.Point(229, 178);
            this.cbGenre.Name = "cbGenre";
            this.cbGenre.Size = new System.Drawing.Size(202, 28);
            this.cbGenre.TabIndex = 12;
            // 
            // btnAddNewSong
            // 
            this.btnAddNewSong.Location = new System.Drawing.Point(22, 246);
            this.btnAddNewSong.Name = "btnAddNewSong";
            this.btnAddNewSong.Size = new System.Drawing.Size(94, 29);
            this.btnAddNewSong.TabIndex = 13;
            this.btnAddNewSong.Text = "Add";
            this.btnAddNewSong.UseVisualStyleBackColor = true;
            this.btnAddNewSong.Click += new System.EventHandler(this.btnAddNewSong_Click);
            // 
            // btnClearNewSong
            // 
            this.btnClearNewSong.Location = new System.Drawing.Point(337, 246);
            this.btnClearNewSong.Name = "btnClearNewSong";
            this.btnClearNewSong.Size = new System.Drawing.Size(94, 29);
            this.btnClearNewSong.TabIndex = 14;
            this.btnClearNewSong.Text = "Clear";
            this.btnClearNewSong.UseVisualStyleBackColor = true;
            this.btnClearNewSong.Click += new System.EventHandler(this.btnClearNewSong_Click);
            // 
            // rtbViewAllUsers
            // 
            this.rtbViewAllUsers.Location = new System.Drawing.Point(3, 19);
            this.rtbViewAllUsers.Name = "rtbViewAllUsers";
            this.rtbViewAllUsers.Size = new System.Drawing.Size(566, 371);
            this.rtbViewAllUsers.TabIndex = 0;
            this.rtbViewAllUsers.Text = "";
            // 
            // btnClearNewUser
            // 
            this.btnClearNewUser.Location = new System.Drawing.Point(267, 257);
            this.btnClearNewUser.Name = "btnClearNewUser";
            this.btnClearNewUser.Size = new System.Drawing.Size(202, 29);
            this.btnClearNewUser.TabIndex = 15;
            this.btnClearNewUser.Text = "Clear";
            this.btnClearNewUser.UseVisualStyleBackColor = true;
            this.btnClearNewUser.Click += new System.EventHandler(this.btnClearNewUser_Click);
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.Location = new System.Drawing.Point(17, 257);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.Size = new System.Drawing.Size(202, 29);
            this.btnAddNewUser.TabIndex = 14;
            this.btnAddNewUser.Text = "Add";
            this.btnAddNewUser.UseVisualStyleBackColor = true;
            this.btnAddNewUser.Click += new System.EventHandler(this.btnAddNewUser_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Address:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "User Name:";
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(207, 152);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(262, 27);
            this.tbAddress.TabIndex = 10;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(207, 102);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(262, 27);
            this.tbEmail.TabIndex = 9;
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(207, 47);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(262, 27);
            this.tbUserName.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Users";
            // 
            // lvUsers
            // 
            this.lvUsers.FullRowSelect = true;
            this.lvUsers.HideSelection = false;
            this.lvUsers.Location = new System.Drawing.Point(3, 45);
            this.lvUsers.MultiSelect = false;
            this.lvUsers.Name = "lvUsers";
            this.lvUsers.Size = new System.Drawing.Size(326, 319);
            this.lvUsers.TabIndex = 4;
            this.lvUsers.UseCompatibleStateImageBehavior = false;
            this.lvUsers.View = System.Windows.Forms.View.Details;
            this.lvUsers.SelectedIndexChanged += new System.EventHandler(this.lvUsers_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(407, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(225, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "Favourite Songs of Selected User";
            // 
            // rtbFavoriteSongsUser
            // 
            this.rtbFavoriteSongsUser.Location = new System.Drawing.Point(352, 45);
            this.rtbFavoriteSongsUser.Name = "rtbFavoriteSongsUser";
            this.rtbFavoriteSongsUser.Size = new System.Drawing.Size(326, 319);
            this.rtbFavoriteSongsUser.TabIndex = 7;
            this.rtbFavoriteSongsUser.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(776, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 20);
            this.label10.TabIndex = 8;
            this.label10.Text = "All Available Songs";
            // 
            // lvAllAvailableSongs
            // 
            this.lvAllAvailableSongs.FullRowSelect = true;
            this.lvAllAvailableSongs.HideSelection = false;
            this.lvAllAvailableSongs.Location = new System.Drawing.Point(697, 45);
            this.lvAllAvailableSongs.MultiSelect = false;
            this.lvAllAvailableSongs.Name = "lvAllAvailableSongs";
            this.lvAllAvailableSongs.Size = new System.Drawing.Size(310, 254);
            this.lvAllAvailableSongs.TabIndex = 9;
            this.lvAllAvailableSongs.UseCompatibleStateImageBehavior = false;
            this.lvAllAvailableSongs.View = System.Windows.Forms.View.Details;
            // 
            // btnAssignSongToFavourites
            // 
            this.btnAssignSongToFavourites.Location = new System.Drawing.Point(697, 335);
            this.btnAssignSongToFavourites.Name = "btnAssignSongToFavourites";
            this.btnAssignSongToFavourites.Size = new System.Drawing.Size(310, 29);
            this.btnAssignSongToFavourites.TabIndex = 10;
            this.btnAssignSongToFavourites.Text = "Assign Song to User Favourites";
            this.btnAssignSongToFavourites.UseVisualStyleBackColor = true;
            this.btnAssignSongToFavourites.Click += new System.EventHandler(this.btnAssignSongToFavourites_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox rtbViewAllSongs;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button btnClearNewSong;
        private System.Windows.Forms.Button btnAddNewSong;
        private System.Windows.Forms.ComboBox cbGenre;
        private System.Windows.Forms.TextBox tbDuration;
        private System.Windows.Forms.TextBox tbArtist;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.RichTextBox rtbViewAllUsers;
        private System.Windows.Forms.Button btnClearNewUser;
        private System.Windows.Forms.Button btnAddNewUser;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Button btnAssignSongToFavourites;
        private System.Windows.Forms.ListView lvAllAvailableSongs;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox rtbFavoriteSongsUser;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListView lvUsers;
        private System.Windows.Forms.Label label8;
    }
}

