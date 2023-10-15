// We're going to pretend that you're in a music
// playing application and you've clicked a song to play.
// Now, the music starts playing, so we automatically
// start with the MusicPlayingState
var musicPlayerContext = new PlayPauseMusicButtonContext();

// When a user presses a key, the music button is 
while (true)
{
    Console.WriteLine("Press a key to click the button");
    Console.ReadKey();
    musicPlayerContext.ClickButton();
}