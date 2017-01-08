/*------------------------------------------------------------------------------------------------------------------------------------
Your application's Consumer Key and Secret are used to authenticate requests to the Twitter Platform.
Access level    Read and write(modify app permissions)
Callback URL    None
Callback URL Locked No
Sign in with Twitter    Yes
App-only authentication https://api.twitter.com/oauth2/token
Request token URL https://api.twitter.com/oauth/request_token
Authorize URL   https://api.twitter.com/oauth/authorize
Access token URL https://api.twitter.com/oauth/access_token
George Gilbert @enclave2k17
------------------------------------------------------------------------------------------------------------------------------------*/

using LinqToTwitter;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Web;

namespace TwitterSwagRetriever
{
	public partial class MainWindow : Form
	{
		//George's test data, dont forget to take out
		//private const string CustomerKey = "";
		//private const string ConsumerSecret = "";
		//private const string AccessToken = "";
		//private const string AccessTokenSecret = "";
		private const string Description = "1";
		private const string CustomerKey = "2KS3iTsbSUaV7Ls2doNNeBDEj";
		private const string ConsumerSecret = "MW6GuGVy2Odjn0ycsD8WIfy6TD7tkTeViANsFmDh9fUZvjKCyE";
		private const string AccessToken = "818045890090901504-pD0nJPP77FVrxOoDiqZOeoEnHiRex8E";
		private const string AccessTokenSecret = "LuNFhE5FbT3vyC2GW77hnuqbcQLKJVpcVy8bhVulVsL7i";

		protected string SearchString
		{
			get
			{
				return txtPhraseLocation.Text;
			}
			set
			{
				txtPhraseLocation.Text = value;
			}
		}

		protected string Log
		{
			get
			{
				return txtLog.Text;
			}
			set
			{
				txtLog.Text = value + System.Environment.NewLine;
			}
		}

		private List<string> phrases;
		protected List<string> Phrases
		{
			get
			{
				return phrases;
			}
			set
			{
				phrases = value;
			}
		}

		public MainWindow()
		{
			InitializeComponent();
			LoadDefaultCreds();
			lstUserList.SelectionMode = SelectionMode.One;
			lstUserList.DisplayMember = "Description";
			lstUserList.ValueMember = "TwitterAuth";
		}

		private void LoadDefaultCreds()
		{
			txtDescription.Text = Description;
			txtCustomerKey.Text = CustomerKey;
			txtCustomerSecret.Text = ConsumerSecret;
			txtTwitterAccessToken.Text = AccessToken;
			txtTwitterAccessTokenSecret.Text = AccessTokenSecret;
		}

		private async void Login(Credential credential)
		{
			try
			{
				var verifyResponse =
					await
						(from acct in credential.GetTwitterContext.Account
						 where acct.Type == AccountType.VerifyCredentials
						 select acct).SingleOrDefaultAsync();

				if (verifyResponse != null && verifyResponse.User != null)
				{
					User user = verifyResponse.User;
					LogMessage(string.Format(
						"Credentials are good for {0}.",
						user.ScreenNameResponse));
				}
			}
			catch (TwitterQueryException exception)
			{
				LogException(exception);
			}
		}

		private async void Search(string searchTerm)
		{
			try
			{
				if (null != lstUserList.SelectedItem && lstUserList.SelectedItem.GetType() == typeof(Credential))
				{
					Credential cred = (Credential)lstUserList.SelectedItem;

					LogMessage(string.Format("Using '{0}' credential to search...", cred.Description));
					var searchResponse = await
						(from search in cred.GetTwitterContext.Search
						 where search.Type == SearchType.Search &&
							   search.Query == searchTerm
						 select search).SingleOrDefaultAsync();

					if (searchResponse != null && searchResponse.Statuses != null)
					{
						searchResponse.Statuses.ForEach(tweet =>
							LogMessage(string.Format(
								"User: {0}, Tweet: {1}",
								tweet.User.ScreenNameResponse,
								tweet.Text)));
					}
				}
				else if(lstUserList.SelectedItem == null)
				{
					LogMessage("Select a user.");
				}
			}
			catch (TwitterQueryException exception)
			{
				LogException(exception);
			}
		}

