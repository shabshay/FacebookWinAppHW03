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
using System.Threading;
using FacebookWinFormApplication.Logic;
using FacebookWinFormApplication.Followers;

namespace FacebookWinFormApplication
{
    /// <summary>
    /// Also plays the role of Director in Builder pattern.
    /// </summary>
    public partial class FormFBApp : Form, IProgressObserver
    {
        #region Members
        private const string k_ApplicationID = "777317175673043";
        private User m_LoggedInUser;
        private int m_CollectionLimit = 100;
        private FollowersProvider.Builder m_FollowersBuilder;

        #endregion Members

        #region C'tor
        public FormFBApp()
        {
            InitializeComponent();
            this.disableControls();
            FacebookService.s_CollectionLimit = this.m_CollectionLimit;
            m_FollowersBuilder = new FollowersProvider.Builder();
            this.SetFollowersStatisticsFileBuilder();
        }

        #endregion C'tor

        #region Implementation
        private void SetFollowersStatisticsFileBuilder()
        {
            IFollowersStatisticsFileBuilder fileBuilder = null;
            int resultsPerFile = 0;

            // XML or JSON
            if (radioButtonXML.Checked)
            {
                fileBuilder = new FollowersStatisticsFileBuilderXML();
            }
            else if (radioButtonJSON.Checked)
            {
                fileBuilder = new FollowersStatisticsFileBuilderJSON();
            }
            else if (radioButtonNone.Checked)
            {
                fileBuilder = null;
            }

            // Number of results per file
            if (radioButton10.Checked)
            {
                resultsPerFile = 10;
            }
            else if (radioButton50.Checked)
            {
                resultsPerFile = 50;
            }
            else if (radioButton100.Checked)
            {
                resultsPerFile = 100;
            }

            if (fileBuilder != null)
            {
                if (resultsPerFile > 0)
                    m_FollowersBuilder.SetStatisticsFileBuilder(new FollowersStatisticsFileSeperator(fileBuilder, resultsPerFile));
                else
                    m_FollowersBuilder.SetStatisticsFileBuilder(fileBuilder);
            }
        }

