namespace TwitterSwagRetriever
{
	partial class MainWindow
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
			this.btnSearch = new System.Windows.Forms.Button();
			this.txtLog = new System.Windows.Forms.RichTextBox();
			this.txtPhraseLocation = new System.Windows.Forms.TextBox();
			this.lblLocation = new System.Windows.Forms.Label();
			this.boxUserList = new System.Windows.Forms.GroupBox();
			this.btnRemove = new System.Windows.Forms.Button();
			this.btnAddUser = new System.Windows.Forms.Button();
			this.txtTwitterAccessTokenSecret = new System.Windows.Forms.TextBox();
			this.lblTwitterAccessTokenSecret = new System.Windows.Forms.Label();
			this.txtTwitterAccessToken = new System.Windows.Forms.TextBox();
			this.lblTwitterAccessToken = new System.Windows.Forms.Label();
			this.txtCustomerSecret = new System.Windows.Forms.TextBox();
			this.lblCustomerSecret = new System.Windows.Forms.Label();
			this.txtCustomerKey = new System.Windows.Forms.TextBox();
			this.lblCustomerKey = new System.Windows.Forms.Label();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.lblDescription = new System.Windows.Forms.Label();
			this.lstUserList = new System.Windows.Forms.ListBox();
			this.boxFollowUser = new System.Windows.Forms.GroupBox();
			this.txtPhrases = new System.Windows.Forms.RichTextBox();
			this.btnLoad = new System.Windows.Forms.Button();
			this.boxStatus = new System.Windows.Forms.GroupBox();
			this.boxUserList.SuspendLayout();
			this.boxFollowUser.SuspendLayout();
			this.boxStatus.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(932, 742);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(75, 23);
			this.btnSearch.TabIndex = 1;
			this.btnSearch.Text = "Search";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// txtLog
			// 
			this.txtLog.Location = new System.Drawing.Point(198, 19);
			this.txtLog.Name = "txtLog";
			this.txtLog.Size = new System.Drawing.Size(790, 303);
			this.txtLog.TabIndex = 2;
			this.txtLog.Text = "";
			// 
			// txtPhraseLocation
			// 
			this.txtPhraseLocation.Location = new System.Drawing.Point(686, 15);
			this.txtPhraseLocation.Name = "txtPhraseLocation";
			this.txtPhraseLocation.Size = new System.Drawing.Size(228, 20);
			this.txtPhraseLocation.TabIndex = 3;
			this.txtPhraseLocation.Text = "C:\\temp\\phrases.txt";
			// 
			// lblLocation
			// 
			this.lblLocation.AutoSize = true;
			this.lblLocation.Location = new System.Drawing.Point(581, 18);
			this.lblLocation.Name = "lblLocation";
			this.lblLocation.Size = new System.Drawing.Size(99, 13);
			this.lblLocation.TabIndex = 4;
			this.lblLocation.Text = "Phrase file location:";
			// 
			// boxUserList
			// 
			this.boxUserList.Controls.Add(this.btnRemove);
			this.boxUserList.Controls.Add(this.btnAddUser);
			this.boxUserList.Controls.Add(this.txtTwitterAccessTokenSecret);
			this.boxUserList.Controls.Add(this.lblTwitterAccessTokenSecret);
			this.boxUserList.Controls.Add(this.txtTwitterAccessToken);
			this.boxUserList.Controls.Add(this.lblTwitterAccessToken);
			this.boxUserList.Controls.Add(this.txtCustomerSecret);
			this.boxUserList.Controls.Add(this.lblCustomerSecret);
			this.boxUserList.Controls.Add(this.txtCustomerKey);
			this.boxUserList.Controls.Add(this.lblCustomerKey);
			this.boxUserList.Controls.Add(this.txtDescription);
			this.boxUserList.Controls.Add(this.lblDescription);
			this.boxUserList.Controls.Add(this.lstUserList);
			this.boxUserList.Location = new System.Drawing.Point(6, 12);
			this.boxUserList.Name = "boxUserList";
			this.boxUserList.Size = new System.Drawing.Size(1001, 213);
			this.boxUserList.TabIndex = 5;
			this.boxUserList.TabStop = false;
			this.boxUserList.Text = "User List";
			// 
			// btnRemove
			// 
			this.btnRemove.Location = new System.Drawing.Point(846, 184);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Size = new System.Drawing.Size(75, 23);
			this.btnRemove.TabIndex = 12;
			this.btnRemove.Text = "Remove";
			this.btnRemove.UseVisualStyleBackColor = true;
			this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
			// 
			// btnAddUser
			// 
			this.btnAddUser.Location = new System.Drawing.Point(764, 184);
			this.btnAddUser.Name = "btnAddUser";
			this.btnAddUser.Size = new System.Drawing.Size(75, 23);
			this.btnAddUser.TabIndex = 11;
			this.btnAddUser.Text = "Add";
			this.btnAddUser.UseVisualStyleBackColor = true;
			this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
			// 
			// txtTwitterAccessTokenSecret
			// 
			this.txtTwitterAccessTokenSecret.Location = new System.Drawing.Point(621, 121);
			this.txtTwitterAccessTokenSecret.Name = "txtTwitterAccessTokenSecret";
			this.txtTwitterAccessTokenSecret.Size = new System.Drawing.Size(374, 20);
			this.txtTwitterAccessTokenSecret.TabIndex = 10;
			// 
			// lblTwitterAccessTokenSecret
			// 
			this.lblTwitterAccessTokenSecret.AutoSize = true;
			this.lblTwitterAccessTokenSecret.Location = new System.Drawing.Point(480, 124);
			this.lblTwitterAccessTokenSecret.Name = "lblTwitterAccessTokenSecret";
			this.lblTwitterAccessTokenSecret.Size = new System.Drawing.Size(145, 13);
			this.lblTwitterAccessTokenSecret.TabIndex = 9;
			this.lblTwitterAccessTokenSecret.Text = "Twitter Access Token Secret";
			// 
			// txtTwitterAccessToken
			// 
			this.txtTwitterAccessToken.Location = new System.Drawing.Point(621, 95);
			this.txtTwitterAccessToken.Name = "txtTwitterAccessToken";
			this.txtTwitterAccessToken.Size = new System.Drawing.Size(374, 20);
			this.txtTwitterAccessToken.TabIndex = 8;
			// 
			// lblTwitterAccessToken
			// 
			this.lblTwitterAccessToken.AutoSize = true;
			this.lblTwitterAccessToken.Location = new System.Drawing.Point(480, 98);
			this.lblTwitterAccessToken.Name = "lblTwitterAccessToken";
			this.lblTwitterAccessToken.Size = new System.Drawing.Size(111, 13);
			this.lblTwitterAccessToken.TabIndex = 7;
			this.lblTwitterAccessToken.Text = "Twitter Access Token";
			// 
			// txtCustomerSecret
			// 
			this.txtCustomerSecret.Location = new System.Drawing.Point(621, 69);
			this.txtCustomerSecret.Name = "txtCustomerSecret";
			this.txtCustomerSecret.Size = new System.Drawing.Size(374, 20);
			this.txtCustomerSecret.TabIndex = 6;
			// 
			// lblCustomerSecret
			// 
			this.lblCustomerSecret.AutoSize = true;
			this.lblCustomerSecret.Location = new System.Drawing.Point(480, 72);
			this.lblCustomerSecret.Name = "lblCustomerSecret";
			this.lblCustomerSecret.Size = new System.Drawing.Size(85, 13);
			this.lblCustomerSecret.TabIndex = 5;
			this.lblCustomerSecret.Text = "Customer Secret";
			// 
			// txtCustomerKey
			// 
			this.txtCustomerKey.Location = new System.Drawing.Point(621, 43);
			this.txtCustomerKey.Name = "txtCustomerKey";
			this.txtCustomerKey.Size = new System.Drawing.Size(374, 20);
			this.txtCustomerKey.TabIndex = 4;
			// 
			// lblCustomerKey
			// 
			this.lblCustomerKey.AutoSize = true;
			this.lblCustomerKey.Location = new System.Drawing.Point(480, 46);
			this.lblCustomerKey.Name = "lblCustomerKey";
			this.lblCustomerKey.Size = new System.Drawing.Size(72, 13);
			this.lblCustomerKey.TabIndex = 3;
			this.lblCustomerKey.Text = "Customer Key";
			// 
			// txtDescription
			// 
			this.txtDescription.Location = new System.Drawing.Point(621, 17);
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new System.Drawing.Size(374, 20);
			this.txtDescription.TabIndex = 2;
			// 
			// lblDescription
			// 
			this.lblDescription.AutoSize = true;
			this.lblDescription.Location = new System.Drawing.Point(480, 20);
			this.lblDescription.Name = "lblDescription";
			this.lblDescription.Size = new System.Drawing.Size(60, 13);
			this.lblDescription.TabIndex = 1;
			this.lblDescription.Text = "Description";
			// 
			// lstUserList
			// 
			this.lstUserList.FormattingEnabled = true;
			this.lstUserList.Location = new System.Drawing.Point(7, 19);
			this.lstUserList.Name = "lstUserList";
			this.lstUserList.Size = new System.Drawing.Size(467, 147);
			this.lstUserList.TabIndex = 0;
			this.lstUserList.SelectedIndexChanged += new System.EventHandler(this.lstUserList_SelectedIndexChanged);
			// 
			// boxFollowUser
			// 
			this.boxFollowUser.Controls.Add(this.txtPhrases);
			this.boxFollowUser.Controls.Add(this.btnLoad);
			this.boxFollowUser.Controls.Add(this.lblLocation);
			this.boxFollowUser.Controls.Add(this.txtPhraseLocation);
			this.boxFollowUser.Location = new System.Drawing.Point(6, 231);
			this.boxFollowUser.Name = "boxFollowUser";
			this.boxFollowUser.Size = new System.Drawing.Size(1001, 170);
			this.boxFollowUser.TabIndex = 6;
			this.boxFollowUser.TabStop = false;
			this.boxFollowUser.Text = "Follow Users";
			// 
			// txtPhrases
			// 
			this.txtPhrases.Location = new System.Drawing.Point(584, 39);
			this.txtPhrases.Name = "txtPhrases";
			this.txtPhrases.Size = new System.Drawing.Size(411, 125);
			this.txtPhrases.TabIndex = 6;
			this.txtPhrases.Text = "";
			// 
			// btnLoad
			// 
			this.btnLoad.Location = new System.Drawing.Point(920, 12);
			this.btnLoad.Name = "btnLoad";
			this.btnLoad.Size = new System.Drawing.Size(75, 23);
			this.btnLoad.TabIndex = 5;
			this.btnLoad.Text = "Load";
			this.btnLoad.UseVisualStyleBackColor = true;
			this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
			// 
			// boxStatus
			// 
			this.boxStatus.Controls.Add(this.txtLog);
			this.boxStatus.Location = new System.Drawing.Point(13, 408);
			this.boxStatus.Name = "boxStatus";
			this.boxStatus.Size = new System.Drawing.Size(994, 328);
			this.boxStatus.TabIndex = 7;
			this.boxStatus.TabStop = false;
			this.boxStatus.Text = "Current Status";
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1019, 777);
			this.Controls.Add(this.boxStatus);
			this.Controls.Add(this.boxFollowUser);
			this.Controls.Add(this.boxUserList);
			this.Controls.Add(this.btnSearch);
			this.Name = "MainWindow";
			this.Text = "Twitter Swag Retriever";
			this.boxUserList.ResumeLayout(false);
			this.boxUserList.PerformLayout();
			this.boxFollowUser.ResumeLayout(false);
			this.boxFollowUser.PerformLayout();
			this.boxStatus.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.RichTextBox txtLog;
		private System.Windows.Forms.TextBox txtPhraseLocation;
		private System.Windows.Forms.Label lblLocation;
		private System.Windows.Forms.GroupBox boxUserList;
		private System.Windows.Forms.GroupBox boxFollowUser;
		private System.Windows.Forms.GroupBox boxStatus;
		private System.Windows.Forms.Button btnLoad;
		private System.Windows.Forms.ListBox lstUserList;
		private System.Windows.Forms.RichTextBox txtPhrases;
		private System.Windows.Forms.TextBox txtTwitterAccessTokenSecret;
		private System.Windows.Forms.Label lblTwitterAccessTokenSecret;
		private System.Windows.Forms.TextBox txtTwitterAccessToken;
		private System.Windows.Forms.Label lblTwitterAccessToken;
		private System.Windows.Forms.TextBox txtCustomerSecret;
		private System.Windows.Forms.Label lblCustomerSecret;
		private System.Windows.Forms.TextBox txtCustomerKey;
		private System.Windows.Forms.Label lblCustomerKey;
		private System.Windows.Forms.TextBox txtDescription;
		private System.Windows.Forms.Label lblDescription;
		private System.Windows.Forms.Button btnAddUser;
		private System.Windows.Forms.Button btnRemove;
	}
}

