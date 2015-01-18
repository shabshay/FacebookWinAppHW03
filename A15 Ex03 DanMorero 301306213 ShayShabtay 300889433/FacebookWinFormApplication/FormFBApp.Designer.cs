namespace FacebookWinFormApplication
{
    partial class FormFBApp
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
            this.buttonLogin = new System.Windows.Forms.Button();
            this.pictureBoxProfilePicture = new System.Windows.Forms.PictureBox();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.labelForStatus = new System.Windows.Forms.Label();
            this.labelWelcomeMsg = new System.Windows.Forms.Label();
            this.linkLabelMostFollowers = new System.Windows.Forms.LinkLabel();
            this.labelMostFollower = new System.Windows.Forms.Label();
            this.labelLoading = new System.Windows.Forms.Label();
            this.checkedListBoxGroups = new System.Windows.Forms.CheckedListBox();
            this.labelSelect = new System.Windows.Forms.Label();
            this.richTextBoxMessage = new System.Windows.Forms.RichTextBox();
            this.labelEdit = new System.Windows.Forms.Label();
            this.buttonPost = new System.Windows.Forms.Button();
            this.labelClick = new System.Windows.Forms.Label();
            this.linkLabelSelectAll = new System.Windows.Forms.LinkLabel();
            this.linkLabelClearAll = new System.Windows.Forms.LinkLabel();
            this.listBoxFollowers = new System.Windows.Forms.ListBox();
            this.labelIns = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imagePictureBoxFollower = new System.Windows.Forms.PictureBox();
            this.labelFollowerName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonXML = new System.Windows.Forms.RadioButton();
            this.radioButtonJSON = new System.Windows.Forms.RadioButton();
            this.radioButtonNone = new System.Windows.Forms.RadioButton();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButtonResultsOneFile = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton50 = new System.Windows.Forms.RadioButton();
            this.radioButton100 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBoxFollower)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(13, 15);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 23);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // pictureBoxProfilePicture
            // 
            this.pictureBoxProfilePicture.Location = new System.Drawing.Point(15, 86);
            this.pictureBoxProfilePicture.Name = "pictureBoxProfilePicture";
            this.pictureBoxProfilePicture.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxProfilePicture.TabIndex = 1;
            this.pictureBoxProfilePicture.TabStop = false;
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Location = new System.Drawing.Point(279, 18);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.ReadOnly = true;
            this.textBoxStatus.Size = new System.Drawing.Size(474, 20);
            this.textBoxStatus.TabIndex = 2;
            // 
            // labelForStatus
            // 
            this.labelForStatus.AutoSize = true;
            this.labelForStatus.Location = new System.Drawing.Point(191, 20);
            this.labelForStatus.Name = "labelForStatus";
            this.labelForStatus.Size = new System.Drawing.Size(82, 13);
            this.labelForStatus.TabIndex = 3;
            this.labelForStatus.Text = "Your last status:";
            // 
            // labelWelcomeMsg
            // 
            this.labelWelcomeMsg.AutoSize = true;
            this.labelWelcomeMsg.Location = new System.Drawing.Point(12, 56);
            this.labelWelcomeMsg.Name = "labelWelcomeMsg";
            this.labelWelcomeMsg.Size = new System.Drawing.Size(68, 13);
            this.labelWelcomeMsg.TabIndex = 4;
            this.labelWelcomeMsg.Text = "Please Login";
            // 
            // linkLabelMostFollowers
            // 
            this.linkLabelMostFollowers.AutoSize = true;
            this.linkLabelMostFollowers.Enabled = false;
            this.linkLabelMostFollowers.Location = new System.Drawing.Point(191, 56);
            this.linkLabelMostFollowers.Name = "linkLabelMostFollowers";
            this.linkLabelMostFollowers.Size = new System.Drawing.Size(350, 13);
            this.linkLabelMostFollowers.TabIndex = 5;
            this.linkLabelMostFollowers.TabStop = true;
            this.linkLabelMostFollowers.Text = "Click here to see your most followers friends (this can take a few minutes)";
            this.linkLabelMostFollowers.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelMostFollowers_LinkClicked);
            // 
            // labelMostFollower
            // 
            this.labelMostFollower.AutoSize = true;
            this.labelMostFollower.Location = new System.Drawing.Point(252, 205);
            this.labelMostFollower.Name = "labelMostFollower";
            this.labelMostFollower.Size = new System.Drawing.Size(0, 13);
            this.labelMostFollower.TabIndex = 12;
            // 
            // labelLoading
            // 
            this.labelLoading.AutoSize = true;
            this.labelLoading.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelLoading.ForeColor = System.Drawing.Color.Red;
            this.labelLoading.Location = new System.Drawing.Point(15, 203);
            this.labelLoading.Name = "labelLoading";
            this.labelLoading.Size = new System.Drawing.Size(66, 16);
            this.labelLoading.TabIndex = 15;
            this.labelLoading.Text = "Loading...";
            this.labelLoading.Visible = false;
            // 
            // checkedListBoxGroups
            // 
            this.checkedListBoxGroups.CheckOnClick = true;
            this.checkedListBoxGroups.FormattingEnabled = true;
            this.checkedListBoxGroups.Location = new System.Drawing.Point(15, 344);
            this.checkedListBoxGroups.Margin = new System.Windows.Forms.Padding(2);
            this.checkedListBoxGroups.Name = "checkedListBoxGroups";
            this.checkedListBoxGroups.Size = new System.Drawing.Size(263, 94);
            this.checkedListBoxGroups.TabIndex = 17;
            // 
            // labelSelect
            // 
            this.labelSelect.AutoSize = true;
            this.labelSelect.Location = new System.Drawing.Point(15, 320);
            this.labelSelect.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSelect.Name = "labelSelect";
            this.labelSelect.Size = new System.Drawing.Size(242, 13);
            this.labelSelect.TabIndex = 18;
            this.labelSelect.Text = "Select the groups you want to post your message:";
            // 
            // richTextBoxMessage
            // 
            this.richTextBoxMessage.Location = new System.Drawing.Point(310, 340);
            this.richTextBoxMessage.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBoxMessage.Name = "richTextBoxMessage";
            this.richTextBoxMessage.Size = new System.Drawing.Size(241, 113);
            this.richTextBoxMessage.TabIndex = 19;
            this.richTextBoxMessage.Text = "";
            // 
            // labelEdit
            // 
            this.labelEdit.AutoSize = true;
            this.labelEdit.Location = new System.Drawing.Point(308, 316);
            this.labelEdit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEdit.Name = "labelEdit";
            this.labelEdit.Size = new System.Drawing.Size(96, 13);
            this.labelEdit.TabIndex = 20;
            this.labelEdit.Text = "Edit your message:";
            // 
            // buttonPost
            // 
            this.buttonPost.Location = new System.Drawing.Point(583, 337);
            this.buttonPost.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(70, 112);
            this.buttonPost.TabIndex = 21;
            this.buttonPost.Text = "Post to selected groups";
            this.buttonPost.UseVisualStyleBackColor = true;
            this.buttonPost.Click += new System.EventHandler(this.buttonPost_Click);
            // 
            // labelClick
            // 
            this.labelClick.AutoSize = true;
            this.labelClick.Location = new System.Drawing.Point(580, 313);
            this.labelClick.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelClick.Name = "labelClick";
            this.labelClick.Size = new System.Drawing.Size(68, 13);
            this.labelClick.TabIndex = 22;
            this.labelClick.Text = "Click to post:";
            // 
            // linkLabelSelectAll
            // 
            this.linkLabelSelectAll.AutoSize = true;
            this.linkLabelSelectAll.Location = new System.Drawing.Point(191, 455);
            this.linkLabelSelectAll.Name = "linkLabelSelectAll";
            this.linkLabelSelectAll.Size = new System.Drawing.Size(50, 13);
            this.linkLabelSelectAll.TabIndex = 23;
            this.linkLabelSelectAll.TabStop = true;
            this.linkLabelSelectAll.Text = "Select all";
            this.linkLabelSelectAll.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSelectAll_LinkClicked);
            // 
            // linkLabelClearAll
            // 
            this.linkLabelClearAll.AutoSize = true;
            this.linkLabelClearAll.Location = new System.Drawing.Point(247, 455);
            this.linkLabelClearAll.Name = "linkLabelClearAll";
            this.linkLabelClearAll.Size = new System.Drawing.Size(31, 13);
            this.linkLabelClearAll.TabIndex = 24;
            this.linkLabelClearAll.TabStop = true;
            this.linkLabelClearAll.Text = "Clear";
            this.linkLabelClearAll.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelClearAll_LinkClicked);
            // 
            // listBoxFollowers
            // 
            this.listBoxFollowers.FormattingEnabled = true;
            this.listBoxFollowers.Location = new System.Drawing.Point(194, 86);
            this.listBoxFollowers.Name = "listBoxFollowers";
            this.listBoxFollowers.Size = new System.Drawing.Size(140, 173);
            this.listBoxFollowers.TabIndex = 25;
            this.listBoxFollowers.SelectedIndexChanged += new System.EventHandler(this.listBoxFollowers_SelectedIndexChanged);
            // 
            // labelIns
            // 
            this.labelIns.AutoSize = true;
            this.labelIns.Location = new System.Drawing.Point(347, 214);
            this.labelIns.Name = "labelIns";
            this.labelIns.Size = new System.Drawing.Size(246, 65);
            this.labelIns.TabIndex = 26;
            this.labelIns.Text = "The friends list is sorted from your most follower \r\nfriend in the top to your le" +
    "ast follower friend in \r\nthe bottom.\r\n\r\nYou can click your friend\'s name to see " +
    "his picture.";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.checkBox1.Location = new System.Drawing.Point(350, 103);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(60, 17);
            this.checkBox1.TabIndex = 28;
            this.checkBox1.Text = "Albums";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.albumsCheckBox_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(350, 122);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(67, 17);
            this.checkBox2.TabIndex = 29;
            this.checkBox2.Text = "Statuses";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.statusesCheckBox_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(350, 141);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(76, 17);
            this.checkBox3.TabIndex = 30;
            this.checkBox3.Text = "Wall Posts";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.wallpostsCheckBox_CheckedChanged);
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.User);
            // 
            // imagePictureBoxFollower
            // 
            this.imagePictureBoxFollower.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.userBindingSource, "ImageLarge", true));
            this.imagePictureBoxFollower.Location = new System.Drawing.Point(462, 109);
            this.imagePictureBoxFollower.Name = "imagePictureBoxFollower";
            this.imagePictureBoxFollower.Size = new System.Drawing.Size(100, 83);
            this.imagePictureBoxFollower.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagePictureBoxFollower.TabIndex = 7;
            this.imagePictureBoxFollower.TabStop = false;
            // 
            // labelFollowerName
            // 
            this.labelFollowerName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Name", true));
            this.labelFollowerName.Location = new System.Drawing.Point(462, 83);
            this.labelFollowerName.Name = "labelFollowerName";
            this.labelFollowerName.Size = new System.Drawing.Size(100, 23);
            this.labelFollowerName.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(585, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Save results as:";
            // 
            // radioButtonXML
            // 
            this.radioButtonXML.AutoSize = true;
            this.radioButtonXML.Checked = true;
            this.radioButtonXML.Location = new System.Drawing.Point(588, 92);
            this.radioButtonXML.Name = "radioButtonXML";
            this.radioButtonXML.Size = new System.Drawing.Size(47, 17);
            this.radioButtonXML.TabIndex = 32;
            this.radioButtonXML.TabStop = true;
            this.radioButtonXML.Text = "XML";
            this.radioButtonXML.UseVisualStyleBackColor = true;
            this.radioButtonXML.CheckedChanged += new System.EventHandler(this.radioButtonStatistics_CheckedChanged);
            // 
            // radioButtonJSON
            // 
            this.radioButtonJSON.AutoSize = true;
            this.radioButtonJSON.Location = new System.Drawing.Point(588, 113);
            this.radioButtonJSON.Name = "radioButtonJSON";
            this.radioButtonJSON.Size = new System.Drawing.Size(53, 17);
            this.radioButtonJSON.TabIndex = 33;
            this.radioButtonJSON.Text = "JSON";
            this.radioButtonJSON.UseVisualStyleBackColor = true;
            this.radioButtonJSON.CheckedChanged += new System.EventHandler(this.radioButtonStatistics_CheckedChanged);
            // 
            // radioButtonNone
            // 
            this.radioButtonNone.AutoSize = true;
            this.radioButtonNone.Location = new System.Drawing.Point(588, 136);
            this.radioButtonNone.Name = "radioButtonNone";
            this.radioButtonNone.Size = new System.Drawing.Size(51, 17);
            this.radioButtonNone.TabIndex = 34;
            this.radioButtonNone.Text = "None";
            this.radioButtonNone.UseVisualStyleBackColor = true;
            this.radioButtonNone.CheckedChanged += new System.EventHandler(this.radioButtonStatistics_CheckedChanged);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(18, 234);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(147, 23);
            this.progressBar.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(585, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "(will be saved in \'Statistics.txt\')";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Number of results per file:";
            // 
            // radioButtonResultsOneFile
            // 
            this.radioButtonResultsOneFile.AutoSize = true;
            this.radioButtonResultsOneFile.Checked = true;
            this.radioButtonResultsOneFile.Location = new System.Drawing.Point(6, 28);
            this.radioButtonResultsOneFile.Name = "radioButtonResultsOneFile";
            this.radioButtonResultsOneFile.Size = new System.Drawing.Size(61, 17);
            this.radioButtonResultsOneFile.TabIndex = 38;
            this.radioButtonResultsOneFile.TabStop = true;
            this.radioButtonResultsOneFile.Text = "One file";
            this.radioButtonResultsOneFile.UseVisualStyleBackColor = true;
            this.radioButtonResultsOneFile.CheckedChanged += new System.EventHandler(this.radioButtonStatistics_CheckedChanged);
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Location = new System.Drawing.Point(6, 51);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(84, 17);
            this.radioButton10.TabIndex = 39;
            this.radioButton10.Text = "10 Followers";
            this.radioButton10.UseVisualStyleBackColor = true;
            this.radioButton10.CheckedChanged += new System.EventHandler(this.radioButtonStatistics_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton100);
            this.panel1.Controls.Add(this.radioButton50);
            this.panel1.Controls.Add(this.radioButtonResultsOneFile);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.radioButton10);
            this.panel1.Location = new System.Drawing.Point(609, 159);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(144, 123);
            this.panel1.TabIndex = 40;
            // 
            // radioButton50
            // 
            this.radioButton50.AutoSize = true;
            this.radioButton50.Location = new System.Drawing.Point(6, 74);
            this.radioButton50.Name = "radioButton50";
            this.radioButton50.Size = new System.Drawing.Size(84, 17);
            this.radioButton50.TabIndex = 40;
            this.radioButton50.Text = "50 Followers";
            this.radioButton50.UseVisualStyleBackColor = true;
            this.radioButton50.CheckedChanged += new System.EventHandler(this.radioButtonStatistics_CheckedChanged);
            // 
            // radioButton100
            // 
            this.radioButton100.AutoSize = true;
            this.radioButton100.Location = new System.Drawing.Point(6, 97);
            this.radioButton100.Name = "radioButton100";
            this.radioButton100.Size = new System.Drawing.Size(90, 17);
            this.radioButton100.TabIndex = 41;
            this.radioButton100.Text = "100 Followers";
            this.radioButton100.UseVisualStyleBackColor = true;
            this.radioButton100.CheckedChanged += new System.EventHandler(this.radioButtonStatistics_CheckedChanged);
            // 
            // FormFBApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 480);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.radioButtonNone);
            this.Controls.Add(this.radioButtonJSON);
            this.Controls.Add(this.radioButtonXML);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.labelIns);
            this.Controls.Add(this.imagePictureBoxFollower);
            this.Controls.Add(this.listBoxFollowers);
            this.Controls.Add(this.linkLabelClearAll);
            this.Controls.Add(this.linkLabelSelectAll);
            this.Controls.Add(this.labelFollowerName);
            this.Controls.Add(this.labelClick);
            this.Controls.Add(this.buttonPost);
            this.Controls.Add(this.labelEdit);
            this.Controls.Add(this.richTextBoxMessage);
            this.Controls.Add(this.labelSelect);
            this.Controls.Add(this.checkedListBoxGroups);
            this.Controls.Add(this.labelLoading);
            this.Controls.Add(this.labelMostFollower);
            this.Controls.Add(this.linkLabelMostFollowers);
            this.Controls.Add(this.labelWelcomeMsg);
            this.Controls.Add(this.labelForStatus);
            this.Controls.Add(this.textBoxStatus);
            this.Controls.Add(this.pictureBoxProfilePicture);
            this.Controls.Add(this.buttonLogin);
            this.Name = "FormFBApp";
            this.Text = "Facebook Application";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBoxFollower)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.PictureBox pictureBoxProfilePicture;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.Label labelForStatus;
        private System.Windows.Forms.Label labelWelcomeMsg;
        private System.Windows.Forms.LinkLabel linkLabelMostFollowers;
        private System.Windows.Forms.Label labelMostFollower;
        private System.Windows.Forms.Label labelLoading;
        private System.Windows.Forms.CheckedListBox checkedListBoxGroups;
        private System.Windows.Forms.Label labelSelect;
        private System.Windows.Forms.RichTextBox richTextBoxMessage;
        private System.Windows.Forms.Label labelEdit;
        private System.Windows.Forms.Button buttonPost;
        private System.Windows.Forms.Label labelClick;
        private System.Windows.Forms.LinkLabel linkLabelSelectAll;
        private System.Windows.Forms.LinkLabel linkLabelClearAll;
        private System.Windows.Forms.ListBox listBoxFollowers;
        private System.Windows.Forms.Label labelIns;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.Label labelFollowerName;
        private System.Windows.Forms.PictureBox imagePictureBoxFollower;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonXML;
        private System.Windows.Forms.RadioButton radioButtonJSON;
        private System.Windows.Forms.RadioButton radioButtonNone;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButtonResultsOneFile;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton50;
        private System.Windows.Forms.RadioButton radioButton100;
    }
}

