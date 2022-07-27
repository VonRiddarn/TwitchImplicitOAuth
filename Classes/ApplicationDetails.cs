namespace VonRiddarn.Twitch.ImplicitOath
{
	public static class ApplicationDetails
	{
		// The client ID you get from your Twitch developer console (https://dev.twitch.tv/).
		public static string twitchClientId = "YOUR_CLIENT_ID";

		// The URI you entered when registering your application in the twitch console.
		// Default is fine.
		public static string redirectUri = "http://localhost:8080/";

		// Any URI you want to fetch results on.
		// Default is fine.
		public static string fetchUri = "http://localhost:8081/";
	}
}