		//private Action<User> followUserDelegate = null;
		//public void Follow(string userid, Action<User> delgt)
		//{
		//	followUserDelegate = delgt;
		//	var cb = new TwitterAsyncResponse<User>();
		//	var act = new Action<TwitterAsyncResponse<User>>(followUserCallback);

		//	getRateLimits().WaitIfNeeded();

		//	twitterCtx.CreateFriendship(userid, null, true, act);
		//}

		//void followUserCallback(TwitterAsyncResponse<User> response)
		//{
		//	User user = response.State;
		//	Exception except = response.Exception;

		//	if (user != null)
		//	{
		//		followUserDelegate(user);
		//	}
		//}

		private void LoadFile(string path)
		{
			if (File.Exists(path))
			{
				string readText = File.ReadAllText(path);
				Phrases = new List<string>(
						   readText.Split(new string[] { "\r\n" },
						   StringSplitOptions.RemoveEmptyEntries));
				Phrases.ForEach(x => txtPhrases.Text += string.Format("{0}, ", x));
				LogMessage("Phrases loaded from file.");
			}
			else
			{
				LogMessage("Could not load phrase file; file not found");
			}
		}

		private void LogException(Exception exception)
		{
			Log += string.Format(exception.Message);
		}

		private void LogMessage(string message)
		{
			Log += HttpUtility.HtmlDecode(message);
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			try
			{
				if (null != Phrases && Phrases.Count > 0)
				{
					Phrases.ForEach(x => Search(x));
				}
				else
				{
					LogMessage("No phrases loaded.");
				}
			}
			catch (Exception exception)
			{
				LogException(exception);
			}
		}

		private void btnLoad_Click(object sender, EventArgs e)
		{
			LoadFile(txtPhraseLocation.Text);
		}

		private void btnAddUser_Click(object sender, EventArgs e)
		{
			var myAuth = new SingleUserAuthorizer
			{
				CredentialStore = new SingleUserInMemoryCredentialStore
				{
					ConsumerKey = txtCustomerKey.Text,
					ConsumerSecret = txtCustomerSecret.Text,
					AccessToken = txtTwitterAccessToken.Text,
					AccessTokenSecret = txtTwitterAccessTokenSecret.Text
				}
			};

			Credential credential = new Credential(txtDescription.Text, myAuth);
			lstUserList.Items.Add(credential);
			lstUserList.SelectedItem = credential;
			Login(credential);
		}

		private void btnRemove_Click(object sender, EventArgs e)
		{
			if(lstUserList.SelectedItems.Count > 0)
			{
				lstUserList.Items.Remove(lstUserList.SelectedItem);
			}

			txtDescription.Text = "";
			txtCustomerKey.Text = "";
			txtCustomerSecret.Text = "";
			txtTwitterAccessToken.Text = "";
			txtTwitterAccessTokenSecret.Text = "";
		}

		private void lstUserList_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (null != sender && sender.GetType() == typeof(ListBox))
			{
				var listbox = (ListBox)sender;
				if (null != listbox.SelectedItem && listbox.SelectedItem.GetType() == typeof(Credential))
				{
					Credential selectedItem = (Credential)listbox.SelectedItem;
					txtDescription.Text = selectedItem.Description;
					txtCustomerKey.Text = selectedItem.ConsumerKey;
					txtCustomerSecret.Text = selectedItem.ConsumerSecret;
					txtTwitterAccessToken.Text = selectedItem.AccessToken;
					txtTwitterAccessTokenSecret.Text = selectedItem.AccessTokenSecret;
				}
			}
		}
	}
}
