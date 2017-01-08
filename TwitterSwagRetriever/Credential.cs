using LinqToTwitter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterSwagRetriever
{
	public class Credential
	{
		public Credential(string description, string consumerKey, string consumerSecret, string accessToken, string accessTokenSecret)
		{
			Description = description;
			TwitterAuth = new SingleUserAuthorizer
			{
				CredentialStore = new SingleUserInMemoryCredentialStore
				{
					ConsumerKey = consumerKey,
					ConsumerSecret = consumerSecret,
					AccessToken = accessToken,
					AccessTokenSecret = accessTokenSecret
				}
			};
			this.twitterContext = new TwitterContext(this.twitterAuth);
		}

		public Credential(string description, SingleUserAuthorizer auth)
		{
			Description = description;
			TwitterAuth = auth;
			this.twitterContext = new TwitterContext(this.twitterAuth);
		}

		public TwitterContext GetTwitterContext
		{
			get
			{ 
				return this.twitterContext;
			}
		}

		private string description;
		private SingleUserAuthorizer twitterAuth;
		private TwitterContext twitterContext;

		public SingleUserAuthorizer TwitterAuth
		{
			get
			{
				return twitterAuth;
			}
			set
			{
				twitterAuth = value;
			}
		}

		public string Description
		{
			get
			{
				return description;
			}
			set
			{
				description = value;
			}
		}

		public string ConsumerKey
		{
			get
			{
				return twitterAuth.CredentialStore.ConsumerKey;
			}
			set
			{
				twitterAuth.CredentialStore.ConsumerKey = value;
			}
		}

		public string ConsumerSecret
		{
			get
			{
				return twitterAuth.CredentialStore.ConsumerSecret;
			}
			set
			{
				twitterAuth.CredentialStore.ConsumerSecret = value;
			}
		}

		public string AccessToken
		{
			get
			{
				return twitterAuth.CredentialStore.OAuthToken;
			}
			set
			{
				twitterAuth.CredentialStore.OAuthToken = value;
			}
		}

		public string AccessTokenSecret
		{
			get
			{
				return twitterAuth.CredentialStore.OAuthTokenSecret;
			}
			set
			{
				twitterAuth.CredentialStore.OAuthTokenSecret = value;
			}
		}
	}
}
