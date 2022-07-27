# TwitchImplicitOAuth

<p align="center">
  <img src="https://i.imgur.com/8IqzYgF.png"/>
</p>
<p align="center">Simple library for getting user OAuth tokens through the implicit grant flow.</p>

## About

This is a simple  library that automates the work needed to grab a user-token to use with the Twitch API.<br/>
The library is compatible with any and all applications running on C# no matter what other libraries or frameworks you have implemented.

This library will only help you with getting the user to autorize the application and recieve a user token in accordance with the implicit flow.<br/>
It will not help you connect to the Twitch API. You will need a separate library, such as [TwitchLib](https://github.com/TwitchLib/TwitchLib) for that.

## How To use

Place the scripts directory anywhere in your project where you can access their namespace with the "using" statement.<br/>
In Unity that would be anywhere in your "Assets" folder, in any other project that would simply be your project folder.
```C#
using VonRiddarn.Twitch.ImplicitOAuth;

// Constructor can be passed an int salt value to get "your own" random randomness.
// Empty constructor defaults to 42.
ImplicitOAuth ioa = new ImplicitOAuth(1234);
string currentState = null;

// This event is triggered when the application recieves a new token and state from the "RequestClientAuthorization" method.
ioa.OnRevcievedValues += Foo;

// This method initialize the flow of getting the token and returns a temporary random state that we will use to check authenticity.
currentState = ioa.RequestClientAuthorization();

private void Foo(string state, string token)
{
  if(state != currentState)
  {
    Console.WriteLine("State does not match up. Possible CSRF attack or other error.");
    return;
  }
  
  // Don't actually print the user token on screen or to the console.
  // Here you should save it where the application can access it whenever it wants to, such as in appdata.
  Console.WriteLine($"User Token: {token}");
}
```

## License

MIT-License.<br/>
See the license file for more info.

## Special thanks

This script is very loosely based on HellCat's [Unity-Twitch-OAuth-Example](https://github.com/TheHellcat/Unity-Twitch-OAuth-Example).<br/>
The main difference being that this project uses Implicit Flow, whilst HellCat's uses Authorization Flow.<br/>
A lot of help was also recieved in the creation of this library from [Kraegon](https://github.com/Kraegon/TwitchOauthTest).