        private void fetchMostFollowers()
        {
            try
            {
                this.linkLabelMostFollowers.Invoke((MethodInvoker)(() => this.linkLabelMostFollowers.Enabled = false));
                this.labelLoading.Invoke((MethodInvoker)(() => this.labelLoading.Visible = true));

                try
                {
                    this.showFollowersStatistics();
                }
                catch (Exception e)
                {
                    MessageBox.Show(string.Format("Error while trying to show followers: \n{0}", e.Message));
                    return;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(string.Format("Error while trying to calculate followers statistics: \n{0}", e.Message));
                this.linkLabelMostFollowers.Invoke((MethodInvoker)(() => this.linkLabelMostFollowers.Enabled = true));
                return;
            }
            finally
            {
                this.labelLoading.Invoke((MethodInvoker)(() => this.labelLoading.Visible = false));
                this.linkLabelMostFollowers.Invoke((MethodInvoker)(() => this.linkLabelMostFollowers.Enabled = true));

            }
        }

        public void UpdateProgress(int i_Percent)
        {
            progressBar.Invoke(new MethodInvoker(() => progressBar.Value = i_Percent));
        }

        private void showFollowersStatistics()
        {
            listBoxFollowers.Invoke(new MethodInvoker(() => listBoxFollowers.DisplayMember = "Name"));

            try
            {
                FollowersProvider followersProvider = m_FollowersBuilder.Build(this);

                SortedList<int, User> sortedFollowers = followersProvider.GetFollowersSortedList(m_LoggedInUser);

                foreach (KeyValuePair<int, User> entry in sortedFollowers)
                {
                    listBoxFollowers.Invoke(new MethodInvoker(() => listBoxFollowers.Items.Add(entry.Value)));
                }

                if (listBoxFollowers.Items.Count > 0)
                {
                    listBoxFollowers.Invoke(new MethodInvoker(() => listBoxFollowers.SetSelected(0, true)));
                }
            } 
            catch(Exception e)
            {
                MessageBox.Show(string.Format("Please provide at least one category"));
            }
        }

        private void fetchUserInfo()
        {
            this.pictureBoxProfilePicture.LoadAsync(this.m_LoggedInUser.PictureNormalURL);
            if (this.m_LoggedInUser.Statuses != null && this.m_LoggedInUser.Statuses.Count > 0)
            {
                this.textBoxStatus.Text = this.m_LoggedInUser.Statuses[0].Message;
            }
        }

        private void loginAndInit()
        {
            this.labelLoading.Visible = true;
            try
            {
                LoginResult result = FacebookService.Login(k_ApplicationID, "user_about_me", "user_friends", "friends_about_me", "publish_stream", "read_stream", "user_status", "user_groups", "user_photos","publish_actions");

                if (!string.IsNullOrEmpty(result.AccessToken))
                {
                    this.m_LoggedInUser = result.LoggedInUser;
                    this.fetchUserInfo();
                    this.labelWelcomeMsg.Text = string.Format("Hello {0} {1}!", this.m_LoggedInUser.FirstName, this.m_LoggedInUser.LastName);
                    this.enableControls();

                    // takes time therefore should be performed in a background thread.
                    new Thread(() => this.fetchGroups()).Start();
                }
                else
                {
                    MessageBox.Show(string.Format("Error while trying to login: \n{0}", result.ErrorMessage));
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(string.Format("Error while trying to login: \n{0}", e.Message));
            }

            this.labelLoading.Visible = false;
        }

        private void enableControls()
        {
            this.pictureBoxProfilePicture.Visible = true;
            this.buttonLogin.Enabled = false;
            this.linkLabelMostFollowers.Enabled = true;
            this.richTextBoxMessage.Enabled = true;
            this.buttonPost.Enabled = true;
        }

        private void disableControls()
        {
            this.labelWelcomeMsg.Text = "Please Login";
            this.textBoxStatus.Text = string.Empty;
            this.checkedListBoxGroups.Items.Clear();
            this.pictureBoxProfilePicture.Visible = false;
            this.buttonLogin.Enabled = true;
            this.linkLabelMostFollowers.Enabled = false;
            this.richTextBoxMessage.Enabled = false;
            this.buttonPost.Enabled = false;
        }

        private void fetchGroups()
        {
            if (this.m_LoggedInUser != null)
            {
                foreach (Group group in this.m_LoggedInUser.Groups)
                {
                    this.checkedListBoxGroups.Invoke(new MethodInvoker(() =>
                    {
                        this.checkedListBoxGroups.Items.Add(new ListGroupItem(group));
                    }));
                }
            }
        }

        private void postToGroups()
        {
            this.labelLoading.Visible = true;
            this.checkedListBoxGroups.Enabled = false;
            this.richTextBoxMessage.Enabled = false;

            List<ListGroupItem> groups =  this.checkedListBoxGroups.CheckedItems.OfType<ListGroupItem>().ToList();

            try
            {
                GroupsNotifier.SendPost(groups, this.richTextBoxMessage.Text);
                MessageBox.Show("Message has been posted to the selected groups successfuly!");
            }
            catch (Exception e)
            {
                MessageBox.Show(string.Format("Failed to post message: \n{0}", e.Message));
            }

            this.labelLoading.Visible = false;
            this.checkedListBoxGroups.Enabled = true;
            this.richTextBoxMessage.Enabled = true;
            this.richTextBoxMessage.Text = string.Empty;
            this.labelLoading.Visible = false;
        }

        private void setCheckedGroups(bool i_Check)
        {
            for (int i = 0; i < this.checkedListBoxGroups.Items.Count; i++)
            {
                this.checkedListBoxGroups.SetItemChecked(i, i_Check);
            }
        }

        private void displaySelectedFriend()
        {
            if (listBoxFollowers.SelectedItems.Count == 1)
            {
                User selectedFriend = listBoxFollowers.SelectedItem as User;
                if (selectedFriend != null)
                {
                    this.userBindingSource.DataSource = selectedFriend;
                }
            }
        }

        private void ConfigureFollowersSerachCriteria(bool i_Enabled, eFollowerCriteria i_type)
        {
            if (i_Enabled)
            {
                m_FollowersBuilder.EnableCriteriaParser(i_type);
            }
            else
            {
                m_FollowersBuilder.DisableCriteriaParser(i_type);
            }
        }
        #endregion Implementation

        #region Event Handlers
        private void linkLabelMostFollowers_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            listBoxFollowers.Items.Clear();

            // This operation takes time and should not be on main thread
            // so that the main thread won't block
            // note that the result is called back on the UI component's thread          
            new Thread(() => this.fetchMostFollowers()).Start();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            this.loginAndInit();
        }

        private void buttonPost_Click(object sender, EventArgs e)
        {
            if (GroupsNotifier.PostIsValid(m_LoggedInUser, this.richTextBoxMessage.Text, this.checkedListBoxGroups.SelectedItems))
            {
                this.postToGroups();
            }
            else
            {
                MessageBox.Show("Please Login, enter your message and select groups before posting!");
            }
        }

        private void linkLabelSelectAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.setCheckedGroups(true);
        }

        private void linkLabelClearAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.setCheckedGroups(false);
        }

        private void listBoxFollowers_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.displaySelectedFriend();
        }

        private void albumsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ConfigureFollowersSerachCriteria(((CheckBox)sender).Checked, eFollowerCriteria.Albums);
        }

        private void statusesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ConfigureFollowersSerachCriteria(((CheckBox)sender).Checked, eFollowerCriteria.Status);
        }

        private void wallpostsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ConfigureFollowersSerachCriteria(((CheckBox)sender).Checked, eFollowerCriteria.Wallposts);
        }

        private void radioButtonStatistics_CheckedChanged(object sender, EventArgs e)
        {
            SetFollowersStatisticsFileBuilder();
        }
        #endregion Event Handlers
    }
}
